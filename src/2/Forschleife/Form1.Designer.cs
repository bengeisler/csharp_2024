﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Forschleife
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
            LblAnzeige1 = new Label();
            CmdButton2 = new Button();
            LblAnzeige2 = new Label();
            LblAnzeige3 = new Label();
            CmdButton3 = new Button();
            LblAnzeige4 = new Label();
            CmdButton4 = new Button();
            SuspendLayout();
            // 
            // CmdButton1
            // 
            CmdButton1.Location = new Point(44, 40);
            CmdButton1.Name = "CmdButton1";
            CmdButton1.Size = new Size(75, 23);
            CmdButton1.TabIndex = 0;
            CmdButton1.Text = "Anzeigen1";
            CmdButton1.UseVisualStyleBackColor = true;
            CmdButton1.Click += CmdButton1_Click;
            // 
            // LblAnzeige1
            // 
            LblAnzeige1.AutoSize = true;
            LblAnzeige1.Location = new Point(44, 93);
            LblAnzeige1.Name = "LblAnzeige1";
            LblAnzeige1.Size = new Size(38, 15);
            LblAnzeige1.TabIndex = 1;
            LblAnzeige1.Text = "label1";
            // 
            // CmdButton2
            // 
            CmdButton2.Location = new Point(137, 40);
            CmdButton2.Name = "CmdButton2";
            CmdButton2.Size = new Size(75, 23);
            CmdButton2.TabIndex = 2;
            CmdButton2.Text = "Anzeigen2";
            CmdButton2.UseVisualStyleBackColor = true;
            CmdButton2.Click += CmdButton2_Click;
            // 
            // LblAnzeige2
            // 
            LblAnzeige2.AutoSize = true;
            LblAnzeige2.Location = new Point(137, 93);
            LblAnzeige2.Name = "LblAnzeige2";
            LblAnzeige2.Size = new Size(38, 15);
            LblAnzeige2.TabIndex = 3;
            LblAnzeige2.Text = "label1";
            // 
            // LblAnzeige3
            // 
            LblAnzeige3.AutoSize = true;
            LblAnzeige3.Location = new Point(231, 93);
            LblAnzeige3.Name = "LblAnzeige3";
            LblAnzeige3.Size = new Size(38, 15);
            LblAnzeige3.TabIndex = 5;
            LblAnzeige3.Text = "label1";
            // 
            // CmdButton3
            // 
            CmdButton3.Location = new Point(231, 40);
            CmdButton3.Name = "CmdButton3";
            CmdButton3.Size = new Size(75, 23);
            CmdButton3.TabIndex = 4;
            CmdButton3.Text = "Anzeigen3";
            CmdButton3.UseVisualStyleBackColor = true;
            CmdButton3.Click += CmdButton3_Click;
            // 
            // LblAnzeige4
            // 
            LblAnzeige4.AutoSize = true;
            LblAnzeige4.Location = new Point(335, 93);
            LblAnzeige4.Name = "LblAnzeige4";
            LblAnzeige4.Size = new Size(62, 15);
            LblAnzeige4.TabIndex = 7;
            LblAnzeige4.Text = "Anzeigen4";
            // 
            // CmdButton4
            // 
            CmdButton4.Location = new Point(335, 40);
            CmdButton4.Name = "CmdButton4";
            CmdButton4.Size = new Size(75, 23);
            CmdButton4.TabIndex = 6;
            CmdButton4.Text = "Anzeigen4";
            CmdButton4.UseVisualStyleBackColor = true;
            CmdButton4.Click += CmdButton4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAnzeige4);
            Controls.Add(CmdButton4);
            Controls.Add(LblAnzeige3);
            Controls.Add(CmdButton3);
            Controls.Add(LblAnzeige2);
            Controls.Add(CmdButton2);
            Controls.Add(LblAnzeige1);
            Controls.Add(CmdButton1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdButton1;
        private Label LblAnzeige1;
        private Button CmdButton2;
        private Label LblAnzeige2;
        private Label LblAnzeige3;
        private Button CmdButton3;
        private Label LblAnzeige4;
        private Button CmdButton4;
    }
}