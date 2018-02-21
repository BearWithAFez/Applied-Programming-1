using System;
using System.Windows.Forms;
using System.IO;
using ILogic;
using Logic;

namespace GUI
{
    public partial class GUI : Form
    {
        private ILinker backend = new Linker();
        public GUI()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            //Set new source; if valid
            if (backend.chooseNewSource())
            {
                //enable next step
                txtbxSource.Text = Path.GetFileNameWithoutExtension( backend.getSourceFileName() );

                btnPlaySource.Enabled = true;
                btnStopSource.Enabled = true;
                btnScrambler.Enabled = true;
                btnPlayResult.Enabled = false;
                btnStopResult.Enabled = false;
                btnSave.Enabled = false;
            }
            else
            {
                //disable next steps
                btnPlaySource.Enabled = false;
                btnStopSource.Enabled = false;
                btnScrambler.Enabled = false;
                btnPlayResult.Enabled = false;
                btnStopResult.Enabled = false;
                btnSave.Enabled = false;
            }
        }

        private void btnPlaySource_Click(object sender, EventArgs e)
        {
            //When playing only make stop active
            backend.playSource();

            btnStopSource.Enabled = true;
            btnScrambler.Enabled = false;
            btnPlaySource.Enabled = false;
            btnPlayResult.Enabled = false;
            btnStopResult.Enabled = false;
            btnSave.Enabled = false;
            btnChoose.Enabled = false;
        }

        private void btnStopSource_Click(object sender, EventArgs e)
        {
            //reactivate on stop.
            backend.stopSource();

            btnStopSource.Enabled = false;
            btnPlaySource.Enabled = true;
            btnScrambler.Enabled = true;
            btnChoose.Enabled = true;
        }

        private void btnScrambler_Click(object sender, EventArgs e)
        {
            //Scramble and activate next step
            backend.scramble();

            btnPlayResult.Enabled = true;
            btnSave.Enabled = true;
            btnStopResult.Enabled = false;

        }

        private void btnPlayResult_Click(object sender, EventArgs e)
        {
            //When playing only make stop active
            backend.playResult();

            btnPlayResult.Enabled = false;
            btnScrambler.Enabled = false;
            btnSave.Enabled = false;
            btnPlaySource.Enabled = false;
            btnChoose.Enabled = false;
            btnStopResult.Enabled = true;
        }

        private void btnStopResult_Click(object sender, EventArgs e)
        {
            //reactivate on stop.
            backend.stopResult();

            btnScrambler.Enabled = true;
            btnSave.Enabled = true;
            btnPlaySource.Enabled = true;
            btnPlayResult.Enabled = true;
            btnChoose.Enabled = true;
            btnStopResult.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //save the new wav file
            backend.saveResult();
        }
    }
}