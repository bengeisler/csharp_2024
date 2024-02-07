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
            btnHinzufügen = new Button();
            btnAllesLoeschen = new Button();
            btnLoeschen = new Button();
            btnBeenden = new Button();
            label1 = new Label();
            label2 = new Label();
            LstToDo = new ListBox();
            LstErledigt = new ListBox();
            buttonLinks = new Button();
            buttonRechts = new Button();
            txtAnzahl = new TextBox();
            txtBezeichnung = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnHinzufügen
            // 
            btnHinzufügen.Location = new Point(540, 55);
            btnHinzufügen.Name = "btnHinzufügen";
            btnHinzufügen.Size = new Size(166, 40);
            btnHinzufügen.TabIndex = 0;
            btnHinzufügen.Text = "Hinzufügen";
            btnHinzufügen.UseVisualStyleBackColor = true;
            btnHinzufügen.Click += btnHinzufügen_Click;
            // 
            // btnAllesLoeschen
            // 
            btnAllesLoeschen.Location = new Point(219, 502);
            btnAllesLoeschen.Name = "btnAllesLoeschen";
            btnAllesLoeschen.Size = new Size(166, 40);
            btnAllesLoeschen.TabIndex = 1;
            btnAllesLoeschen.Text = "Alle löschen";
            btnAllesLoeschen.UseVisualStyleBackColor = true;
            btnAllesLoeschen.Click += btnAllesLoeschen_Click;
            // 
            // btnLoeschen
            // 
            btnLoeschen.Location = new Point(34, 502);
            btnLoeschen.Name = "btnLoeschen";
            btnLoeschen.Size = new Size(166, 40);
            btnLoeschen.TabIndex = 2;
            btnLoeschen.Text = "Löschen";
            btnLoeschen.UseVisualStyleBackColor = true;
            btnLoeschen.Click += btnLoeschen_Click;
            // 
            // btnBeenden
            // 
            btnBeenden.Location = new Point(579, 502);
            btnBeenden.Name = "btnBeenden";
            btnBeenden.Size = new Size(166, 40);
            btnBeenden.TabIndex = 3;
            btnBeenden.Text = "Beenden";
            btnBeenden.UseVisualStyleBackColor = true;
            btnBeenden.Click += btnBeenden_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 44);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 4;
            label1.Text = "Anzahl:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 44);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 5;
            label2.Text = "Beschreibung:";
            label2.Click += label2_Click;
            // 
            // LstToDo
            // 
            LstToDo.FormattingEnabled = true;
            LstToDo.ItemHeight = 15;
            LstToDo.Location = new Point(43, 159);
            LstToDo.Name = "LstToDo";
            LstToDo.Size = new Size(209, 274);
            LstToDo.TabIndex = 6;
            LstToDo.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // LstErledigt
            // 
            LstErledigt.FormattingEnabled = true;
            LstErledigt.ItemHeight = 15;
            LstErledigt.Location = new Point(547, 173);
            LstErledigt.Name = "LstErledigt";
            LstErledigt.Size = new Size(227, 259);
            LstErledigt.TabIndex = 7;
            LstErledigt.SelectedIndexChanged += LstErledigt_SelectedIndexChanged;
            // 
            // buttonLinks
            // 
            buttonLinks.Location = new Point(363, 186);
            buttonLinks.Name = "buttonLinks";
            buttonLinks.Size = new Size(75, 70);
            buttonLinks.TabIndex = 8;
            buttonLinks.Text = ">";
            buttonLinks.UseVisualStyleBackColor = true;
            buttonLinks.Click += button5_Click;
            // 
            // buttonRechts
            // 
            buttonRechts.Location = new Point(363, 295);
            buttonRechts.Name = "buttonRechts";
            buttonRechts.Size = new Size(75, 76);
            buttonRechts.TabIndex = 9;
            buttonRechts.Text = "<";
            buttonRechts.UseVisualStyleBackColor = true;
            buttonRechts.Click += buttonRechts_Click;
            // 
            // txtAnzahl
            // 
            txtAnzahl.Location = new Point(34, 72);
            txtAnzahl.Name = "txtAnzahl";
            txtAnzahl.Size = new Size(100, 23);
            txtAnzahl.TabIndex = 10;
            txtAnzahl.TextChanged += txtAnzahl_TextChanged;
            // 
            // txtBezeichnung
            // 
            txtBezeichnung.Location = new Point(203, 72);
            txtBezeichnung.Name = "txtBezeichnung";
            txtBezeichnung.Size = new Size(256, 23);
            txtBezeichnung.TabIndex = 11;
            txtBezeichnung.TextChanged += txtBezeichnung_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(99, 111);
            label3.Name = "label3";
            label3.Size = new Size(77, 32);
            label3.TabIndex = 12;
            label3.Text = "To Do";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(615, 121);
            label4.Name = "label4";
            label4.Size = new Size(95, 32);
            label4.TabIndex = 13;
            label4.Text = "Erledigt";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 568);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtBezeichnung);
            Controls.Add(txtAnzahl);
            Controls.Add(buttonRechts);
            Controls.Add(buttonLinks);
            Controls.Add(LstErledigt);
            Controls.Add(LstToDo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBeenden);
            Controls.Add(btnLoeschen);
            Controls.Add(btnAllesLoeschen);
            Controls.Add(btnHinzufügen);
            Name = "Form1";
            Text = "Einkaufsliste";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHinzufügen;
        private Button btnAllesLoeschen;
        private Button btnLoeschen;
        private Button btnBeenden;
        private Label label1;
        private Label label2;
        private ListBox LstToDo;
        private ListBox LstErledigt;
        private Button buttonLinks;
        private Button buttonRechts;
        private TextBox txtAnzahl;
        private TextBox txtBezeichnung;
        private Label label3;
        private Label label4;
    }
}
