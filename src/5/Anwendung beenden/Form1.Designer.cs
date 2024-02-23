// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Anwendung_beenden
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
            cmdBeenden = new Button();
            SuspendLayout();
            // 
            // cmdBeenden
            // 
            cmdBeenden.Location = new Point(31, 54);
            cmdBeenden.Name = "cmdBeenden";
            cmdBeenden.Size = new Size(75, 23);
            cmdBeenden.TabIndex = 0;
            cmdBeenden.Text = "Beenden";
            cmdBeenden.UseVisualStyleBackColor = true;
            cmdBeenden.Click += cmdBeenden_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdBeenden);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button cmdBeenden;
    }
}
