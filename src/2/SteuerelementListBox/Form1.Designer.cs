﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementListBox
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
            CmdAnzeigen = new Button();
            LblAusgabe = new Label();
            CmdAnzeige2 = new Button();
            SuspendLayout();
            // 
            // LstSpeisen
            // 
            LstSpeisen.FormattingEnabled = true;
            LstSpeisen.ItemHeight = 15;
            LstSpeisen.Location = new Point(205, 84);
            LstSpeisen.Name = "LstSpeisen";
            LstSpeisen.Size = new Size(255, 139);
            LstSpeisen.TabIndex = 0;
            LstSpeisen.SelectedIndexChanged += LstSpeisen_SelectedIndexChanged;
            // 
            // CmdAnzeigen
            // 
            CmdAnzeigen.Location = new Point(283, 274);
            CmdAnzeigen.Name = "CmdAnzeigen";
            CmdAnzeigen.Size = new Size(75, 23);
            CmdAnzeigen.TabIndex = 1;
            CmdAnzeigen.Text = "Anzeigen";
            CmdAnzeigen.UseVisualStyleBackColor = true;
            CmdAnzeigen.Click += CmdAnzeigen_Click;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(513, 96);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(38, 15);
            LblAusgabe.TabIndex = 2;
            LblAusgabe.Text = "label1";
            // 
            // CmdAnzeige2
            // 
            CmdAnzeige2.Location = new Point(304, 335);
            CmdAnzeige2.Name = "CmdAnzeige2";
            CmdAnzeige2.Size = new Size(75, 23);
            CmdAnzeige2.TabIndex = 3;
            CmdAnzeige2.Text = "button1";
            CmdAnzeige2.UseVisualStyleBackColor = true;
            CmdAnzeige2.Click += CmdAnzeige2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdAnzeige2);
            Controls.Add(LblAusgabe);
            Controls.Add(CmdAnzeigen);
            Controls.Add(LstSpeisen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LstSpeisen;
        private Button CmdAnzeigen;
        private Label LblAusgabe;
        private Button CmdAnzeige2;
    }
}
