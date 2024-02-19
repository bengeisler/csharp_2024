// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace KlassenFormulare
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
            TxtBox = new TextBox();
            SuspendLayout();
            // 
            // CmdButton
            // 
            CmdButton.Location = new Point(120, 98);
            CmdButton.Name = "CmdButton";
            CmdButton.Size = new Size(100, 48);
            CmdButton.TabIndex = 0;
            CmdButton.Text = "Formular 2 Aufrufen";
            CmdButton.UseVisualStyleBackColor = true;
            CmdButton.Click += CmdButton_Click;
            // 
            // TxtBox
            // 
            TxtBox.Location = new Point(120, 69);
            TxtBox.Name = "TxtBox";
            TxtBox.Size = new Size(100, 23);
            TxtBox.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtBox);
            Controls.Add(CmdButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdButton;
        private TextBox TxtBox;
    }
}
