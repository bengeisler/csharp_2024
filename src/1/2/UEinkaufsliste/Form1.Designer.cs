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
            cmdHinzufügen = new Button();
            label1 = new Label();
            label2 = new Label();
            txtBeschreibung = new TextBox();
            txtAnzahl = new TextBox();
            lstToDo = new ListBox();
            lstErledigt = new ListBox();
            cmdrechts = new Button();
            cmdlinks = new Button();
            label3 = new Label();
            label4 = new Label();
            LblProdukte = new Label();
            cmdBeenden = new Button();
            cmdAllesLöschen = new Button();
            cmdLöschen = new Button();
            SuspendLayout();
            // 
            // cmdHinzufügen
            // 
            cmdHinzufügen.Location = new Point(433, 35);
            cmdHinzufügen.Name = "cmdHinzufügen";
            cmdHinzufügen.Size = new Size(78, 23);
            cmdHinzufügen.TabIndex = 0;
            cmdHinzufügen.Text = "Hinzufügen";
            cmdHinzufügen.UseVisualStyleBackColor = true;
            cmdHinzufügen.Click += cmdHinzufügen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Anzahl:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 18);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 2;
            label2.Text = "Beschreibung:";
            // 
            // txtBeschreibung
            // 
            txtBeschreibung.Location = new Point(149, 37);
            txtBeschreibung.Name = "txtBeschreibung";
            txtBeschreibung.Size = new Size(248, 23);
            txtBeschreibung.TabIndex = 3;
            // 
            // txtAnzahl
            // 
            txtAnzahl.Location = new Point(12, 36);
            txtAnzahl.Name = "txtAnzahl";
            txtAnzahl.Size = new Size(100, 23);
            txtAnzahl.TabIndex = 4;
            // 
            // lstToDo
            // 
            lstToDo.FormattingEnabled = true;
            lstToDo.ItemHeight = 15;
            lstToDo.Location = new Point(12, 150);
            lstToDo.Name = "lstToDo";
            lstToDo.Size = new Size(251, 439);
            lstToDo.TabIndex = 5;
            // 
            // lstErledigt
            // 
            lstErledigt.FormattingEnabled = true;
            lstErledigt.ItemHeight = 15;
            lstErledigt.Location = new Point(350, 150);
            lstErledigt.Name = "lstErledigt";
            lstErledigt.Size = new Size(251, 439);
            lstErledigt.TabIndex = 6;
            // 
            // cmdrechts
            // 
            cmdrechts.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdrechts.Location = new Point(269, 295);
            cmdrechts.Name = "cmdrechts";
            cmdrechts.Size = new Size(75, 71);
            cmdrechts.TabIndex = 7;
            cmdrechts.Text = ">";
            cmdrechts.UseVisualStyleBackColor = true;
            cmdrechts.Click += cmdrechts_Click;
            // 
            // cmdlinks
            // 
            cmdlinks.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdlinks.Location = new Point(269, 372);
            cmdlinks.Name = "cmdlinks";
            cmdlinks.Size = new Size(75, 71);
            cmdlinks.TabIndex = 8;
            cmdlinks.Text = "<";
            cmdlinks.UseVisualStyleBackColor = true;
            cmdlinks.Click += cmdlinks_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(87, 115);
            label3.Name = "label3";
            label3.Size = new Size(74, 32);
            label3.TabIndex = 9;
            label3.Text = "ToDo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(433, 115);
            label4.Name = "label4";
            label4.Size = new Size(103, 32);
            label4.TabIndex = 10;
            label4.Text = "Erledigt";
            // 
            // LblProdukte
            // 
            LblProdukte.AutoSize = true;
            LblProdukte.Location = new Point(286, 632);
            LblProdukte.Name = "LblProdukte";
            LblProdukte.Size = new Size(38, 15);
            LblProdukte.TabIndex = 11;
            LblProdukte.Text = "label5";
            // 
            // cmdBeenden
            // 
            cmdBeenden.Location = new Point(520, 669);
            cmdBeenden.Name = "cmdBeenden";
            cmdBeenden.Size = new Size(81, 23);
            cmdBeenden.TabIndex = 12;
            cmdBeenden.Text = "Beenden";
            cmdBeenden.UseVisualStyleBackColor = true;
            cmdBeenden.Click += cmdBeenden_Click;
            // 
            // cmdAllesLöschen
            // 
            cmdAllesLöschen.Location = new Point(123, 669);
            cmdAllesLöschen.Name = "cmdAllesLöschen";
            cmdAllesLöschen.Size = new Size(81, 23);
            cmdAllesLöschen.TabIndex = 13;
            cmdAllesLöschen.Text = "Alle löschen";
            cmdAllesLöschen.UseVisualStyleBackColor = true;
            cmdAllesLöschen.Click += cmdAllesLöschen_Click;
            // 
            // cmdLöschen
            // 
            cmdLöschen.Location = new Point(12, 669);
            cmdLöschen.Name = "cmdLöschen";
            cmdLöschen.Size = new Size(78, 23);
            cmdLöschen.TabIndex = 14;
            cmdLöschen.Text = "Löschen";
            cmdLöschen.UseVisualStyleBackColor = true;
            cmdLöschen.Click += cmdLöschen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 754);
            Controls.Add(cmdLöschen);
            Controls.Add(cmdAllesLöschen);
            Controls.Add(cmdBeenden);
            Controls.Add(LblProdukte);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmdlinks);
            Controls.Add(cmdrechts);
            Controls.Add(lstErledigt);
            Controls.Add(lstToDo);
            Controls.Add(txtAnzahl);
            Controls.Add(txtBeschreibung);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmdHinzufügen);
            Name = "Form1";
            Text = "Einkaufsliste";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdHinzufügen;
        private Label label1;
        private Label label2;
        private TextBox txtBeschreibung;
        private TextBox txtAnzahl;
        private ListBox lstToDo;
        private ListBox lstErledigt;
        private Button cmdrechts;
        private Button cmdlinks;
        private Label label3;
        private Label label4;
        private Label LblProdukte;
        private Button cmdBeenden;
        private Button cmdAllesLöschen;
        private Button cmdLöschen;
    }
}
