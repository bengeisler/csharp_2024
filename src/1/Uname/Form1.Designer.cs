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
            BtnName = new Button();
            ButtonEnde = new Button();
            LblName = new Label();
            SuspendLayout();
            // 
            // BtnName
            // 
            BtnName.Location = new Point(220, 183);
            BtnName.Name = "BtnName";
            BtnName.Size = new Size(119, 23);
            BtnName.TabIndex = 0;
            BtnName.Text = "Mein Name";
            BtnName.UseVisualStyleBackColor = true;
            BtnName.Click += BtnName_Click;
            // 
            // ButtonEnde
            // 
            ButtonEnde.Location = new Point(370, 183);
            ButtonEnde.Name = "ButtonEnde";
            ButtonEnde.Size = new Size(75, 23);
            ButtonEnde.TabIndex = 1;
            ButtonEnde.Text = "Ende";
            ButtonEnde.UseVisualStyleBackColor = true;
            ButtonEnde.Click += ButtonEnde_Click;
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(233, 122);
            LblName.Name = "LblName";
            LblName.Size = new Size(38, 15);
            LblName.TabIndex = 2;
            LblName.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(LblName);
            Controls.Add(ButtonEnde);
            Controls.Add(BtnName);
            Name = "Form1";
            Text = "Mein Name";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnName;
        private Button ButtonEnde;
        private Label LblName;
    }
}
