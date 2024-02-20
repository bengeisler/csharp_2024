// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UArraysSummieren
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
            CmdErgebnis = new Button();
            SuspendLayout();
            // 
            // CmdErgebnis
            // 
            CmdErgebnis.Location = new Point(85, 27);
            CmdErgebnis.Name = "CmdErgebnis";
            CmdErgebnis.Size = new Size(75, 23);
            CmdErgebnis.TabIndex = 0;
            CmdErgebnis.Text = "Ergebnis";
            CmdErgebnis.UseVisualStyleBackColor = true;
            CmdErgebnis.Click += CmdErgebnis_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdErgebnis);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button CmdErgebnis;
    }
}
