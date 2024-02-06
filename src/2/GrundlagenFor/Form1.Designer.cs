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
            BtnAnzeigen1 = new Button();
            LblAnzeigen = new Label();
            BtnAnzeigen2 = new Button();
            LblAnzeigen2 = new Label();
            BtnAnzeigen3 = new Button();
            LblAnzeigen3 = new Label();
            LblAnzeigen4 = new Label();
            BtnAnzeigen4 = new Button();
            SuspendLayout();
            // 
            // BtnAnzeigen1
            // 
            BtnAnzeigen1.Location = new Point(12, 12);
            BtnAnzeigen1.Name = "BtnAnzeigen1";
            BtnAnzeigen1.Size = new Size(75, 23);
            BtnAnzeigen1.TabIndex = 0;
            BtnAnzeigen1.Text = "Anzeigen 1";
            BtnAnzeigen1.UseVisualStyleBackColor = true;
            BtnAnzeigen1.Click += BtnAnzeigen1_Click;
            // 
            // LblAnzeigen
            // 
            LblAnzeigen.AutoSize = true;
            LblAnzeigen.Location = new Point(27, 53);
            LblAnzeigen.Name = "LblAnzeigen";
            LblAnzeigen.Size = new Size(38, 15);
            LblAnzeigen.TabIndex = 1;
            LblAnzeigen.Text = "label1";
            // 
            // BtnAnzeigen2
            // 
            BtnAnzeigen2.Location = new Point(108, 12);
            BtnAnzeigen2.Name = "BtnAnzeigen2";
            BtnAnzeigen2.Size = new Size(75, 23);
            BtnAnzeigen2.TabIndex = 2;
            BtnAnzeigen2.Text = "Anzeigen 2";
            BtnAnzeigen2.UseVisualStyleBackColor = true;
            BtnAnzeigen2.Click += BtnAnzeigen2_Click;
            // 
            // LblAnzeigen2
            // 
            LblAnzeigen2.AutoSize = true;
            LblAnzeigen2.Location = new Point(121, 53);
            LblAnzeigen2.Name = "LblAnzeigen2";
            LblAnzeigen2.Size = new Size(38, 15);
            LblAnzeigen2.TabIndex = 3;
            LblAnzeigen2.Text = "label1";
            // 
            // BtnAnzeigen3
            // 
            BtnAnzeigen3.Location = new Point(209, 12);
            BtnAnzeigen3.Name = "BtnAnzeigen3";
            BtnAnzeigen3.Size = new Size(75, 23);
            BtnAnzeigen3.TabIndex = 4;
            BtnAnzeigen3.Text = "Anzeigen 3";
            BtnAnzeigen3.UseVisualStyleBackColor = true;
            BtnAnzeigen3.Click += BtnAnzeigen3_Click;
            // 
            // LblAnzeigen3
            // 
            LblAnzeigen3.AutoSize = true;
            LblAnzeigen3.Location = new Point(223, 53);
            LblAnzeigen3.Name = "LblAnzeigen3";
            LblAnzeigen3.Size = new Size(38, 15);
            LblAnzeigen3.TabIndex = 5;
            LblAnzeigen3.Text = "label2";
            // 
            // LblAnzeigen4
            // 
            LblAnzeigen4.AutoSize = true;
            LblAnzeigen4.Location = new Point(329, 53);
            LblAnzeigen4.Name = "LblAnzeigen4";
            LblAnzeigen4.Size = new Size(38, 15);
            LblAnzeigen4.TabIndex = 7;
            LblAnzeigen4.Text = "label2";
            // 
            // BtnAnzeigen4
            // 
            BtnAnzeigen4.Location = new Point(315, 12);
            BtnAnzeigen4.Name = "BtnAnzeigen4";
            BtnAnzeigen4.Size = new Size(75, 23);
            BtnAnzeigen4.TabIndex = 6;
            BtnAnzeigen4.Text = "Anzeigen 4";
            BtnAnzeigen4.UseVisualStyleBackColor = true;
            BtnAnzeigen4.Click += BtnAnzeigen4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAnzeigen4);
            Controls.Add(BtnAnzeigen4);
            Controls.Add(LblAnzeigen3);
            Controls.Add(BtnAnzeigen3);
            Controls.Add(LblAnzeigen2);
            Controls.Add(BtnAnzeigen2);
            Controls.Add(LblAnzeigen);
            Controls.Add(BtnAnzeigen1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAnzeigen1;
        private Label LblAnzeigen;
        private Button BtnAnzeigen2;
        private Label LblAnzeigen2;
        private Button BtnAnzeigen3;
        private Label LblAnzeigen3;
        private Label LblAnzeigen4;
        private Button BtnAnzeigen4;
    }
}
