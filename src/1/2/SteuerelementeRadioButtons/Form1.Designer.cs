// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementeRadioButtons
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
            cmdPrüfen = new Button();
            cmdAuswählen = new Button();
            LblAnzeigen1 = new Label();
            LblAnzeigen2 = new Label();
            OptRot = new RadioButton();
            OptGruen = new RadioButton();
            OptBlau = new RadioButton();
            SuspendLayout();
            // 
            // cmdPrüfen
            // 
            cmdPrüfen.Location = new Point(196, 26);
            cmdPrüfen.Name = "cmdPrüfen";
            cmdPrüfen.Size = new Size(107, 23);
            cmdPrüfen.TabIndex = 0;
            cmdPrüfen.Text = "Prüfen";
            cmdPrüfen.UseVisualStyleBackColor = true;
            cmdPrüfen.Click += cmdPrüfen_Click;
            // 
            // cmdAuswählen
            // 
            cmdAuswählen.Location = new Point(196, 156);
            cmdAuswählen.Name = "cmdAuswählen";
            cmdAuswählen.Size = new Size(107, 23);
            cmdAuswählen.TabIndex = 1;
            cmdAuswählen.Text = "Rot auswählen";
            cmdAuswählen.UseVisualStyleBackColor = true;
            cmdAuswählen.Click += cmdAuswählen_Click;
            // 
            // LblAnzeigen1
            // 
            LblAnzeigen1.AutoSize = true;
            LblAnzeigen1.Location = new Point(40, 30);
            LblAnzeigen1.Name = "LblAnzeigen1";
            LblAnzeigen1.Size = new Size(38, 15);
            LblAnzeigen1.TabIndex = 2;
            LblAnzeigen1.Text = "label1";
            // 
            // LblAnzeigen2
            // 
            LblAnzeigen2.AutoSize = true;
            LblAnzeigen2.Location = new Point(40, 160);
            LblAnzeigen2.Name = "LblAnzeigen2";
            LblAnzeigen2.Size = new Size(38, 15);
            LblAnzeigen2.TabIndex = 3;
            LblAnzeigen2.Text = "label2";
            // 
            // OptRot
            // 
            OptRot.AutoSize = true;
            OptRot.Location = new Point(196, 70);
            OptRot.Name = "OptRot";
            OptRot.Size = new Size(43, 19);
            OptRot.TabIndex = 4;
            OptRot.TabStop = true;
            OptRot.Text = "Rot";
            OptRot.UseVisualStyleBackColor = true;
            OptRot.CheckedChanged += OptRot_CheckedChanged;
            // 
            // OptGruen
            // 
            OptGruen.AutoSize = true;
            OptGruen.Location = new Point(196, 95);
            OptGruen.Name = "OptGruen";
            OptGruen.Size = new Size(51, 19);
            OptGruen.TabIndex = 5;
            OptGruen.TabStop = true;
            OptGruen.Text = "Grün";
            OptGruen.UseVisualStyleBackColor = true;
            OptGruen.CheckedChanged += OptGruen_CheckedChanged;
            // 
            // OptBlau
            // 
            OptBlau.AutoSize = true;
            OptBlau.Location = new Point(196, 120);
            OptBlau.Name = "OptBlau";
            OptBlau.Size = new Size(48, 19);
            OptBlau.TabIndex = 6;
            OptBlau.TabStop = true;
            OptBlau.Text = "Blau";
            OptBlau.UseVisualStyleBackColor = true;
            OptBlau.CheckedChanged += OptBlau_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OptBlau);
            Controls.Add(OptGruen);
            Controls.Add(OptRot);
            Controls.Add(LblAnzeigen2);
            Controls.Add(LblAnzeigen1);
            Controls.Add(cmdAuswählen);
            Controls.Add(cmdPrüfen);
            Name = "Form1";
            Text = "RadioButtons";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdPrüfen;
        private Button cmdAuswählen;
        private Label LblAnzeigen1;
        private Label LblAnzeigen2;
        private RadioButton OptRot;
        private RadioButton OptGruen;
        private RadioButton OptBlau;
    }
}
