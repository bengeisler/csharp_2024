// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenKonstanten
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
            BtnAnzeige1 = new Button();
            LblAnzeige = new Label();
            BtnAnzeige2 = new Button();
            SuspendLayout();
            // 
            // BtnAnzeige1
            // 
            BtnAnzeige1.Location = new Point(141, 33);
            BtnAnzeige1.Name = "BtnAnzeige1";
            BtnAnzeige1.Size = new Size(75, 23);
            BtnAnzeige1.TabIndex = 0;
            BtnAnzeige1.Text = "Anzeige 1";
            BtnAnzeige1.UseVisualStyleBackColor = true;
            BtnAnzeige1.Click += BtnAnzeige1_Click;
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(30, 33);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(38, 15);
            LblAnzeige.TabIndex = 1;
            LblAnzeige.Text = "label1";
            // 
            // BtnAnzeige2
            // 
            BtnAnzeige2.Location = new Point(141, 62);
            BtnAnzeige2.Name = "BtnAnzeige2";
            BtnAnzeige2.Size = new Size(75, 23);
            BtnAnzeige2.TabIndex = 2;
            BtnAnzeige2.Text = "Anzeige 2";
            BtnAnzeige2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnAnzeige2);
            Controls.Add(LblAnzeige);
            Controls.Add(BtnAnzeige1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAnzeige1;
        private Label LblAnzeige;
        private Button BtnAnzeige2;
    }
}
