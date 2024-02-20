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
            CmdÖffnen = new Button();
            CmdSpeichern = new Button();
            SuspendLayout();
            // 
            // CmdÖffnen
            // 
            CmdÖffnen.Location = new Point(47, 38);
            CmdÖffnen.Name = "CmdÖffnen";
            CmdÖffnen.Size = new Size(92, 23);
            CmdÖffnen.TabIndex = 0;
            CmdÖffnen.Text = "Öffnen";
            CmdÖffnen.UseVisualStyleBackColor = true;
            CmdÖffnen.Click += CmdEigenschaften_Click;
            // 
            // CmdSpeichern
            // 
            CmdSpeichern.Location = new Point(195, 38);
            CmdSpeichern.Name = "CmdSpeichern";
            CmdSpeichern.Size = new Size(75, 23);
            CmdSpeichern.TabIndex = 1;
            CmdSpeichern.Text = "Speichern";
            CmdSpeichern.UseVisualStyleBackColor = true;
            CmdSpeichern.Click += CmdSpeichern_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdSpeichern);
            Controls.Add(CmdÖffnen);
            Name = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button CmdÖffnen;
        private Button CmdSpeichern;
    }
}
