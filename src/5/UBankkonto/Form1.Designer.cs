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
            CmdEinzahlen = new Button();
            TxtBeitrag = new TextBox();
            LblAusgabe = new Label();
            CmdAuszahlen = new Button();
            CmdKontostand = new Button();
            CmdKStand = new Button();
            SuspendLayout();
            // 
            // CmdEinzahlen
            // 
            CmdEinzahlen.Location = new Point(202, 156);
            CmdEinzahlen.Name = "CmdEinzahlen";
            CmdEinzahlen.Size = new Size(102, 49);
            CmdEinzahlen.TabIndex = 0;
            CmdEinzahlen.Text = "Einzahlen";
            CmdEinzahlen.UseVisualStyleBackColor = true;
            CmdEinzahlen.Click += CmdEinzahlen_Click;
            // 
            // TxtBeitrag
            // 
            TxtBeitrag.Location = new Point(278, 66);
            TxtBeitrag.Name = "TxtBeitrag";
            TxtBeitrag.Size = new Size(100, 23);
            TxtBeitrag.TabIndex = 1;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(185, 69);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(44, 15);
            LblAusgabe.TabIndex = 2;
            LblAusgabe.Text = "Beitrag";
            // 
            // CmdAuszahlen
            // 
            CmdAuszahlen.Location = new Point(353, 156);
            CmdAuszahlen.Name = "CmdAuszahlen";
            CmdAuszahlen.Size = new Size(103, 49);
            CmdAuszahlen.TabIndex = 3;
            CmdAuszahlen.Text = "Auszahlen";
            CmdAuszahlen.UseVisualStyleBackColor = true;
            CmdAuszahlen.Click += CmdAuszahlen_Click;
            // 
            // CmdKontostand
            // 
            CmdKontostand.Location = new Point(291, 247);
            CmdKontostand.Name = "CmdKontostand";
            CmdKontostand.Size = new Size(123, 50);
            CmdKontostand.TabIndex = 4;
            CmdKontostand.Text = "Kontostand";
            CmdKontostand.UseVisualStyleBackColor = true;
            CmdKontostand.Click += CmdKontostand_Click;
            // 
            // CmdKStand
            // 
            CmdKStand.Location = new Point(291, 337);
            CmdKStand.Name = "CmdKStand";
            CmdKStand.Size = new Size(123, 51);
            CmdKStand.TabIndex = 5;
            CmdKStand.Text = "Kontoauszug drucken";
            CmdKStand.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdKStand);
            Controls.Add(CmdKontostand);
            Controls.Add(CmdAuszahlen);
            Controls.Add(LblAusgabe);
            Controls.Add(TxtBeitrag);
            Controls.Add(CmdEinzahlen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdEinzahlen;
        private TextBox TxtBeitrag;
        private Label LblAusgabe;
        private Button CmdAuszahlen;
        private Button CmdKontostand;
        private Button CmdKStand;
    }
}
