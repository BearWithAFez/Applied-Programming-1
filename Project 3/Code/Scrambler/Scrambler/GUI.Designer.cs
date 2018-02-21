namespace GUI
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxSource = new System.Windows.Forms.TextBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnPlaySource = new System.Windows.Forms.Button();
            this.btnStopSource = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnScrambler = new System.Windows.Forms.Button();
            this.btnStopResult = new System.Windows.Forms.Button();
            this.btnPlayResult = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana Pro", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project WT1.3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Step 1: Choose a File (.wav only!)";
            // 
            // txtbxSource
            // 
            this.txtbxSource.Location = new System.Drawing.Point(46, 86);
            this.txtbxSource.Name = "txtbxSource";
            this.txtbxSource.ReadOnly = true;
            this.txtbxSource.Size = new System.Drawing.Size(253, 22);
            this.txtbxSource.TabIndex = 2;
            this.txtbxSource.Text = "Please choose a file...";
            // 
            // btnChoose
            // 
            this.btnChoose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnChoose.Location = new System.Drawing.Point(305, 86);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(87, 24);
            this.btnChoose.TabIndex = 3;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnPlaySource
            // 
            this.btnPlaySource.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPlaySource.Enabled = false;
            this.btnPlaySource.Location = new System.Drawing.Point(398, 86);
            this.btnPlaySource.Name = "btnPlaySource";
            this.btnPlaySource.Size = new System.Drawing.Size(72, 24);
            this.btnPlaySource.TabIndex = 4;
            this.btnPlaySource.Text = "Play";
            this.btnPlaySource.UseVisualStyleBackColor = true;
            this.btnPlaySource.Click += new System.EventHandler(this.btnPlaySource_Click);
            // 
            // btnStopSource
            // 
            this.btnStopSource.Enabled = false;
            this.btnStopSource.Location = new System.Drawing.Point(476, 86);
            this.btnStopSource.Name = "btnStopSource";
            this.btnStopSource.Size = new System.Drawing.Size(72, 24);
            this.btnStopSource.TabIndex = 5;
            this.btnStopSource.Text = "Stop";
            this.btnStopSource.UseVisualStyleBackColor = true;
            this.btnStopSource.Click += new System.EventHandler(this.btnStopSource_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Step 2: (un)scramble";
            // 
            // btnScrambler
            // 
            this.btnScrambler.Enabled = false;
            this.btnScrambler.Location = new System.Drawing.Point(46, 197);
            this.btnScrambler.Name = "btnScrambler";
            this.btnScrambler.Size = new System.Drawing.Size(500, 43);
            this.btnScrambler.TabIndex = 7;
            this.btnScrambler.Text = "(un)Scramble";
            this.btnScrambler.UseVisualStyleBackColor = true;
            this.btnScrambler.Click += new System.EventHandler(this.btnScrambler_Click);
            // 
            // btnStopResult
            // 
            this.btnStopResult.Enabled = false;
            this.btnStopResult.Location = new System.Drawing.Point(163, 311);
            this.btnStopResult.Name = "btnStopResult";
            this.btnStopResult.Size = new System.Drawing.Size(108, 24);
            this.btnStopResult.TabIndex = 10;
            this.btnStopResult.Text = "Stop";
            this.btnStopResult.UseVisualStyleBackColor = true;
            this.btnStopResult.Click += new System.EventHandler(this.btnStopResult_Click);
            // 
            // btnPlayResult
            // 
            this.btnPlayResult.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPlayResult.Enabled = false;
            this.btnPlayResult.Location = new System.Drawing.Point(46, 311);
            this.btnPlayResult.Name = "btnPlayResult";
            this.btnPlayResult.Size = new System.Drawing.Size(111, 24);
            this.btnPlayResult.TabIndex = 9;
            this.btnPlayResult.Text = "Play";
            this.btnPlayResult.UseVisualStyleBackColor = true;
            this.btnPlayResult.Click += new System.EventHandler(this.btnPlayResult_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Step 3: Listen to the New sound and save";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(380, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(166, 24);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(235, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "(Created by Dwight VdV)";
            // 
            // OFD
            // 
            this.OFD.Filter = "Wav files|*.wav";
            // 
            // SFD
            // 
            this.SFD.DefaultExt = "wav";
            this.SFD.Filter = "Wav files|*.wav";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 350);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStopResult);
            this.Controls.Add(this.btnPlayResult);
            this.Controls.Add(this.btnScrambler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStopSource);
            this.Controls.Add(this.btnPlaySource);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.txtbxSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GUI";
            this.Text = "Project WT 1.3 (by Dwight)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxSource;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnPlaySource;
        private System.Windows.Forms.Button btnStopSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnScrambler;
        private System.Windows.Forms.Button btnStopResult;
        private System.Windows.Forms.Button btnPlayResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.SaveFileDialog SFD;
    }
}

