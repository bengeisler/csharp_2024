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
            cmdAnzeigen1 = new Button();
            LblAnzeigen1 = new Label();
            cmdAnzeigen2 = new Button();
            LblAnzeigen2 = new Label();
            cmdAnzeigen3 = new Button();
            LblAnzeigen3 = new Label();
            cmdAnzeigen4 = new Button();
            LblAnzeigen4 = new Label();
            SuspendLayout();
            // 
            // cmdAnzeigen1
            // 
            cmdAnzeigen1.Location = new Point(12, 12);
            cmdAnzeigen1.Name = "cmdAnzeigen1";
            cmdAnzeigen1.Size = new Size(75, 23);
            cmdAnzeigen1.TabIndex = 0;
            cmdAnzeigen1.Text = "Anzeigen1";
            cmdAnzeigen1.UseVisualStyleBackColor = true;
            cmdAnzeigen1.Click += cmdAnzeigen1_Click;
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
            // cmdAnzeigen2
            // 
            cmdAnzeigen2.Location = new Point(110, 12);
            cmdAnzeigen2.Name = "cmdAnzeigen2";
            cmdAnzeigen2.Size = new Size(75, 23);
            cmdAnzeigen2.TabIndex = 2;
            cmdAnzeigen2.Text = "Anzeigen2";
            cmdAnzeigen2.UseVisualStyleBackColor = true;
            cmdAnzeigen2.Click += cmdAnzeigen2_Click;
            // 
            // LblAnzeigen2
            // 
            LblAnzeigen2.AutoSize = true;
            LblAnzeigen2.Location = new Point(110, 60);
            LblAnzeigen2.Name = "LblAnzeigen2";
            LblAnzeigen2.Size = new Size(38, 15);
            LblAnzeigen2.TabIndex = 3;
            LblAnzeigen2.Text = "label1";
            // 
            // cmdAnzeigen3
            // 
            cmdAnzeigen3.Location = new Point(209, 12);
            cmdAnzeigen3.Name = "cmdAnzeigen3";
            cmdAnzeigen3.Size = new Size(75, 23);
            cmdAnzeigen3.TabIndex = 4;
            cmdAnzeigen3.Text = "Anzeigen3";
            cmdAnzeigen3.UseVisualStyleBackColor = true;
            cmdAnzeigen3.Click += cmdAnzeigen3_Click;
            // 
            // LblAnzeigen3
            // 
            LblAnzeigen3.AutoSize = true;
            LblAnzeigen3.Location = new Point(209, 60);
            LblAnzeigen3.Name = "LblAnzeigen3";
            LblAnzeigen3.Size = new Size(38, 15);
            LblAnzeigen3.TabIndex = 5;
            LblAnzeigen3.Text = "label1";
            // 
            // cmdAnzeigen4
            // 
            cmdAnzeigen4.Location = new Point(307, 12);
            cmdAnzeigen4.Name = "cmdAnzeigen4";
            cmdAnzeigen4.Size = new Size(75, 23);
            cmdAnzeigen4.TabIndex = 6;
            cmdAnzeigen4.Text = "Anzeigen4";
            cmdAnzeigen4.UseVisualStyleBackColor = true;
            cmdAnzeigen4.Click += cmdAnzeigen4_Click;
            // 
            // LblAnzeigen4
            // 
            LblAnzeigen4.AutoSize = true;
            LblAnzeigen4.Location = new Point(307, 60);
            LblAnzeigen4.Name = "LblAnzeigen4";
            LblAnzeigen4.Size = new Size(38, 15);
            LblAnzeigen4.TabIndex = 7;
            LblAnzeigen4.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAnzeigen4);
            Controls.Add(cmdAnzeigen4);
            Controls.Add(LblAnzeigen3);
            Controls.Add(cmdAnzeigen3);
            Controls.Add(LblAnzeigen2);
            Controls.Add(cmdAnzeigen2);
            Controls.Add(LblAnzeigen1);
            Controls.Add(cmdAnzeigen1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdAnzeigen1;
        private Label LblAnzeigen1;
        private Button cmdAnzeigen2;
        private Label LblAnzeigen2;
        private Button cmdAnzeigen3;
        private Label LblAnzeigen3;
        private Button cmdAnzeigen4;
        private Label LblAnzeigen4;
    }
}
