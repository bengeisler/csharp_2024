// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementComboBox
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
            CmbBox = new ComboBox();
            BtnAnzeigen1 = new Button();
            LblAnzeigen1 = new Label();
            SuspendLayout();
            // 
            // CmbBox
            // 
            CmbBox.FormattingEnabled = true;
            CmbBox.Location = new Point(12, 37);
            CmbBox.Name = "CmbBox";
            CmbBox.Size = new Size(121, 23);
            CmbBox.TabIndex = 0;
            CmbBox.SelectedIndexChanged += CmbBox_SelectedIndexChanged;
            // 
            // BtnAnzeigen1
            // 
            BtnAnzeigen1.Location = new Point(171, 38);
            BtnAnzeigen1.Name = "BtnAnzeigen1";
            BtnAnzeigen1.Size = new Size(75, 23);
            BtnAnzeigen1.TabIndex = 1;
            BtnAnzeigen1.Text = "Anzeigen 1";
            BtnAnzeigen1.UseVisualStyleBackColor = true;
            BtnAnzeigen1.Click += BtnAnzeigen1_Click;
            // 
            // LblAnzeigen1
            // 
            LblAnzeigen1.AutoSize = true;
            LblAnzeigen1.Location = new Point(280, 39);
            LblAnzeigen1.Name = "LblAnzeigen1";
            LblAnzeigen1.Size = new Size(38, 15);
            LblAnzeigen1.TabIndex = 2;
            LblAnzeigen1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAnzeigen1);
            Controls.Add(BtnAnzeigen1);
            Controls.Add(CmbBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CmbBox;
        private Button BtnAnzeigen1;
        private Label LblAnzeigen1;
    }
}
