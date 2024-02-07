// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelemntCheckBox
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
            cmdpruefen = new Button();
            cmdUmschalten = new Button();
            chkSchalter = new CheckBox();
            LblPruefen = new Label();
            LblSchalter = new Label();
            SuspendLayout();
            // 
            // cmdpruefen
            // 
            cmdpruefen.Location = new Point(589, 54);
            cmdpruefen.Name = "cmdpruefen";
            cmdpruefen.Size = new Size(75, 23);
            cmdpruefen.TabIndex = 0;
            cmdpruefen.Text = "Prüfen";
            cmdpruefen.UseVisualStyleBackColor = true;
            cmdpruefen.Click += button1_Click;
            // 
            // cmdUmschalten
            // 
            cmdUmschalten.Location = new Point(589, 150);
            cmdUmschalten.Name = "cmdUmschalten";
            cmdUmschalten.Size = new Size(75, 23);
            cmdUmschalten.TabIndex = 1;
            cmdUmschalten.Text = "Umschalten";
            cmdUmschalten.UseVisualStyleBackColor = true;
            cmdUmschalten.Click += cmdUmschalten_Click;
            // 
            // chkSchalter
            // 
            chkSchalter.AutoSize = true;
            chkSchalter.Checked = true;
            chkSchalter.CheckState = CheckState.Checked;
            chkSchalter.Location = new Point(589, 103);
            chkSchalter.Name = "chkSchalter";
            chkSchalter.Size = new Size(68, 19);
            chkSchalter.TabIndex = 2;
            chkSchalter.Text = "Schalter";
            chkSchalter.UseVisualStyleBackColor = true;
            chkSchalter.CheckedChanged += chkSchalter_CheckedChanged;
            // 
            // LblPruefen
            // 
            LblPruefen.AutoSize = true;
            LblPruefen.Location = new Point(33, 54);
            LblPruefen.Name = "LblPruefen";
            LblPruefen.Size = new Size(38, 15);
            LblPruefen.TabIndex = 3;
            LblPruefen.Text = "label1";
            // 
            // LblSchalter
            // 
            LblSchalter.AutoSize = true;
            LblSchalter.Location = new Point(33, 150);
            LblSchalter.Name = "LblSchalter";
            LblSchalter.Size = new Size(38, 15);
            LblSchalter.TabIndex = 4;
            LblSchalter.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblSchalter);
            Controls.Add(LblPruefen);
            Controls.Add(chkSchalter);
            Controls.Add(cmdUmschalten);
            Controls.Add(cmdpruefen);
            Name = "Form1";
            Text = "CheckBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdpruefen;
        private Button cmdUmschalten;
        private CheckBox chkSchalter;
        private Label LblPruefen;
        private Label LblSchalter;
    }
}
