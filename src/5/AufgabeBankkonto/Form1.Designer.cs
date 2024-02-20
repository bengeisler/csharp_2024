// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace AufgabeBankkonto
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
            lblAnzeige = new Label();
            txtAnzeige = new TextBox();
            cmdEinzahlen = new Button();
            cmdAuszahlen = new Button();
            cmdKontostand = new Button();
            cmdKontoauszugdrucken = new Button();
            SuspendLayout();
            // 
            // lblAnzeige
            // 
            lblAnzeige.AutoSize = true;
            lblAnzeige.Location = new Point(96, 21);
            lblAnzeige.Name = "lblAnzeige";
            lblAnzeige.Size = new Size(38, 15);
            lblAnzeige.TabIndex = 0;
            lblAnzeige.Text = "label1";
            // 
            // txtAnzeige
            // 
            txtAnzeige.Location = new Point(259, 21);
            txtAnzeige.Name = "txtAnzeige";
            txtAnzeige.Size = new Size(100, 23);
            txtAnzeige.TabIndex = 1;
            // 
            // cmdEinzahlen
            // 
            cmdEinzahlen.Location = new Point(76, 73);
            cmdEinzahlen.Name = "cmdEinzahlen";
            cmdEinzahlen.Size = new Size(75, 23);
            cmdEinzahlen.TabIndex = 2;
            cmdEinzahlen.Text = "Einzahlen";
            cmdEinzahlen.UseVisualStyleBackColor = true;
            cmdEinzahlen.Click += cmdEinzahlen_Click;
            // 
            // cmdAuszahlen
            // 
            cmdAuszahlen.Location = new Point(259, 73);
            cmdAuszahlen.Name = "cmdAuszahlen";
            cmdAuszahlen.Size = new Size(75, 23);
            cmdAuszahlen.TabIndex = 3;
            cmdAuszahlen.Text = "Auszahlen";
            cmdAuszahlen.UseVisualStyleBackColor = true;
            cmdAuszahlen.Click += cmdAuszahlen_Click;
            // 
            // cmdKontostand
            // 
            cmdKontostand.Location = new Point(144, 143);
            cmdKontostand.Name = "cmdKontostand";
            cmdKontostand.Size = new Size(141, 23);
            cmdKontostand.TabIndex = 4;
            cmdKontostand.Text = "Kontostand";
            cmdKontostand.UseVisualStyleBackColor = true;
            cmdKontostand.Click += cmdKontostand_Click;
            // 
            // cmdKontoauszugdrucken
            // 
            cmdKontoauszugdrucken.Location = new Point(144, 227);
            cmdKontoauszugdrucken.Name = "cmdKontoauszugdrucken";
            cmdKontoauszugdrucken.Size = new Size(141, 23);
            cmdKontoauszugdrucken.TabIndex = 5;
            cmdKontoauszugdrucken.Text = "Kontoauszugdrucken";
            cmdKontoauszugdrucken.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdKontoauszugdrucken);
            Controls.Add(cmdKontostand);
            Controls.Add(cmdAuszahlen);
            Controls.Add(cmdEinzahlen);
            Controls.Add(txtAnzeige);
            Controls.Add(lblAnzeige);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAnzeige;
        private TextBox txtAnzeige;
        private Button cmdEinzahlen;
        private Button cmdAuszahlen;
        private Button cmdKontostand;
        private Button cmdKontoauszugdrucken;
    }
}
