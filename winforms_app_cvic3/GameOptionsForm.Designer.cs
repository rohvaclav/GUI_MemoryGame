
namespace winforms_app_cvic3
{
    partial class GameOptionsForm
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
            this.VyberObtiznosti = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.symbolCheckbox = new System.Windows.Forms.CheckBox();
            this.pocitaniCheckbox = new System.Windows.Forms.CheckBox();
            this.sekvenceCheckbox = new System.Windows.Forms.CheckBox();
            this.GameOptionsStartButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.VyberObtiznosti)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // VyberObtiznosti
            // 
            this.VyberObtiznosti.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.VyberObtiznosti.Location = new System.Drawing.Point(261, 164);
            this.VyberObtiznosti.Maximum = 9;
            this.VyberObtiznosti.Minimum = 1;
            this.VyberObtiznosti.Name = "VyberObtiznosti";
            this.VyberObtiznosti.Size = new System.Drawing.Size(252, 45);
            this.VyberObtiznosti.TabIndex = 0;
            this.VyberObtiznosti.Value = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(261, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 106);
            this.label1.TabIndex = 1;
            this.label1.Text = "Obtížnost:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // symbolCheckbox
            // 
            this.symbolCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.symbolCheckbox.AutoSize = true;
            this.symbolCheckbox.Location = new System.Drawing.Point(6, 14);
            this.symbolCheckbox.Name = "symbolCheckbox";
            this.symbolCheckbox.Size = new System.Drawing.Size(65, 17);
            this.symbolCheckbox.TabIndex = 2;
            this.symbolCheckbox.Text = "Symboly";
            this.symbolCheckbox.UseVisualStyleBackColor = true;
            // 
            // pocitaniCheckbox
            // 
            this.pocitaniCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pocitaniCheckbox.AutoSize = true;
            this.pocitaniCheckbox.Location = new System.Drawing.Point(88, 14);
            this.pocitaniCheckbox.Name = "pocitaniCheckbox";
            this.pocitaniCheckbox.Size = new System.Drawing.Size(68, 17);
            this.pocitaniCheckbox.TabIndex = 3;
            this.pocitaniCheckbox.Text = "Počítání";
            this.pocitaniCheckbox.UseVisualStyleBackColor = true;
            // 
            // sekvenceCheckbox
            // 
            this.sekvenceCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sekvenceCheckbox.AutoSize = true;
            this.sekvenceCheckbox.Location = new System.Drawing.Point(181, 14);
            this.sekvenceCheckbox.Name = "sekvenceCheckbox";
            this.sekvenceCheckbox.Size = new System.Drawing.Size(75, 17);
            this.sekvenceCheckbox.TabIndex = 4;
            this.sekvenceCheckbox.Text = "Sekvence";
            this.sekvenceCheckbox.UseVisualStyleBackColor = true;
            // 
            // GameOptionsStartButton
            // 
            this.GameOptionsStartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameOptionsStartButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GameOptionsStartButton.Location = new System.Drawing.Point(54, 20);
            this.GameOptionsStartButton.Name = "GameOptionsStartButton";
            this.GameOptionsStartButton.Size = new System.Drawing.Size(140, 64);
            this.GameOptionsStartButton.TabIndex = 5;
            this.GameOptionsStartButton.Text = "&Zapni hru";
            this.GameOptionsStartButton.UseVisualStyleBackColor = true;
            this.GameOptionsStartButton.Click += new System.EventHandler(this.GameOptionsStartButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.symbolCheckbox);
            this.panel1.Controls.Add(this.sekvenceCheckbox);
            this.panel1.Controls.Add(this.pocitaniCheckbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(261, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 100);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.VyberObtiznosti, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 426);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.GameOptionsStartButton);
            this.panel2.Location = new System.Drawing.Point(261, 321);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 102);
            this.panel2.TabIndex = 3;
            // 
            // GameOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GameOptionsForm";
            this.Text = "GameOptionsForm";
            ((System.ComponentModel.ISupportInitialize)(this.VyberObtiznosti)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar VyberObtiznosti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox symbolCheckbox;
        private System.Windows.Forms.CheckBox pocitaniCheckbox;
        private System.Windows.Forms.CheckBox sekvenceCheckbox;
        private System.Windows.Forms.Button GameOptionsStartButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
    }
}