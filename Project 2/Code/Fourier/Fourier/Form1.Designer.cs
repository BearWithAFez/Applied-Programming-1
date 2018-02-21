namespace Fourier
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonWav = new System.Windows.Forms.Button();
            this.buttonCSV = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.tBoutput = new System.Windows.Forms.TextBox();
            this.txtWav = new System.Windows.Forms.Label();
            this.txtCsv = new System.Windows.Forms.Label();
            this.ofdWAV = new System.Windows.Forms.OpenFileDialog();
            this.ofdCSV = new System.Windows.Forms.OpenFileDialog();
            this.nUDTime = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbRound = new System.Windows.Forms.CheckBox();
            this.cbShow = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nUDTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fourier analyser";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(15, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wav file:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(9, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Output:";
            // 
            // buttonWav
            // 
            this.buttonWav.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWav.Location = new System.Drawing.Point(92, 35);
            this.buttonWav.Name = "buttonWav";
            this.buttonWav.Size = new System.Drawing.Size(150, 23);
            this.buttonWav.TabIndex = 3;
            this.buttonWav.Text = "Choose WAV";
            this.buttonWav.UseVisualStyleBackColor = true;
            this.buttonWav.Click += new System.EventHandler(this.buttonWav_Click);
            // 
            // buttonCSV
            // 
            this.buttonCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCSV.Location = new System.Drawing.Point(92, 164);
            this.buttonCSV.Name = "buttonCSV";
            this.buttonCSV.Size = new System.Drawing.Size(150, 23);
            this.buttonCSV.TabIndex = 4;
            this.buttonCSV.Text = "Choose CSV";
            this.buttonCSV.UseVisualStyleBackColor = true;
            this.buttonCSV.Click += new System.EventHandler(this.buttonCSV_Click);
            // 
            // buttonConvert
            // 
            this.buttonConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvert.Location = new System.Drawing.Point(12, 415);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(367, 44);
            this.buttonConvert.TabIndex = 5;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // tBoutput
            // 
            this.tBoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoutput.Location = new System.Drawing.Point(12, 508);
            this.tBoutput.Multiline = true;
            this.tBoutput.Name = "tBoutput";
            this.tBoutput.ReadOnly = true;
            this.tBoutput.Size = new System.Drawing.Size(367, 121);
            this.tBoutput.TabIndex = 6;
            // 
            // txtWav
            // 
            this.txtWav.AutoSize = true;
            this.txtWav.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWav.Location = new System.Drawing.Point(33, 72);
            this.txtWav.Name = "txtWav";
            this.txtWav.Size = new System.Drawing.Size(59, 34);
            this.txtWav.TabIndex = 7;
            this.txtWav.Text = "Using:\r\ntest.wav";
            // 
            // txtCsv
            // 
            this.txtCsv.AutoSize = true;
            this.txtCsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCsv.Location = new System.Drawing.Point(32, 203);
            this.txtCsv.Name = "txtCsv";
            this.txtCsv.Size = new System.Drawing.Size(48, 17);
            this.txtCsv.TabIndex = 8;
            this.txtCsv.Text = "Using:";
            // 
            // ofdWAV
            // 
            this.ofdWAV.FileName = "openFileDialog1";
            this.ofdWAV.Filter = "WAV files|*.wav";
            // 
            // ofdCSV
            // 
            this.ofdCSV.FileName = "openFileDialog2";
            this.ofdCSV.Filter = "CSV files|*.csv";
            // 
            // nUDTime
            // 
            this.nUDTime.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nUDTime.Location = new System.Drawing.Point(174, 128);
            this.nUDTime.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nUDTime.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nUDTime.Name = "nUDTime";
            this.nUDTime.Size = new System.Drawing.Size(86, 20);
            this.nUDTime.TabIndex = 12;
            this.nUDTime.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nUDTime.ValueChanged += new System.EventHandler(this.nUDTime_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(9, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Csv file:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(266, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "ms";
            // 
            // cbRound
            // 
            this.cbRound.AutoSize = true;
            this.cbRound.Checked = true;
            this.cbRound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRound.Location = new System.Drawing.Point(25, 343);
            this.cbRound.Name = "cbRound";
            this.cbRound.Size = new System.Drawing.Size(116, 17);
            this.cbRound.TabIndex = 14;
            this.cbRound.Text = "Round frequencies";
            this.cbRound.UseVisualStyleBackColor = true;
            this.cbRound.CheckedChanged += new System.EventHandler(this.cbRound_CheckedChanged);
            // 
            // cbShow
            // 
            this.cbShow.AutoSize = true;
            this.cbShow.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbShow.Location = new System.Drawing.Point(25, 366);
            this.cbShow.Name = "cbShow";
            this.cbShow.Size = new System.Drawing.Size(158, 17);
            this.cbShow.TabIndex = 15;
            this.cbShow.Text = "Show unknown frequencies";
            this.cbShow.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Location = new System.Drawing.Point(9, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Optional:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Time per tone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Seperator";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(139, 258);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 17);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.Text = "comma";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(230, 258);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(75, 17);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "semi colon";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(394, 641);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbShow);
            this.Controls.Add(this.cbRound);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nUDTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCsv);
            this.Controls.Add(this.txtWav);
            this.Controls.Add(this.tBoutput);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.buttonCSV);
            this.Controls.Add(this.buttonWav);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Project WT1 ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUDTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonWav;
        private System.Windows.Forms.Button buttonCSV;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.TextBox tBoutput;
        private System.Windows.Forms.Label txtWav;
        private System.Windows.Forms.Label txtCsv;
        private System.Windows.Forms.OpenFileDialog ofdWAV;
        private System.Windows.Forms.OpenFileDialog ofdCSV;
        private System.Windows.Forms.NumericUpDown nUDTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbRound;
        private System.Windows.Forms.CheckBox cbShow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

