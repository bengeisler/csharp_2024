﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace DialogEingabeAusgabe
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
            CmdEingabe = new Button();
            LblAusgabe = new Label();
            CmdInfo = new Button();
            CmdJaNein = new Button();
            SuspendLayout();
            // 
            // CmdEingabe
            // 
            CmdEingabe.Location = new Point(12, 12);
            CmdEingabe.Name = "CmdEingabe";
            CmdEingabe.Size = new Size(112, 34);
            CmdEingabe.TabIndex = 0;
            CmdEingabe.Text = "Eingabe";
            CmdEingabe.UseVisualStyleBackColor = true;
            CmdEingabe.Click += CmdEingabe_Click;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(207, 17);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(59, 25);
            LblAusgabe.TabIndex = 1;
            LblAusgabe.Text = "label1";
            // 
            // CmdInfo
            // 
            CmdInfo.Location = new Point(12, 75);
            CmdInfo.Name = "CmdInfo";
            CmdInfo.Size = new Size(112, 34);
            CmdInfo.TabIndex = 2;
            CmdInfo.Text = "Info";
            CmdInfo.UseVisualStyleBackColor = true;
            CmdInfo.Click += CmdInfo_Click;
            // 
            // CmdJaNein
            // 
            CmdJaNein.Location = new Point(130, 75);
            CmdJaNein.Name = "CmdJaNein";
            CmdJaNein.Size = new Size(112, 34);
            CmdJaNein.TabIndex = 3;
            CmdJaNein.Text = "Ja/Nein";
            CmdJaNein.UseVisualStyleBackColor = true;
            CmdJaNein.Click += CmdJaNein_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdJaNein);
            Controls.Add(CmdInfo);
            Controls.Add(LblAusgabe);
            Controls.Add(CmdEingabe);
            Name = "Form1";
            Text = "Eingabe & Ausgabe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdEingabe;
        private Label LblAusgabe;
        private Button CmdInfo;
        private Button CmdJaNein;
    }
}
