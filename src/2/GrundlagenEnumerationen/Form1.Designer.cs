// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenEnumerationen
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
            CmdAnzeige2 = new Button();
            CmdAnzeige1 = new Button();
            LblAnzeige = new Label();
            SuspendLayout();
            // 
            // CmdAnzeige2
            // 
            CmdAnzeige2.Location = new Point(236, 57);
            CmdAnzeige2.Name = "CmdAnzeige2";
            CmdAnzeige2.Size = new Size(75, 23);
            CmdAnzeige2.TabIndex = 0;
            CmdAnzeige2.Text = "Anzeige2";
            CmdAnzeige2.UseVisualStyleBackColor = true;
            CmdAnzeige2.Click += CmdAnzeige2_Click;
            // 
            // CmdAnzeige1
            // 
            CmdAnzeige1.Location = new Point(236, 98);
            CmdAnzeige1.Name = "CmdAnzeige1";
            CmdAnzeige1.Size = new Size(75, 23);
            CmdAnzeige1.TabIndex = 1;
            CmdAnzeige1.Text = "Anzeige1";
            CmdAnzeige1.UseVisualStyleBackColor = true;
            CmdAnzeige1.Click += CmdAnzeige1_Click;
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(45, 48);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(38, 15);
            LblAnzeige.TabIndex = 2;
            LblAnzeige.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAnzeige);
            Controls.Add(CmdAnzeige1);
            Controls.Add(CmdAnzeige2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAnzeige2;
        private Button CmdAnzeige1;
        private Label LblAnzeige;
    }
}
