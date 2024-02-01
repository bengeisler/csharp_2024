// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UName
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
            CmdEnde = new Button();
            CmdMeinName = new Button();
            LblMeinName = new Label();
            SuspendLayout();
            // 
            // CmdEnde
            // 
            CmdEnde.Location = new Point(560, 357);
            CmdEnde.Name = "CmdEnde";
            CmdEnde.Size = new Size(204, 50);
            CmdEnde.TabIndex = 0;
            CmdEnde.Text = "Ende";
            CmdEnde.UseVisualStyleBackColor = true;
            CmdEnde.Click += CmdEnde_Click;
            // 
            // CmdMeinName
            // 
            CmdMeinName.Location = new Point(277, 353);
            CmdMeinName.Name = "CmdMeinName";
            CmdMeinName.Size = new Size(173, 58);
            CmdMeinName.TabIndex = 1;
            CmdMeinName.Text = "Mein Name";
            CmdMeinName.UseVisualStyleBackColor = true;
            CmdMeinName.Click += CmdMeinName_Click;
            // 
            // LblMeinName
            // 
            LblMeinName.AutoSize = true;
            LblMeinName.Location = new Point(277, 292);
            LblMeinName.Name = "LblMeinName";
            LblMeinName.Size = new Size(0, 15);
            LblMeinName.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblMeinName);
            Controls.Add(CmdMeinName);
            Controls.Add(CmdEnde);
            Name = "Form1";
            Text = "Mein Name";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdEnde;
        private Button CmdMeinName;
        private Label LblMeinName;
    }
}
