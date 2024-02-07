// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementListBox
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
            LstSpeisen = new ListBox();
            CmdAnzeigen1 = new Button();
            LblAnzeige1 = new Label();
            CmdButton2 = new Button();
            SuspendLayout();
            // 
            // LstSpeisen
            // 
            LstSpeisen.FormattingEnabled = true;
            LstSpeisen.ItemHeight = 15;
            LstSpeisen.Location = new Point(12, 12);
            LstSpeisen.Name = "LstSpeisen";
            LstSpeisen.Size = new Size(120, 184);
            LstSpeisen.TabIndex = 0;
            LstSpeisen.SelectedIndexChanged += LstSpeisen_SelectedIndexChanged;
            // 
            // CmdAnzeigen1
            // 
            CmdAnzeigen1.Location = new Point(26, 202);
            CmdAnzeigen1.Name = "CmdAnzeigen1";
            CmdAnzeigen1.Size = new Size(75, 23);
            CmdAnzeigen1.TabIndex = 1;
            CmdAnzeigen1.Text = "Anzeigen";
            CmdAnzeigen1.UseVisualStyleBackColor = true;
            CmdAnzeigen1.Click += CmdAnzeigen1_Click;
            // 
            // LblAnzeige1
            // 
            LblAnzeige1.AutoSize = true;
            LblAnzeige1.Location = new Point(157, 12);
            LblAnzeige1.Name = "LblAnzeige1";
            LblAnzeige1.Size = new Size(38, 15);
            LblAnzeige1.TabIndex = 2;
            LblAnzeige1.Text = "label1";
            // 
            // CmdButton2
            // 
            CmdButton2.Location = new Point(26, 231);
            CmdButton2.Name = "CmdButton2";
            CmdButton2.Size = new Size(75, 23);
            CmdButton2.TabIndex = 3;
            CmdButton2.Text = "Anzeigem 2";
            CmdButton2.UseVisualStyleBackColor = true;
            CmdButton2.Click += CmdButton2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdButton2);
            Controls.Add(LblAnzeige1);
            Controls.Add(CmdAnzeigen1);
            Controls.Add(LstSpeisen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LstSpeisen;
        private Button CmdAnzeigen1;
        private Label LblAnzeige1;
        private Button CmdButton2;
    }
}
