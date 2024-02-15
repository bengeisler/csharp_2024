// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UBankkonto
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
            btnEinzahlen = new Button();
            label1 = new Label();
            txtEingabe = new TextBox();
            btnAuszahlen = new Button();
            btnKontostand = new Button();
            btnKontoauszugdrucken = new Button();
            SuspendLayout();
            // 
            // btnEinzahlen
            // 
            btnEinzahlen.Location = new Point(37, 106);
            btnEinzahlen.Name = "btnEinzahlen";
            btnEinzahlen.Size = new Size(75, 23);
            btnEinzahlen.TabIndex = 0;
            btnEinzahlen.Text = "Einzahlen";
            btnEinzahlen.UseVisualStyleBackColor = true;
            btnEinzahlen.Click += btnEinzahlen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 46);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Betrag:";
            // 
            // txtEingabe
            // 
            txtEingabe.Location = new Point(129, 46);
            txtEingabe.Name = "txtEingabe";
            txtEingabe.Size = new Size(100, 23);
            txtEingabe.TabIndex = 2;
            // 
            // btnAuszahlen
            // 
            btnAuszahlen.Location = new Point(173, 106);
            btnAuszahlen.Name = "btnAuszahlen";
            btnAuszahlen.Size = new Size(75, 23);
            btnAuszahlen.TabIndex = 3;
            btnAuszahlen.Text = "Auzahlen";
            btnAuszahlen.UseVisualStyleBackColor = true;
            btnAuszahlen.Click += btnAuszahlen_Click;
            // 
            // btnKontostand
            // 
            btnKontostand.Location = new Point(108, 135);
            btnKontostand.Name = "btnKontostand";
            btnKontostand.Size = new Size(75, 23);
            btnKontostand.TabIndex = 4;
            btnKontostand.Text = "Kontostand";
            btnKontostand.UseVisualStyleBackColor = true;
            btnKontostand.Click += btnKontostand_Click;
            // 
            // btnKontoauszugdrucken
            // 
            btnKontoauszugdrucken.Location = new Point(90, 164);
            btnKontoauszugdrucken.Name = "btnKontoauszugdrucken";
            btnKontoauszugdrucken.Size = new Size(116, 50);
            btnKontoauszugdrucken.TabIndex = 5;
            btnKontoauszugdrucken.Text = "Kontoauszug drucken";
            btnKontoauszugdrucken.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 289);
            Controls.Add(btnKontoauszugdrucken);
            Controls.Add(btnKontostand);
            Controls.Add(btnAuszahlen);
            Controls.Add(txtEingabe);
            Controls.Add(label1);
            Controls.Add(btnEinzahlen);
            Name = "Form1";
            Text = "Konto verwalten";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEinzahlen;
        private Label label1;
        private TextBox txtEingabe;
        private Button btnAuszahlen;
        private Button btnKontostand;
        private Button btnKontoauszugdrucken;
    }
}
