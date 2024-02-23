// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Mitarbeiterverwaltung
{
    partial class Mitarbeiter_Bearbeiten
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
            CmdSpeichern = new Button();
            CmdAbbrechen = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            TxtTelefonnummer = new TextBox();
            TxtOrt = new TextBox();
            TxtPLZ = new TextBox();
            TxtAdresse = new TextBox();
            TxtStellenbezeichnung = new TextBox();
            TxtVorname = new TextBox();
            TxtName = new TextBox();
            TxtPersonalnummer = new TextBox();
            CmbAbteilung = new ComboBox();
            SuspendLayout();
            // 
            // CmdSpeichern
            // 
            CmdSpeichern.Location = new Point(22, 313);
            CmdSpeichern.Name = "CmdSpeichern";
            CmdSpeichern.Size = new Size(75, 23);
            CmdSpeichern.TabIndex = 0;
            CmdSpeichern.Text = "Speichern";
            CmdSpeichern.UseVisualStyleBackColor = true;
            // 
            // CmdAbbrechen
            // 
            CmdAbbrechen.Location = new Point(186, 313);
            CmdAbbrechen.Name = "CmdAbbrechen";
            CmdAbbrechen.Size = new Size(75, 23);
            CmdAbbrechen.TabIndex = 1;
            CmdAbbrechen.Text = "Abbrechen";
            CmdAbbrechen.UseVisualStyleBackColor = true;
            CmdAbbrechen.Click += CmdAbbrechen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 46);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 2;
            label1.Text = "Personalnummer:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 75);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 3;
            label2.Text = "Abteilung:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 104);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 4;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 133);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 5;
            label4.Text = "Vorname:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 162);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 6;
            label5.Text = "Stellenbezeichnung";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 191);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 7;
            label6.Text = "Adresse:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 220);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 8;
            label7.Text = "PLZ:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 249);
            label8.Name = "label8";
            label8.Size = new Size(27, 15);
            label8.TabIndex = 9;
            label8.Text = "Ort:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 278);
            label9.Name = "label9";
            label9.Size = new Size(94, 15);
            label9.TabIndex = 10;
            label9.Text = "Telefonnummer:";
            // 
            // TxtTelefonnummer
            // 
            TxtTelefonnummer.Location = new Point(140, 275);
            TxtTelefonnummer.Name = "TxtTelefonnummer";
            TxtTelefonnummer.Size = new Size(121, 23);
            TxtTelefonnummer.TabIndex = 11;
            // 
            // TxtOrt
            // 
            TxtOrt.Location = new Point(140, 246);
            TxtOrt.Name = "TxtOrt";
            TxtOrt.Size = new Size(121, 23);
            TxtOrt.TabIndex = 12;
            // 
            // TxtPLZ
            // 
            TxtPLZ.Location = new Point(140, 217);
            TxtPLZ.Name = "TxtPLZ";
            TxtPLZ.Size = new Size(121, 23);
            TxtPLZ.TabIndex = 13;
            // 
            // TxtAdresse
            // 
            TxtAdresse.Location = new Point(140, 188);
            TxtAdresse.Name = "TxtAdresse";
            TxtAdresse.Size = new Size(121, 23);
            TxtAdresse.TabIndex = 14;
            // 
            // TxtStellenbezeichnung
            // 
            TxtStellenbezeichnung.Location = new Point(140, 159);
            TxtStellenbezeichnung.Name = "TxtStellenbezeichnung";
            TxtStellenbezeichnung.Size = new Size(121, 23);
            TxtStellenbezeichnung.TabIndex = 15;
            // 
            // TxtVorname
            // 
            TxtVorname.Location = new Point(140, 130);
            TxtVorname.Name = "TxtVorname";
            TxtVorname.Size = new Size(121, 23);
            TxtVorname.TabIndex = 16;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(140, 101);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(121, 23);
            TxtName.TabIndex = 17;
            // 
            // TxtPersonalnummer
            // 
            TxtPersonalnummer.Location = new Point(140, 43);
            TxtPersonalnummer.Name = "TxtPersonalnummer";
            TxtPersonalnummer.Size = new Size(121, 23);
            TxtPersonalnummer.TabIndex = 18;
            // 
            // CmbAbteilung
            // 
            CmbAbteilung.FormattingEnabled = true;
            CmbAbteilung.Location = new Point(140, 72);
            CmbAbteilung.Name = "CmbAbteilung";
            CmbAbteilung.Size = new Size(121, 23);
            CmbAbteilung.TabIndex = 19;
            // 
            // Mitarbeiter_Bearbeiten
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmbAbteilung);
            Controls.Add(TxtPersonalnummer);
            Controls.Add(TxtName);
            Controls.Add(TxtVorname);
            Controls.Add(TxtStellenbezeichnung);
            Controls.Add(TxtAdresse);
            Controls.Add(TxtPLZ);
            Controls.Add(TxtOrt);
            Controls.Add(TxtTelefonnummer);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CmdAbbrechen);
            Controls.Add(CmdSpeichern);
            Name = "Mitarbeiter_Bearbeiten";
            Text = "Mitarbeiter_Bearbeiten";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdSpeichern;
        private Button CmdAbbrechen;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox TxtTelefonnummer;
        private TextBox TxtOrt;
        private TextBox TxtPLZ;
        private TextBox TxtAdresse;
        private TextBox TxtStellenbezeichnung;
        private TextBox TxtVorname;
        private TextBox TxtName;
        private TextBox TxtPersonalnummer;
        private ComboBox CmbAbteilung;
    }
}