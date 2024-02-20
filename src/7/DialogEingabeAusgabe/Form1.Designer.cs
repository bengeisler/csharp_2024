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
            LblAusgabe = new Label();
            CmdInfo = new Button();
            CmdYesNo = new Button();
            SuspendLayout();
            // 
            // CmdEingabe
            // 
            CmdEingabe.Location = new Point(500, 79);
            CmdEingabe.Name = "CmdEingabe";
            CmdEingabe.Size = new Size(75, 23);
            CmdEingabe.TabIndex = 0;
            CmdEingabe.Text = "Eingabe";
            CmdEingabe.UseVisualStyleBackColor = true;
            CmdEingabe.Click += CmdEingabe_Click;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(182, 83);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(38, 15);
            LblAusgabe.TabIndex = 1;
            LblAusgabe.Text = "label1";
            // 
            // CmdInfo
            // 
            CmdInfo.Location = new Point(500, 126);
            CmdInfo.Name = "CmdInfo";
            CmdInfo.Size = new Size(75, 34);
            CmdInfo.TabIndex = 2;
            CmdInfo.Text = "Info";
            CmdInfo.UseVisualStyleBackColor = true;
            CmdInfo.Click += CmdInfo_Click;
            // 
            // CmdYesNo
            // 
            CmdYesNo.Location = new Point(500, 185);
            CmdYesNo.Name = "CmdYesNo";
            CmdYesNo.Size = new Size(75, 23);
            CmdYesNo.TabIndex = 3;
            CmdYesNo.Text = "Ja/Nein";
            CmdYesNo.UseVisualStyleBackColor = true;
            CmdYesNo.Click += CmdYesNo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdYesNo);
            Controls.Add(CmdInfo);
            Controls.Add(LblAusgabe);
            Controls.Add(CmdEingabe);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdEingabe;
        private Label LblAusgabe;
        private Button CmdInfo;
        private Button CmdYesNo;
    }
}
