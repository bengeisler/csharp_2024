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
            cmdAnzeigen1 = new Button();
            cmdAnzeigen2 = new Button();
            cmdAnzeigen3 = new Button();
            cmdAnzeigen4 = new Button();
            cmdAnzeigen5 = new Button();
            cmdAnzeigen6 = new Button();
            cmdAnzeigen7 = new Button();
            cmdAnzeigen8 = new Button();
            SuspendLayout();
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(29, 16);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(38, 15);
            LblAusgabe.TabIndex = 0;
            LblAusgabe.Text = "label1";
            // 
            // cmdAnzeigen1
            // 
            cmdAnzeigen1.Location = new Point(204, 12);
            cmdAnzeigen1.Name = "cmdAnzeigen1";
            cmdAnzeigen1.Size = new Size(75, 23);
            cmdAnzeigen1.TabIndex = 1;
            cmdAnzeigen1.Text = "Anzeigen1";
            cmdAnzeigen1.UseVisualStyleBackColor = true;
            cmdAnzeigen1.Click += cmdAnzeigen1_Click;
            // 
            // cmdAnzeigen2
            // 
            cmdAnzeigen2.Location = new Point(204, 76);
            cmdAnzeigen2.Name = "cmdAnzeigen2";
            cmdAnzeigen2.Size = new Size(75, 23);
            cmdAnzeigen2.TabIndex = 2;
            cmdAnzeigen2.Text = "Anzeigen2";
            cmdAnzeigen2.UseVisualStyleBackColor = true;
            cmdAnzeigen2.Click += cmdAnzeigen2_Click;
            // 
            // cmdAnzeigen3
            // 
            cmdAnzeigen3.Location = new Point(204, 133);
            cmdAnzeigen3.Name = "cmdAnzeigen3";
            cmdAnzeigen3.Size = new Size(75, 23);
            cmdAnzeigen3.TabIndex = 3;
            cmdAnzeigen3.Text = "Anzeigen3";
            cmdAnzeigen3.UseVisualStyleBackColor = true;
            cmdAnzeigen3.Click += cmdAnzeigen3_Click;
            // 
            // cmdAnzeigen4
            // 
            cmdAnzeigen4.Location = new Point(204, 176);
            cmdAnzeigen4.Name = "cmdAnzeigen4";
            cmdAnzeigen4.Size = new Size(75, 23);
            cmdAnzeigen4.TabIndex = 4;
            cmdAnzeigen4.Text = "Anzeigen4";
            cmdAnzeigen4.UseVisualStyleBackColor = true;
            cmdAnzeigen4.Click += cmdAnzeigen4_Click;
            // 
            // cmdAnzeigen5
            // 
            cmdAnzeigen5.Location = new Point(204, 220);
            cmdAnzeigen5.Name = "cmdAnzeigen5";
            cmdAnzeigen5.Size = new Size(75, 23);
            cmdAnzeigen5.TabIndex = 5;
            cmdAnzeigen5.Text = "Anzeigen5";
            cmdAnzeigen5.UseVisualStyleBackColor = true;
            cmdAnzeigen5.Click += cmdAnzeigen5_Click;
            // 
            // cmdAnzeigen6
            // 
            cmdAnzeigen6.Location = new Point(204, 260);
            cmdAnzeigen6.Name = "cmdAnzeigen6";
            cmdAnzeigen6.Size = new Size(75, 23);
            cmdAnzeigen6.TabIndex = 6;
            cmdAnzeigen6.Text = "Anzeigen6";
            cmdAnzeigen6.UseVisualStyleBackColor = true;
            cmdAnzeigen6.Click += cmdAnzeigen6_Click;
            // 
            // cmdAnzeigen7
            // 
            cmdAnzeigen7.Location = new Point(204, 304);
            cmdAnzeigen7.Name = "cmdAnzeigen7";
            cmdAnzeigen7.Size = new Size(75, 23);
            cmdAnzeigen7.TabIndex = 7;
            cmdAnzeigen7.Text = "Anzeigen7";
            cmdAnzeigen7.UseVisualStyleBackColor = true;
            cmdAnzeigen7.Click += cmdAnzeigen7_Click;
            // 
            // cmdAnzeigen8
            // 
            cmdAnzeigen8.Location = new Point(204, 349);
            cmdAnzeigen8.Name = "cmdAnzeigen8";
            cmdAnzeigen8.Size = new Size(75, 23);
            cmdAnzeigen8.TabIndex = 8;
            cmdAnzeigen8.Text = "Anzeigen8";
            cmdAnzeigen8.UseVisualStyleBackColor = true;
            cmdAnzeigen8.Click += cmdAnzeigen8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdAnzeigen8);
            Controls.Add(cmdAnzeigen7);
            Controls.Add(cmdAnzeigen6);
            Controls.Add(cmdAnzeigen5);
            Controls.Add(cmdAnzeigen4);
            Controls.Add(cmdAnzeigen3);
            Controls.Add(cmdAnzeigen2);
            Controls.Add(cmdAnzeigen1);
            Controls.Add(LblAusgabe);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAusgabe;
        private Button cmdAnzeigen1;
        private Button cmdAnzeigen2;
        private Button cmdAnzeigen3;
        private Button cmdAnzeigen4;
        private Button cmdAnzeigen5;
        private Button cmdAnzeigen6;
        private Button cmdAnzeigen7;
        private Button cmdAnzeigen8;
    }
}
