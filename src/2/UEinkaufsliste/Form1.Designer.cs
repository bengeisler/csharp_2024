// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UEinkaufsliste
{
    partial class Einkaufsliste
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
            CmdHinzufügen = new Button();
            Cmdloeschen = new Button();
            CmdAllesLoeschen = new Button();
            CmdBeenden = new Button();
            CmdToErledigt = new Button();
            CmdToDo = new Button();
            LstToDo = new ListBox();
            LstErledigt = new ListBox();
            LblAnzahl = new Label();
            LblBeschreibung = new Label();
            LblToDo = new Label();
            LblErledigt = new Label();
            LblAnzeigen = new Label();
            TxtAnzahl = new TextBox();
            TxtBeschreibung = new TextBox();
            SuspendLayout();
            // 
            // CmdHinzufügen
            // 
            CmdHinzufügen.Location = new Point(594, 47);
            CmdHinzufügen.Name = "CmdHinzufügen";
            CmdHinzufügen.Size = new Size(88, 23);
            CmdHinzufügen.TabIndex = 0;
            CmdHinzufügen.Text = "Hinzufügen";
            CmdHinzufügen.UseVisualStyleBackColor = true;
            CmdHinzufügen.Click += CmdHinzufügen_Click;
            // 
            // Cmdloeschen
            // 
            Cmdloeschen.Location = new Point(64, 423);
            Cmdloeschen.Name = "Cmdloeschen";
            Cmdloeschen.Size = new Size(90, 23);
            Cmdloeschen.TabIndex = 1;
            Cmdloeschen.Text = "Löschen";
            Cmdloeschen.UseVisualStyleBackColor = true;
            Cmdloeschen.Click += Cmdloeschen_Click;
            // 
            // CmdAllesLoeschen
            // 
            CmdAllesLoeschen.Location = new Point(188, 423);
            CmdAllesLoeschen.Name = "CmdAllesLoeschen";
            CmdAllesLoeschen.Size = new Size(120, 23);
            CmdAllesLoeschen.TabIndex = 2;
            CmdAllesLoeschen.Text = "Alle löschen";
            CmdAllesLoeschen.UseVisualStyleBackColor = true;
            CmdAllesLoeschen.Click += CmdAllesLoeschen_Click;
            // 
            // CmdBeenden
            // 
            CmdBeenden.Location = new Point(661, 423);
            CmdBeenden.Name = "CmdBeenden";
            CmdBeenden.Size = new Size(75, 23);
            CmdBeenden.TabIndex = 3;
            CmdBeenden.Text = "Beenden";
            CmdBeenden.UseVisualStyleBackColor = true;
            CmdBeenden.Click += CmdBeenden_Click;
            // 
            // CmdToErledigt
            // 
            CmdToErledigt.Location = new Point(365, 199);
            CmdToErledigt.Name = "CmdToErledigt";
            CmdToErledigt.Size = new Size(19, 36);
            CmdToErledigt.TabIndex = 4;
            CmdToErledigt.Text = ">";
            CmdToErledigt.UseVisualStyleBackColor = true;
            CmdToErledigt.Click += CmdToErledigt_Click;
            // 
            // CmdToDo
            // 
            CmdToDo.Location = new Point(366, 241);
            CmdToDo.Name = "CmdToDo";
            CmdToDo.Size = new Size(18, 33);
            CmdToDo.TabIndex = 5;
            CmdToDo.Text = "<";
            CmdToDo.UseVisualStyleBackColor = true;
            CmdToDo.Click += CmdToDo_Click;
            // 
            // LstToDo
            // 
            LstToDo.FormattingEnabled = true;
            LstToDo.ItemHeight = 15;
            LstToDo.Location = new Point(241, 136);
            LstToDo.Name = "LstToDo";
            LstToDo.Size = new Size(120, 184);
            LstToDo.TabIndex = 6;
            // 
            // LstErledigt
            // 
            LstErledigt.FormattingEnabled = true;
            LstErledigt.ItemHeight = 15;
            LstErledigt.Location = new Point(392, 136);
            LstErledigt.Name = "LstErledigt";
            LstErledigt.Size = new Size(120, 184);
            LstErledigt.TabIndex = 7;
            // 
            // LblAnzahl
            // 
            LblAnzahl.AutoSize = true;
            LblAnzahl.Location = new Point(39, 29);
            LblAnzahl.Name = "LblAnzahl";
            LblAnzahl.Size = new Size(46, 15);
            LblAnzahl.TabIndex = 8;
            LblAnzahl.Text = "Anzahl:";
            // 
            // LblBeschreibung
            // 
            LblBeschreibung.AutoSize = true;
            LblBeschreibung.Location = new Point(201, 30);
            LblBeschreibung.Name = "LblBeschreibung";
            LblBeschreibung.Size = new Size(82, 15);
            LblBeschreibung.TabIndex = 9;
            LblBeschreibung.Text = "Beschreibung:";
            // 
            // LblToDo
            // 
            LblToDo.AutoSize = true;
            LblToDo.Location = new Point(291, 118);
            LblToDo.Name = "LblToDo";
            LblToDo.Size = new Size(34, 15);
            LblToDo.TabIndex = 10;
            LblToDo.Text = "ToDo";
            // 
            // LblErledigt
            // 
            LblErledigt.AutoSize = true;
            LblErledigt.Location = new Point(447, 115);
            LblErledigt.Name = "LblErledigt";
            LblErledigt.Size = new Size(47, 15);
            LblErledigt.TabIndex = 11;
            LblErledigt.Text = "Erledigt";
            // 
            // LblAnzeigen
            // 
            LblAnzeigen.AutoSize = true;
            LblAnzeigen.Location = new Point(367, 360);
            LblAnzeigen.Name = "LblAnzeigen";
            LblAnzeigen.Size = new Size(38, 15);
            LblAnzeigen.TabIndex = 12;
            LblAnzeigen.Text = "label5";
            // 
            // TxtAnzahl
            // 
            TxtAnzahl.Location = new Point(39, 47);
            TxtAnzahl.Name = "TxtAnzahl";
            TxtAnzahl.Size = new Size(100, 23);
            TxtAnzahl.TabIndex = 13;
            TxtAnzahl.TextChanged += TxtAnzahl_TextChanged;
            // 
            // TxtBeschreibung
            // 
            TxtBeschreibung.Location = new Point(201, 48);
            TxtBeschreibung.Name = "TxtBeschreibung";
            TxtBeschreibung.Size = new Size(311, 23);
            TxtBeschreibung.TabIndex = 14;
            // 
            // Einkaufsliste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 472);
            Controls.Add(TxtBeschreibung);
            Controls.Add(TxtAnzahl);
            Controls.Add(LblAnzeigen);
            Controls.Add(LblErledigt);
            Controls.Add(LblToDo);
            Controls.Add(LblBeschreibung);
            Controls.Add(LblAnzahl);
            Controls.Add(LstErledigt);
            Controls.Add(LstToDo);
            Controls.Add(CmdToDo);
            Controls.Add(CmdToErledigt);
            Controls.Add(CmdBeenden);
            Controls.Add(CmdAllesLoeschen);
            Controls.Add(Cmdloeschen);
            Controls.Add(CmdHinzufügen);
            Name = "Einkaufsliste";
            Text = "Einkaufsliste";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdHinzufügen;
        private Button Cmdloeschen;
        private Button CmdAllesLoeschen;
        private Button CmdBeenden;
        private Button CmdToErledigt;
        private Button CmdToDo;
        private ListBox LstToDo;
        private ListBox LstErledigt;
        private Label LblAnzahl;
        private Label LblBeschreibung;
        private Label LblToDo;
        private Label LblErledigt;
        private Label LblAnzeigen;
        private TextBox TxtAnzahl;
        private TextBox TxtBeschreibung;
    }
}
