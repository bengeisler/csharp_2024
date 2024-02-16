// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UBankkonten
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
            LblAnzeige = new Label();
            txtBox = new TextBox();
            CmdEinzahlen = new Button();
            CmdAuszahlen = new Button();
            CmdKontostand = new Button();
            CmdKontoauszug = new Button();
            SuspendLayout();
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(146, 32);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(44, 15);
            LblAnzeige.TabIndex = 0;
            LblAnzeige.Text = "Betrag:";
            // 
            // txtBox
            // 
            txtBox.Location = new Point(285, 32);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(100, 23);
            txtBox.TabIndex = 1;
            // 
            // CmdEinzahlen
            // 
            CmdEinzahlen.Location = new Point(146, 103);
            CmdEinzahlen.Name = "CmdEinzahlen";
            CmdEinzahlen.Size = new Size(75, 23);
            CmdEinzahlen.TabIndex = 2;
            CmdEinzahlen.Text = "Einzahlen";
            CmdEinzahlen.UseVisualStyleBackColor = true;
            // 
            // CmdAuszahlen
            // 
            CmdAuszahlen.Location = new Point(434, 103);
            CmdAuszahlen.Name = "CmdAuszahlen";
            CmdAuszahlen.Size = new Size(75, 23);
            CmdAuszahlen.TabIndex = 3;
            CmdAuszahlen.Text = "Auszahlen";
            CmdAuszahlen.UseVisualStyleBackColor = true;
            // 
            // CmdKontostand
            // 
            CmdKontostand.Location = new Point(285, 178);
            CmdKontostand.Name = "CmdKontostand";
            CmdKontostand.Size = new Size(125, 45);
            CmdKontostand.TabIndex = 4;
            CmdKontostand.Text = "Kontostand";
            CmdKontostand.UseVisualStyleBackColor = true;
            // 
            // CmdKontoauszug
            // 
            CmdKontoauszug.Location = new Point(285, 290);
            CmdKontoauszug.Name = "CmdKontoauszug";
            CmdKontoauszug.Size = new Size(125, 51);
            CmdKontoauszug.TabIndex = 5;
            CmdKontoauszug.Text = "Kontoauszug drucken";
            CmdKontoauszug.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdKontoauszug);
            Controls.Add(CmdKontostand);
            Controls.Add(CmdAuszahlen);
            Controls.Add(CmdEinzahlen);
            Controls.Add(txtBox);
            Controls.Add(LblAnzeige);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAnzeige;
        private TextBox txtBox;
        private Button CmdEinzahlen;
        private Button CmdAuszahlen;
        private Button CmdKontostand;
        private Button CmdKontoauszug;
    }
}
