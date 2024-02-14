// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Übung_Methoden
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
            CmdButton1 = new Button();
            Lbl1 = new Label();
            SuspendLayout();
            // 
            // CmdButton1
            // 
            CmdButton1.Location = new Point(266, 22);
            CmdButton1.Name = "CmdButton1";
            CmdButton1.Size = new Size(75, 23);
            CmdButton1.TabIndex = 0;
            CmdButton1.Text = "Anzeigen1";
            CmdButton1.UseVisualStyleBackColor = true;
            CmdButton1.Click += CmdButton1_Click;
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Location = new Point(175, 26);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(38, 15);
            Lbl1.TabIndex = 1;
            Lbl1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Lbl1);
            Controls.Add(CmdButton1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdButton1;
        private Label Lbl1;
    }
}
