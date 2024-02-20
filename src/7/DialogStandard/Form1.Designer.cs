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
            CmdOeffnen = new Button();
            CmdSpeichern = new Button();
            SuspendLayout();
            // 
            // CmdOeffnen
            // 
            CmdOeffnen.Location = new Point(501, 74);
            CmdOeffnen.Name = "CmdOeffnen";
            CmdOeffnen.Size = new Size(75, 23);
            CmdOeffnen.TabIndex = 0;
            CmdOeffnen.Text = "Öffnen";
            CmdOeffnen.UseVisualStyleBackColor = true;
            CmdOeffnen.Click += CmdOeffnen_Click;
            // 
            // CmdSpeichern
            // 
            CmdSpeichern.Location = new Point(501, 118);
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
            Controls.Add(CmdOeffnen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button CmdOeffnen;
        private Button CmdSpeichern;
    }
}
