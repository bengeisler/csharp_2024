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
            CmdPruefen = new Button();
            LblAuswahl = new Label();
            OptRot = new RadioButton();
            OptGruen = new RadioButton();
            OptBlau = new RadioButton();
            CmdAuswahl = new Button();
            SuspendLayout();
            // 
            // LblPruefen
            // 
            LblPruefen.AutoSize = true;
            LblPruefen.Location = new Point(12, 9);
            LblPruefen.Name = "LblPruefen";
            LblPruefen.Size = new Size(59, 25);
            LblPruefen.TabIndex = 0;
            LblPruefen.Text = "label1";
            // 
            // CmdPruefen
            // 
            CmdPruefen.Location = new Point(306, 4);
            CmdPruefen.Name = "CmdPruefen";
            CmdPruefen.Size = new Size(141, 34);
            CmdPruefen.TabIndex = 1;
            CmdPruefen.Text = "Prüfen";
            CmdPruefen.UseVisualStyleBackColor = true;
            CmdPruefen.Click += CmdPruefen_Click;
            // 
            // LblAuswahl
            // 
            LblAuswahl.AutoSize = true;
            LblAuswahl.Location = new Point(12, 155);
            LblAuswahl.Name = "LblAuswahl";
            LblAuswahl.Size = new Size(59, 25);
            LblAuswahl.TabIndex = 2;
            LblAuswahl.Text = "label2";
            // 
            // OptRot
            // 
            OptRot.AutoSize = true;
            OptRot.Location = new Point(306, 43);
            OptRot.Name = "OptRot";
            OptRot.Size = new Size(64, 29);
            OptRot.TabIndex = 3;
            OptRot.TabStop = true;
            OptRot.Text = "Rot";
            OptRot.UseVisualStyleBackColor = true;
            OptRot.CheckedChanged += OptRot_CheckedChanged;
            // 
            // OptGruen
            // 
            OptGruen.AutoSize = true;
            OptGruen.Location = new Point(306, 78);
            OptGruen.Name = "OptGruen";
            OptGruen.Size = new Size(75, 29);
            OptGruen.TabIndex = 4;
            OptGruen.TabStop = true;
            OptGruen.Text = "Grün";
            OptGruen.UseVisualStyleBackColor = true;
            OptGruen.CheckedChanged += OptGruen_CheckedChanged;
            // 
            // OptBlau
            // 
            OptBlau.AutoSize = true;
            OptBlau.Location = new Point(306, 113);
            OptBlau.Name = "OptBlau";
            OptBlau.Size = new Size(70, 29);
            OptBlau.TabIndex = 5;
            OptBlau.TabStop = true;
            OptBlau.Text = "Blau";
            OptBlau.UseVisualStyleBackColor = true;
            OptBlau.CheckedChanged += OptBlau_CheckedChanged;
            // 
            // CmdAuswahl
            // 
            CmdAuswahl.Location = new Point(306, 150);
            CmdAuswahl.Name = "CmdAuswahl";
            CmdAuswahl.Size = new Size(141, 34);
            CmdAuswahl.TabIndex = 6;
            CmdAuswahl.Text = "Rot auswählen";
            CmdAuswahl.UseVisualStyleBackColor = true;
            CmdAuswahl.Click += CmdAuswahl_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 205);
            Controls.Add(CmdAuswahl);
            Controls.Add(OptBlau);
            Controls.Add(OptGruen);
            Controls.Add(OptRot);
            Controls.Add(LblAuswahl);
            Controls.Add(CmdPruefen);
            Controls.Add(LblPruefen);
            Name = "Form1";
            Text = "RadioButtons";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblPruefen;
        private Button CmdPruefen;
        private Label LblAuswahl;
        private RadioButton OptRot;
        private RadioButton OptGruen;
        private RadioButton OptBlau;
        private Button CmdAuswahl;
    }
}
