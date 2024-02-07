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
            CmdAnzeigen2 = new Button();
            LblAnzeige2 = new Label();
            CmdAnzeige3 = new Button();
            CmdAnzeige4 = new Button();
            SuspendLayout();
            // 
            // CmdAnzeigen1
            // 
            CmdAnzeigen1.Location = new Point(56, 36);
            CmdAnzeigen1.Name = "CmdAnzeigen1";
            CmdAnzeigen1.Size = new Size(75, 23);
            CmdAnzeigen1.TabIndex = 0;
            CmdAnzeigen1.Text = "Anzeigen1";
            CmdAnzeigen1.UseVisualStyleBackColor = true;
            CmdAnzeigen1.Click += CmdAnzeigen1_Click;
            // 
            // LblAnzeigen1
            // 
            LblAnzeigen1.AutoSize = true;
            LblAnzeigen1.Location = new Point(80, 94);
            LblAnzeigen1.Name = "LblAnzeigen1";
            LblAnzeigen1.Size = new Size(94, 15);
            LblAnzeigen1.TabIndex = 1;
            LblAnzeigen1.Text = "Schleifen mit for";
            // 
            // CmdAnzeigen2
            // 
            CmdAnzeigen2.Location = new Point(189, 36);
            CmdAnzeigen2.Name = "CmdAnzeigen2";
            CmdAnzeigen2.Size = new Size(75, 23);
            CmdAnzeigen2.TabIndex = 2;
            CmdAnzeigen2.Text = "Anzeigen2";
            CmdAnzeigen2.UseVisualStyleBackColor = true;
            CmdAnzeigen2.Click += CmdAnzeigen2_Click;
            // 
            // LblAnzeige2
            // 
            LblAnzeige2.AutoSize = true;
            LblAnzeige2.Location = new Point(353, 218);
            LblAnzeige2.Name = "LblAnzeige2";
            LblAnzeige2.Size = new Size(94, 15);
            LblAnzeige2.TabIndex = 3;
            LblAnzeige2.Text = "Schleifen mit for";
            // 
            // CmdAnzeige3
            // 
            CmdAnzeige3.Location = new Point(296, 303);
            CmdAnzeige3.Name = "CmdAnzeige3";
            CmdAnzeige3.Size = new Size(75, 23);
            CmdAnzeige3.TabIndex = 4;
            CmdAnzeige3.Text = "button1";
            CmdAnzeige3.UseVisualStyleBackColor = true;
            CmdAnzeige3.Click += CmdAnzeige3_Click;
            // 
            // CmdAnzeige4
            // 
            CmdAnzeige4.Location = new Point(372, 67);
            CmdAnzeige4.Name = "CmdAnzeige4";
            CmdAnzeige4.Size = new Size(75, 23);
            CmdAnzeige4.TabIndex = 5;
            CmdAnzeige4.Text = "Anzeige4";
            CmdAnzeige4.UseVisualStyleBackColor = true;
            CmdAnzeige4.Click += CmdAnzeige4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdAnzeige4);
            Controls.Add(CmdAnzeige3);
            Controls.Add(LblAnzeige2);
            Controls.Add(CmdAnzeigen2);
            Controls.Add(LblAnzeigen1);
            Controls.Add(CmdAnzeigen1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAnzeigen1;
        private Label LblAnzeigen1;
        private Button CmdAnzeigen2;
        private Label LblAnzeige2;
        private Button CmdAnzeige3;
        private Button CmdAnzeige4;
    }
}
