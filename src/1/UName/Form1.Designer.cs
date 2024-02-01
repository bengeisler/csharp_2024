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
            LblName = new Label();
            BtnName = new Button();
            BtnEnde = new Button();
            SuspendLayout();
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(24, 91);
            LblName.Name = "LblName";
            LblName.Size = new Size(72, 15);
            LblName.TabIndex = 0;
            LblName.Text = "Claus Clever";
            // 
            // BtnName
            // 
            BtnName.Location = new Point(24, 162);
            BtnName.Name = "BtnName";
            BtnName.Size = new Size(145, 23);
            BtnName.TabIndex = 1;
            BtnName.Text = "Mein Name";
            BtnName.UseVisualStyleBackColor = true;
            BtnName.Click += BtnName_Click;
            // 
            // BtnEnde
            // 
            BtnEnde.Location = new Point(214, 162);
            BtnEnde.Name = "BtnEnde";
            BtnEnde.Size = new Size(171, 23);
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
            Controls.Add(BtnName);
            Controls.Add(LblName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblName;
        private Button BtnName;
        private Button BtnEnde;
    }
}
