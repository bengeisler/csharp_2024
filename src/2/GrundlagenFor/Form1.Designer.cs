﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenFor
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
            LblAnzeigen1 = new Label();
            LblAnzeigen2 = new Label();
            CmdAnzeigen2 = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // CmdAnzeigen1
            // 
            CmdAnzeigen1.Location = new Point(12, 12);
            CmdAnzeigen1.Name = "CmdAnzeigen1";
            CmdAnzeigen1.Size = new Size(93, 21);
            CmdAnzeigen1.TabIndex = 0;
            CmdAnzeigen1.Text = "Anzeigen 1";
            CmdAnzeigen1.UseVisualStyleBackColor = true;
            CmdAnzeigen1.Click += CmdAnzeigen1_Click;
            // 
            // LblAnzeigen1
            // 
            LblAnzeigen1.AutoSize = true;
            LblAnzeigen1.Location = new Point(12, 60);
            LblAnzeigen1.Name = "LblAnzeigen1";
            LblAnzeigen1.Size = new Size(38, 15);
            LblAnzeigen1.TabIndex = 1;
            LblAnzeigen1.Text = "label1";
            // 
            // LblAnzeigen2
            // 
            LblAnzeigen2.AutoSize = true;
            LblAnzeigen2.Location = new Point(134, 60);
            LblAnzeigen2.Name = "LblAnzeigen2";
            LblAnzeigen2.Size = new Size(38, 15);
            LblAnzeigen2.TabIndex = 2;
            LblAnzeigen2.Text = "label1";
            // 
            // CmdAnzeigen2
            // 
            CmdAnzeigen2.Location = new Point(134, 12);
            CmdAnzeigen2.Name = "CmdAnzeigen2";
            CmdAnzeigen2.Size = new Size(104, 26);
            CmdAnzeigen2.TabIndex = 3;
            CmdAnzeigen2.Text = "Anzeigen";
            CmdAnzeigen2.UseVisualStyleBackColor = true;
            CmdAnzeigen2.Click += CmdAnzeigen2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(270, 12);
            button1.Name = "button1";
            button1.Size = new Size(88, 30);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(395, 12);
            button2.Name = "button2";
            button2.Size = new Size(88, 30);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CmdAnzeigen2);
            Controls.Add(LblAnzeigen2);
            Controls.Add(LblAnzeigen1);
            Controls.Add(CmdAnzeigen1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAnzeigen1;
        private Label LblAnzeigen1;
        private Label LblAnzeigen2;
        private Button CmdAnzeigen2;
        private Button button1;
        private Button button2;
    }
}
