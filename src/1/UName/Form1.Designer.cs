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
            LblMeinName = new Label();
            BtnMeinName = new Button();
            BtnEnde = new Button();
            SuspendLayout();
            // 
            // LblMeinName
            // 
            LblMeinName.AutoSize = true;
            LblMeinName.Location = new Point(27, 18);
            LblMeinName.Name = "LblMeinName";
            LblMeinName.Size = new Size(59, 25);
            LblMeinName.TabIndex = 2;
            LblMeinName.Text = "label1";
            // 
            // BtnMeinName
            // 
            BtnMeinName.Location = new Point(27, 59);
            BtnMeinName.Name = "BtnMeinName";
            BtnMeinName.Size = new Size(112, 34);
            BtnMeinName.TabIndex = 3;
            BtnMeinName.Text = "Mein Name";
            BtnMeinName.UseVisualStyleBackColor = true;
            BtnMeinName.Click += BtnMeinName_Click;
            // 
            // BtnEnde
            // 
            BtnEnde.Location = new Point(272, 59);
            BtnEnde.Name = "BtnEnde";
            BtnEnde.Size = new Size(112, 34);
            BtnEnde.TabIndex = 4;
            BtnEnde.Text = "Ende";
            BtnEnde.UseVisualStyleBackColor = true;
            BtnEnde.Click += BtnEnde_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 115);
            Controls.Add(BtnEnde);
            Controls.Add(BtnMeinName);
            Controls.Add(LblMeinName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblMeinName;
        private Button BtnMeinName;
        private Button BtnEnde;
    }
}
