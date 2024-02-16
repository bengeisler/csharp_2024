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
            label1 = new Label();
            TxtEingabe = new TextBox();
            CmdEinzahlen = new Button();
            CmdAuszahlen = new Button();
            CmdKontostand = new Button();
            CmdKontoauszug = new Button();
            LblKontostand = new Label();
            LblKontoauszug = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 11);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 0;
            label1.Text = "Betrag:";
            // 
            // TxtEingabe
            // 
            TxtEingabe.Location = new Point(94, 8);
            TxtEingabe.Name = "TxtEingabe";
            TxtEingabe.Size = new Size(226, 31);
            TxtEingabe.TabIndex = 1;
            // 
            // CmdEinzahlen
            // 
            CmdEinzahlen.Location = new Point(17, 78);
            CmdEinzahlen.Name = "CmdEinzahlen";
            CmdEinzahlen.Size = new Size(112, 34);
            CmdEinzahlen.TabIndex = 2;
            CmdEinzahlen.Text = "Einzahlen";
            CmdEinzahlen.UseVisualStyleBackColor = true;
            CmdEinzahlen.Click += CmdEinzahlen_Click;
            // 
            // CmdAuszahlen
            // 
            CmdAuszahlen.Location = new Point(208, 78);
            CmdAuszahlen.Name = "CmdAuszahlen";
            CmdAuszahlen.Size = new Size(112, 34);
            CmdAuszahlen.TabIndex = 3;
            CmdAuszahlen.Text = "Auszahlen";
            CmdAuszahlen.UseVisualStyleBackColor = true;
            CmdAuszahlen.Click += CmdAuszahlen_Click;
            // 
            // CmdKontostand
            // 
            CmdKontostand.Location = new Point(94, 174);
            CmdKontostand.Name = "CmdKontostand";
            CmdKontostand.Size = new Size(137, 34);
            CmdKontostand.TabIndex = 4;
            CmdKontostand.Text = "Kontostand";
            CmdKontostand.UseVisualStyleBackColor = true;
            CmdKontostand.Click += CmdKontostand_Click;
            // 
            // CmdKontoauszug
            // 
            CmdKontoauszug.Location = new Point(94, 227);
            CmdKontoauszug.Name = "CmdKontoauszug";
            CmdKontoauszug.Size = new Size(137, 69);
            CmdKontoauszug.TabIndex = 5;
            CmdKontoauszug.Text = "Kontoauszug drucken";
            CmdKontoauszug.UseVisualStyleBackColor = true;
            // 
            // LblKontostand
            // 
            LblKontostand.AutoSize = true;
            LblKontostand.Location = new Point(70, 132);
            LblKontostand.Name = "LblKontostand";
            LblKontostand.Size = new Size(0, 25);
            LblKontostand.TabIndex = 6;
            // 
            // LblKontoauszug
            // 
            LblKontoauszug.AutoSize = true;
            LblKontoauszug.Location = new Point(60, 326);
            LblKontoauszug.Name = "LblKontoauszug";
            LblKontoauszug.Size = new Size(0, 25);
            LblKontoauszug.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 421);
            Controls.Add(LblKontoauszug);
            Controls.Add(LblKontostand);
            Controls.Add(CmdKontoauszug);
            Controls.Add(CmdKontostand);
            Controls.Add(CmdAuszahlen);
            Controls.Add(CmdEinzahlen);
            Controls.Add(TxtEingabe);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Konto verwalten";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtEingabe;
        private Button CmdEinzahlen;
        private Button CmdAuszahlen;
        private Button CmdKontostand;
        private Button CmdKontoauszug;
        private Label LblKontostand;
        private Label LblKontoauszug;
    }
}
