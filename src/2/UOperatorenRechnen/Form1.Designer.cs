// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UOperatorenRechnen
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
            BtnRechnung1 = new Button();
            BtnRechnung2 = new Button();
            LblAnzeige = new Label();
            BtnRechnung3 = new Button();
            BtnRechnung4 = new Button();
            SuspendLayout();
            // 
            // BtnRechnung1
            // 
            BtnRechnung1.Location = new Point(203, 12);
            BtnRechnung1.Name = "BtnRechnung1";
            BtnRechnung1.Size = new Size(96, 23);
            BtnRechnung1.TabIndex = 0;
            BtnRechnung1.Text = "Rechnung 1";
            BtnRechnung1.UseVisualStyleBackColor = true;
            BtnRechnung1.Click += BtnRechnung1_Click;
            // 
            // BtnRechnung2
            // 
            BtnRechnung2.Location = new Point(203, 41);
            BtnRechnung2.Name = "BtnRechnung2";
            BtnRechnung2.Size = new Size(96, 23);
            BtnRechnung2.TabIndex = 1;
            BtnRechnung2.Text = "Rechnung 2";
            BtnRechnung2.UseVisualStyleBackColor = true;
            BtnRechnung2.Click += BtnRechnung2_Click;
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(32, 20);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(38, 15);
            LblAnzeige.TabIndex = 2;
            LblAnzeige.Text = "label1";
            // 
            // BtnRechnung3
            // 
            BtnRechnung3.Location = new Point(203, 70);
            BtnRechnung3.Name = "BtnRechnung3";
            BtnRechnung3.Size = new Size(96, 23);
            BtnRechnung3.TabIndex = 3;
            BtnRechnung3.Text = "Rechnung 3";
            BtnRechnung3.UseVisualStyleBackColor = true;
            BtnRechnung3.Click += BtnRechnung3_Click;
            // 
            // BtnRechnung4
            // 
            BtnRechnung4.Location = new Point(203, 99);
            BtnRechnung4.Name = "BtnRechnung4";
            BtnRechnung4.Size = new Size(96, 23);
            BtnRechnung4.TabIndex = 4;
            BtnRechnung4.Text = "Rechnung 4";
            BtnRechnung4.UseVisualStyleBackColor = true;
            BtnRechnung4.Click += BtnRechnung4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 135);
            Controls.Add(BtnRechnung4);
            Controls.Add(BtnRechnung3);
            Controls.Add(LblAnzeige);
            Controls.Add(BtnRechnung2);
            Controls.Add(BtnRechnung1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnRechnung1;
        private Button BtnRechnung2;
        private Label LblAnzeige;
        private Button BtnRechnung3;
        private Button BtnRechnung4;
    }
}
