// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementRadioButton
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
            OptRot = new RadioButton();
            OptGruen = new RadioButton();
            OptBlau = new RadioButton();
            CmdPruefen = new Button();
            LblPruefen = new Label();
            LblAuswahl = new Label();
            CmdRot = new Button();
            SuspendLayout();
            // 
            // OptRot
            // 
            OptRot.AutoSize = true;
            OptRot.Location = new Point(584, 129);
            OptRot.Name = "OptRot";
            OptRot.Size = new Size(43, 19);
            OptRot.TabIndex = 0;
            OptRot.TabStop = true;
            OptRot.Text = "Rot";
            OptRot.UseVisualStyleBackColor = true;
            OptRot.CheckedChanged += OptRot_CheckedChanged;
            // 
            // OptGruen
            // 
            OptGruen.AutoSize = true;
            OptGruen.Location = new Point(584, 176);
            OptGruen.Name = "OptGruen";
            OptGruen.Size = new Size(51, 19);
            OptGruen.TabIndex = 1;
            OptGruen.TabStop = true;
            OptGruen.Text = "Grün";
            OptGruen.UseVisualStyleBackColor = true;
            OptGruen.CheckedChanged += OptGruen_CheckedChanged;
            // 
            // OptBlau
            // 
            OptBlau.AutoSize = true;
            OptBlau.Location = new Point(584, 225);
            OptBlau.Name = "OptBlau";
            OptBlau.Size = new Size(48, 19);
            OptBlau.TabIndex = 2;
            OptBlau.TabStop = true;
            OptBlau.Text = "Blau";
            OptBlau.UseVisualStyleBackColor = true;
            OptBlau.CheckedChanged += OptBlau_CheckedChanged;
            // 
            // CmdPruefen
            // 
            CmdPruefen.Location = new Point(569, 45);
            CmdPruefen.Name = "CmdPruefen";
            CmdPruefen.Size = new Size(146, 47);
            CmdPruefen.TabIndex = 3;
            CmdPruefen.Text = "Prüfen";
            CmdPruefen.UseVisualStyleBackColor = true;
            CmdPruefen.Click += CmdPruefen_Click;
            // 
            // LblPruefen
            // 
            LblPruefen.AutoSize = true;
            LblPruefen.Location = new Point(279, 77);
            LblPruefen.Name = "LblPruefen";
            LblPruefen.Size = new Size(38, 15);
            LblPruefen.TabIndex = 4;
            LblPruefen.Text = "label1";
            // 
            // LblAuswahl
            // 
            LblAuswahl.AutoSize = true;
            LblAuswahl.Location = new Point(279, 316);
            LblAuswahl.Name = "LblAuswahl";
            LblAuswahl.Size = new Size(38, 15);
            LblAuswahl.TabIndex = 5;
            LblAuswahl.Text = "label2";
            // 
            // CmdRot
            // 
            CmdRot.Location = new Point(569, 316);
            CmdRot.Name = "CmdRot";
            CmdRot.Size = new Size(146, 47);
            CmdRot.TabIndex = 6;
            CmdRot.Text = "Rot auswählen";
            CmdRot.UseVisualStyleBackColor = true;
            CmdRot.Click += CmdRot_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdRot);
            Controls.Add(LblAuswahl);
            Controls.Add(LblPruefen);
            Controls.Add(CmdPruefen);
            Controls.Add(OptBlau);
            Controls.Add(OptGruen);
            Controls.Add(OptRot);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton OptRot;
        private RadioButton OptGruen;
        private RadioButton OptBlau;
        private Button CmdPruefen;
        private Label LblPruefen;
        private Label LblAuswahl;
        private Button CmdRot;
    }
}
