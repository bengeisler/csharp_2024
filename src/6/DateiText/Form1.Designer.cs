// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace DateiText
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
            TxtBox = new TextBox();
            CmdButton1 = new Button();
            CmdButton2 = new Button();
            CmdButton3 = new Button();
            LblAnzeige1 = new Label();
            SuspendLayout();
            // 
            // TxtBox
            // 
            TxtBox.Location = new Point(12, 40);
            TxtBox.Multiline = true;
            TxtBox.Name = "TxtBox";
            TxtBox.Size = new Size(449, 170);
            TxtBox.TabIndex = 0;
            TxtBox.TextChanged += TxtBox_TextChanged;
            // 
            // CmdButton1
            // 
            CmdButton1.Location = new Point(12, 11);
            CmdButton1.Name = "CmdButton1";
            CmdButton1.Size = new Size(75, 23);
            CmdButton1.TabIndex = 1;
            CmdButton1.Text = "Schreiben";
            CmdButton1.UseVisualStyleBackColor = true;
            CmdButton1.Click += CmdButton1_Click;
            // 
            // CmdButton2
            // 
            CmdButton2.Location = new Point(199, 11);
            CmdButton2.Name = "CmdButton2";
            CmdButton2.Size = new Size(75, 23);
            CmdButton2.TabIndex = 3;
            CmdButton2.Text = "Anhängen";
            CmdButton2.UseVisualStyleBackColor = true;
            CmdButton2.Click += CmdButton2_Click;
            // 
            // CmdButton3
            // 
            CmdButton3.Location = new Point(386, 10);
            CmdButton3.Name = "CmdButton3";
            CmdButton3.Size = new Size(75, 23);
            CmdButton3.TabIndex = 5;
            CmdButton3.Text = "Lesen";
            CmdButton3.UseVisualStyleBackColor = true;
            CmdButton3.Click += CmdButton3_Click;
            // 
            // LblAnzeige1
            // 
            LblAnzeige1.AutoSize = true;
            LblAnzeige1.Location = new Point(12, 213);
            LblAnzeige1.Name = "LblAnzeige1";
            LblAnzeige1.Size = new Size(38, 15);
            LblAnzeige1.TabIndex = 6;
            LblAnzeige1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 241);
            Controls.Add(LblAnzeige1);
            Controls.Add(CmdButton3);
            Controls.Add(CmdButton2);
            Controls.Add(CmdButton1);
            Controls.Add(TxtBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBox;
        private Button CmdButton1;
        private Button CmdButton2;
        private Button CmdButton3;
        private Label LblAnzeige1;
    }
}
