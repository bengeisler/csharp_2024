// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UMethoden
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
            CmdAnzeigen1 = new Button();
            LblAnzeige1 = new Label();
            LblAnzeige2 = new Label();
            SuspendLayout();
            // 
            // CmdAnzeigen1
            // 
            CmdAnzeigen1.Location = new Point(199, 59);
            CmdAnzeigen1.Name = "CmdAnzeigen1";
            CmdAnzeigen1.Size = new Size(75, 23);
            CmdAnzeigen1.TabIndex = 0;
            CmdAnzeigen1.Text = "button1";
            CmdAnzeigen1.UseVisualStyleBackColor = true;
            CmdAnzeigen1.Click += CmdAnzeigen1_Click;
            // 
            // LblAnzeige1
            // 
            LblAnzeige1.AutoSize = true;
            LblAnzeige1.Location = new Point(40, 56);
            LblAnzeige1.Name = "LblAnzeige1";
            LblAnzeige1.Size = new Size(38, 15);
            LblAnzeige1.TabIndex = 1;
            LblAnzeige1.Text = "label1";
            // 
            // LblAnzeige2
            // 
            LblAnzeige2.AutoSize = true;
            LblAnzeige2.Location = new Point(44, 96);
            LblAnzeige2.Name = "LblAnzeige2";
            LblAnzeige2.Size = new Size(38, 15);
            LblAnzeige2.TabIndex = 2;
            LblAnzeige2.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAnzeige2);
            Controls.Add(LblAnzeige1);
            Controls.Add(CmdAnzeigen1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAnzeigen1;
        private Label LblAnzeige1;
        private Label LblAnzeige2;
    }
}
