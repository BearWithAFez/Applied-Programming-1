using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using Logic;
using Logica_Interface;

namespace Fourier
{
    public partial class Form1 : Form
    {
        // comunication with Logic layer
        private IbasicLogica backend = new basicLogic();

        //defaultValues
        private const string startupWavPath = @"resources\abcde.wav";
        private const string startupCsvPath = @"resources\CSV.csv";

        public Form1()
        {
            InitializeComponent();
            backend.changePath(startupWavPath, false);
            txtWav.Text = "Using:\n" + Path.GetFileName(startupWavPath);
            backend.changePath(startupCsvPath, true);
            txtCsv.Text = "Using:\n" + Path.GetFileName(startupCsvPath);
        }

        //events
        private void buttonWav_Click(object sender, EventArgs e)
        {
            tBoutput.Text = "";
            if (ofdWAV.ShowDialog() == DialogResult.OK)
            {
                backend.changePath(ofdWAV.FileName, false);
                txtWav.Text = "Using:\n" + Path.GetFileName(ofdWAV.FileName);
            }
        }

        private void buttonCSV_Click(object sender, EventArgs e)
        {
            tBoutput.Text = "";
            if (ofdCSV.ShowDialog() == DialogResult.OK)
            {
                backend.changePath(ofdCSV.FileName, true);
                txtCsv.Text = "Using:\n" + Path.GetFileName(ofdCSV.FileName);
            }
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            try
            {
                tBoutput.Text = backend.convert((int)nUDTime.Value, cbRound.Checked, cbShow.Checked, radioButton1.Checked);
                if (tBoutput.Text.Contains('?')) MessageBox.Show("Unknown frequencies will be represented as\"?\"", "Unknown frequencies!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("CSV") || ex.Message.Contains("WAV"))
                {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Something went wrong...", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void nUDTime_ValueChanged(object sender, EventArgs e)
        {
            tBoutput.Text = "";
        }

        private void cbRound_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbRound.Checked) MessageBox.Show("Not rounding can lead to simple errors. I suggest leaving this feature on, or atleast showing unfound values.", "No more rounding?!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new Size(410, 680); //bug where Form was Gigantic
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked && radioButton2.Checked) radioButton1.Checked = false;
            tBoutput.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked && radioButton2.Checked) radioButton2.Checked = false;
            tBoutput.Text = "";
        }
    }
}
