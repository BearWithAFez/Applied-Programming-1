using System;
using System.Windows.Forms;
using System.Media;
using Logic;
using System.IO;
using System.Drawing;

namespace GUI
{
    public partial class Form1 : Form
    {
        private string csvPath = @"Recources\noten.csv"; //standaard waarde.
        private int duration = 200; //ms
        private const string placeholder = @"space = silence, (text) = double tempo, [text] = halve tempo";

        BasisLogica backend = new BasisLogica();
        SoundPlayer player = new SoundPlayer();        

        public Form1()
        {
            InitializeComponent();
            backend.setCsv(csvPath);
            usingLabel.Text = "Currently using: " + Path.GetFileName(csvPath);
            textBox.Text = placeholder;
            textBoxDuration.Text = "" + duration;
            csvButton.Select();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if(textBox.Text != "" && textBox.Text != placeholder)
            {
                playButton.Enabled = true;
                saveButton.Enabled = true;
            }
            else
            {
                playButton.Enabled = false;
                saveButton.Enabled = false;
            }
        }

        private void play_Click(object sender, EventArgs e)
        {
            // maak Wav en sla deze in tijdelijk bestand op
            backend.generate(textBox.Text,duration, (trackBar1.Value * 1f) / 100, "temp.wav");

            //speel geluid af
            player = new SoundPlayer("temp.wav");
            player.Play();
        }

        private void save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                backend.generate(textBox.Text,duration,(trackBar1.Value * 1f)/100, saveFileDialog1.FileName);
                saveFileDialog1.FileName = "";
            }
        }

        private void csv_Click(object sender, EventArgs e)
        {
            if (OFDcsv.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    csvPath = OFDcsv.FileName;
                    backend.setCsv(csvPath);
                    usingLabel.Text = "Currently using: " + Path.GetFileName(csvPath);
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fout inlezen CSV bestand", MessageBoxButtons.OK , MessageBoxIcon.Error);
                }                
            }
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            if(textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            if (textBox.Text == "")
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(File.Exists("temp.wav")) File.Delete("temp.wav");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelVol.Text = "vol:" + trackBar1.Value + "%";
        }

        private void textBoxDuration_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxDuration.Text.Trim(), out duration))
            {
                MessageBox.Show("INVALID VALUE!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDuration.Text = "" + 200;
                return;
            }
            duration = Math.Abs(duration);
        }
    }
}
