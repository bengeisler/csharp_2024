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
            CmdPrüfen = new Button();
            CmdAuswählen = new Button();
            OptRot = new RadioButton();
            OptGrün = new RadioButton();
            OptBlau = new RadioButton();
            LabelPruefen = new Label();
            LabelAuswahl = new Label();
            SuspendLayout();
            // 
            // CmdPrüfen
            // 
            CmdPrüfen.Location = new Point(341, 21);
            CmdPrüfen.Name = "CmdPrüfen";
            CmdPrüfen.Size = new Size(75, 23);
            CmdPrüfen.TabIndex = 0;
            CmdPrüfen.Text = "Prüfen";
            CmdPrüfen.UseVisualStyleBackColor = true;
            CmdPrüfen.Click += CmdPrüfen_Click;
            // 
            // CmdAuswählen
            // 
            CmdAuswählen.Location = new Point(341, 142);
            CmdAuswählen.Name = "CmdAuswählen";
            CmdAuswählen.Size = new Size(138, 23);
            CmdAuswählen.TabIndex = 1;
            CmdAuswählen.Text = "Rot auswählen";
            CmdAuswählen.UseVisualStyleBackColor = true;
            CmdAuswählen.Click += CmdAuswählen_Click;
            // 
            // OptRot
            // 
            OptRot.AutoSize = true;
            OptRot.Location = new Point(341, 50);
            OptRot.Name = "OptRot";
            OptRot.Size = new Size(43, 19);
            OptRot.TabIndex = 2;
            OptRot.TabStop = true;
            OptRot.Text = "Rot";
            OptRot.UseVisualStyleBackColor = true;
            OptRot.CheckedChanged += OptRot_CheckedChanged;
            // 
            // OptGrün
            // 
            OptGrün.AutoSize = true;
            OptGrün.Location = new Point(341, 74);
            OptGrün.Name = "OptGrün";
            OptGrün.Size = new Size(51, 19);
            OptGrün.TabIndex = 3;
            OptGrün.TabStop = true;
            OptGrün.Text = "Grün";
            OptGrün.UseVisualStyleBackColor = true;
            OptGrün.CheckedChanged += OptGrün_CheckedChanged;
            // 
            // OptBlau
            // 
            OptBlau.AutoSize = true;
            OptBlau.Location = new Point(341, 99);
            OptBlau.Name = "OptBlau";
            OptBlau.Size = new Size(48, 19);
            OptBlau.TabIndex = 4;
            OptBlau.TabStop = true;
            OptBlau.Text = "Blau";
            OptBlau.UseVisualStyleBackColor = true;
            OptBlau.CheckedChanged += OptBlau_CheckedChanged;
            // 
            // LabelPruefen
            // 
            LabelPruefen.AutoSize = true;
            LabelPruefen.Location = new Point(44, 25);
            LabelPruefen.Name = "LabelPruefen";
            LabelPruefen.Size = new Size(38, 15);
            LabelPruefen.TabIndex = 6;
            LabelPruefen.Text = "label1";
            // 
            // LabelAuswahl
            // 
            LabelAuswahl.AutoSize = true;
            LabelAuswahl.Location = new Point(44, 146);
            LabelAuswahl.Name = "LabelAuswahl";
            LabelAuswahl.Size = new Size(38, 15);
            LabelAuswahl.TabIndex = 7;
            LabelAuswahl.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LabelAuswahl);
            Controls.Add(LabelPruefen);
            Controls.Add(OptBlau);
            Controls.Add(OptGrün);
            Controls.Add(OptRot);
            Controls.Add(CmdAuswählen);
            Controls.Add(CmdPrüfen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdPrüfen;
        private Button CmdAuswählen;
        private RadioButton OptRot;
        private RadioButton OptGrün;
        private RadioButton OptBlau;
        private Label LabelPruefen;
        private Label LabelAuswahl;
    }
}
