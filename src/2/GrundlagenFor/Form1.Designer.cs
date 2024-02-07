// Licensed to the .NET Foundation under one or more agreements.
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
            LblAnzeigen3 = new Label();
            CmdAnzeigen3 = new Button();
            LblAnzeigen4 = new Label();
            CmdAnzeigen4 = new Button();
            LblAnzeigen5 = new Label();
            CmdAnzeigen5 = new Button();
            SuspendLayout();
            // 
            // CmdAnzeigen1
            // 
            CmdAnzeigen1.Location = new Point(12, 12);
            CmdAnzeigen1.Name = "CmdAnzeigen1";
            CmdAnzeigen1.Size = new Size(112, 34);
            CmdAnzeigen1.TabIndex = 0;
            CmdAnzeigen1.Text = "Anzeigen 1";
            CmdAnzeigen1.UseVisualStyleBackColor = true;
            CmdAnzeigen1.Click += CmdAnzeigen1_Click;
            // 
            // LblAnzeigen1
            // 
            LblAnzeigen1.AutoSize = true;
            LblAnzeigen1.Location = new Point(12, 63);
            LblAnzeigen1.Name = "LblAnzeigen1";
            LblAnzeigen1.Size = new Size(59, 25);
            LblAnzeigen1.TabIndex = 1;
            LblAnzeigen1.Text = "label1";
            // 
            // LblAnzeigen2
            // 
            LblAnzeigen2.AutoSize = true;
            LblAnzeigen2.Location = new Point(143, 63);
            LblAnzeigen2.Name = "LblAnzeigen2";
            LblAnzeigen2.Size = new Size(59, 25);
            LblAnzeigen2.TabIndex = 3;
            LblAnzeigen2.Text = "label1";
            // 
            // CmdAnzeigen2
            // 
            CmdAnzeigen2.Location = new Point(143, 12);
            CmdAnzeigen2.Name = "CmdAnzeigen2";
            CmdAnzeigen2.Size = new Size(112, 34);
            CmdAnzeigen2.TabIndex = 2;
            CmdAnzeigen2.Text = "Anzeigen 2";
            CmdAnzeigen2.UseVisualStyleBackColor = true;
            CmdAnzeigen2.Click += CmdAnzeigen2_Click;
            // 
            // LblAnzeigen3
            // 
            LblAnzeigen3.AutoSize = true;
            LblAnzeigen3.Location = new Point(271, 63);
            LblAnzeigen3.Name = "LblAnzeigen3";
            LblAnzeigen3.Size = new Size(59, 25);
            LblAnzeigen3.TabIndex = 5;
            LblAnzeigen3.Text = "label1";
            // 
            // CmdAnzeigen3
            // 
            CmdAnzeigen3.Location = new Point(271, 12);
            CmdAnzeigen3.Name = "CmdAnzeigen3";
            CmdAnzeigen3.Size = new Size(112, 34);
            CmdAnzeigen3.TabIndex = 4;
            CmdAnzeigen3.Text = "Anzeigen 3";
            CmdAnzeigen3.UseVisualStyleBackColor = true;
            CmdAnzeigen3.Click += CmdAnzeigen3_Click;
            // 
            // LblAnzeigen4
            // 
            LblAnzeigen4.AutoSize = true;
            LblAnzeigen4.Location = new Point(400, 63);
            LblAnzeigen4.Name = "LblAnzeigen4";
            LblAnzeigen4.Size = new Size(59, 25);
            LblAnzeigen4.TabIndex = 7;
            LblAnzeigen4.Text = "label1";
            // 
            // CmdAnzeigen4
            // 
            CmdAnzeigen4.Location = new Point(400, 12);
            CmdAnzeigen4.Name = "CmdAnzeigen4";
            CmdAnzeigen4.Size = new Size(112, 34);
            CmdAnzeigen4.TabIndex = 6;
            CmdAnzeigen4.Text = "Anzeigen 4";
            CmdAnzeigen4.UseVisualStyleBackColor = true;
            CmdAnzeigen4.Click += CmdAnzeigen4_Click;
            // 
            // LblAnzeigen5
            // 
            LblAnzeigen5.AutoSize = true;
            LblAnzeigen5.Location = new Point(530, 63);
            LblAnzeigen5.Name = "LblAnzeigen5";
            LblAnzeigen5.Size = new Size(59, 25);
            LblAnzeigen5.TabIndex = 9;
            LblAnzeigen5.Text = "label1";
            // 
            // CmdAnzeigen5
            // 
            CmdAnzeigen5.Location = new Point(530, 12);
            CmdAnzeigen5.Name = "CmdAnzeigen5";
            CmdAnzeigen5.Size = new Size(112, 34);
            CmdAnzeigen5.TabIndex = 8;
            CmdAnzeigen5.Text = "Anzeigen 5";
            CmdAnzeigen5.UseVisualStyleBackColor = true;
            CmdAnzeigen5.Click += CmdAnzeigen5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAnzeigen5);
            Controls.Add(CmdAnzeigen5);
            Controls.Add(LblAnzeigen4);
            Controls.Add(CmdAnzeigen4);
            Controls.Add(LblAnzeigen3);
            Controls.Add(CmdAnzeigen3);
            Controls.Add(LblAnzeigen2);
            Controls.Add(CmdAnzeigen2);
            Controls.Add(LblAnzeigen1);
            Controls.Add(CmdAnzeigen1);
            Name = "Form1";
            Text = "Schleifen mit for";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAnzeigen1;
        private Label LblAnzeigen1;
        private Label LblAnzeigen2;
        private Button CmdAnzeigen2;
        private Label LblAnzeigen3;
        private Button CmdAnzeigen3;
        private Label LblAnzeigen4;
        private Button CmdAnzeigen4;
        private Label LblAnzeigen5;
        private Button CmdAnzeigen5;
    }
}
