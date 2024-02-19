// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UListe
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
            LstListe = new ListBox();
            TxtEingabe = new TextBox();
            CmdHinzufügen = new Button();
            CmdLöschen = new Button();
            CmdAlleLöschen = new Button();
            ChkSortieren = new CheckBox();
            CmdSpeichern = new Button();
            CmdLaden = new Button();
            CmdBeenden = new Button();
            SuspendLayout();
            // 
            // LstListe
            // 
            LstListe.FormattingEnabled = true;
            LstListe.ItemHeight = 25;
            LstListe.Location = new Point(12, 12);
            LstListe.Name = "LstListe";
            LstListe.Size = new Size(469, 304);
            LstListe.TabIndex = 0;
            // 
            // TxtEingabe
            // 
            TxtEingabe.Location = new Point(12, 322);
            TxtEingabe.Name = "TxtEingabe";
            TxtEingabe.Size = new Size(469, 31);
            TxtEingabe.TabIndex = 1;
            // 
            // CmdHinzufügen
            // 
            CmdHinzufügen.Location = new Point(12, 364);
            CmdHinzufügen.Name = "CmdHinzufügen";
            CmdHinzufügen.Size = new Size(112, 34);
            CmdHinzufügen.TabIndex = 2;
            CmdHinzufügen.Text = "Hinzufügen";
            CmdHinzufügen.UseVisualStyleBackColor = true;
            CmdHinzufügen.Click += CmdHinzufügen_Click;
            // 
            // CmdLöschen
            // 
            CmdLöschen.Location = new Point(133, 364);
            CmdLöschen.Name = "CmdLöschen";
            CmdLöschen.Size = new Size(112, 34);
            CmdLöschen.TabIndex = 3;
            CmdLöschen.Text = "Löschen";
            CmdLöschen.UseVisualStyleBackColor = true;
            CmdLöschen.Click += CmdLöschen_Click;
            // 
            // CmdAlleLöschen
            // 
            CmdAlleLöschen.Location = new Point(133, 403);
            CmdAlleLöschen.Name = "CmdAlleLöschen";
            CmdAlleLöschen.Size = new Size(112, 61);
            CmdAlleLöschen.TabIndex = 4;
            CmdAlleLöschen.Text = "Alle löschen";
            CmdAlleLöschen.UseVisualStyleBackColor = true;
            CmdAlleLöschen.Click += CmdAlleLöschen_Click;
            // 
            // ChkSortieren
            // 
            ChkSortieren.AutoSize = true;
            ChkSortieren.Location = new Point(12, 408);
            ChkSortieren.Name = "ChkSortieren";
            ChkSortieren.Size = new Size(109, 29);
            ChkSortieren.TabIndex = 5;
            ChkSortieren.Text = "Sortieren";
            ChkSortieren.UseVisualStyleBackColor = true;
            ChkSortieren.CheckedChanged += ChkSortieren_CheckedChanged;
            // 
            // CmdSpeichern
            // 
            CmdSpeichern.Location = new Point(251, 364);
            CmdSpeichern.Name = "CmdSpeichern";
            CmdSpeichern.Size = new Size(112, 34);
            CmdSpeichern.TabIndex = 6;
            CmdSpeichern.Text = "Speichern";
            CmdSpeichern.UseVisualStyleBackColor = true;
            CmdSpeichern.Click += CmdSpeichern_Click;
            // 
            // CmdLaden
            // 
            CmdLaden.Location = new Point(251, 404);
            CmdLaden.Name = "CmdLaden";
            CmdLaden.Size = new Size(112, 34);
            CmdLaden.TabIndex = 7;
            CmdLaden.Text = "Laden";
            CmdLaden.UseVisualStyleBackColor = true;
            CmdLaden.Click += CmdLaden_Click;
            // 
            // CmdBeenden
            // 
            CmdBeenden.Location = new Point(369, 403);
            CmdBeenden.Name = "CmdBeenden";
            CmdBeenden.Size = new Size(112, 34);
            CmdBeenden.TabIndex = 8;
            CmdBeenden.Text = "Beenden";
            CmdBeenden.UseVisualStyleBackColor = true;
            CmdBeenden.Click += CmdBeenden_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 476);
            Controls.Add(CmdBeenden);
            Controls.Add(CmdLaden);
            Controls.Add(CmdSpeichern);
            Controls.Add(ChkSortieren);
            Controls.Add(CmdAlleLöschen);
            Controls.Add(CmdLöschen);
            Controls.Add(CmdHinzufügen);
            Controls.Add(TxtEingabe);
            Controls.Add(LstListe);
            Name = "Form1";
            Text = "Liste";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LstListe;
        private TextBox TxtEingabe;
        private Button CmdHinzufügen;
        private Button CmdLöschen;
        private Button CmdAlleLöschen;
        private CheckBox ChkSortieren;
        private Button CmdSpeichern;
        private Button CmdLaden;
        private Button CmdBeenden;
    }
}
