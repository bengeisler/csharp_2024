// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UDatei
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
            TxtStadt = new TextBox();
            BtnHinzufuegen = new Button();
            BtnLoeschen = new Button();
            button1 = new Button();
            BtnBeenden = new Button();
            BtnSpeichern = new Button();
            BtnListeLaden = new Button();
            ChkSortiert = new CheckBox();
            SuspendLayout();
            // 
            // LstListe
            // 
            LstListe.FormattingEnabled = true;
            LstListe.ItemHeight = 15;
            LstListe.Location = new Point(18, 12);
            LstListe.Name = "LstListe";
            LstListe.Size = new Size(526, 184);
            LstListe.TabIndex = 1;
            // 
            // TxtStadt
            // 
            TxtStadt.Location = new Point(18, 213);
            TxtStadt.Name = "TxtStadt";
            TxtStadt.Size = new Size(526, 23);
            TxtStadt.TabIndex = 2;
            // 
            // BtnHinzufuegen
            // 
            BtnHinzufuegen.Location = new Point(18, 275);
            BtnHinzufuegen.Name = "BtnHinzufuegen";
            BtnHinzufuegen.Size = new Size(75, 23);
            BtnHinzufuegen.TabIndex = 3;
            BtnHinzufuegen.Text = "Hinzufügen";
            BtnHinzufuegen.UseVisualStyleBackColor = true;
            BtnHinzufuegen.Click += BtnHinzufuegen_Click;
            // 
            // BtnLoeschen
            // 
            BtnLoeschen.Location = new Point(99, 275);
            BtnLoeschen.Name = "BtnLoeschen";
            BtnLoeschen.Size = new Size(75, 23);
            BtnLoeschen.TabIndex = 4;
            BtnLoeschen.Text = "Löschen";
            BtnLoeschen.UseVisualStyleBackColor = true;
            BtnLoeschen.Click += BtnLoeschen_Click;
            // 
            // button1
            // 
            button1.Location = new Point(180, 275);
            button1.Name = "button1";
            button1.Size = new Size(86, 23);
            button1.TabIndex = 5;
            button1.Text = "Alle löschen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BtnBeenden
            // 
            BtnBeenden.Location = new Point(458, 275);
            BtnBeenden.Name = "BtnBeenden";
            BtnBeenden.Size = new Size(86, 23);
            BtnBeenden.TabIndex = 6;
            BtnBeenden.Text = "Beenden";
            BtnBeenden.UseVisualStyleBackColor = true;
            BtnBeenden.Click += BtnBeenden_Click;
            // 
            // BtnSpeichern
            // 
            BtnSpeichern.Location = new Point(366, 275);
            BtnSpeichern.Name = "BtnSpeichern";
            BtnSpeichern.Size = new Size(86, 23);
            BtnSpeichern.TabIndex = 7;
            BtnSpeichern.Text = "Speichern";
            BtnSpeichern.UseVisualStyleBackColor = true;
            BtnSpeichern.Click += BtnSpeichern_Click;
            // 
            // BtnListeLaden
            // 
            BtnListeLaden.Location = new Point(366, 246);
            BtnListeLaden.Name = "BtnListeLaden";
            BtnListeLaden.Size = new Size(86, 23);
            BtnListeLaden.TabIndex = 8;
            BtnListeLaden.Text = "Liste laden";
            BtnListeLaden.UseVisualStyleBackColor = true;
            BtnListeLaden.Click += BtnListeLaden_Click;
            // 
            // ChkSortiert
            // 
            ChkSortiert.AutoSize = true;
            ChkSortiert.Location = new Point(281, 275);
            ChkSortiert.Name = "ChkSortiert";
            ChkSortiert.Size = new Size(64, 19);
            ChkSortiert.TabIndex = 9;
            ChkSortiert.Text = "Sortiert";
            ChkSortiert.UseVisualStyleBackColor = true;
            ChkSortiert.CheckedChanged += ChkSortiert_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 417);
            Controls.Add(ChkSortiert);
            Controls.Add(BtnListeLaden);
            Controls.Add(BtnSpeichern);
            Controls.Add(BtnBeenden);
            Controls.Add(button1);
            Controls.Add(BtnLoeschen);
            Controls.Add(BtnHinzufuegen);
            Controls.Add(TxtStadt);
            Controls.Add(LstListe);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LstListe;
        private TextBox TxtStadt;
        private Button BtnHinzufuegen;
        private Button BtnLoeschen;
        private Button button1;
        private Button BtnBeenden;
        private Button BtnSpeichern;
        private Button BtnListeLaden;
        private CheckBox ChkSortiert;
    }
}
