// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenEnumerationen
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
            LblAnzeigen = new Label();
            cmdAnzeigen1 = new Button();
            cmdAnzeigen2 = new Button();
            SuspendLayout();
            // 
            // LblAnzeigen
            // 
            LblAnzeigen.AutoSize = true;
            LblAnzeigen.Location = new Point(12, 39);
            LblAnzeigen.Name = "LblAnzeigen";
            LblAnzeigen.Size = new Size(38, 15);
            LblAnzeigen.TabIndex = 0;
            LblAnzeigen.Text = "label1";
            // 
            // cmdAnzeigen1
            // 
            cmdAnzeigen1.Location = new Point(128, 35);
            cmdAnzeigen1.Name = "cmdAnzeigen1";
            cmdAnzeigen1.Size = new Size(75, 23);
            cmdAnzeigen1.TabIndex = 1;
            cmdAnzeigen1.Text = "Anzeigen1";
            cmdAnzeigen1.UseVisualStyleBackColor = true;
            cmdAnzeigen1.Click += cmdAnzeigen1_Click;
            // 
            // cmdAnzeigen2
            // 
            cmdAnzeigen2.Location = new Point(128, 64);
            cmdAnzeigen2.Name = "cmdAnzeigen2";
            cmdAnzeigen2.Size = new Size(75, 23);
            cmdAnzeigen2.TabIndex = 2;
            cmdAnzeigen2.Text = "Anzeigen2";
            cmdAnzeigen2.UseVisualStyleBackColor = true;
            cmdAnzeigen2.Click += cmdAnzeigen2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdAnzeigen2);
            Controls.Add(cmdAnzeigen1);
            Controls.Add(LblAnzeigen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAnzeigen;
        private Button cmdAnzeigen1;
        private Button cmdAnzeigen2;
    }
}
