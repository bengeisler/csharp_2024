// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Mitarbeiterverwaltung
{
    partial class FrmAbteilungBearbeiten
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
            CmdAbbrechen = new Button();
            CmdSpeichern = new Button();
            label3 = new Label();
            TxtAbteilungsbezeichnung = new TextBox();
            TxtAbteilungsnummer = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // CmdAbbrechen
            // 
            CmdAbbrechen.Location = new Point(395, 96);
            CmdAbbrechen.Name = "CmdAbbrechen";
            CmdAbbrechen.Size = new Size(112, 34);
            CmdAbbrechen.TabIndex = 25;
            CmdAbbrechen.Text = "Abbrechen";
            CmdAbbrechen.UseVisualStyleBackColor = true;
            // 
            // CmdSpeichern
            // 
            CmdSpeichern.Location = new Point(233, 96);
            CmdSpeichern.Name = "CmdSpeichern";
            CmdSpeichern.Size = new Size(112, 34);
            CmdSpeichern.TabIndex = 24;
            CmdSpeichern.Text = "Speichern";
            CmdSpeichern.UseVisualStyleBackColor = true;
            CmdSpeichern.Click += CmdSpeichern_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 46);
            label3.Name = "label3";
            label3.Size = new Size(201, 25);
            label3.TabIndex = 23;
            label3.Text = "Abteilungsbezeichnung:";
            // 
            // TxtAbteilungsbezeichnung
            // 
            TxtAbteilungsbezeichnung.Location = new Point(233, 43);
            TxtAbteilungsbezeichnung.Name = "TxtAbteilungsbezeichnung";
            TxtAbteilungsbezeichnung.Size = new Size(274, 31);
            TxtAbteilungsbezeichnung.TabIndex = 22;
            // 
            // TxtAbteilungsnummer
            // 
            TxtAbteilungsnummer.Location = new Point(233, 6);
            TxtAbteilungsnummer.Name = "TxtAbteilungsnummer";
            TxtAbteilungsnummer.ReadOnly = true;
            TxtAbteilungsnummer.Size = new Size(274, 31);
            TxtAbteilungsnummer.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(168, 25);
            label1.TabIndex = 20;
            label1.Text = "Abteilungsnummer:";
            // 
            // FrmAbteilungBearbeiten
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 144);
            Controls.Add(CmdAbbrechen);
            Controls.Add(CmdSpeichern);
            Controls.Add(label3);
            Controls.Add(TxtAbteilungsbezeichnung);
            Controls.Add(TxtAbteilungsnummer);
            Controls.Add(label1);
            Name = "FrmAbteilungBearbeiten";
            Text = "Abteilung bearbeiten";
            Load += FrmAbteilungBearbeiten_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAbbrechen;
        private Button CmdSpeichern;
        private Label label3;
        private TextBox TxtAbteilungsbezeichnung;
        private TextBox TxtAbteilungsnummer;
        private Label label1;
    }
}