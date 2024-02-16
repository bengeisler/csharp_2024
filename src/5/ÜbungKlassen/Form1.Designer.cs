// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace ÜbungKlassen
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
            CmdButtonEin = new Button();
            CmdButtonAus = new Button();
            CmdButtonStand = new Button();
            CmdButtonAusz = new Button();
            CmdButtonC = new Button();
            TxtBox = new TextBox();
            LblAnzeige2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 70);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Betrag:";
            // 
            // CmdButtonEin
            // 
            CmdButtonEin.Location = new Point(78, 128);
            CmdButtonEin.Name = "CmdButtonEin";
            CmdButtonEin.Size = new Size(75, 35);
            CmdButtonEin.TabIndex = 1;
            CmdButtonEin.Text = "Einzahlen";
            CmdButtonEin.UseVisualStyleBackColor = true;
            CmdButtonEin.Click += CmdButtonEin_Click;
            // 
            // CmdButtonAus
            // 
            CmdButtonAus.Location = new Point(181, 128);
            CmdButtonAus.Name = "CmdButtonAus";
            CmdButtonAus.Size = new Size(75, 35);
            CmdButtonAus.TabIndex = 2;
            CmdButtonAus.Text = "Auszahlen";
            CmdButtonAus.UseVisualStyleBackColor = true;
            CmdButtonAus.Click += CmdButtonAus_Click;
            // 
            // CmdButtonStand
            // 
            CmdButtonStand.Location = new Point(120, 200);
            CmdButtonStand.Name = "CmdButtonStand";
            CmdButtonStand.Size = new Size(91, 24);
            CmdButtonStand.TabIndex = 3;
            CmdButtonStand.Text = "Kontostand";
            CmdButtonStand.UseVisualStyleBackColor = true;
            CmdButtonStand.Click += CmdButtonStand_Click;
            // 
            // CmdButtonAusz
            // 
            CmdButtonAusz.Location = new Point(108, 248);
            CmdButtonAusz.Name = "CmdButtonAusz";
            CmdButtonAusz.Size = new Size(112, 44);
            CmdButtonAusz.TabIndex = 4;
            CmdButtonAusz.Text = "Kontoauszug drucken";
            CmdButtonAusz.UseVisualStyleBackColor = true;
            // 
            // CmdButtonC
            // 
            CmdButtonC.Location = new Point(230, 248);
            CmdButtonC.Name = "CmdButtonC";
            CmdButtonC.Size = new Size(75, 35);
            CmdButtonC.TabIndex = 5;
            CmdButtonC.Text = "Cancle";
            CmdButtonC.UseVisualStyleBackColor = true;
            CmdButtonC.Click += CmdButtonC_Click;
            // 
            // TxtBox
            // 
            TxtBox.Location = new Point(120, 70);
            TxtBox.Name = "TxtBox";
            TxtBox.Size = new Size(100, 23);
            TxtBox.TabIndex = 6;
            // 
            // LblAnzeige2
            // 
            LblAnzeige2.AutoSize = true;
            LblAnzeige2.Location = new Point(147, 182);
            LblAnzeige2.Name = "LblAnzeige2";
            LblAnzeige2.Size = new Size(38, 15);
            LblAnzeige2.TabIndex = 7;
            LblAnzeige2.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 450);
            Controls.Add(LblAnzeige2);
            Controls.Add(TxtBox);
            Controls.Add(CmdButtonC);
            Controls.Add(CmdButtonAusz);
            Controls.Add(CmdButtonStand);
            Controls.Add(CmdButtonAus);
            Controls.Add(CmdButtonEin);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button CmdButtonEin;
        private Button CmdButtonAus;
        private Button CmdButtonStand;
        private Button CmdButtonAusz;
        private Button CmdButtonC;
        private TextBox TxtBox;
        private Label LblAnzeige2;
    }
}
