// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UComboBox
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
            LstToDo = new ListBox();
            LstErledigt = new ListBox();
            TxtAnzahl = new TextBox();
            TxtBeschreibung = new TextBox();
            BtnHinzufuegen = new Button();
            BtnRechts = new Button();
            BtnLinks = new Button();
            LblAusgabe = new Label();
            BtnLoeschen = new Button();
            BtnAllesLoeschen = new Button();
            BtnBeenden = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // LstToDo
            // 
            LstToDo.FormattingEnabled = true;
            LstToDo.ItemHeight = 15;
            LstToDo.Location = new Point(55, 139);
            LstToDo.Name = "LstToDo";
            LstToDo.Size = new Size(167, 244);
            LstToDo.TabIndex = 0;
            // 
            // LstErledigt
            // 
            LstErledigt.FormattingEnabled = true;
            LstErledigt.ItemHeight = 15;
            LstErledigt.Location = new Point(321, 139);
            LstErledigt.Name = "LstErledigt";
            LstErledigt.Size = new Size(167, 244);
            LstErledigt.TabIndex = 1;
            // 
            // TxtAnzahl
            // 
            TxtAnzahl.Location = new Point(54, 44);
            TxtAnzahl.Name = "TxtAnzahl";
            TxtAnzahl.Size = new Size(100, 23);
            TxtAnzahl.TabIndex = 2;
            // 
            // TxtBeschreibung
            // 
            TxtBeschreibung.Location = new Point(175, 44);
            TxtBeschreibung.Name = "TxtBeschreibung";
            TxtBeschreibung.Size = new Size(265, 23);
            TxtBeschreibung.TabIndex = 3;
            // 
            // BtnHinzufuegen
            // 
            BtnHinzufuegen.Location = new Point(474, 44);
            BtnHinzufuegen.Name = "BtnHinzufuegen";
            BtnHinzufuegen.Size = new Size(75, 23);
            BtnHinzufuegen.TabIndex = 4;
            BtnHinzufuegen.Text = "Hinzufügen";
            BtnHinzufuegen.UseVisualStyleBackColor = true;
            BtnHinzufuegen.Click += BtnHinzufuegen_Click;
            // 
            // BtnRechts
            // 
            BtnRechts.Location = new Point(250, 200);
            BtnRechts.Name = "BtnRechts";
            BtnRechts.Size = new Size(43, 49);
            BtnRechts.TabIndex = 5;
            BtnRechts.Text = ">";
            BtnRechts.UseVisualStyleBackColor = true;
            BtnRechts.Click += BtnRechts_Click;
            // 
            // BtnLinks
            // 
            BtnLinks.Location = new Point(250, 255);
            BtnLinks.Name = "BtnLinks";
            BtnLinks.Size = new Size(43, 49);
            BtnLinks.TabIndex = 6;
            BtnLinks.Text = "<";
            BtnLinks.UseVisualStyleBackColor = true;
            BtnLinks.Click += BtnLinks_Click;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(176, 415);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(38, 15);
            LblAusgabe.TabIndex = 7;
            LblAusgabe.Text = "label1";
            // 
            // BtnLoeschen
            // 
            BtnLoeschen.Location = new Point(55, 489);
            BtnLoeschen.Name = "BtnLoeschen";
            BtnLoeschen.Size = new Size(75, 23);
            BtnLoeschen.TabIndex = 8;
            BtnLoeschen.Text = "Löschen";
            BtnLoeschen.UseVisualStyleBackColor = true;
            BtnLoeschen.Click += BtnLoeschen_Click;
            // 
            // BtnAllesLoeschen
            // 
            BtnAllesLoeschen.Location = new Point(147, 489);
            BtnAllesLoeschen.Name = "BtnAllesLoeschen";
            BtnAllesLoeschen.Size = new Size(93, 23);
            BtnAllesLoeschen.TabIndex = 9;
            BtnAllesLoeschen.Text = "Alles löschen";
            BtnAllesLoeschen.UseVisualStyleBackColor = true;
            BtnAllesLoeschen.Click += BtnAllesLoeschen_Click;
            // 
            // BtnBeenden
            // 
            BtnBeenden.Location = new Point(475, 489);
            BtnBeenden.Name = "BtnBeenden";
            BtnBeenden.Size = new Size(75, 23);
            BtnBeenden.TabIndex = 10;
            BtnBeenden.Text = "Beenden";
            BtnBeenden.UseVisualStyleBackColor = true;
            BtnBeenden.Click += BtnBeenden_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 26);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 11;
            label2.Text = "Anzahl:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 26);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 12;
            label3.Text = "Beschreibung:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(108, 121);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 13;
            label4.Text = "ToDo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(383, 121);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 14;
            label5.Text = "Erledigt";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 569);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BtnBeenden);
            Controls.Add(BtnAllesLoeschen);
            Controls.Add(BtnLoeschen);
            Controls.Add(LblAusgabe);
            Controls.Add(BtnLinks);
            Controls.Add(BtnRechts);
            Controls.Add(BtnHinzufuegen);
            Controls.Add(TxtBeschreibung);
            Controls.Add(TxtAnzahl);
            Controls.Add(LstErledigt);
            Controls.Add(LstToDo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LstToDo;
        private ListBox LstErledigt;
        private TextBox TxtAnzahl;
        private TextBox TxtBeschreibung;
        private Button BtnHinzufuegen;
        private Button BtnRechts;
        private Button BtnLinks;
        private Label LblAusgabe;
        private Button BtnLoeschen;
        private Button BtnAllesLoeschen;
        private Button BtnBeenden;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
