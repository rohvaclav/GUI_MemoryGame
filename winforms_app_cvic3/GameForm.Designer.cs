
namespace winforms_app_cvic3
{
    partial class GameForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerTextBox = new System.Windows.Forms.TextBox();
            this.symbolTextBox = new System.Windows.Forms.TextBox();
            this.symbolTextBox_result = new System.Windows.Forms.TextBox();
            this.skoreTextBox = new System.Windows.Forms.TextBox();
            this.zivotyTextBox = new System.Windows.Forms.TextBox();
            this.numpadButton4 = new System.Windows.Forms.Button();
            this.numpadButton5 = new System.Windows.Forms.Button();
            this.numpadButton6 = new System.Windows.Forms.Button();
            this.numpadButton7 = new System.Windows.Forms.Button();
            this.numpadButton8 = new System.Windows.Forms.Button();
            this.numpadButton9 = new System.Windows.Forms.Button();
            this.sekvenceTextBox_result = new System.Windows.Forms.TextBox();
            this.timerTextBox2 = new System.Windows.Forms.TextBox();
            this.pocitaniTextBox_result = new System.Windows.Forms.TextBox();
            this.pocitaniTimer = new System.Windows.Forms.Timer(this.components);
            this.labelCara_rozdelujici = new System.Windows.Forms.Label();
            this.labelCara_nalevo = new System.Windows.Forms.Label();
            this.labelCara_napravo = new System.Windows.Forms.Label();
            this.labelCara_horni = new System.Windows.Forms.Label();
            this.labelCara_spodni = new System.Windows.Forms.Label();
            this.redColorButton = new System.Windows.Forms.Button();
            this.greenColorButton = new System.Windows.Forms.Button();
            this.blueColorButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(665, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(374, 14);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(84, 23);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerTextBox
            // 
            this.timerTextBox.Location = new System.Drawing.Point(603, 252);
            this.timerTextBox.Name = "timerTextBox";
            this.timerTextBox.ReadOnly = true;
            this.timerTextBox.Size = new System.Drawing.Size(171, 20);
            this.timerTextBox.TabIndex = 6;
            // 
            // symbolTextBox
            // 
            this.symbolTextBox.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.symbolTextBox.Location = new System.Drawing.Point(80, 107);
            this.symbolTextBox.Multiline = true;
            this.symbolTextBox.Name = "symbolTextBox";
            this.symbolTextBox.Size = new System.Drawing.Size(75, 68);
            this.symbolTextBox.TabIndex = 9;
            this.symbolTextBox.Click += new System.EventHandler(this.symbolTextBox_click);
            // 
            // symbolTextBox_result
            // 
            this.symbolTextBox_result.Font = new System.Drawing.Font("Webdings", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.symbolTextBox_result.Location = new System.Drawing.Point(95, 38);
            this.symbolTextBox_result.Multiline = true;
            this.symbolTextBox_result.Name = "symbolTextBox_result";
            this.symbolTextBox_result.Size = new System.Drawing.Size(44, 40);
            this.symbolTextBox_result.TabIndex = 10;
            // 
            // skoreTextBox
            // 
            this.skoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.skoreTextBox.Location = new System.Drawing.Point(374, 43);
            this.skoreTextBox.Multiline = true;
            this.skoreTextBox.Name = "skoreTextBox";
            this.skoreTextBox.Size = new System.Drawing.Size(84, 39);
            this.skoreTextBox.TabIndex = 11;
            this.skoreTextBox.Text = "0";
            this.skoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // zivotyTextBox
            // 
            this.zivotyTextBox.Font = new System.Drawing.Font("Webdings", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.zivotyTextBox.ForeColor = System.Drawing.Color.Red;
            this.zivotyTextBox.Location = new System.Drawing.Point(339, 88);
            this.zivotyTextBox.Multiline = true;
            this.zivotyTextBox.Name = "zivotyTextBox";
            this.zivotyTextBox.Size = new System.Drawing.Size(151, 61);
            this.zivotyTextBox.TabIndex = 12;
            this.zivotyTextBox.Text = "YYY";
            // 
            // numpadButton4
            // 
            this.numpadButton4.Location = new System.Drawing.Point(318, 178);
            this.numpadButton4.Name = "numpadButton4";
            this.numpadButton4.Size = new System.Drawing.Size(61, 23);
            this.numpadButton4.TabIndex = 14;
            this.numpadButton4.Tag = "4";
            this.numpadButton4.Text = "4";
            this.numpadButton4.UseVisualStyleBackColor = true;
            this.numpadButton4.Click += new System.EventHandler(this.numpadButton_Click);
            // 
            // numpadButton5
            // 
            this.numpadButton5.Location = new System.Drawing.Point(385, 178);
            this.numpadButton5.Name = "numpadButton5";
            this.numpadButton5.Size = new System.Drawing.Size(61, 23);
            this.numpadButton5.TabIndex = 15;
            this.numpadButton5.Tag = "5";
            this.numpadButton5.Text = "5";
            this.numpadButton5.UseVisualStyleBackColor = true;
            this.numpadButton5.Click += new System.EventHandler(this.numpadButton_Click);
            // 
            // numpadButton6
            // 
            this.numpadButton6.Location = new System.Drawing.Point(452, 179);
            this.numpadButton6.Name = "numpadButton6";
            this.numpadButton6.Size = new System.Drawing.Size(61, 23);
            this.numpadButton6.TabIndex = 16;
            this.numpadButton6.Tag = "6";
            this.numpadButton6.Text = "6";
            this.numpadButton6.UseVisualStyleBackColor = true;
            this.numpadButton6.Click += new System.EventHandler(this.numpadButton_Click);
            // 
            // numpadButton7
            // 
            this.numpadButton7.Location = new System.Drawing.Point(318, 208);
            this.numpadButton7.Name = "numpadButton7";
            this.numpadButton7.Size = new System.Drawing.Size(61, 23);
            this.numpadButton7.TabIndex = 17;
            this.numpadButton7.Tag = "7";
            this.numpadButton7.Text = "7";
            this.numpadButton7.UseVisualStyleBackColor = true;
            this.numpadButton7.Click += new System.EventHandler(this.numpadButton_Click);
            // 
            // numpadButton8
            // 
            this.numpadButton8.Location = new System.Drawing.Point(385, 208);
            this.numpadButton8.Name = "numpadButton8";
            this.numpadButton8.Size = new System.Drawing.Size(61, 23);
            this.numpadButton8.TabIndex = 18;
            this.numpadButton8.Tag = "8";
            this.numpadButton8.Text = "8";
            this.numpadButton8.UseVisualStyleBackColor = true;
            this.numpadButton8.Click += new System.EventHandler(this.numpadButton_Click);
            // 
            // numpadButton9
            // 
            this.numpadButton9.Location = new System.Drawing.Point(452, 208);
            this.numpadButton9.Name = "numpadButton9";
            this.numpadButton9.Size = new System.Drawing.Size(61, 23);
            this.numpadButton9.TabIndex = 19;
            this.numpadButton9.Tag = "9";
            this.numpadButton9.Text = "9";
            this.numpadButton9.UseVisualStyleBackColor = true;
            this.numpadButton9.Click += new System.EventHandler(this.numpadButton_Click);
            // 
            // sekvenceTextBox_result
            // 
            this.sekvenceTextBox_result.Font = new System.Drawing.Font("Webdings", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.sekvenceTextBox_result.Location = new System.Drawing.Point(670, 43);
            this.sekvenceTextBox_result.Multiline = true;
            this.sekvenceTextBox_result.Name = "sekvenceTextBox_result";
            this.sekvenceTextBox_result.Size = new System.Drawing.Size(45, 40);
            this.sekvenceTextBox_result.TabIndex = 20;
            // 
            // timerTextBox2
            // 
            this.timerTextBox2.Location = new System.Drawing.Point(330, 252);
            this.timerTextBox2.Name = "timerTextBox2";
            this.timerTextBox2.Size = new System.Drawing.Size(171, 20);
            this.timerTextBox2.TabIndex = 21;
            // 
            // pocitaniTextBox_result
            // 
            this.pocitaniTextBox_result.Font = new System.Drawing.Font("Webdings", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.pocitaniTextBox_result.Location = new System.Drawing.Point(390, 35);
            this.pocitaniTextBox_result.Multiline = true;
            this.pocitaniTextBox_result.Name = "pocitaniTextBox_result";
            this.pocitaniTextBox_result.Size = new System.Drawing.Size(50, 43);
            this.pocitaniTextBox_result.TabIndex = 22;
            // 
            // pocitaniTimer
            // 
            this.pocitaniTimer.Tick += new System.EventHandler(this.pocitaniTimer_Tick);
            // 
            // labelCara_rozdelujici
            // 
            this.labelCara_rozdelujici.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCara_rozdelujici.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCara_rozdelujici.Location = new System.Drawing.Point(-1, 286);
            this.labelCara_rozdelujici.Name = "labelCara_rozdelujici";
            this.labelCara_rozdelujici.Size = new System.Drawing.Size(800, 2);
            this.labelCara_rozdelujici.TabIndex = 24;
            // 
            // labelCara_nalevo
            // 
            this.labelCara_nalevo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCara_nalevo.Location = new System.Drawing.Point(318, 80);
            this.labelCara_nalevo.Name = "labelCara_nalevo";
            this.labelCara_nalevo.Size = new System.Drawing.Size(2, 95);
            this.labelCara_nalevo.TabIndex = 25;
            // 
            // labelCara_napravo
            // 
            this.labelCara_napravo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCara_napravo.Location = new System.Drawing.Point(511, 80);
            this.labelCara_napravo.Name = "labelCara_napravo";
            this.labelCara_napravo.Size = new System.Drawing.Size(2, 95);
            this.labelCara_napravo.TabIndex = 26;
            // 
            // labelCara_horni
            // 
            this.labelCara_horni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCara_horni.Location = new System.Drawing.Point(318, 81);
            this.labelCara_horni.Name = "labelCara_horni";
            this.labelCara_horni.Size = new System.Drawing.Size(193, 2);
            this.labelCara_horni.TabIndex = 27;
            // 
            // labelCara_spodni
            // 
            this.labelCara_spodni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCara_spodni.Location = new System.Drawing.Point(318, 173);
            this.labelCara_spodni.Name = "labelCara_spodni";
            this.labelCara_spodni.Size = new System.Drawing.Size(193, 2);
            this.labelCara_spodni.TabIndex = 28;
            // 
            // redColorButton
            // 
            this.redColorButton.BackColor = System.Drawing.Color.Red;
            this.redColorButton.Location = new System.Drawing.Point(606, 179);
            this.redColorButton.Name = "redColorButton";
            this.redColorButton.Size = new System.Drawing.Size(53, 50);
            this.redColorButton.TabIndex = 29;
            this.redColorButton.Tag = "0";
            this.redColorButton.UseVisualStyleBackColor = false;
            this.redColorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // greenColorButton
            // 
            this.greenColorButton.BackColor = System.Drawing.Color.Green;
            this.greenColorButton.Location = new System.Drawing.Point(665, 179);
            this.greenColorButton.Name = "greenColorButton";
            this.greenColorButton.Size = new System.Drawing.Size(53, 50);
            this.greenColorButton.TabIndex = 30;
            this.greenColorButton.Tag = "1";
            this.greenColorButton.UseVisualStyleBackColor = false;
            this.greenColorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // blueColorButton
            // 
            this.blueColorButton.BackColor = System.Drawing.Color.LightBlue;
            this.blueColorButton.Location = new System.Drawing.Point(721, 179);
            this.blueColorButton.Name = "blueColorButton";
            this.blueColorButton.Size = new System.Drawing.Size(53, 50);
            this.blueColorButton.TabIndex = 31;
            this.blueColorButton.Tag = "2";
            this.blueColorButton.UseVisualStyleBackColor = false;
            this.blueColorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.splitContainer1.Location = new System.Drawing.Point(-1, -1);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelCara_spodni);
            this.splitContainer1.Panel1.Controls.Add(this.blueColorButton);
            this.splitContainer1.Panel1.Controls.Add(this.labelCara_horni);
            this.splitContainer1.Panel1.Controls.Add(this.symbolTextBox_result);
            this.splitContainer1.Panel1.Controls.Add(this.labelCara_napravo);
            this.splitContainer1.Panel1.Controls.Add(this.redColorButton);
            this.splitContainer1.Panel1.Controls.Add(this.labelCara_nalevo);
            this.splitContainer1.Panel1.Controls.Add(this.greenColorButton);
            this.splitContainer1.Panel1.Controls.Add(this.symbolTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.numpadButton4);
            this.splitContainer1.Panel1.Controls.Add(this.numpadButton5);
            this.splitContainer1.Panel1.Controls.Add(this.numpadButton6);
            this.splitContainer1.Panel1.Controls.Add(this.numpadButton9);
            this.splitContainer1.Panel1.Controls.Add(this.timerTextBox2);
            this.splitContainer1.Panel1.Controls.Add(this.numpadButton8);
            this.splitContainer1.Panel1.Controls.Add(this.pocitaniTextBox_result);
            this.splitContainer1.Panel1.Controls.Add(this.numpadButton7);
            this.splitContainer1.Panel1.Controls.Add(this.sekvenceTextBox_result);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.timerTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.startButton);
            this.splitContainer1.Panel2.Controls.Add(this.skoreTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.zivotyTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(800, 451);
            this.splitContainer1.SplitterDistance = 287;
            this.splitContainer1.TabIndex = 32;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCara_rozdelujici);
            this.Controls.Add(this.splitContainer1);
            this.Name = "GameForm";
            this.Text = "Multitask memory hra";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label labelCara_nalevo;
        public System.Windows.Forms.Label labelCara_napravo;
        public System.Windows.Forms.Label labelCara_horni;
        public System.Windows.Forms.Label labelCara_spodni;
        public System.Windows.Forms.TextBox skoreTextBox;
        public System.Windows.Forms.TextBox pocitaniTextBox_result;
        public System.Windows.Forms.Timer pocitaniTimer;
        public System.Windows.Forms.TextBox zivotyTextBox;
        public System.Windows.Forms.TextBox symbolTextBox;
        public System.Windows.Forms.TextBox symbolTextBox_result;
        public System.Windows.Forms.Button startButton;
        public System.Windows.Forms.Button numpadButton4;
        public System.Windows.Forms.Button numpadButton5;
        public System.Windows.Forms.Button numpadButton6;
        public System.Windows.Forms.Button numpadButton7;
        public System.Windows.Forms.Button numpadButton8;
        public System.Windows.Forms.Button numpadButton9;
        public System.Windows.Forms.TextBox sekvenceTextBox_result;
        public System.Windows.Forms.TextBox timerTextBox2;
        public System.Windows.Forms.Label labelCara_rozdelujici;
        private System.Windows.Forms.Button redColorButton;
        private System.Windows.Forms.Button greenColorButton;
        private System.Windows.Forms.Button blueColorButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox timerTextBox;
    }
}

