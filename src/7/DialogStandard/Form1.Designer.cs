// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace DialogStandard
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
            BtnÖffnen = new Button();
            BtnSpeichern = new Button();
            SuspendLayout();
            // 
            // BtnÖffnen
            // 
            BtnÖffnen.Location = new Point(12, 12);
            BtnÖffnen.Name = "BtnÖffnen";
            BtnÖffnen.Size = new Size(75, 23);
            BtnÖffnen.TabIndex = 0;
            BtnÖffnen.Text = "Öffnen";
            BtnÖffnen.UseVisualStyleBackColor = true;
            BtnÖffnen.Click += BtnÖffnen_Click;
            // 
            // BtnSpeichern
            // 
            BtnSpeichern.Location = new Point(124, 12);
            BtnSpeichern.Name = "BtnSpeichern";
            BtnSpeichern.Size = new Size(75, 23);
            BtnSpeichern.TabIndex = 1;
            BtnSpeichern.Text = "Speichern";
            BtnSpeichern.UseVisualStyleBackColor = true;
            BtnSpeichern.Click += BtnSpeichern_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSpeichern);
            Controls.Add(BtnÖffnen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnÖffnen;
        private Button BtnSpeichern;
    }
}
