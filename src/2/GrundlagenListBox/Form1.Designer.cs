// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenListBox
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
            LstSpeisen = new ListBox();
            BtnAnzeigen = new Button();
            LblAnzeigen = new Label();
            SuspendLayout();
            // 
            // LstSpeisen
            // 
            LstSpeisen.FormattingEnabled = true;
            LstSpeisen.ItemHeight = 15;
            LstSpeisen.Location = new Point(21, 39);
            LstSpeisen.Name = "LstSpeisen";
            LstSpeisen.Size = new Size(120, 94);
            LstSpeisen.TabIndex = 0;
            // 
            // BtnAnzeigen
            // 
            BtnAnzeigen.Location = new Point(21, 156);
            BtnAnzeigen.Name = "BtnAnzeigen";
            BtnAnzeigen.Size = new Size(75, 23);
            BtnAnzeigen.TabIndex = 1;
            BtnAnzeigen.Text = "Anzeigen";
            BtnAnzeigen.UseVisualStyleBackColor = true;
            BtnAnzeigen.Click += BtnAnzeigen_Click;
            // 
            // LblAnzeigen
            // 
            LblAnzeigen.AutoSize = true;
            LblAnzeigen.Location = new Point(170, 39);
            LblAnzeigen.Name = "LblAnzeigen";
            LblAnzeigen.Size = new Size(38, 15);
            LblAnzeigen.TabIndex = 2;
            LblAnzeigen.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAnzeigen);
            Controls.Add(BtnAnzeigen);
            Controls.Add(LstSpeisen);
            Name = "Form1";
            Text = "ListBox";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LstSpeisen;
        private Button BtnAnzeigen;
        private Label LblAnzeigen;
    }
}
