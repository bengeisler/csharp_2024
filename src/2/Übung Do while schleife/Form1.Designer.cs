// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Übung_Do_while_schleife
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
            CmdButton2 = new Button();
            LblAnzeigen1 = new Label();
            LblAnzeigen3 = new Label();
            LblAnzeigen4 = new Label();
            SuspendLayout();
            // 
            // CmdButton1
            // 
            CmdButton1.Location = new Point(142, 139);
            CmdButton1.Name = "CmdButton1";
            CmdButton1.Size = new Size(75, 23);
            CmdButton1.TabIndex = 0;
            CmdButton1.Text = "button1";
            CmdButton1.UseVisualStyleBackColor = true;
            CmdButton1.Click += CmdButton1_Click;
            // 
            // CmdButton2
            // 
            CmdButton2.Location = new Point(223, 139);
            CmdButton2.Name = "CmdButton2";
            CmdButton2.Size = new Size(75, 23);
            CmdButton2.TabIndex = 1;
            CmdButton2.Text = "button2";
            CmdButton2.UseVisualStyleBackColor = true;
            CmdButton2.Click += CmdButton2_Click;
            // 
            // LblAnzeigen1
            // 
            LblAnzeigen1.AutoSize = true;
            LblAnzeigen1.Location = new Point(155, 180);
            LblAnzeigen1.Name = "LblAnzeigen1";
            LblAnzeigen1.Size = new Size(38, 15);
            LblAnzeigen1.TabIndex = 5;
            LblAnzeigen1.Text = "label1";
            // 
            // LblAnzeigen3
            // 
            LblAnzeigen3.AutoSize = true;
            LblAnzeigen3.Location = new Point(12, 143);
            LblAnzeigen3.Name = "LblAnzeigen3";
            LblAnzeigen3.Size = new Size(38, 15);
            LblAnzeigen3.TabIndex = 7;
            LblAnzeigen3.Text = "label3";
            // 
            // LblAnzeigen4
            // 
            LblAnzeigen4.AutoSize = true;
            LblAnzeigen4.Location = new Point(12, 180);
            LblAnzeigen4.Name = "LblAnzeigen4";
            LblAnzeigen4.Size = new Size(38, 15);
            LblAnzeigen4.TabIndex = 8;
            LblAnzeigen4.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAnzeigen4);
            Controls.Add(LblAnzeigen3);
            Controls.Add(LblAnzeigen1);
            Controls.Add(CmdButton2);
            Controls.Add(CmdButton1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdButton1;
        private Button CmdButton2;
        private Label LblAnzeigen1;
        private Label LblAnzeigen3;
        private Label LblAnzeigen4;
    }
}
