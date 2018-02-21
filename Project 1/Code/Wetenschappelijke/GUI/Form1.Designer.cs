namespace GUI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.saveButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.csvButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.usingLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.OFDcsv = new System.Windows.Forms.OpenFileDialog();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.labelVol = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(418, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(65, 52);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.toolTip1.SetToolTip(this.saveButton, "Click here to save selected sound as a .wav file.");
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.save_Click);
            // 
            // playButton
            // 
            this.playButton.Enabled = false;
            this.playButton.Location = new System.Drawing.Point(260, 12);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(152, 52);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Play";
            this.toolTip1.SetToolTip(this.playButton, "Click here to play the text!");
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.play_Click);
            // 
            // csvButton
            // 
            this.csvButton.Location = new System.Drawing.Point(12, 41);
            this.csvButton.Name = "csvButton";
            this.csvButton.Size = new System.Drawing.Size(242, 23);
            this.csvButton.TabIndex = 1;
            this.csvButton.Text = "Load csv";
            this.toolTip1.SetToolTip(this.csvButton, "Click to load in a other letter-frequency file.");
            this.csvButton.UseVisualStyleBackColor = true;
            this.csvButton.Click += new System.EventHandler(this.csv_Click);
            // 
            // textBox
            // 
            this.textBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox.Location = new System.Drawing.Point(63, 70);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(421, 261);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "space = silence, () = double tempo, [] = halve tempo";
            this.toolTip1.SetToolTip(this.textBox, "This text will be transformed to sound.");
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox.Enter += new System.EventHandler(this.textBox_Enter);
            this.textBox.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // usingLabel
            // 
            this.usingLabel.AutoSize = true;
            this.usingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usingLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.usingLabel.Location = new System.Drawing.Point(60, 334);
            this.usingLabel.Name = "usingLabel";
            this.usingLabel.Size = new System.Drawing.Size(172, 13);
            this.usingLabel.TabIndex = 5;
            this.usingLabel.Text = "Currently using: standard.csv";
            // 
            // OFDcsv
            // 
            this.OFDcsv.FileName = "openFileDialog1";
            this.OFDcsv.Filter = "csv files|*.csv|All files|*.*";
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(181, 15);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(73, 20);
            this.textBoxDuration.TabIndex = 6;
            this.textBoxDuration.Text = "200";
            this.textBoxDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxDuration.Leave += new System.EventHandler(this.textBoxDuration_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Duration letter: (ms)";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 94);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 253);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 100;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // labelVol
            // 
            this.labelVol.AutoSize = true;
            this.labelVol.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVol.Location = new System.Drawing.Point(9, 71);
            this.labelVol.Name = "labelVol";
            this.labelVol.Size = new System.Drawing.Size(53, 12);
            this.labelVol.TabIndex = 101;
            this.labelVol.Text = "Vol:100%";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "WaveFiles|*.wav";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 356);
            this.Controls.Add(this.labelVol);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDuration);
            this.Controls.Add(this.usingLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.csvButton);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.Text = "Workshop Geluid";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button csvButton;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label usingLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog OFDcsv;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label labelVol;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

