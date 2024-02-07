// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UEinkaufsliste
{
    partial class FrmEinkaufsliste
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
            LstErledigt = new ListBox();
            LstToDo = new ListBox();
            label1 = new Label();
            CmdLoeschen = new Button();
            CmdAlleLoeschen = new Button();
            CmdBeenden = new Button();
            label2 = new Label();
            label3 = new Label();
            TxtAnzahl = new TextBox();
            TxtBeschreibung = new TextBox();
            CmdHinzufuegen = new Button();
            label4 = new Label();
            label5 = new Label();
            CmdRechts = new Button();
            CmdLinks = new Button();
            SuspendLayout();
            // 
            // LstErledigt
            // 
            LstErledigt.FormattingEnabled = true;
            LstErledigt.ItemHeight = 15;
            LstErledigt.Location = new Point(623, 146);
            LstErledigt.Name = "LstErledigt";
            LstErledigt.Size = new Size(299, 394);
            LstErledigt.TabIndex = 0;
            // 
            // LstToDo
            // 
            LstToDo.FormattingEnabled = true;
            LstToDo.ItemHeight = 15;
            LstToDo.Location = new Point(156, 146);
            LstToDo.Name = "LstToDo";
            LstToDo.Size = new Size(288, 394);
            LstToDo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(406, 571);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // CmdLoeschen
            // 
            CmdLoeschen.Location = new Point(156, 614);
            CmdLoeschen.Name = "CmdLoeschen";
            CmdLoeschen.Size = new Size(196, 48);
            CmdLoeschen.TabIndex = 3;
            CmdLoeschen.Text = "Löschen";
            CmdLoeschen.UseVisualStyleBackColor = true;
            CmdLoeschen.Click += CmdLoeschen_Click;
            // 
            // CmdAlleLoeschen
            // 
            CmdAlleLoeschen.Location = new Point(388, 614);
            CmdAlleLoeschen.Name = "CmdAlleLoeschen";
            CmdAlleLoeschen.Size = new Size(196, 48);
            CmdAlleLoeschen.TabIndex = 4;
            CmdAlleLoeschen.Text = "Alle Löschen";
            CmdAlleLoeschen.UseVisualStyleBackColor = true;
            CmdAlleLoeschen.Click += CmdAlleLoeschen_Click;
            // 
            // CmdBeenden
            // 
            CmdBeenden.Location = new Point(752, 614);
            CmdBeenden.Name = "CmdBeenden";
            CmdBeenden.Size = new Size(196, 48);
            CmdBeenden.TabIndex = 5;
            CmdBeenden.Text = "Beenden";
            CmdBeenden.UseVisualStyleBackColor = true;
            CmdBeenden.Click += CmdBeenden_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 9);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 6;
            label2.Text = "Anzahl";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(388, 9);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 7;
            label3.Text = "Beschreibung";
            // 
            // TxtAnzahl
            // 
            TxtAnzahl.Location = new Point(159, 36);
            TxtAnzahl.Name = "TxtAnzahl";
            TxtAnzahl.Size = new Size(154, 23);
            TxtAnzahl.TabIndex = 8;
            // 
            // TxtBeschreibung
            // 
            TxtBeschreibung.Location = new Point(388, 36);
            TxtBeschreibung.Name = "TxtBeschreibung";
            TxtBeschreibung.Size = new Size(154, 23);
            TxtBeschreibung.TabIndex = 9;
            // 
            // CmdHinzufuegen
            // 
            CmdHinzufuegen.Location = new Point(623, 36);
            CmdHinzufuegen.Name = "CmdHinzufuegen";
            CmdHinzufuegen.Size = new Size(160, 33);
            CmdHinzufuegen.TabIndex = 10;
            CmdHinzufuegen.Text = "Hinzufügen";
            CmdHinzufuegen.UseVisualStyleBackColor = true;
            CmdHinzufuegen.Click += CmdHinzufuegen_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(275, 107);
            label4.Name = "label4";
            label4.Size = new Size(64, 30);
            label4.TabIndex = 11;
            label4.Text = "ToDo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(745, 107);
            label5.Name = "label5";
            label5.Size = new Size(89, 30);
            label5.TabIndex = 12;
            label5.Text = "Erledigt";
            // 
            // CmdRechts
            // 
            CmdRechts.Location = new Point(485, 231);
            CmdRechts.Name = "CmdRechts";
            CmdRechts.Size = new Size(99, 80);
            CmdRechts.TabIndex = 13;
            CmdRechts.Text = ">";
            CmdRechts.UseVisualStyleBackColor = true;
            CmdRechts.Click += CmdRechts_Click;
            // 
            // CmdLinks
            // 
            CmdLinks.Location = new Point(485, 345);
            CmdLinks.Name = "CmdLinks";
            CmdLinks.Size = new Size(99, 80);
            CmdLinks.TabIndex = 14;
            CmdLinks.Text = "<";
            CmdLinks.UseVisualStyleBackColor = true;
            CmdLinks.Click += CmdLinks_Click;
            // 
            // FrmEinkaufsliste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 707);
            Controls.Add(CmdLinks);
            Controls.Add(CmdRechts);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(CmdHinzufuegen);
            Controls.Add(TxtBeschreibung);
            Controls.Add(TxtAnzahl);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CmdBeenden);
            Controls.Add(CmdAlleLoeschen);
            Controls.Add(CmdLoeschen);
            Controls.Add(label1);
            Controls.Add(LstToDo);
            Controls.Add(LstErledigt);
            Name = "FrmEinkaufsliste";
            Text = "Einkaufsliste";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LstErledigt;
        private ListBox LstToDo;
        private Label label1;
        private Button CmdLoeschen;
        private Button CmdAlleLoeschen;
        private Button CmdBeenden;
        private Label label2;
        private Label label3;
        private TextBox TxtAnzahl;
        private TextBox TxtBeschreibung;
        private Button CmdHinzufuegen;
        private Label label4;
        private Label label5;
        private Button CmdRechts;
        private Button CmdLinks;
    }
}
