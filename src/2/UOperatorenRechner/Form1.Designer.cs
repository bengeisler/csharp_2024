// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UOperatorenRechner
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
            CmdAusgabe1 = new Button();
            CmdAusgabe2 = new Button();
            CmdAusgabe3 = new Button();
            CmdAusgabe4 = new Button();
            LblAusgabe = new Label();
            SuspendLayout();
            // 
            // CmdAusgabe1
            // 
            CmdAusgabe1.Location = new Point(346, 92);
            CmdAusgabe1.Name = "CmdAusgabe1";
            CmdAusgabe1.Size = new Size(75, 23);
            CmdAusgabe1.TabIndex = 0;
            CmdAusgabe1.Text = "Ausgabe1";
            CmdAusgabe1.UseVisualStyleBackColor = true;
            CmdAusgabe1.Click += CmdAusgabe1_Click;
            // 
            // CmdAusgabe2
            // 
            CmdAusgabe2.Location = new Point(346, 131);
            CmdAusgabe2.Name = "CmdAusgabe2";
            CmdAusgabe2.Size = new Size(75, 23);
            CmdAusgabe2.TabIndex = 1;
            CmdAusgabe2.Text = "Ausgabe2";
            CmdAusgabe2.UseVisualStyleBackColor = true;
            CmdAusgabe2.Click += CmdAusgabe2_Click;
            // 
            // CmdAusgabe3
            // 
            CmdAusgabe3.Location = new Point(346, 172);
            CmdAusgabe3.Name = "CmdAusgabe3";
            CmdAusgabe3.Size = new Size(75, 23);
            CmdAusgabe3.TabIndex = 2;
            CmdAusgabe3.Text = "Ausgabe3";
            CmdAusgabe3.UseVisualStyleBackColor = true;
            CmdAusgabe3.Click += CmdAusgabe3_Click;
            // 
            // CmdAusgabe4
            // 
            CmdAusgabe4.Location = new Point(346, 217);
            CmdAusgabe4.Name = "CmdAusgabe4";
            CmdAusgabe4.Size = new Size(75, 23);
            CmdAusgabe4.TabIndex = 3;
            CmdAusgabe4.Text = "Ausgabe4";
            CmdAusgabe4.UseVisualStyleBackColor = true;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(40, 51);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(38, 15);
            LblAusgabe.TabIndex = 4;
            LblAusgabe.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAusgabe);
            Controls.Add(CmdAusgabe4);
            Controls.Add(CmdAusgabe3);
            Controls.Add(CmdAusgabe2);
            Controls.Add(CmdAusgabe1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAusgabe1;
        private Button CmdAusgabe2;
        private Button CmdAusgabe3;
        private Button CmdAusgabe4;
        private Label LblAusgabe;
    }
}
