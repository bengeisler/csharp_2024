// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UEinkaufsliste
{
    partial class FormEinkaufsliste
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
            LblAnzahl = new Label();
            LblBeschreibung = new Label();
            txtBoxAnzahl = new TextBox();
            TxtBoxBeschreibung = new TextBox();
            CmdHinzufügen = new Button();
            lstToDo = new ListBox();
            lstErledigt = new ListBox();
            Cmdnachrechts = new Button();
            Cmdnachlinks = new Button();
            Cmdlöschen = new Button();
            CmdAlleLöschen = new Button();
            CmdBeenden = new Button();
            Lblwurdeschoneingekauft = new Label();
            LblToDo = new Label();
            LblErledigt = new Label();
            SuspendLayout();
            // 
            // LblAnzahl
            // 
            LblAnzahl.AutoSize = true;
            LblAnzahl.Location = new Point(32, 9);
            LblAnzahl.Name = "LblAnzahl";
            LblAnzahl.Size = new Size(43, 15);
            LblAnzahl.TabIndex = 0;
            LblAnzahl.Text = "Anzahl";
            // 
            // LblBeschreibung
            // 
            LblBeschreibung.AutoSize = true;
            LblBeschreibung.Location = new Point(260, 9);
            LblBeschreibung.Name = "LblBeschreibung";
            LblBeschreibung.Size = new Size(79, 15);
            LblBeschreibung.TabIndex = 1;
            LblBeschreibung.Text = "Beschreibung";
            // 
            // txtBoxAnzahl
            // 
            txtBoxAnzahl.Location = new Point(12, 27);
            txtBoxAnzahl.Name = "txtBoxAnzahl";
            txtBoxAnzahl.Size = new Size(100, 23);
            txtBoxAnzahl.TabIndex = 2;
            // 
            // TxtBoxBeschreibung
            // 
            TxtBoxBeschreibung.Location = new Point(260, 27);
            TxtBoxBeschreibung.Name = "TxtBoxBeschreibung";
            TxtBoxBeschreibung.Size = new Size(203, 23);
            TxtBoxBeschreibung.TabIndex = 3;
            // 
            // CmdHinzufügen
            // 
            CmdHinzufügen.Location = new Point(543, 26);
            CmdHinzufügen.Name = "CmdHinzufügen";
            CmdHinzufügen.Size = new Size(103, 23);
            CmdHinzufügen.TabIndex = 4;
            CmdHinzufügen.Text = "Hinzufügen";
            CmdHinzufügen.UseVisualStyleBackColor = true;
            CmdHinzufügen.Click += CmdHinzufügen_Click;
            // 
            // lstToDo
            // 
            lstToDo.FormattingEnabled = true;
            lstToDo.ItemHeight = 15;
            lstToDo.Location = new Point(12, 78);
            lstToDo.Name = "lstToDo";
            lstToDo.Size = new Size(184, 334);
            lstToDo.TabIndex = 5;
            // 
            // lstErledigt
            // 
            lstErledigt.FormattingEnabled = true;
            lstErledigt.ItemHeight = 15;
            lstErledigt.Location = new Point(370, 78);
            lstErledigt.Name = "lstErledigt";
            lstErledigt.Size = new Size(155, 334);
            lstErledigt.TabIndex = 6;
            // 
            // Cmdnachrechts
            // 
            Cmdnachrechts.Location = new Point(247, 168);
            Cmdnachrechts.Name = "Cmdnachrechts";
            Cmdnachrechts.Size = new Size(75, 23);
            Cmdnachrechts.TabIndex = 7;
            Cmdnachrechts.Text = ">";
            Cmdnachrechts.UseVisualStyleBackColor = true;
            Cmdnachrechts.Click += Cmdnachrechts_Click;
            // 
            // Cmdnachlinks
            // 
            Cmdnachlinks.Location = new Point(247, 287);
            Cmdnachlinks.Name = "Cmdnachlinks";
            Cmdnachlinks.Size = new Size(75, 23);
            Cmdnachlinks.TabIndex = 8;
            Cmdnachlinks.Text = "<";
            Cmdnachlinks.UseVisualStyleBackColor = true;
            Cmdnachlinks.Click += Cmdnachlinks_Click;
            // 
            // Cmdlöschen
            // 
            Cmdlöschen.Location = new Point(32, 477);
            Cmdlöschen.Name = "Cmdlöschen";
            Cmdlöschen.Size = new Size(75, 23);
            Cmdlöschen.TabIndex = 9;
            Cmdlöschen.Text = "Löschen";
            Cmdlöschen.UseVisualStyleBackColor = true;
            Cmdlöschen.Click += Cmdlöschen_Click;
            // 
            // CmdAlleLöschen
            // 
            CmdAlleLöschen.Location = new Point(156, 477);
            CmdAlleLöschen.Name = "CmdAlleLöschen";
            CmdAlleLöschen.Size = new Size(124, 23);
            CmdAlleLöschen.TabIndex = 10;
            CmdAlleLöschen.Text = "Alle Löschen";
            CmdAlleLöschen.UseVisualStyleBackColor = true;
            CmdAlleLöschen.Click += CmdAlleLöschen_Click;
            // 
            // CmdBeenden
            // 
            CmdBeenden.Location = new Point(543, 477);
            CmdBeenden.Name = "CmdBeenden";
            CmdBeenden.Size = new Size(75, 23);
            CmdBeenden.TabIndex = 11;
            CmdBeenden.Text = "Beenden";
            CmdBeenden.UseVisualStyleBackColor = true;
            CmdBeenden.Click += CmdBeenden_Click;
            // 
            // Lblwurdeschoneingekauft
            // 
            Lblwurdeschoneingekauft.AutoSize = true;
            Lblwurdeschoneingekauft.Location = new Point(284, 434);
            Lblwurdeschoneingekauft.Name = "Lblwurdeschoneingekauft";
            Lblwurdeschoneingekauft.Size = new Size(38, 15);
            Lblwurdeschoneingekauft.TabIndex = 12;
            Lblwurdeschoneingekauft.Text = "label3";
            // 
            // LblToDo
            // 
            LblToDo.AutoSize = true;
            LblToDo.Location = new Point(69, 60);
            LblToDo.Name = "LblToDo";
            LblToDo.Size = new Size(34, 15);
            LblToDo.TabIndex = 13;
            LblToDo.Text = "ToDo";
            // 
            // LblErledigt
            // 
            LblErledigt.AutoSize = true;
            LblErledigt.Location = new Point(425, 60);
            LblErledigt.Name = "LblErledigt";
            LblErledigt.Size = new Size(47, 15);
            LblErledigt.TabIndex = 14;
            LblErledigt.Text = "Erledigt";
            // 
            // FormEinkaufsliste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 620);
            Controls.Add(LblErledigt);
            Controls.Add(LblToDo);
            Controls.Add(Lblwurdeschoneingekauft);
            Controls.Add(CmdBeenden);
            Controls.Add(CmdAlleLöschen);
            Controls.Add(Cmdlöschen);
            Controls.Add(Cmdnachlinks);
            Controls.Add(Cmdnachrechts);
            Controls.Add(lstErledigt);
            Controls.Add(lstToDo);
            Controls.Add(CmdHinzufügen);
            Controls.Add(TxtBoxBeschreibung);
            Controls.Add(txtBoxAnzahl);
            Controls.Add(LblBeschreibung);
            Controls.Add(LblAnzahl);
            Name = "FormEinkaufsliste";
            Text = "Einkaufsliste";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAnzahl;
        private Label LblBeschreibung;
        private TextBox txtBoxAnzahl;
        private TextBox TxtBoxBeschreibung;
        private Button CmdHinzufügen;
        private ListBox lstToDo;
        private ListBox lstErledigt;
        private Button Cmdnachrechts;
        private Button Cmdnachlinks;
        private Button Cmdlöschen;
        private Button CmdAlleLöschen;
        private Button CmdBeenden;
        private Label Lblwurdeschoneingekauft;
        private Label LblToDo;
        private Label LblErledigt;
    }
}
