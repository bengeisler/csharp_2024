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
            CmdEingabe = new Button();
            LblAngabe = new Label();
            CmdInfo = new Button();
            CmdJaNein = new Button();
            SuspendLayout();
            // 
            // CmdEingabe
            // 
            CmdEingabe.Location = new Point(12, 19);
            CmdEingabe.Name = "CmdEingabe";
            CmdEingabe.Size = new Size(75, 23);
            CmdEingabe.TabIndex = 0;
            CmdEingabe.Text = "Eingabe";
            CmdEingabe.UseVisualStyleBackColor = true;
            CmdEingabe.Click += CmdEingabe_Click;
            // 
            // LblAngabe
            // 
            LblAngabe.AutoSize = true;
            LblAngabe.Location = new Point(254, 23);
            LblAngabe.Name = "LblAngabe";
            LblAngabe.Size = new Size(38, 15);
            LblAngabe.TabIndex = 1;
            LblAngabe.Text = "label1";
            // 
            // CmdInfo
            // 
            CmdInfo.Location = new Point(12, 62);
            CmdInfo.Name = "CmdInfo";
            CmdInfo.Size = new Size(75, 23);
            CmdInfo.TabIndex = 2;
            CmdInfo.Text = "Info";
            CmdInfo.UseVisualStyleBackColor = true;
            CmdInfo.Click += CmdInfo_Click;
            // 
            // CmdJaNein
            // 
            CmdJaNein.Location = new Point(93, 62);
            CmdJaNein.Name = "CmdJaNein";
            CmdJaNein.Size = new Size(75, 23);
            CmdJaNein.TabIndex = 3;
            CmdJaNein.Text = "Ja/Nein";
            CmdJaNein.UseVisualStyleBackColor = true;
            CmdJaNein.Click += CmdJaNein_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdJaNein);
            Controls.Add(CmdInfo);
            Controls.Add(LblAngabe);
            Controls.Add(CmdEingabe);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdEingabe;
        private Label LblAngabe;
        private Button CmdInfo;
        private Button CmdJaNein;
    }
}
