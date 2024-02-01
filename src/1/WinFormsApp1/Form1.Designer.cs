// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace WinFormsApp1
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
            CmdAnzeigen2 = new Button();
            CmdAnzeigen3 = new Button();
            CmdAnzeigen4 = new Button();
            LblAnzeige = new Label();
            SuspendLayout();
            // 
            // CmdAnzeigen1
            // 
            CmdAnzeigen1.Location = new Point(431, 90);
            CmdAnzeigen1.Name = "CmdAnzeigen1";
            CmdAnzeigen1.Size = new Size(75, 23);
            CmdAnzeigen1.TabIndex = 0;
            CmdAnzeigen1.Text = "button1";
            CmdAnzeigen1.UseVisualStyleBackColor = true;
            CmdAnzeigen1.Click += CmdAnzeigen1_Click;
            // 
            // CmdAnzeigen2
            // 
            CmdAnzeigen2.Location = new Point(431, 119);
            CmdAnzeigen2.Name = "CmdAnzeigen2";
            CmdAnzeigen2.Size = new Size(75, 23);
            CmdAnzeigen2.TabIndex = 1;
            CmdAnzeigen2.Text = "button2";
            CmdAnzeigen2.UseVisualStyleBackColor = true;
            CmdAnzeigen2.Click += CmdAnzeigen2_Click;
            // 
            // CmdAnzeigen3
            // 
            CmdAnzeigen3.Location = new Point(431, 148);
            CmdAnzeigen3.Name = "CmdAnzeigen3";
            CmdAnzeigen3.Size = new Size(75, 23);
            CmdAnzeigen3.TabIndex = 2;
            CmdAnzeigen3.Text = "button3";
            CmdAnzeigen3.UseVisualStyleBackColor = true;
            CmdAnzeigen3.Click += CmdAnzeigen3_Click;
            // 
            // CmdAnzeigen4
            // 
            CmdAnzeigen4.Location = new Point(431, 177);
            CmdAnzeigen4.Name = "CmdAnzeigen4";
            CmdAnzeigen4.Size = new Size(75, 23);
            CmdAnzeigen4.TabIndex = 3;
            CmdAnzeigen4.Text = "button4";
            CmdAnzeigen4.UseVisualStyleBackColor = true;
            CmdAnzeigen4.Click += CmdAnzeigen4_Click;
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(474, 25);
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
            Controls.Add(CmdAnzeigen4);
            Controls.Add(CmdAnzeigen3);
            Controls.Add(CmdAnzeigen2);
            Controls.Add(CmdAnzeigen1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAnzeigen1;
        private Button CmdAnzeigen2;
        private Button CmdAnzeigen3;
        private Button CmdAnzeigen4;
        private Label LblAnzeige;
    }
}
