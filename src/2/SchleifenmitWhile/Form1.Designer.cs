﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SchleifenmitWhile
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
            CmdAnzeige = new Button();
            TxtEingabe = new TextBox();
            LblAusgabe = new Label();
            SuspendLayout();
            // 
            // CmdAnzeige
            // 
            CmdAnzeige.Location = new Point(269, 82);
            CmdAnzeige.Name = "CmdAnzeige";
            CmdAnzeige.Size = new Size(75, 23);
            CmdAnzeige.TabIndex = 0;
            CmdAnzeige.Text = "button1";
            CmdAnzeige.UseVisualStyleBackColor = true;
            CmdAnzeige.Click += CmdAnzeige_Click;
            // 
            // TxtEingabe
            // 
            TxtEingabe.Location = new Point(107, 81);
            TxtEingabe.Name = "TxtEingabe";
            TxtEingabe.Size = new Size(100, 23);
            TxtEingabe.TabIndex = 1;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(145, 168);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(38, 15);
            LblAusgabe.TabIndex = 2;
            LblAusgabe.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAusgabe);
            Controls.Add(TxtEingabe);
            Controls.Add(CmdAnzeige);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAnzeige;
        private TextBox TxtEingabe;
        private Label LblAusgabe;
    }
}
