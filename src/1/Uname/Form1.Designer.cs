// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Uname
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
            CmdMeinName = new Button();
            CmdEnde = new Button();
            LblMeinName = new Label();
            SuspendLayout();
            // 
            // CmdMeinName
            // 
            CmdMeinName.Location = new Point(46, 125);
            CmdMeinName.Name = "CmdMeinName";
            CmdMeinName.Size = new Size(122, 37);
            CmdMeinName.TabIndex = 0;
            CmdMeinName.Text = "Mein Name";
            CmdMeinName.UseVisualStyleBackColor = true;
            CmdMeinName.Click += CmdMeinName_Click;
            // 
            // CmdEnde
            // 
            CmdEnde.Location = new Point(203, 125);
            CmdEnde.Name = "CmdEnde";
            CmdEnde.Size = new Size(84, 37);
            CmdEnde.TabIndex = 1;
            CmdEnde.Text = "Ende";
            CmdEnde.UseVisualStyleBackColor = true;
            CmdEnde.Click += CmdEnde_Click;
            // 
            // LblMeinName
            // 
            LblMeinName.AutoSize = true;
            LblMeinName.Location = new Point(75, 69);
            LblMeinName.Name = "LblMeinName";
            LblMeinName.Size = new Size(38, 15);
            LblMeinName.TabIndex = 2;
            LblMeinName.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblMeinName);
            Controls.Add(CmdEnde);
            Controls.Add(CmdMeinName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdMeinName;
        private Button CmdEnde;
        private Label LblMeinName;
    }
}
