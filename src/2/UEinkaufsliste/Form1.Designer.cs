// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UEinkaufsliste
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
            label1 = new Label();
            label2 = new Label();
            TxtAnzahl = new TextBox();
            TxtBeschreibung = new TextBox();
            CmdHinzufügen = new Button();
            label3 = new Label();
            label4 = new Label();
            LstTodo = new ListBox();
            LstErledigt = new ListBox();
            CmdNachLinks = new Button();
            CmdNachRechts = new Button();
            LblStatus = new Label();
            CmdLöschen = new Button();
            CmdAlleLöschen = new Button();
            CmdBeenden = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 0;
            label1.Text = "Anzahl:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 9);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 1;
            label2.Text = "Beschreibung:";
            // 
            // TxtAnzahl
            // 
            TxtAnzahl.Location = new Point(12, 37);
            TxtAnzahl.Name = "TxtAnzahl";
            TxtAnzahl.Size = new Size(85, 31);
            TxtAnzahl.TabIndex = 2;
            // 
            // TxtBeschreibung
            // 
            TxtBeschreibung.Location = new Point(133, 37);
            TxtBeschreibung.Name = "TxtBeschreibung";
            TxtBeschreibung.Size = new Size(317, 31);
            TxtBeschreibung.TabIndex = 3;
            // 
            // CmdHinzufügen
            // 
            CmdHinzufügen.Location = new Point(474, 35);
            CmdHinzufügen.Name = "CmdHinzufügen";
            CmdHinzufügen.Size = new Size(112, 34);
            CmdHinzufügen.TabIndex = 4;
            CmdHinzufügen.Text = "Hinzufügen";
            CmdHinzufügen.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(404, 81);
            label3.Name = "label3";
            label3.Size = new Size(119, 38);
            label3.TabIndex = 6;
            label3.Text = "Erledigt";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(77, 81);
            label4.Name = "label4";
            label4.Size = new Size(85, 38);
            label4.TabIndex = 5;
            label4.Text = "ToDo";
            // 
            // LstTodo
            // 
            LstTodo.FormattingEnabled = true;
            LstTodo.ItemHeight = 25;
            LstTodo.Location = new Point(12, 122);
            LstTodo.Name = "LstTodo";
            LstTodo.Size = new Size(234, 204);
            LstTodo.TabIndex = 7;
            // 
            // LstErledigt
            // 
            LstErledigt.FormattingEnabled = true;
            LstErledigt.ItemHeight = 25;
            LstErledigt.Location = new Point(341, 122);
            LstErledigt.Name = "LstErledigt";
            LstErledigt.Size = new Size(245, 204);
            LstErledigt.TabIndex = 8;
            // 
            // CmdNachLinks
            // 
            CmdNachLinks.Location = new Point(252, 223);
            CmdNachLinks.Name = "CmdNachLinks";
            CmdNachLinks.Size = new Size(83, 60);
            CmdNachLinks.TabIndex = 9;
            CmdNachLinks.Text = "<";
            CmdNachLinks.UseVisualStyleBackColor = true;
            // 
            // CmdNachRechts
            // 
            CmdNachRechts.Location = new Point(252, 157);
            CmdNachRechts.Name = "CmdNachRechts";
            CmdNachRechts.Size = new Size(83, 60);
            CmdNachRechts.TabIndex = 10;
            CmdNachRechts.Text = ">";
            CmdNachRechts.UseVisualStyleBackColor = true;
            // 
            // LblStatus
            // 
            LblStatus.AutoSize = true;
            LblStatus.Location = new Point(114, 348);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(59, 25);
            LblStatus.TabIndex = 11;
            LblStatus.Text = "label5";
            // 
            // CmdLöschen
            // 
            CmdLöschen.Location = new Point(12, 404);
            CmdLöschen.Name = "CmdLöschen";
            CmdLöschen.Size = new Size(112, 34);
            CmdLöschen.TabIndex = 12;
            CmdLöschen.Text = "Löschen";
            CmdLöschen.UseVisualStyleBackColor = true;
            // 
            // CmdAlleLöschen
            // 
            CmdAlleLöschen.Location = new Point(134, 404);
            CmdAlleLöschen.Name = "CmdAlleLöschen";
            CmdAlleLöschen.Size = new Size(148, 34);
            CmdAlleLöschen.TabIndex = 13;
            CmdAlleLöschen.Text = "Alle löschen";
            CmdAlleLöschen.UseVisualStyleBackColor = true;
            // 
            // CmdBeenden
            // 
            CmdBeenden.Location = new Point(474, 404);
            CmdBeenden.Name = "CmdBeenden";
            CmdBeenden.Size = new Size(112, 34);
            CmdBeenden.TabIndex = 14;
            CmdBeenden.Text = "Beenden";
            CmdBeenden.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 450);
            Controls.Add(CmdBeenden);
            Controls.Add(CmdAlleLöschen);
            Controls.Add(CmdLöschen);
            Controls.Add(LblStatus);
            Controls.Add(CmdNachRechts);
            Controls.Add(CmdNachLinks);
            Controls.Add(LstErledigt);
            Controls.Add(LstTodo);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(CmdHinzufügen);
            Controls.Add(TxtBeschreibung);
            Controls.Add(TxtAnzahl);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Einkaufsliste";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtAnzahl;
        private TextBox TxtBeschreibung;
        private Button CmdHinzufügen;
        private Label label3;
        private Label label4;
        private ListBox LstTodo;
        private ListBox LstErledigt;
        private Button CmdNachLinks;
        private Button CmdNachRechts;
        private Label LblStatus;
        private Button CmdLöschen;
        private Button CmdAlleLöschen;
        private Button CmdBeenden;
    }
}
