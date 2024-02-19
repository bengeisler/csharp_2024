// Licensed to the .NET Foundation under one or more agreements.
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
            BtnEingabe = new Button();
            LblAusgabe = new Label();
            BtnInfo = new Button();
            BtnJaNein = new Button();
            SuspendLayout();
            // 
            // BtnEingabe
            // 
            BtnEingabe.Location = new Point(12, 12);
            BtnEingabe.Name = "BtnEingabe";
            BtnEingabe.Size = new Size(75, 23);
            BtnEingabe.TabIndex = 0;
            BtnEingabe.Text = "Eingabe";
            BtnEingabe.UseVisualStyleBackColor = true;
            BtnEingabe.Click += BtnEingabe_Click;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(108, 16);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(38, 15);
            LblAusgabe.TabIndex = 1;
            LblAusgabe.Text = "label1";
            // 
            // BtnInfo
            // 
            BtnInfo.Location = new Point(12, 41);
            BtnInfo.Name = "BtnInfo";
            BtnInfo.Size = new Size(75, 23);
            BtnInfo.TabIndex = 2;
            BtnInfo.Text = "Info";
            BtnInfo.UseVisualStyleBackColor = true;
            BtnInfo.Click += BtnInfo_Click;
            // 
            // BtnJaNein
            // 
            BtnJaNein.Location = new Point(93, 41);
            BtnJaNein.Name = "BtnJaNein";
            BtnJaNein.Size = new Size(75, 23);
            BtnJaNein.TabIndex = 3;
            BtnJaNein.Text = "Ja/Nein";
            BtnJaNein.UseVisualStyleBackColor = true;
            BtnJaNein.Click += BtnJaNein_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnJaNein);
            Controls.Add(BtnInfo);
            Controls.Add(LblAusgabe);
            Controls.Add(BtnEingabe);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnEingabe;
        private Label LblAusgabe;
        private Button BtnInfo;
        private Button BtnJaNein;
    }
}
