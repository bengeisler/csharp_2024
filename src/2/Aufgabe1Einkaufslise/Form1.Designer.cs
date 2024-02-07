// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Aufgabe1Einkaufslise
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
            ButtonHinzufügen = new Button();
            TxtAnzahl = new TextBox();
            TxtBeschreibung = new TextBox();
            Buttonlöschen = new Button();
            ButtonAllelöschen = new Button();
            Buttonbeenden = new Button();
            ButtonNachRechts = new Button();
            ButtonnachLinks = new Button();
            ListboxTodo = new ListBox();
            ListboxErledigt = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            LblWievielwurdeeingekauft = new Label();
            SuspendLayout();
            // 
            // ButtonHinzufügen
            // 
            ButtonHinzufügen.Location = new Point(521, 43);
            ButtonHinzufügen.Name = "ButtonHinzufügen";
            ButtonHinzufügen.Size = new Size(103, 23);
            ButtonHinzufügen.TabIndex = 0;
            ButtonHinzufügen.Text = "Hinzufügen";
            ButtonHinzufügen.UseVisualStyleBackColor = true;
            ButtonHinzufügen.Click += ButtonHinzufügen_Click;
            // 
            // TxtAnzahl
            // 
            TxtAnzahl.Location = new Point(84, 44);
            TxtAnzahl.Name = "TxtAnzahl";
            TxtAnzahl.Size = new Size(100, 23);
            TxtAnzahl.TabIndex = 1;
            // 
            // TxtBeschreibung
            // 
            TxtBeschreibung.Location = new Point(247, 43);
            TxtBeschreibung.Name = "TxtBeschreibung";
            TxtBeschreibung.Size = new Size(228, 23);
            TxtBeschreibung.TabIndex = 2;
            // 
            // Buttonlöschen
            // 
            Buttonlöschen.Location = new Point(84, 378);
            Buttonlöschen.Name = "Buttonlöschen";
            Buttonlöschen.Size = new Size(75, 23);
            Buttonlöschen.TabIndex = 3;
            Buttonlöschen.Text = "Löschen";
            Buttonlöschen.UseVisualStyleBackColor = true;
            Buttonlöschen.Click += Buttonlöschen_Click;
            // 
            // ButtonAllelöschen
            // 
            ButtonAllelöschen.Location = new Point(187, 378);
            ButtonAllelöschen.Name = "ButtonAllelöschen";
            ButtonAllelöschen.Size = new Size(112, 23);
            ButtonAllelöschen.TabIndex = 4;
            ButtonAllelöschen.Text = "Alle Löschen";
            ButtonAllelöschen.UseVisualStyleBackColor = true;
            ButtonAllelöschen.Click += ButtonAllelöschen_Click;
            // 
            // Buttonbeenden
            // 
            Buttonbeenden.Location = new Point(549, 378);
            Buttonbeenden.Name = "Buttonbeenden";
            Buttonbeenden.Size = new Size(75, 23);
            Buttonbeenden.TabIndex = 5;
            Buttonbeenden.Text = "Beenden";
            Buttonbeenden.UseVisualStyleBackColor = true;
            // 
            // ButtonNachRechts
            // 
            ButtonNachRechts.Location = new Point(340, 143);
            ButtonNachRechts.Name = "ButtonNachRechts";
            ButtonNachRechts.Size = new Size(50, 23);
            ButtonNachRechts.TabIndex = 6;
            ButtonNachRechts.Text = ">";
            ButtonNachRechts.UseVisualStyleBackColor = true;
            ButtonNachRechts.Click += ButtonNachRechts_Click;
            // 
            // ButtonnachLinks
            // 
            ButtonnachLinks.Location = new Point(340, 196);
            ButtonnachLinks.Name = "ButtonnachLinks";
            ButtonnachLinks.Size = new Size(50, 23);
            ButtonnachLinks.TabIndex = 7;
            ButtonnachLinks.Text = "<";
            ButtonnachLinks.UseVisualStyleBackColor = true;
            ButtonnachLinks.Click += ButtonnachLinks_Click;
            // 
            // ListboxTodo
            // 
            ListboxTodo.FormattingEnabled = true;
            ListboxTodo.ItemHeight = 15;
            ListboxTodo.Location = new Point(84, 117);
            ListboxTodo.Name = "ListboxTodo";
            ListboxTodo.Size = new Size(215, 199);
            ListboxTodo.TabIndex = 8;
            // 
            // ListboxErledigt
            // 
            ListboxErledigt.FormattingEnabled = true;
            ListboxErledigt.ItemHeight = 15;
            ListboxErledigt.Location = new Point(431, 117);
            ListboxErledigt.Name = "ListboxErledigt";
            ListboxErledigt.Size = new Size(193, 199);
            ListboxErledigt.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 15);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 10;
            label1.Text = "Anzahl:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 15);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 11;
            label2.Text = "Beschreibung:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 94);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 12;
            label3.Text = "ToDo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(510, 94);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 13;
            label4.Text = "Erledigt";
            // 
            // LblWievielwurdeeingekauft
            // 
            LblWievielwurdeeingekauft.AutoSize = true;
            LblWievielwurdeeingekauft.Location = new Point(292, 342);
            LblWievielwurdeeingekauft.Name = "LblWievielwurdeeingekauft";
            LblWievielwurdeeingekauft.Size = new Size(38, 15);
            LblWievielwurdeeingekauft.TabIndex = 14;
            LblWievielwurdeeingekauft.Text = "label5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblWievielwurdeeingekauft);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ListboxErledigt);
            Controls.Add(ListboxTodo);
            Controls.Add(ButtonnachLinks);
            Controls.Add(ButtonNachRechts);
            Controls.Add(Buttonbeenden);
            Controls.Add(ButtonAllelöschen);
            Controls.Add(Buttonlöschen);
            Controls.Add(TxtBeschreibung);
            Controls.Add(TxtAnzahl);
            Controls.Add(ButtonHinzufügen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonHinzufügen;
        private TextBox TxtAnzahl;
        private TextBox TxtBeschreibung;
        private Button Buttonlöschen;
        private Button ButtonAllelöschen;
        private Button Buttonbeenden;
        private Button ButtonNachRechts;
        private Button ButtonnachLinks;
        private ListBox ListboxTodo;
        private ListBox ListboxErledigt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label LblWievielwurdeeingekauft;
    }
}
