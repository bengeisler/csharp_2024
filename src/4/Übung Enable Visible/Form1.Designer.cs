// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Übung_Enable_Visible
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
            LstBox = new ListBox();
            CmdButton2 = new Button();
            SuspendLayout();
            // 
            // CmdButton
            // 
            CmdButton.Location = new Point(234, 60);
            CmdButton.Name = "CmdButton";
            CmdButton.Size = new Size(75, 23);
            CmdButton.TabIndex = 1;
            CmdButton.Text = "Löschen";
            CmdButton.UseVisualStyleBackColor = true;
            CmdButton.Click += CmdButton_Click;
            // 
            // LstBox
            // 
            LstBox.FormattingEnabled = true;
            LstBox.ItemHeight = 15;
            LstBox.Location = new Point(12, 60);
            LstBox.Name = "LstBox";
            LstBox.Size = new Size(120, 94);
            LstBox.TabIndex = 2;
            LstBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // CmdButton2
            // 
            CmdButton2.Location = new Point(234, 131);
            CmdButton2.Name = "CmdButton2";
            CmdButton2.Size = new Size(75, 23);
            CmdButton2.TabIndex = 3;
            CmdButton2.Text = "Close";
            CmdButton2.UseVisualStyleBackColor = true;
            CmdButton2.Click += CmdButton2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdButton2);
            Controls.Add(LstBox);
            Controls.Add(CmdButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button CmdButton;
        private ListBox LstBox;
        private Button CmdButton2;
    }
}
