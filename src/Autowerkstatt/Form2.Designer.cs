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
            components = new System.ComponentModel.Container();
            LblNrF2 = new Label();
            TxtKennzeichenFr2 = new TextBox();
            fahrzeugBindingSource = new BindingSource(components);
            fahrzeugBindingSource1 = new BindingSource(components);
            LblKennzeichenFr2 = new Label();
            LblMarkeFr2 = new Label();
            LblModellFr2 = new Label();
            LblHalterFr2 = new Label();
            LblOrtFr2 = new Label();
            LblNummer = new Label();
            TxtOrtFr2 = new TextBox();
            TxtHalterFr2 = new TextBox();
            TxtModellFr2 = new TextBox();
            TxtMarkeFr2 = new TextBox();
            CmdSpeichern3 = new Button();
            CmdAbbrechen = new Button();
            ((System.ComponentModel.ISupportInitialize)fahrzeugBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fahrzeugBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // LblNrF2
            // 
            LblNrF2.AutoSize = true;
            LblNrF2.Location = new Point(51, 24);
            LblNrF2.Name = "LblNrF2";
            LblNrF2.Size = new Size(23, 15);
            LblNrF2.TabIndex = 0;
            LblNrF2.Text = "Nr:";
            // 
            // TxtKennzeichenFr2
            // 
            TxtKennzeichenFr2.Location = new Point(146, 59);
            TxtKennzeichenFr2.Name = "TxtKennzeichenFr2";
            TxtKennzeichenFr2.Size = new Size(100, 23);
            TxtKennzeichenFr2.TabIndex = 1;
            // 
            // fahrzeugBindingSource
            // 
            fahrzeugBindingSource.DataSource = typeof(Models.Fahrzeug);
            // 
            // fahrzeugBindingSource1
            // 
            fahrzeugBindingSource1.DataSource = typeof(Models.Fahrzeug);
            // 
            // LblKennzeichenFr2
            // 
            LblKennzeichenFr2.AutoSize = true;
            LblKennzeichenFr2.Location = new Point(51, 62);
            LblKennzeichenFr2.Name = "LblKennzeichenFr2";
            LblKennzeichenFr2.Size = new Size(74, 15);
            LblKennzeichenFr2.TabIndex = 2;
            LblKennzeichenFr2.Text = "Kennzeichen";
            // 
            // LblMarkeFr2
            // 
            LblMarkeFr2.AutoSize = true;
            LblMarkeFr2.Location = new Point(51, 98);
            LblMarkeFr2.Name = "LblMarkeFr2";
            LblMarkeFr2.Size = new Size(43, 15);
            LblMarkeFr2.TabIndex = 3;
            LblMarkeFr2.Text = "Marke:";
            // 
            // LblModellFr2
            // 
            LblModellFr2.AutoSize = true;
            LblModellFr2.Location = new Point(51, 135);
            LblModellFr2.Name = "LblModellFr2";
            LblModellFr2.Size = new Size(47, 15);
            LblModellFr2.TabIndex = 4;
            LblModellFr2.Text = "Modell:";
            // 
            // LblHalterFr2
            // 
            LblHalterFr2.AutoSize = true;
            LblHalterFr2.Location = new Point(51, 168);
            LblHalterFr2.Name = "LblHalterFr2";
            LblHalterFr2.Size = new Size(42, 15);
            LblHalterFr2.TabIndex = 5;
            LblHalterFr2.Text = "Halter:";
            // 
            // LblOrtFr2
            // 
            LblOrtFr2.AutoSize = true;
            LblOrtFr2.Location = new Point(51, 200);
            LblOrtFr2.Name = "LblOrtFr2";
            LblOrtFr2.Size = new Size(27, 15);
            LblOrtFr2.TabIndex = 6;
            LblOrtFr2.Text = "Ort:";
            // 
            // LblNummer
            // 
            LblNummer.AutoSize = true;
            LblNummer.Location = new Point(146, 24);
            LblNummer.Name = "LblNummer";
            LblNummer.Size = new Size(38, 15);
            LblNummer.TabIndex = 7;
            LblNummer.Text = "label7";
            // 
            // TxtOrtFr2
            // 
            TxtOrtFr2.Location = new Point(146, 197);
            TxtOrtFr2.Name = "TxtOrtFr2";
            TxtOrtFr2.Size = new Size(100, 23);
            TxtOrtFr2.TabIndex = 8;
            // 
            // TxtHalterFr2
            // 
            TxtHalterFr2.Location = new Point(146, 165);
            TxtHalterFr2.Name = "TxtHalterFr2";
            TxtHalterFr2.Size = new Size(100, 23);
            TxtHalterFr2.TabIndex = 9;
            // 
            // TxtModellFr2
            // 
            TxtModellFr2.Location = new Point(146, 132);
            TxtModellFr2.Name = "TxtModellFr2";
            TxtModellFr2.Size = new Size(100, 23);
            TxtModellFr2.TabIndex = 10;
            // 
            // TxtMarkeFr2
            // 
            TxtMarkeFr2.Location = new Point(146, 90);
            TxtMarkeFr2.Name = "TxtMarkeFr2";
            TxtMarkeFr2.Size = new Size(100, 23);
            TxtMarkeFr2.TabIndex = 11;
            // 
            // CmdSpeichern3
            // 
            CmdSpeichern3.Location = new Point(50, 253);
            CmdSpeichern3.Name = "CmdSpeichern3";
            CmdSpeichern3.Size = new Size(75, 23);
            CmdSpeichern3.TabIndex = 12;
            CmdSpeichern3.Text = "Speichern";
            CmdSpeichern3.UseVisualStyleBackColor = true;
            CmdSpeichern3.Click += CmdSpeichern3_Click;
            // 
            // CmdAbbrechen
            // 
            CmdAbbrechen.Location = new Point(171, 253);
            CmdAbbrechen.Name = "CmdAbbrechen";
            CmdAbbrechen.Size = new Size(75, 23);
            CmdAbbrechen.TabIndex = 13;
            CmdAbbrechen.Text = "Abbrechen";
            CmdAbbrechen.UseVisualStyleBackColor = true;
            CmdAbbrechen.Click += CmdAbbrechen_Click;
            // 
            // FrmFahrzeuge
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 304);
            Controls.Add(CmdAbbrechen);
            Controls.Add(CmdSpeichern3);
            Controls.Add(TxtMarkeFr2);
            Controls.Add(TxtModellFr2);
            Controls.Add(TxtHalterFr2);
            Controls.Add(TxtOrtFr2);
            Controls.Add(LblNummer);
            Controls.Add(LblOrtFr2);
            Controls.Add(LblHalterFr2);
            Controls.Add(LblModellFr2);
            Controls.Add(LblMarkeFr2);
            Controls.Add(LblKennzeichenFr2);
            Controls.Add(TxtKennzeichenFr2);
            Controls.Add(LblNrF2);
            Name = "FrmFahrzeuge";
            Text = "frmFahrzeuge";
            Load += FrmFahrzeuge_Load;
            ((System.ComponentModel.ISupportInitialize)fahrzeugBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)fahrzeugBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNrF2;
        private TextBox TxtKennzeichenFr2;
        private Label LblKennzeichenFr2;
        private Label LblMarkeFr2;
        private Label LblModellFr2;
        private Label LblHalterFr2;
        private Label LblOrtFr2;
        private Label LblNummer;
        private TextBox TxtOrtFr2;
        private TextBox TxtHalterFr2;
        private TextBox TxtModellFr2;
        private TextBox TxtMarkeFr2;
        private Button CmdSpeichern3;
        private Button CmdAbbrechen;
        private BindingSource fahrzeugBindingSource;
        private BindingSource fahrzeugBindingSource1;
    }
}