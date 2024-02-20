// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UArraySummieren
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
            cmdBerechnen = new Button();
            SuspendLayout();
            // 
            // cmdBerechnen
            // 
            cmdBerechnen.Location = new Point(517, 160);
            cmdBerechnen.Name = "cmdBerechnen";
            cmdBerechnen.Size = new Size(75, 23);
            cmdBerechnen.TabIndex = 0;
            cmdBerechnen.Text = "Berechnen";
            cmdBerechnen.UseVisualStyleBackColor = true;
            cmdBerechnen.Click += cmdBerechnen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdBerechnen);
            Name = "Form1";
            Text = "Array Summieren";
            ResumeLayout(false);
        }

        #endregion

        private Button cmdBerechnen;
    }
}
