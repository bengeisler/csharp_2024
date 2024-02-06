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
            ChkSchalter = new CheckBox();
            LblPruefen = new Label();
            LblUmschalten = new Label();
            CmdPruefen = new Button();
            CmdUmschalten = new Button();
            SuspendLayout();
            // 
            // ChkSchalter
            // 
            ChkSchalter.AutoSize = true;
            ChkSchalter.Location = new Point(411, 70);
            ChkSchalter.Name = "ChkSchalter";
            ChkSchalter.Size = new Size(68, 19);
            ChkSchalter.TabIndex = 0;
            ChkSchalter.Text = "Schalter";
            ChkSchalter.UseVisualStyleBackColor = true;
            ChkSchalter.CheckedChanged += ChkSchalter_CheckedChanged;
            // 
            // LblPruefen
            // 
            LblPruefen.AutoSize = true;
            LblPruefen.Location = new Point(274, 19);
            LblPruefen.Name = "LblPruefen";
            LblPruefen.Size = new Size(38, 15);
            LblPruefen.TabIndex = 1;
            LblPruefen.Text = "label1";
            // 
            // LblUmschalten
            // 
            LblUmschalten.AutoSize = true;
            LblUmschalten.Location = new Point(274, 143);
            LblUmschalten.Name = "LblUmschalten";
            LblUmschalten.Size = new Size(38, 15);
            LblUmschalten.TabIndex = 2;
            LblUmschalten.Text = "label2";
            // 
            // CmdPruefen
            // 
            CmdPruefen.Location = new Point(411, 19);
            CmdPruefen.Name = "CmdPruefen";
            CmdPruefen.Size = new Size(140, 32);
            CmdPruefen.TabIndex = 3;
            CmdPruefen.Text = "Prüfen";
            CmdPruefen.UseVisualStyleBackColor = true;
            CmdPruefen.Click += CmdPruefen_Click;
            // 
            // CmdUmschalten
            // 
            CmdUmschalten.Location = new Point(411, 143);
            CmdUmschalten.Name = "CmdUmschalten";
            CmdUmschalten.Size = new Size(140, 32);
            CmdUmschalten.TabIndex = 4;
            CmdUmschalten.Text = "Umschalten";
            CmdUmschalten.UseVisualStyleBackColor = true;
            CmdUmschalten.Click += CmdUmschalten_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 333);
            Controls.Add(CmdUmschalten);
            Controls.Add(CmdPruefen);
            Controls.Add(LblUmschalten);
            Controls.Add(LblPruefen);
            Controls.Add(ChkSchalter);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ChkSchalter;
        private Label LblPruefen;
        private Label LblUmschalten;
        private Button CmdPruefen;
        private Button CmdUmschalten;
    }
}
