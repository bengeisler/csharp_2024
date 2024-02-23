// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Mitarbeiterverwaltung4
{
    partial class Abteilungbearbeiten
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
            TxtAbteilungsnummer = new TextBox();
            TxtAbteilungsbezeichung = new TextBox();
            CmdSpeichern = new Button();
            CmdAbbrechen = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 44);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Abteilungsnummer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 102);
            label2.Name = "label2";
            label2.Size = new Size(132, 15);
            label2.TabIndex = 1;
            label2.Text = "Abteilungsbezeichnung";
            // 
            // TxtAbteilungsnummer
            // 
            TxtAbteilungsnummer.Location = new Point(154, 44);
            TxtAbteilungsnummer.Name = "TxtAbteilungsnummer";
            TxtAbteilungsnummer.Size = new Size(100, 23);
            TxtAbteilungsnummer.TabIndex = 2;
            // 
            // TxtAbteilungsbezeichung
            // 
            TxtAbteilungsbezeichung.Location = new Point(154, 102);
            TxtAbteilungsbezeichung.Name = "TxtAbteilungsbezeichung";
            TxtAbteilungsbezeichung.Size = new Size(100, 23);
            TxtAbteilungsbezeichung.TabIndex = 3;
            // 
            // CmdSpeichern
            // 
            CmdSpeichern.Location = new Point(40, 175);
            CmdSpeichern.Name = "CmdSpeichern";
            CmdSpeichern.Size = new Size(75, 23);
            CmdSpeichern.TabIndex = 4;
            CmdSpeichern.Text = "Speichern";
            CmdSpeichern.UseVisualStyleBackColor = true;
            // 
            // CmdAbbrechen
            // 
            CmdAbbrechen.Location = new Point(179, 175);
            CmdAbbrechen.Name = "CmdAbbrechen";
            CmdAbbrechen.Size = new Size(75, 23);
            CmdAbbrechen.TabIndex = 5;
            CmdAbbrechen.Text = "Abbrechen";
            CmdAbbrechen.UseVisualStyleBackColor = true;
            // 
            // Abteilungbearbeiten
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdAbbrechen);
            Controls.Add(CmdSpeichern);
            Controls.Add(TxtAbteilungsbezeichung);
            Controls.Add(TxtAbteilungsnummer);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Abteilungbearbeiten";
            Text = "Abteilungbearbeiten";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtAbteilungsnummer;
        private TextBox TxtAbteilungsbezeichung;
        private Button CmdSpeichern;
        private Button CmdAbbrechen;
    }
}