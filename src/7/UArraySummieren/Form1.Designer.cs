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
            CmdErgebnis = new Button();
            SuspendLayout();
            // 
            // CmdErgebnis
            // 
            CmdErgebnis.Location = new Point(119, 25);
            CmdErgebnis.Name = "CmdErgebnis";
            CmdErgebnis.Size = new Size(112, 34);
            CmdErgebnis.TabIndex = 0;
            CmdErgebnis.Text = "Ergebnis";
            CmdErgebnis.UseVisualStyleBackColor = true;
            CmdErgebnis.Click += CmdErgebnis_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 87);
            Controls.Add(CmdErgebnis);
            Name = "Form1";
            Text = "Array summieren";
            ResumeLayout(false);
        }

        #endregion

        private Button CmdErgebnis;
    }
}
