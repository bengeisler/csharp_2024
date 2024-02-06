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
            CmdPruefen = new Button();
            CmdUmschalten = new Button();
            LblPruefen = new Label();
            LblSchalter = new Label();
            ChkSchalter = new CheckBox();
            SuspendLayout();
            // 
            // CmdPruefen
            // 
            CmdPruefen.Location = new Point(332, 6);
            CmdPruefen.Name = "CmdPruefen";
            CmdPruefen.Size = new Size(112, 34);
            CmdPruefen.TabIndex = 0;
            CmdPruefen.Text = "Prüfen";
            CmdPruefen.UseVisualStyleBackColor = true;
            CmdPruefen.Click += CmdPruefen_Click;
            // 
            // CmdUmschalten
            // 
            CmdUmschalten.Location = new Point(332, 107);
            CmdUmschalten.Name = "CmdUmschalten";
            CmdUmschalten.Size = new Size(112, 34);
            CmdUmschalten.TabIndex = 1;
            CmdUmschalten.Text = "Umschalten";
            CmdUmschalten.UseVisualStyleBackColor = true;
            CmdUmschalten.Click += CmdUmschalten_Click;
            // 
            // LblPruefen
            // 
            LblPruefen.AutoSize = true;
            LblPruefen.Location = new Point(15, 11);
            LblPruefen.Name = "LblPruefen";
            LblPruefen.Size = new Size(59, 25);
            LblPruefen.TabIndex = 2;
            LblPruefen.Text = "label1";
            // 
            // LblSchalter
            // 
            LblSchalter.AutoSize = true;
            LblSchalter.Location = new Point(15, 60);
            LblSchalter.Name = "LblSchalter";
            LblSchalter.Size = new Size(59, 25);
            LblSchalter.TabIndex = 3;
            LblSchalter.Text = "label2";
            // 
            // ChkSchalter
            // 
            ChkSchalter.AutoSize = true;
            ChkSchalter.Location = new Point(332, 56);
            ChkSchalter.Name = "ChkSchalter";
            ChkSchalter.Size = new Size(100, 29);
            ChkSchalter.TabIndex = 4;
            ChkSchalter.Text = "Schalter";
            ChkSchalter.UseVisualStyleBackColor = true;
            ChkSchalter.CheckedChanged += ChkSchalter_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 165);
            Controls.Add(ChkSchalter);
            Controls.Add(LblSchalter);
            Controls.Add(LblPruefen);
            Controls.Add(CmdUmschalten);
            Controls.Add(CmdPruefen);
            Name = "Form1";
            Text = "CheckBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdPruefen;
        private Button CmdUmschalten;
        private Label LblPruefen;
        private Label LblSchalter;
        private CheckBox ChkSchalter;
    }
}
