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
            CmdAnzeigen = new Button();
            CmdRechnen = new Button();
            TxtEingabe = new TextBox();
            LblAusgabe = new Label();
            SuspendLayout();
            // 
            // CmdAnzeigen
            // 
            CmdAnzeigen.Location = new Point(602, 12);
            CmdAnzeigen.Name = "CmdAnzeigen";
            CmdAnzeigen.Size = new Size(140, 58);
            CmdAnzeigen.TabIndex = 0;
            CmdAnzeigen.Text = "Anzeigen";
            CmdAnzeigen.UseVisualStyleBackColor = true;
            CmdAnzeigen.Click += CmdAnzeigen_Click;
            // 
            // CmdRechnen
            // 
            CmdRechnen.Location = new Point(602, 124);
            CmdRechnen.Name = "CmdRechnen";
            CmdRechnen.Size = new Size(140, 58);
            CmdRechnen.TabIndex = 1;
            CmdRechnen.Text = "Rechnen";
            CmdRechnen.UseVisualStyleBackColor = true;
            CmdRechnen.Click += CmdRechnen_Click;
            // 
            // TxtEingabe
            // 
            TxtEingabe.Location = new Point(248, 12);
            TxtEingabe.Name = "TxtEingabe";
            TxtEingabe.Size = new Size(126, 23);
            TxtEingabe.TabIndex = 2;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(248, 124);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(38, 15);
            LblAusgabe.TabIndex = 3;
            LblAusgabe.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 250);
            Controls.Add(LblAusgabe);
            Controls.Add(TxtEingabe);
            Controls.Add(CmdRechnen);
            Controls.Add(CmdAnzeigen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAnzeigen;
        private Button CmdRechnen;
        private TextBox TxtEingabe;
        private Label LblAusgabe;
    }
}
