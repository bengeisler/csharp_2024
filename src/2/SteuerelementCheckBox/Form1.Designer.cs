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
            LblPruefen = new Label();
            LblSchalter = new Label();
            ChkSchalter = new CheckBox();
            CmdPruefen = new Button();
            CmdUmschalten = new Button();
            SuspendLayout();
            // 
            // LblPruefen
            // 
            LblPruefen.AutoSize = true;
            LblPruefen.Location = new Point(56, 68);
            LblPruefen.Name = "LblPruefen";
            LblPruefen.Size = new Size(27, 15);
            LblPruefen.TabIndex = 0;
            LblPruefen.Text = "Aus";
            // 
            // LblSchalter
            // 
            LblSchalter.AutoSize = true;
            LblSchalter.Location = new Point(56, 168);
            LblSchalter.Name = "LblSchalter";
            LblSchalter.Size = new Size(27, 15);
            LblSchalter.TabIndex = 1;
            LblSchalter.Text = "Aus";
            // 
            // ChkSchalter
            // 
            ChkSchalter.AutoSize = true;
            ChkSchalter.Location = new Point(264, 139);
            ChkSchalter.Name = "ChkSchalter";
            ChkSchalter.Size = new Size(68, 19);
            ChkSchalter.TabIndex = 2;
            ChkSchalter.Text = "Schalter";
            ChkSchalter.UseVisualStyleBackColor = true;
            ChkSchalter.CheckedChanged += ChkSchalter_CheckedChanged;
            // 
            // CmdPruefen
            // 
            CmdPruefen.Location = new Point(265, 67);
            CmdPruefen.Name = "CmdPruefen";
            CmdPruefen.Size = new Size(105, 23);
            CmdPruefen.TabIndex = 3;
            CmdPruefen.Text = "Prüfen";
            CmdPruefen.UseVisualStyleBackColor = true;
            CmdPruefen.Click += CmdPruefen_Click;
            // 
            // CmdUmschalten
            // 
            CmdUmschalten.Location = new Point(265, 218);
            CmdUmschalten.Name = "CmdUmschalten";
            CmdUmschalten.Size = new Size(105, 23);
            CmdUmschalten.TabIndex = 4;
            CmdUmschalten.Text = "Umschalten";
            CmdUmschalten.UseVisualStyleBackColor = true;
            CmdUmschalten.Click += CmdUmschalten_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdUmschalten);
            Controls.Add(CmdPruefen);
            Controls.Add(ChkSchalter);
            Controls.Add(LblSchalter);
            Controls.Add(LblPruefen);
            Name = "Form1";
            Text = "CheckBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblPruefen;
        private Label LblSchalter;
        private CheckBox ChkSchalter;
        private Button CmdPruefen;
        private Button CmdUmschalten;
    }
}
