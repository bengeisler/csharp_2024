// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Mitarbeiterverwaltung
{
    partial class FrmMitarbeiterBearbeiten
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
            TxtPersonalnummer = new TextBox();
            TxtTelefonnummer = new TextBox();
            TxtName = new TextBox();
            TxtVorname = new TextBox();
            TxtStellenbezeichnung = new TextBox();
            TxtAdresse = new TextBox();
            TxtPlz = new TextBox();
            TxtOrt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            CboxAbteilung = new ComboBox();
            CmdSpeichern = new Button();
            CmdAbbrechen = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 0;
            label1.Text = "Personalnummer:";
            // 
            // TxtPersonalnummer
            // 
            TxtPersonalnummer.Location = new Point(197, 6);
            TxtPersonalnummer.Name = "TxtPersonalnummer";
            TxtPersonalnummer.ReadOnly = true;
            TxtPersonalnummer.Size = new Size(267, 31);
            TxtPersonalnummer.TabIndex = 1;
            // 
            // TxtTelefonnummer
            // 
            TxtTelefonnummer.Location = new Point(197, 302);
            TxtTelefonnummer.Name = "TxtTelefonnummer";
            TxtTelefonnummer.Size = new Size(267, 31);
            TxtTelefonnummer.TabIndex = 2;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(197, 80);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(267, 31);
            TxtName.TabIndex = 3;
            // 
            // TxtVorname
            // 
            TxtVorname.Location = new Point(197, 117);
            TxtVorname.Name = "TxtVorname";
            TxtVorname.Size = new Size(267, 31);
            TxtVorname.TabIndex = 4;
            // 
            // TxtStellenbezeichnung
            // 
            TxtStellenbezeichnung.Location = new Point(197, 154);
            TxtStellenbezeichnung.Name = "TxtStellenbezeichnung";
            TxtStellenbezeichnung.Size = new Size(267, 31);
            TxtStellenbezeichnung.TabIndex = 5;
            // 
            // TxtAdresse
            // 
            TxtAdresse.Location = new Point(197, 191);
            TxtAdresse.Name = "TxtAdresse";
            TxtAdresse.Size = new Size(267, 31);
            TxtAdresse.TabIndex = 6;
            // 
            // TxtPlz
            // 
            TxtPlz.Location = new Point(197, 228);
            TxtPlz.Name = "TxtPlz";
            TxtPlz.Size = new Size(267, 31);
            TxtPlz.TabIndex = 7;
            // 
            // TxtOrt
            // 
            TxtOrt.Location = new Point(197, 265);
            TxtOrt.Name = "TxtOrt";
            TxtOrt.Size = new Size(267, 31);
            TxtOrt.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 9;
            label2.Text = "Abteilung";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 83);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 10;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 120);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 11;
            label4.Text = "Vorname:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 157);
            label5.Name = "label5";
            label5.Size = new Size(167, 25);
            label5.TabIndex = 12;
            label5.Text = "Stellenbezeichnung:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 194);
            label6.Name = "label6";
            label6.Size = new Size(79, 25);
            label6.TabIndex = 13;
            label6.Text = "Adresse:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 231);
            label7.Name = "label7";
            label7.Size = new Size(45, 25);
            label7.TabIndex = 14;
            label7.Text = "PLZ:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 268);
            label8.Name = "label8";
            label8.Size = new Size(42, 25);
            label8.TabIndex = 15;
            label8.Text = "Ort:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 305);
            label9.Name = "label9";
            label9.Size = new Size(139, 25);
            label9.TabIndex = 16;
            label9.Text = "Telefonnummer:";
            // 
            // CboxAbteilung
            // 
            CboxAbteilung.FormattingEnabled = true;
            CboxAbteilung.Location = new Point(197, 43);
            CboxAbteilung.Name = "CboxAbteilung";
            CboxAbteilung.Size = new Size(267, 33);
            CboxAbteilung.TabIndex = 17;
            // 
            // CmdSpeichern
            // 
            CmdSpeichern.Location = new Point(12, 368);
            CmdSpeichern.Name = "CmdSpeichern";
            CmdSpeichern.Size = new Size(112, 34);
            CmdSpeichern.TabIndex = 18;
            CmdSpeichern.Text = "Speichern";
            CmdSpeichern.UseVisualStyleBackColor = true;
            CmdSpeichern.Click += CmdSpeichern_Click;
            // 
            // CmdAbbrechen
            // 
            CmdAbbrechen.Location = new Point(352, 368);
            CmdAbbrechen.Name = "CmdAbbrechen";
            CmdAbbrechen.Size = new Size(112, 34);
            CmdAbbrechen.TabIndex = 19;
            CmdAbbrechen.Text = "Abbrechen";
            CmdAbbrechen.UseVisualStyleBackColor = true;
            CmdAbbrechen.Click += CmdAbbrechen_Click;
            // 
            // FrmMitarbeiterBearbeiten
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 412);
            Controls.Add(CmdAbbrechen);
            Controls.Add(CmdSpeichern);
            Controls.Add(CboxAbteilung);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TxtOrt);
            Controls.Add(TxtPlz);
            Controls.Add(TxtAdresse);
            Controls.Add(TxtStellenbezeichnung);
            Controls.Add(TxtVorname);
            Controls.Add(TxtName);
            Controls.Add(TxtTelefonnummer);
            Controls.Add(TxtPersonalnummer);
            Controls.Add(label1);
            Name = "FrmMitarbeiterBearbeiten";
            Text = "Mitarbeiter bearbeiten";
            FormClosing += FrmMitarbeiterBearbeiten_FormClosing;
            Load += FrmMitarbeiterBearbeiten_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtPersonalnummer;
        private TextBox TxtTelefonnummer;
        private TextBox TxtName;
        private TextBox TxtVorname;
        private TextBox TxtStellenbezeichnung;
        private TextBox TxtAdresse;
        private TextBox TxtPlz;
        private TextBox TxtOrt;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox CboxAbteilung;
        private Button CmdSpeichern;
        private Button CmdAbbrechen;
    }
}