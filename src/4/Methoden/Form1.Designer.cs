// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Methoden
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
            LblAusgabe = new Label();
            CmdAnzeigen1 = new Button();
            CmdAnzeigen2 = new Button();
            CmdAnzeigen3 = new Button();
            CmdAnzeigen4 = new Button();
            CmdAnzeigen5 = new Button();
            CmdAnzeigen6 = new Button();
            CmdAnzeigen7 = new Button();
            CmdAnzeigen8 = new Button();
            SuspendLayout();
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(12, 9);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(59, 25);
            LblAusgabe.TabIndex = 0;
            LblAusgabe.Text = "label1";
            // 
            // CmdAnzeigen1
            // 
            CmdAnzeigen1.Location = new Point(323, 4);
            CmdAnzeigen1.Name = "CmdAnzeigen1";
            CmdAnzeigen1.Size = new Size(112, 34);
            CmdAnzeigen1.TabIndex = 1;
            CmdAnzeigen1.Text = "Anzeigen 1";
            CmdAnzeigen1.UseVisualStyleBackColor = true;
            CmdAnzeigen1.Click += CmdAnzeigen1_Click;
            // 
            // CmdAnzeigen2
            // 
            CmdAnzeigen2.ForeColor = SystemColors.ActiveCaption;
            CmdAnzeigen2.Location = new Point(323, 44);
            CmdAnzeigen2.Name = "CmdAnzeigen2";
            CmdAnzeigen2.Size = new Size(112, 34);
            CmdAnzeigen2.TabIndex = 2;
            CmdAnzeigen2.Text = "Anzeigen 2";
            CmdAnzeigen2.UseVisualStyleBackColor = true;
            CmdAnzeigen2.Click += CmdAnzeigen2_Click;
            // 
            // CmdAnzeigen3
            // 
            CmdAnzeigen3.Location = new Point(323, 84);
            CmdAnzeigen3.Name = "CmdAnzeigen3";
            CmdAnzeigen3.Size = new Size(112, 34);
            CmdAnzeigen3.TabIndex = 3;
            CmdAnzeigen3.Text = "Anzeigen 3";
            CmdAnzeigen3.UseVisualStyleBackColor = true;
            CmdAnzeigen3.Click += CmdAnzeigen3_Click;
            // 
            // CmdAnzeigen4
            // 
            CmdAnzeigen4.Location = new Point(323, 124);
            CmdAnzeigen4.Name = "CmdAnzeigen4";
            CmdAnzeigen4.Size = new Size(112, 34);
            CmdAnzeigen4.TabIndex = 4;
            CmdAnzeigen4.Text = "Anzeigen 4";
            CmdAnzeigen4.UseVisualStyleBackColor = true;
            CmdAnzeigen4.Click += CmdAnzeigen4_Click;
            // 
            // CmdAnzeigen5
            // 
            CmdAnzeigen5.Location = new Point(323, 164);
            CmdAnzeigen5.Name = "CmdAnzeigen5";
            CmdAnzeigen5.Size = new Size(112, 34);
            CmdAnzeigen5.TabIndex = 5;
            CmdAnzeigen5.Text = "Anzeigen 5";
            CmdAnzeigen5.UseVisualStyleBackColor = true;
            CmdAnzeigen5.Click += CmdAnzeigen5_Click;
            // 
            // CmdAnzeigen6
            // 
            CmdAnzeigen6.Location = new Point(323, 204);
            CmdAnzeigen6.Name = "CmdAnzeigen6";
            CmdAnzeigen6.Size = new Size(112, 34);
            CmdAnzeigen6.TabIndex = 6;
            CmdAnzeigen6.Text = "Anzeigen 6";
            CmdAnzeigen6.UseVisualStyleBackColor = true;
            CmdAnzeigen6.Click += CmdAnzeigen6_Click;
            // 
            // CmdAnzeigen7
            // 
            CmdAnzeigen7.Location = new Point(323, 244);
            CmdAnzeigen7.Name = "CmdAnzeigen7";
            CmdAnzeigen7.Size = new Size(112, 34);
            CmdAnzeigen7.TabIndex = 7;
            CmdAnzeigen7.Text = "Anzeigen 7";
            CmdAnzeigen7.UseVisualStyleBackColor = true;
            CmdAnzeigen7.Click += CmdAnzeigen7_Click;
            // 
            // CmdAnzeigen8
            // 
            CmdAnzeigen8.Location = new Point(323, 284);
            CmdAnzeigen8.Name = "CmdAnzeigen8";
            CmdAnzeigen8.Size = new Size(112, 34);
            CmdAnzeigen8.TabIndex = 8;
            CmdAnzeigen8.Text = "Anzeigen 8";
            CmdAnzeigen8.UseVisualStyleBackColor = true;
            CmdAnzeigen8.Click += CmdAnzeigen8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 355);
            Controls.Add(CmdAnzeigen8);
            Controls.Add(CmdAnzeigen7);
            Controls.Add(CmdAnzeigen6);
            Controls.Add(CmdAnzeigen5);
            Controls.Add(CmdAnzeigen4);
            Controls.Add(CmdAnzeigen3);
            Controls.Add(CmdAnzeigen2);
            Controls.Add(CmdAnzeigen1);
            Controls.Add(LblAusgabe);
            Name = "Form1";
            Text = "Methoden";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAusgabe;
        private Button CmdAnzeigen1;
        private Button CmdAnzeigen2;
        private Button CmdAnzeigen3;
        private Button CmdAnzeigen4;
        private Button CmdAnzeigen5;
        private Button CmdAnzeigen6;
        private Button CmdAnzeigen7;
        private Button CmdAnzeigen8;
    }
}
