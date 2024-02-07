// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UZahlenraten
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
            BtnZahlerzeugen = new Button();
            BtnEingabeprüfen = new Button();
            LblEingabe = new Label();
            TxtEingabe = new TextBox();
            LblAusgabe = new Label();
            SuspendLayout();
            // 
            // BtnZahlerzeugen
            // 
            BtnZahlerzeugen.Location = new Point(21, 12);
            BtnZahlerzeugen.Name = "BtnZahlerzeugen";
            BtnZahlerzeugen.Size = new Size(108, 23);
            BtnZahlerzeugen.TabIndex = 0;
            BtnZahlerzeugen.Text = "Zahl erzeugen";
            BtnZahlerzeugen.UseVisualStyleBackColor = true;
            BtnZahlerzeugen.Click += BtnZahlerzeugen_Click;
            // 
            // BtnEingabeprüfen
            // 
            BtnEingabeprüfen.Location = new Point(229, 66);
            BtnEingabeprüfen.Name = "BtnEingabeprüfen";
            BtnEingabeprüfen.Size = new Size(111, 23);
            BtnEingabeprüfen.TabIndex = 1;
            BtnEingabeprüfen.Text = "Eingabe prüfen";
            BtnEingabeprüfen.UseVisualStyleBackColor = true;
            BtnEingabeprüfen.Click += BtnEingabeprüfen_Click;
            // 
            // LblEingabe
            // 
            LblEingabe.AutoSize = true;
            LblEingabe.Location = new Point(21, 70);
            LblEingabe.Name = "LblEingabe";
            LblEingabe.Size = new Size(75, 15);
            LblEingabe.TabIndex = 2;
            LblEingabe.Text = "Ihre Eingabe:";
            // 
            // TxtEingabe
            // 
            TxtEingabe.Location = new Point(101, 66);
            TxtEingabe.Name = "TxtEingabe";
            TxtEingabe.Size = new Size(100, 23);
            TxtEingabe.TabIndex = 3;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(21, 108);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(38, 15);
            LblAusgabe.TabIndex = 4;
            LblAusgabe.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 179);
            Controls.Add(LblAusgabe);
            Controls.Add(TxtEingabe);
            Controls.Add(LblEingabe);
            Controls.Add(BtnEingabeprüfen);
            Controls.Add(BtnZahlerzeugen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnZahlerzeugen;
        private Button BtnEingabeprüfen;
        private Label LblEingabe;
        private TextBox TxtEingabe;
        private Label LblAusgabe;
    }
}
