﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace USchleifeWhile
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
            CmdAnzeigen = new Button();
            LblAnzeigen = new Label();
            TxtBox = new TextBox();
            SuspendLayout();
            // 
            // CmdAnzeigen
            // 
            CmdAnzeigen.Location = new Point(576, 108);
            CmdAnzeigen.Name = "CmdAnzeigen";
            CmdAnzeigen.Size = new Size(162, 51);
            CmdAnzeigen.TabIndex = 0;
            CmdAnzeigen.Text = "Anzeigen";
            CmdAnzeigen.UseVisualStyleBackColor = true;
            CmdAnzeigen.Click += CmdAnzeigen_Click;
            // 
            // LblAnzeigen
            // 
            LblAnzeigen.AutoSize = true;
            LblAnzeigen.Location = new Point(273, 29);
            LblAnzeigen.Name = "LblAnzeigen";
            LblAnzeigen.Size = new Size(38, 15);
            LblAnzeigen.TabIndex = 1;
            LblAnzeigen.Text = "label1";
            // 
            // TxtBox
            // 
            TxtBox.Location = new Point(556, 28);
            TxtBox.Name = "TxtBox";
            TxtBox.Size = new Size(160, 23);
            TxtBox.TabIndex = 2;
            TxtBox.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtBox);
            Controls.Add(LblAnzeigen);
            Controls.Add(CmdAnzeigen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAnzeigen;
        private Label LblAnzeigen;
        private TextBox TxtBox;
    }
}