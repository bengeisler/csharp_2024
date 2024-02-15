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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            LblKontostand = new Label();
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
            // button2
            // 
            button2.Location = new Point(208, 78);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 3;
            button2.Text = "Auszahlen";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(94, 174);
            button3.Name = "button3";
            button3.Size = new Size(137, 34);
            button3.TabIndex = 4;
            button3.Text = "Kontostand";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(94, 227);
            button4.Name = "button4";
            button4.Size = new Size(137, 69);
            button4.TabIndex = 5;
            button4.Text = "Kontoauszug drucken";
            button4.UseVisualStyleBackColor = true;
            // 
            // LblKontostand
            // 
            LblKontostand.AutoSize = true;
            LblKontostand.Location = new Point(70, 132);
            LblKontostand.Name = "LblKontostand";
            LblKontostand.Size = new Size(0, 25);
            LblKontostand.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 421);
            Controls.Add(LblKontostand);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
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
        private Button button2;
        private Button button3;
        private Button button4;
        private Label LblKontostand;
    }
}
