﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementTextBox
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
            TxtEingabe = new TextBox();
            LblAnzeige = new Label();
            CmdAnzeigen = new Button();
            CmdRechnen = new Button();
            SuspendLayout();
            // 
            // TxtEingabe
            // 
            TxtEingabe.Location = new Point(12, 12);
            TxtEingabe.Name = "TxtEingabe";
            TxtEingabe.Size = new Size(202, 31);
            TxtEingabe.TabIndex = 0;
            TxtEingabe.Text = "Hallo";
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(12, 61);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(59, 25);
            LblAnzeige.TabIndex = 1;
            LblAnzeige.Text = "label1";
            // 
            // CmdAnzeigen
            // 
            CmdAnzeigen.Location = new Point(302, 12);
            CmdAnzeigen.Name = "CmdAnzeigen";
            CmdAnzeigen.Size = new Size(112, 34);
            CmdAnzeigen.TabIndex = 2;
            CmdAnzeigen.Text = "Anzeigen";
            CmdAnzeigen.UseVisualStyleBackColor = true;
            CmdAnzeigen.Click += CmdAnzeigen_Click;
            // 
            // CmdRechnen
            // 
            CmdRechnen.Location = new Point(302, 52);
            CmdRechnen.Name = "CmdRechnen";
            CmdRechnen.Size = new Size(112, 34);
            CmdRechnen.TabIndex = 3;
            CmdRechnen.Text = "Rechnen";
            CmdRechnen.UseVisualStyleBackColor = true;
            CmdRechnen.Click += CmdRechnen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 116);
            Controls.Add(CmdRechnen);
            Controls.Add(CmdAnzeigen);
            Controls.Add(LblAnzeige);
            Controls.Add(TxtEingabe);
            Name = "Form1";
            Text = "TextBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtEingabe;
        private Label LblAnzeige;
        private Button CmdAnzeigen;
        private Button CmdRechnen;
    }
}
