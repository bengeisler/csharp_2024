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
            LblPruefen = new Label();
            LblAuswahl = new Label();
            CmdPruefen = new Button();
            OptRot = new RadioButton();
            OptGruen = new RadioButton();
            OptBlau = new RadioButton();
            CmdAuswahlRot = new Button();
            SuspendLayout();
            // 
            // LblPruefen
            // 
            LblPruefen.AutoSize = true;
            LblPruefen.Location = new Point(55, 86);
            LblPruefen.Name = "LblPruefen";
            LblPruefen.Size = new Size(52, 15);
            LblPruefen.TabIndex = 0;
            LblPruefen.Text = "Auswahl";
            // 
            // LblAuswahl
            // 
            LblAuswahl.AutoSize = true;
            LblAuswahl.Location = new Point(55, 261);
            LblAuswahl.Name = "LblAuswahl";
            LblAuswahl.Size = new Size(42, 15);
            LblAuswahl.TabIndex = 1;
            LblAuswahl.Text = "Prüfen";
            // 
            // CmdPruefen
            // 
            CmdPruefen.Location = new Point(279, 60);
            CmdPruefen.Name = "CmdPruefen";
            CmdPruefen.Size = new Size(126, 23);
            CmdPruefen.TabIndex = 2;
            CmdPruefen.Text = "Prüfen";
            CmdPruefen.UseVisualStyleBackColor = true;
            CmdPruefen.Click += CmdPruefen_Click;
            // 
            // OptRot
            // 
            OptRot.AutoSize = true;
            OptRot.Location = new Point(279, 135);
            OptRot.Name = "OptRot";
            OptRot.Size = new Size(43, 19);
            OptRot.TabIndex = 3;
            OptRot.TabStop = true;
            OptRot.Text = "Rot";
            OptRot.UseVisualStyleBackColor = true;
            OptRot.CheckedChanged += OptRot_CheckedChanged;
            // 
            // OptGruen
            // 
            OptGruen.AutoSize = true;
            OptGruen.Location = new Point(279, 160);
            OptGruen.Name = "OptGruen";
            OptGruen.Size = new Size(51, 19);
            OptGruen.TabIndex = 4;
            OptGruen.TabStop = true;
            OptGruen.Text = "Grün";
            OptGruen.UseVisualStyleBackColor = true;
            OptGruen.CheckedChanged += OptGruen_CheckedChanged;
            // 
            // OptBlau
            // 
            OptBlau.AutoSize = true;
            OptBlau.Location = new Point(279, 185);
            OptBlau.Name = "OptBlau";
            OptBlau.Size = new Size(48, 19);
            OptBlau.TabIndex = 5;
            OptBlau.TabStop = true;
            OptBlau.Text = "Blau";
            OptBlau.UseVisualStyleBackColor = true;
            OptBlau.CheckedChanged += OptBlau_CheckedChanged;
            // 
            // CmdAuswahlRot
            // 
            CmdAuswahlRot.Location = new Point(279, 253);
            CmdAuswahlRot.Name = "CmdAuswahlRot";
            CmdAuswahlRot.Size = new Size(126, 23);
            CmdAuswahlRot.TabIndex = 6;
            CmdAuswahlRot.Text = "Rot auswählen";
            CmdAuswahlRot.UseVisualStyleBackColor = true;
            CmdAuswahlRot.Click += CmdAuswahlRot_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdAuswahlRot);
            Controls.Add(OptBlau);
            Controls.Add(OptGruen);
            Controls.Add(OptRot);
            Controls.Add(CmdPruefen);
            Controls.Add(LblAuswahl);
            Controls.Add(LblPruefen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblPruefen;
        private Label LblAuswahl;
        private Button CmdPruefen;
        private RadioButton OptRot;
        private RadioButton OptGruen;
        private RadioButton OptBlau;
        private Button CmdAuswahlRot;
    }
}
