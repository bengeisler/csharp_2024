namespace SteuerelementListBoxVerwalten
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CmdButton1 = new Button();
            CmdButton2 = new Button();
            CmdButton3 = new Button();
            CmdButton4 = new Button();
            LblAnzeige1 = new Label();
            LblAnzeige2 = new Label();
            RadBtn1 = new RadioButton();
            RadBtn2 = new RadioButton();
            RadBtn3 = new RadioButton();
            LstBox = new ListBox();
            TxtBtn1 = new TextBox();
            TxtBtn2 = new TextBox();
            LblAnzeige3 = new Label();
            SuspendLayout();
            // 
            // CmdButton1
            // 
            CmdButton1.Location = new Point(12, 155);
            CmdButton1.Name = "CmdButton1";
            CmdButton1.Size = new Size(120, 23);
            CmdButton1.TabIndex = 0;
            CmdButton1.Text = "Löschen";
            CmdButton1.UseVisualStyleBackColor = true;
            CmdButton1.Click += CmdButton1_Click;
            // 
            // CmdButton2
            // 
            CmdButton2.Location = new Point(12, 184);
            CmdButton2.Name = "CmdButton2";
            CmdButton2.Size = new Size(120, 23);
            CmdButton2.TabIndex = 1;
            CmdButton2.Text = "Ersetzen durch:";
            CmdButton2.UseVisualStyleBackColor = true;
            CmdButton2.Click += CmdButton2_Click_1;
            // 
            // CmdButton3
            // 
            CmdButton3.Location = new Point(277, 59);
            CmdButton3.Name = "CmdButton3";
            CmdButton3.Size = new Size(120, 23);
            CmdButton3.TabIndex = 2;
            CmdButton3.Text = "Einfügen";
            CmdButton3.UseVisualStyleBackColor = true;
            CmdButton3.Click += CmdButton3_Click;
            // 
            // CmdButton4
            // 
            CmdButton4.Location = new Point(277, 213);
            CmdButton4.Name = "CmdButton4";
            CmdButton4.Size = new Size(120, 23);
            CmdButton4.TabIndex = 3;
            CmdButton4.Text = "Alles löschen";
            CmdButton4.UseVisualStyleBackColor = true;
            CmdButton4.Click += CmdButton4_Click;
            // 
            // LblAnzeige1
            // 
            LblAnzeige1.AutoSize = true;
            LblAnzeige1.Location = new Point(12, 137);
            LblAnzeige1.Name = "LblAnzeige1";
            LblAnzeige1.Size = new Size(129, 15);
            LblAnzeige1.TabIndex = 4;
            LblAnzeige1.Text = "Ausgewähltes Element:";
            // 
            // LblAnzeige2
            // 
            LblAnzeige2.AutoSize = true;
            LblAnzeige2.Location = new Point(295, 12);
            LblAnzeige2.Name = "LblAnzeige2";
            LblAnzeige2.Size = new Size(89, 15);
            LblAnzeige2.TabIndex = 5;
            LblAnzeige2.Text = "Neues Element:";
            // 
            // RadBtn1
            // 
            RadBtn1.AutoSize = true;
            RadBtn1.Location = new Point(277, 138);
            RadBtn1.Name = "RadBtn1";
            RadBtn1.Size = new Size(120, 19);
            RadBtn1.TabIndex = 6;
            RadBtn1.TabStop = true;
            RadBtn1.Text = "Am Ende der Liste";
            RadBtn1.UseVisualStyleBackColor = true;
            // 
            // RadBtn2
            // 
            RadBtn2.AutoSize = true;
            RadBtn2.Location = new Point(277, 163);
            RadBtn2.Name = "RadBtn2";
            RadBtn2.Size = new Size(133, 19);
            RadBtn2.TabIndex = 7;
            RadBtn2.TabStop = true;
            RadBtn2.Text = "Am Anfang der Liste";
            RadBtn2.UseVisualStyleBackColor = true;
            // 
            // RadBtn3
            // 
            RadBtn3.AutoSize = true;
            RadBtn3.Location = new Point(277, 188);
            RadBtn3.Name = "RadBtn3";
            RadBtn3.Size = new Size(168, 19);
            RadBtn3.TabIndex = 8;
            RadBtn3.TabStop = true;
            RadBtn3.Text = "Vor ausgewähltem Element";
            RadBtn3.UseVisualStyleBackColor = true;
            // 
            // LstBox
            // 
            LstBox.FormattingEnabled = true;
            LstBox.ItemHeight = 15;
            LstBox.Location = new Point(12, 12);
            LstBox.Name = "LstBox";
            LstBox.Size = new Size(120, 124);
            LstBox.TabIndex = 9;
            // 
            // TxtBtn1
            // 
            TxtBtn1.Location = new Point(277, 30);
            TxtBtn1.Name = "TxtBtn1";
            TxtBtn1.Size = new Size(120, 23);
            TxtBtn1.TabIndex = 10;
            // 
            // TxtBtn2
            // 
            TxtBtn2.Location = new Point(12, 213);
            TxtBtn2.Name = "TxtBtn2";
            TxtBtn2.Size = new Size(120, 23);
            TxtBtn2.TabIndex = 11;
            // 
            // LblAnzeige3
            // 
            LblAnzeige3.AutoSize = true;
            LblAnzeige3.Location = new Point(295, 120);
            LblAnzeige3.Name = "LblAnzeige3";
            LblAnzeige3.Size = new Size(65, 15);
            LblAnzeige3.TabIndex = 12;
            LblAnzeige3.Text = "Einfügeort:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 257);
            Controls.Add(LblAnzeige3);
            Controls.Add(TxtBtn2);
            Controls.Add(TxtBtn1);
            Controls.Add(LstBox);
            Controls.Add(RadBtn3);
            Controls.Add(RadBtn2);
            Controls.Add(RadBtn1);
            Controls.Add(LblAnzeige2);
            Controls.Add(LblAnzeige1);
            Controls.Add(CmdButton4);
            Controls.Add(CmdButton3);
            Controls.Add(CmdButton2);
            Controls.Add(CmdButton1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdButton1;
        private Button CmdButton2;
        private Button CmdButton3;
        private Button CmdButton4;
        private Label LblAnzeige1;
        private Label LblAnzeige2;
        private RadioButton RadBtn1;
        private RadioButton RadBtn2;
        private RadioButton RadBtn3;
        private ListBox LstBox;
        private TextBox TxtBtn1;
        private TextBox TxtBtn2;
        private Label LblAnzeige3;
    }
}
