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
            BtnName = new Button();
            LblName = new Label();
            BtnEnde = new Button();
            SuspendLayout();
            // 
            // BtnName
            // 
            BtnName.Location = new Point(81, 130);
            BtnName.Name = "BtnName";
            BtnName.Size = new Size(96, 23);
            BtnName.TabIndex = 0;
            BtnName.Text = "Mein Name";
            BtnName.UseVisualStyleBackColor = true;
            BtnName.Click += BtnName_Click;
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(92, 95);
            LblName.Name = "LblName";
            LblName.Size = new Size(38, 15);
            LblName.TabIndex = 1;
            LblName.Text = "label1";
            // 
            // BtnEnde
            // 
            BtnEnde.Location = new Point(257, 130);
            BtnEnde.Name = "BtnEnde";
            BtnEnde.Size = new Size(75, 23);
            BtnEnde.TabIndex = 2;
            BtnEnde.Text = "Ende";
            BtnEnde.UseVisualStyleBackColor = true;
            BtnEnde.Click += BtnEnde_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnEnde);
            Controls.Add(LblName);
            Controls.Add(BtnName);
            Name = "Form1";
            Text = "Mein Name";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnName;
        private Label LblName;
        private Button BtnEnde;
    }
}
