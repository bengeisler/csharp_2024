﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace DatenfeldEinDimensional
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
            LstBox = new ListBox();
            CmdButton1 = new Button();
            CmdButton2 = new Button();
            CmdButton3 = new Button();
            CmdButton5 = new Button();
            CmdButton4 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // LstBox
            // 
            LstBox.FormattingEnabled = true;
            LstBox.ItemHeight = 15;
            LstBox.Location = new Point(12, 38);
            LstBox.Name = "LstBox";
            LstBox.Size = new Size(120, 154);
            LstBox.TabIndex = 0;
            // 
            // CmdButton1
            // 
            CmdButton1.Location = new Point(170, 38);
            CmdButton1.Name = "CmdButton1";
            CmdButton1.Size = new Size(75, 23);
            CmdButton1.TabIndex = 1;
            CmdButton1.Text = "Anzeigen1";
            CmdButton1.UseVisualStyleBackColor = true;
            CmdButton1.Click += CmdButton1_Click;
            // 
            // CmdButton2
            // 
            CmdButton2.Location = new Point(170, 169);
            CmdButton2.Name = "CmdButton2";
            CmdButton2.Size = new Size(75, 23);
            CmdButton2.TabIndex = 2;
            CmdButton2.Text = "Close";
            CmdButton2.UseVisualStyleBackColor = true;
            CmdButton2.Click += CmdButton2_Click;
            // 
            // CmdButton3
            // 
            CmdButton3.Location = new Point(170, 67);
            CmdButton3.Name = "CmdButton3";
            CmdButton3.Size = new Size(75, 23);
            CmdButton3.TabIndex = 3;
            CmdButton3.Text = "Anzeigen2";
            CmdButton3.UseVisualStyleBackColor = true;
            CmdButton3.Click += CmdButton3_Click;
            // 
            // CmdButton5
            // 
            CmdButton5.Location = new Point(170, 125);
            CmdButton5.Name = "CmdButton5";
            CmdButton5.Size = new Size(75, 23);
            CmdButton5.TabIndex = 4;
            CmdButton5.Text = "Anzeigen4";
            CmdButton5.UseVisualStyleBackColor = true;
            CmdButton5.Click += CmdButton5_Click;
            // 
            // CmdButton4
            // 
            CmdButton4.Location = new Point(170, 96);
            CmdButton4.Name = "CmdButton4";
            CmdButton4.Size = new Size(75, 23);
            CmdButton4.TabIndex = 5;
            CmdButton4.Text = "Anzeigen3";
            CmdButton4.UseVisualStyleBackColor = true;
            CmdButton4.Click += CmdButton4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 195);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(CmdButton4);
            Controls.Add(CmdButton5);
            Controls.Add(CmdButton3);
            Controls.Add(CmdButton2);
            Controls.Add(CmdButton1);
            Controls.Add(LstBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LstBox;
        private Button CmdButton1;
        private Button CmdButton2;
        private Button CmdButton3;
        private Button CmdButton5;
        private Button CmdButton4;
        private Label label1;
    }
}
