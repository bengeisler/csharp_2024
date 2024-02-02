// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Grundl_
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
            LblAnzeige = new Label();
            BtnAnzeige = new Button();
            SuspendLayout();
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(12, 19);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(19, 15);
            LblAnzeige.TabIndex = 1;
            LblAnzeige.Text = "    ";
            // 
            // BtnAnzeige
            // 
            BtnAnzeige.Location = new Point(296, 19);
            BtnAnzeige.Name = "BtnAnzeige";
            BtnAnzeige.Size = new Size(75, 23);
            BtnAnzeige.TabIndex = 2;
            BtnAnzeige.Text = "Anzeigen";
            BtnAnzeige.UseVisualStyleBackColor = true;
            BtnAnzeige.Click += BtnAnzeige_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 187);
            Controls.Add(BtnAnzeige);
            Controls.Add(LblAnzeige);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAnzeige;
        private Button BtnAnzeige;
    }
}
