// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace ÜbungmitSwich
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
            CmdButton = new Button();
            Lblanzeige1 = new Label();
            Lblanzeige2 = new Label();
            Numtext = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)Numtext).BeginInit();
            SuspendLayout();
            // 
            // CmdButton
            // 
            CmdButton.Location = new Point(446, 86);
            CmdButton.Name = "CmdButton";
            CmdButton.Size = new Size(75, 23);
            CmdButton.TabIndex = 0;
            CmdButton.Text = "Show";
            CmdButton.UseVisualStyleBackColor = true;
            CmdButton.Click += CmdButton_Click;
            // 
            // Lblanzeige1
            // 
            Lblanzeige1.AutoSize = true;
            Lblanzeige1.Location = new Point(356, 90);
            Lblanzeige1.Name = "Lblanzeige1";
            Lblanzeige1.Size = new Size(38, 15);
            Lblanzeige1.TabIndex = 2;
            Lblanzeige1.Text = "label1";
            // 
            // Lblanzeige2
            // 
            Lblanzeige2.AutoSize = true;
            Lblanzeige2.Location = new Point(183, 68);
            Lblanzeige2.Name = "Lblanzeige2";
            Lblanzeige2.Size = new Size(41, 15);
            Lblanzeige2.TabIndex = 3;
            Lblanzeige2.Text = "Gehalt";
            // 
            // Numtext
            // 
            Numtext.Location = new Point(183, 86);
            Numtext.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            Numtext.Name = "Numtext";
            Numtext.Size = new Size(120, 23);
            Numtext.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Numtext);
            Controls.Add(Lblanzeige2);
            Controls.Add(Lblanzeige1);
            Controls.Add(CmdButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Numtext).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdButton;
        private Label Lblanzeige1;
        private Label Lblanzeige2;
        private NumericUpDown Numtext;
    }
}
