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
            cmdPrüfen = new Button();
            cmdUmschalten = new Button();
            LblPrüfen = new Label();
            LblSchalter = new Label();
            ChkSchalter = new CheckBox();
            SuspendLayout();
            // 
            // cmdPrüfen
            // 
            cmdPrüfen.Location = new Point(123, 23);
            cmdPrüfen.Name = "cmdPrüfen";
            cmdPrüfen.Size = new Size(83, 23);
            cmdPrüfen.TabIndex = 0;
            cmdPrüfen.Text = "Prüfen";
            cmdPrüfen.UseVisualStyleBackColor = true;
            cmdPrüfen.Click += cmdPrüfen_Click;
            // 
            // cmdUmschalten
            // 
            cmdUmschalten.Location = new Point(123, 100);
            cmdUmschalten.Name = "cmdUmschalten";
            cmdUmschalten.Size = new Size(83, 23);
            cmdUmschalten.TabIndex = 1;
            cmdUmschalten.Text = "Umschalten";
            cmdUmschalten.UseVisualStyleBackColor = true;
            cmdUmschalten.Click += cmdUmschalten_Click;
            // 
            // LblPrüfen
            // 
            LblPrüfen.AutoSize = true;
            LblPrüfen.Location = new Point(16, 27);
            LblPrüfen.Name = "LblPrüfen";
            LblPrüfen.Size = new Size(38, 15);
            LblPrüfen.TabIndex = 2;
            LblPrüfen.Text = "label1";
            // 
            // LblSchalter
            // 
            LblSchalter.AutoSize = true;
            LblSchalter.Location = new Point(16, 104);
            LblSchalter.Name = "LblSchalter";
            LblSchalter.Size = new Size(38, 15);
            LblSchalter.TabIndex = 3;
            LblSchalter.Text = "label2";
            // 
            // ChkSchalter
            // 
            ChkSchalter.AutoSize = true;
            ChkSchalter.Location = new Point(123, 62);
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
            ClientSize = new Size(800, 450);
            Controls.Add(ChkSchalter);
            Controls.Add(LblSchalter);
            Controls.Add(LblPrüfen);
            Controls.Add(cmdUmschalten);
            Controls.Add(cmdPrüfen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdPrüfen;
        private Button cmdUmschalten;
        private Label LblPrüfen;
        private Label LblSchalter;
        private CheckBox ChkSchalter;
    }
}
