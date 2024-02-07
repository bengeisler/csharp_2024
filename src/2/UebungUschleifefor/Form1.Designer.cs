// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UebungUschleifefor
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
            Lbl1 = new Label();
            Lbl2 = new Label();
            Lbl3 = new Label();
            CmdAnzeigen1 = new Button();
            CmdAnziegen2 = new Button();
            SuspendLayout();
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Location = new Point(53, 46);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(38, 15);
            Lbl1.TabIndex = 0;
            Lbl1.Text = "label1";
            // 
            // Lbl2
            // 
            Lbl2.AutoSize = true;
            Lbl2.Location = new Point(53, 329);
            Lbl2.Name = "Lbl2";
            Lbl2.Size = new Size(38, 15);
            Lbl2.TabIndex = 1;
            Lbl2.Text = "label2";
            // 
            // Lbl3
            // 
            Lbl3.AutoSize = true;
            Lbl3.Location = new Point(53, 376);
            Lbl3.Name = "Lbl3";
            Lbl3.Size = new Size(38, 15);
            Lbl3.TabIndex = 2;
            Lbl3.Text = "label3";
            // 
            // CmdAnzeigen1
            // 
            CmdAnzeigen1.Location = new Point(311, 46);
            CmdAnzeigen1.Name = "CmdAnzeigen1";
            CmdAnzeigen1.Size = new Size(75, 23);
            CmdAnzeigen1.TabIndex = 3;
            CmdAnzeigen1.Text = "Anzeigen 1";
            CmdAnzeigen1.UseVisualStyleBackColor = true;
            CmdAnzeigen1.Click += CmdAnzeigen1_Click;
            // 
            // CmdAnziegen2
            // 
            CmdAnziegen2.Location = new Point(311, 75);
            CmdAnziegen2.Name = "CmdAnziegen2";
            CmdAnziegen2.Size = new Size(75, 23);
            CmdAnziegen2.TabIndex = 4;
            CmdAnziegen2.Text = "Anzeigen 2";
            CmdAnziegen2.UseVisualStyleBackColor = true;
            CmdAnziegen2.Click += CmdAnziegen2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdAnziegen2);
            Controls.Add(CmdAnzeigen1);
            Controls.Add(Lbl3);
            Controls.Add(Lbl2);
            Controls.Add(Lbl1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl1;
        private Label Lbl2;
        private Label Lbl3;
        private Button CmdAnzeigen1;
        private Button CmdAnziegen2;
    }
}
