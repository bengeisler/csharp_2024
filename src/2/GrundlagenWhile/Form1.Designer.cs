// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenWhile
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
            Lbl1 = new Label();
            SuspendLayout();
            // 
            // CmdAnzeigen1
            // 
            CmdAnzeigen1.Location = new Point(309, 63);
            CmdAnzeigen1.Name = "CmdAnzeigen1";
            CmdAnzeigen1.Size = new Size(75, 23);
            CmdAnzeigen1.TabIndex = 0;
            CmdAnzeigen1.Text = "button1";
            CmdAnzeigen1.UseVisualStyleBackColor = true;
            CmdAnzeigen1.Click += CmdAnzeigen1_Click;
            // 
            // CmdAnzeigen2
            // 
            CmdAnzeigen2.Location = new Point(327, 124);
            CmdAnzeigen2.Name = "CmdAnzeigen2";
            CmdAnzeigen2.Size = new Size(75, 15);
            CmdAnzeigen2.TabIndex = 1;
            CmdAnzeigen2.Text = "button2";
            CmdAnzeigen2.UseVisualStyleBackColor = true;
            CmdAnzeigen2.Click += CmdAnzeigen2_Click;
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Location = new Point(54, 47);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(38, 15);
            Lbl1.TabIndex = 2;
            Lbl1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Lbl1);
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
        private Label Lbl1;
    }
}
