// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementeRadioButton
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
            LblAusgabe1 = new Label();
            BtnPruefen = new Button();
            BtnRotaus = new Button();
            RbRot = new RadioButton();
            RbGruen = new RadioButton();
            RbBlau = new RadioButton();
            LblAusgabe2 = new Label();
            SuspendLayout();
            // 
            // LblAusgabe1
            // 
            LblAusgabe1.AutoSize = true;
            LblAusgabe1.Location = new Point(49, 33);
            LblAusgabe1.Name = "LblAusgabe1";
            LblAusgabe1.Size = new Size(38, 15);
            LblAusgabe1.TabIndex = 0;
            LblAusgabe1.Text = "label1";
            // 
            // BtnPruefen
            // 
            BtnPruefen.Location = new Point(158, 33);
            BtnPruefen.Name = "BtnPruefen";
            BtnPruefen.Size = new Size(75, 23);
            BtnPruefen.TabIndex = 1;
            BtnPruefen.Text = "Prüfen";
            BtnPruefen.UseVisualStyleBackColor = true;
            BtnPruefen.Click += BtnPruefen_Click;
            // 
            // BtnRotaus
            // 
            BtnRotaus.Location = new Point(158, 164);
            BtnRotaus.Name = "BtnRotaus";
            BtnRotaus.Size = new Size(75, 23);
            BtnRotaus.TabIndex = 2;
            BtnRotaus.Text = "Rot auswählen";
            BtnRotaus.UseVisualStyleBackColor = true;
            BtnRotaus.Click += BtnRotaus_Click;
            // 
            // RbRot
            // 
            RbRot.AutoSize = true;
            RbRot.Location = new Point(139, 75);
            RbRot.Name = "RbRot";
            RbRot.Size = new Size(43, 19);
            RbRot.TabIndex = 3;
            RbRot.TabStop = true;
            RbRot.Text = "Rot";
            RbRot.UseVisualStyleBackColor = true;
            RbRot.CheckedChanged += RbRot_CheckedChanged;
            // 
            // RbGruen
            // 
            RbGruen.AutoSize = true;
            RbGruen.Location = new Point(139, 100);
            RbGruen.Name = "RbGruen";
            RbGruen.Size = new Size(51, 19);
            RbGruen.TabIndex = 4;
            RbGruen.TabStop = true;
            RbGruen.Text = "Grün";
            RbGruen.UseVisualStyleBackColor = true;
            RbGruen.CheckedChanged += RbGruen_CheckedChanged;
            // 
            // RbBlau
            // 
            RbBlau.AutoSize = true;
            RbBlau.Location = new Point(139, 125);
            RbBlau.Name = "RbBlau";
            RbBlau.Size = new Size(48, 19);
            RbBlau.TabIndex = 5;
            RbBlau.TabStop = true;
            RbBlau.Text = "Blau";
            RbBlau.UseVisualStyleBackColor = true;
            RbBlau.CheckedChanged += RbBlau_CheckedChanged;
            // 
            // LblAusgabe2
            // 
            LblAusgabe2.AutoSize = true;
            LblAusgabe2.Location = new Point(49, 172);
            LblAusgabe2.Name = "LblAusgabe2";
            LblAusgabe2.Size = new Size(38, 15);
            LblAusgabe2.TabIndex = 6;
            LblAusgabe2.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 239);
            Controls.Add(LblAusgabe2);
            Controls.Add(RbBlau);
            Controls.Add(RbGruen);
            Controls.Add(RbRot);
            Controls.Add(BtnRotaus);
            Controls.Add(BtnPruefen);
            Controls.Add(LblAusgabe1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAusgabe1;
        private Button BtnPruefen;
        private Button BtnRotaus;
        private RadioButton RbRot;
        private RadioButton RbGruen;
        private RadioButton RbBlau;
        private Label LblAusgabe2;
    }
}
