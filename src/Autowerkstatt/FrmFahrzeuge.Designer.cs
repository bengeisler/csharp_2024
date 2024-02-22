// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Autowerkstatt
{
    partial class FrmFahrzeuge
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            LblNummer = new Label();
            TxtKennzeichen = new TextBox();
            TxtMarke = new TextBox();
            TxtModell = new TextBox();
            TxtHalter = new TextBox();
            TxtOrt = new TextBox();
            CmdSpeichern = new Button();
            CmdAbbrechen = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(35, 25);
            label1.TabIndex = 0;
            label1.Text = "Nr:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 1;
            label2.Text = "Kennzeichen:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 77);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 2;
            label3.Text = "Marke:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 114);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 3;
            label4.Text = "Modell:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 151);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 4;
            label5.Text = "Halter:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 188);
            label6.Name = "label6";
            label6.Size = new Size(42, 25);
            label6.TabIndex = 5;
            label6.Text = "Ort:";
            // 
            // LblNummer
            // 
            LblNummer.AutoSize = true;
            LblNummer.Location = new Point(150, 9);
            LblNummer.Name = "LblNummer";
            LblNummer.Size = new Size(105, 25);
            LblNummer.TabIndex = 6;
            LblNummer.Text = "LblNummer";
            // 
            // TxtKennzeichen
            // 
            TxtKennzeichen.Location = new Point(150, 37);
            TxtKennzeichen.Name = "TxtKennzeichen";
            TxtKennzeichen.Size = new Size(150, 31);
            TxtKennzeichen.TabIndex = 7;
            // 
            // TxtMarke
            // 
            TxtMarke.Location = new Point(150, 74);
            TxtMarke.Name = "TxtMarke";
            TxtMarke.Size = new Size(150, 31);
            TxtMarke.TabIndex = 8;
            // 
            // TxtModell
            // 
            TxtModell.Location = new Point(150, 111);
            TxtModell.Name = "TxtModell";
            TxtModell.Size = new Size(150, 31);
            TxtModell.TabIndex = 9;
            // 
            // TxtHalter
            // 
            TxtHalter.Location = new Point(150, 148);
            TxtHalter.Name = "TxtHalter";
            TxtHalter.Size = new Size(150, 31);
            TxtHalter.TabIndex = 10;
            // 
            // TxtOrt
            // 
            TxtOrt.Location = new Point(150, 185);
            TxtOrt.Name = "TxtOrt";
            TxtOrt.Size = new Size(150, 31);
            TxtOrt.TabIndex = 11;
            // 
            // CmdSpeichern
            // 
            CmdSpeichern.Location = new Point(12, 254);
            CmdSpeichern.Name = "CmdSpeichern";
            CmdSpeichern.Size = new Size(112, 34);
            CmdSpeichern.TabIndex = 12;
            CmdSpeichern.Text = "Speichern";
            CmdSpeichern.UseVisualStyleBackColor = true;
            // 
            // CmdAbbrechen
            // 
            CmdAbbrechen.Location = new Point(188, 254);
            CmdAbbrechen.Name = "CmdAbbrechen";
            CmdAbbrechen.Size = new Size(112, 34);
            CmdAbbrechen.TabIndex = 13;
            CmdAbbrechen.Text = "Abbrechen";
            CmdAbbrechen.UseVisualStyleBackColor = true;
            // 
            // FrmFahrzeuge
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 312);
            Controls.Add(CmdAbbrechen);
            Controls.Add(CmdSpeichern);
            Controls.Add(TxtOrt);
            Controls.Add(TxtHalter);
            Controls.Add(TxtModell);
            Controls.Add(TxtMarke);
            Controls.Add(TxtKennzeichen);
            Controls.Add(LblNummer);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmFahrzeuge";
            Text = "Fahrzeuge";
            Load += FrmFahrzeuge_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label LblNummer;
        private TextBox TxtKennzeichen;
        private TextBox TxtMarke;
        private TextBox TxtModell;
        private TextBox TxtHalter;
        private TextBox TxtOrt;
        private Button CmdSpeichern;
        private Button CmdAbbrechen;
    }
}