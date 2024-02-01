// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenAusgabe
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
            BtnAnzeige1 = new Button();
            BtnAnzeige2 = new Button();
            BtnAnzeige3 = new Button();
            BtnAnzeige4 = new Button();
            LblAnzeige = new Label();
            SuspendLayout();
            // 
            // BtnAnzeige1
            // 
            BtnAnzeige1.Location = new Point(208, 12);
            BtnAnzeige1.Name = "BtnAnzeige1";
            BtnAnzeige1.Size = new Size(75, 23);
            BtnAnzeige1.TabIndex = 0;
            BtnAnzeige1.Text = "button1";
            BtnAnzeige1.UseVisualStyleBackColor = true;
            BtnAnzeige1.Click += BtnAnzeige1_Click;
            // 
            // BtnAnzeige2
            // 
            BtnAnzeige2.Location = new Point(208, 41);
            BtnAnzeige2.Name = "BtnAnzeige2";
            BtnAnzeige2.Size = new Size(75, 23);
            BtnAnzeige2.TabIndex = 1;
            BtnAnzeige2.Text = "button2";
            BtnAnzeige2.UseVisualStyleBackColor = true;
            BtnAnzeige2.Click += BtnAnzeige2_Click;
            // 
            // BtnAnzeige3
            // 
            BtnAnzeige3.Location = new Point(208, 70);
            BtnAnzeige3.Name = "BtnAnzeige3";
            BtnAnzeige3.Size = new Size(75, 23);
            BtnAnzeige3.TabIndex = 2;
            BtnAnzeige3.Text = "button3";
            BtnAnzeige3.UseVisualStyleBackColor = true;
            BtnAnzeige3.Click += BtnAnzeige3_Click;
            // 
            // BtnAnzeige4
            // 
            BtnAnzeige4.Location = new Point(208, 99);
            BtnAnzeige4.Name = "BtnAnzeige4";
            BtnAnzeige4.Size = new Size(75, 23);
            BtnAnzeige4.TabIndex = 3;
            BtnAnzeige4.Text = "button4";
            BtnAnzeige4.UseVisualStyleBackColor = true;
            BtnAnzeige4.Click += BtnAnzeige4_Click;
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(12, 20);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(38, 15);
            LblAnzeige.TabIndex = 4;
            LblAnzeige.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAnzeige);
            Controls.Add(BtnAnzeige4);
            Controls.Add(BtnAnzeige3);
            Controls.Add(BtnAnzeige2);
            Controls.Add(BtnAnzeige1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAnzeige1;
        private Button BtnAnzeige2;
        private Button BtnAnzeige3;
        private Button BtnAnzeige4;
        private Label LblAnzeige;
    }
}
