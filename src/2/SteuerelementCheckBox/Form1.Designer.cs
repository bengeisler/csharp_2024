// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementCheckBox
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
            CmdUmschalten = new Button();
            LblPrüfen = new Label();
            LblSchalter = new Label();
            ChkSchalter = new CheckBox();
            SuspendLayout();
            // 
            // CmdPrüfen
            // 
            CmdPrüfen.Location = new Point(394, 35);
            CmdPrüfen.Name = "CmdPrüfen";
            CmdPrüfen.Size = new Size(113, 23);
            CmdPrüfen.TabIndex = 0;
            CmdPrüfen.Text = "Prüfen";
            CmdPrüfen.UseVisualStyleBackColor = true;
            CmdPrüfen.Click += CmdPrüfen_Click;
            // 
            // CmdUmschalten
            // 
            CmdUmschalten.Location = new Point(394, 127);
            CmdUmschalten.Name = "CmdUmschalten";
            CmdUmschalten.Size = new Size(113, 23);
            CmdUmschalten.TabIndex = 1;
            CmdUmschalten.Text = "Umschalten";
            CmdUmschalten.UseVisualStyleBackColor = true;
            CmdUmschalten.Click += CmdUmschalten_Click;
            // 
            // LblPrüfen
            // 
            LblPrüfen.AutoSize = true;
            LblPrüfen.Location = new Point(28, 43);
            LblPrüfen.Name = "LblPrüfen";
            LblPrüfen.Size = new Size(38, 15);
            LblPrüfen.TabIndex = 2;
            LblPrüfen.Text = "label1";
            // 
            // LblSchalter
            // 
            LblSchalter.AutoSize = true;
            LblSchalter.Location = new Point(28, 127);
            LblSchalter.Name = "LblSchalter";
            LblSchalter.Size = new Size(38, 15);
            LblSchalter.TabIndex = 3;
            LblSchalter.Text = "label2";
            // 
            // ChkSchalter
            // 
            ChkSchalter.AutoSize = true;
            ChkSchalter.Location = new Point(394, 83);
            ChkSchalter.Name = "ChkSchalter";
            ChkSchalter.Size = new Size(68, 19);
            ChkSchalter.TabIndex = 4;
            ChkSchalter.Text = "Schalter";
            ChkSchalter.UseVisualStyleBackColor = true;
            ChkSchalter.CheckedChanged += ChkSchalter_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 258);
            Controls.Add(ChkSchalter);
            Controls.Add(LblSchalter);
            Controls.Add(LblPrüfen);
            Controls.Add(CmdUmschalten);
            Controls.Add(CmdPrüfen);
            Name = "Form1";
            Text = "Prüfen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdPrüfen;
        private Button CmdUmschalten;
        private Label LblPrüfen;
        private Label LblSchalter;
        private CheckBox ChkSchalter;
    }
}
