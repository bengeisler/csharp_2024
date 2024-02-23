// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace AUfgabe_Autowerkstatt
{
    partial class FrmFahzeuge
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
            Lbl1 = new Label();
            Lbl2 = new Label();
            Lbl3 = new Label();
            Lbl4 = new Label();
            Lbl5 = new Label();
            TxtKennzeichen = new TextBox();
            TxtMarke = new TextBox();
            TxtModell = new TextBox();
            TxtHalter = new TextBox();
            TxtOrt = new TextBox();
            CmdSpeichern = new Button();
            CmdAbbrechen = new Button();
            label1 = new Label();
            LblNummer = new Label();
            SuspendLayout();
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Location = new Point(24, 38);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(77, 15);
            Lbl1.TabIndex = 1;
            Lbl1.Text = "Kennzeichen:";
            // 
            // Lbl2
            // 
            Lbl2.AutoSize = true;
            Lbl2.Location = new Point(24, 63);
            Lbl2.Name = "Lbl2";
            Lbl2.Size = new Size(43, 15);
            Lbl2.TabIndex = 2;
            Lbl2.Text = "Marke:";
            // 
            // Lbl3
            // 
            Lbl3.AutoSize = true;
            Lbl3.Location = new Point(24, 95);
            Lbl3.Name = "Lbl3";
            Lbl3.Size = new Size(47, 15);
            Lbl3.TabIndex = 3;
            Lbl3.Text = "Modell:";
            // 
            // Lbl4
            // 
            Lbl4.AutoSize = true;
            Lbl4.Location = new Point(24, 129);
            Lbl4.Name = "Lbl4";
            Lbl4.Size = new Size(42, 15);
            Lbl4.TabIndex = 4;
            Lbl4.Text = "Halter:";
            // 
            // Lbl5
            // 
            Lbl5.AutoSize = true;
            Lbl5.Location = new Point(24, 165);
            Lbl5.Name = "Lbl5";
            Lbl5.Size = new Size(27, 15);
            Lbl5.TabIndex = 5;
            Lbl5.Text = "Ort:";
            // 
            // TxtKennzeichen
            // 
            TxtKennzeichen.Location = new Point(116, 30);
            TxtKennzeichen.Name = "TxtKennzeichen";
            TxtKennzeichen.Size = new Size(100, 23);
            TxtKennzeichen.TabIndex = 7;
            // 
            // TxtMarke
            // 
            TxtMarke.Location = new Point(116, 63);
            TxtMarke.Name = "TxtMarke";
            TxtMarke.Size = new Size(100, 23);
            TxtMarke.TabIndex = 8;
            // 
            // TxtModell
            // 
            TxtModell.Location = new Point(116, 95);
            TxtModell.Name = "TxtModell";
            TxtModell.Size = new Size(100, 23);
            TxtModell.TabIndex = 9;
            // 
            // TxtHalter
            // 
            TxtHalter.Location = new Point(116, 124);
            TxtHalter.Name = "TxtHalter";
            TxtHalter.Size = new Size(100, 23);
            TxtHalter.TabIndex = 10;
            // 
            // TxtOrt
            // 
            TxtOrt.Location = new Point(116, 157);
            TxtOrt.Name = "TxtOrt";
            TxtOrt.Size = new Size(100, 23);
            TxtOrt.TabIndex = 11;
            // 
            // CmdSpeichern
            // 
            CmdSpeichern.Location = new Point(26, 250);
            CmdSpeichern.Name = "CmdSpeichern";
            CmdSpeichern.Size = new Size(75, 23);
            CmdSpeichern.TabIndex = 12;
            CmdSpeichern.Text = "Speichern";
            CmdSpeichern.UseVisualStyleBackColor = true;
            // 
            // CmdAbbrechen
            // 
            CmdAbbrechen.Location = new Point(188, 250);
            CmdAbbrechen.Name = "CmdAbbrechen";
            CmdAbbrechen.Size = new Size(75, 23);
            CmdAbbrechen.TabIndex = 13;
            CmdAbbrechen.Text = "Abbrechen";
            CmdAbbrechen.UseVisualStyleBackColor = true;
            CmdAbbrechen.Click += CmdAbbrechen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 9);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 14;
            label1.Text = "Nr:";
            // 
            // LblNummer
            // 
            LblNummer.AutoSize = true;
            LblNummer.Location = new Point(116, 9);
            LblNummer.Name = "LblNummer";
            LblNummer.Size = new Size(38, 15);
            LblNummer.TabIndex = 15;
            LblNummer.Text = "label2";
            // 
            // FrmFahzeuge
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblNummer);
            Controls.Add(label1);
            Controls.Add(CmdAbbrechen);
            Controls.Add(CmdSpeichern);
            Controls.Add(TxtOrt);
            Controls.Add(TxtHalter);
            Controls.Add(TxtModell);
            Controls.Add(TxtMarke);
            Controls.Add(TxtKennzeichen);
            Controls.Add(Lbl5);
            Controls.Add(Lbl4);
            Controls.Add(Lbl3);
            Controls.Add(Lbl2);
            Controls.Add(Lbl1);
            Name = "FrmFahzeuge";
            Text = "frmFahzeuge";
            Load += FrmFahzeuge_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Lbl1;
        private Label Lbl2;
        private Label Lbl3;
        private Label Lbl4;
        private Label Lbl5;
        private TextBox TxtKennzeichen;
        private TextBox TxtMarke;
        private TextBox TxtModell;
        private TextBox TxtHalter;
        private TextBox TxtOrt;
        private Button CmdSpeichern;
        private Button CmdAbbrechen;
        private Label label1;
        private Label LblNummer;
    }
}
