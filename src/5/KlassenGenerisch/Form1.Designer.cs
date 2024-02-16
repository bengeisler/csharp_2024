// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace KlassenGenerisch
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
            BtnListString = new Button();
            LblAnzeige1 = new Label();
            CmdListDone = new Button();
            SuspendLayout();
            // 
            // BtnListString
            // 
            BtnListString.Location = new Point(420, 83);
            BtnListString.Name = "BtnListString";
            BtnListString.Size = new Size(75, 23);
            BtnListString.TabIndex = 0;
            BtnListString.Text = "Anzeigen1";
            BtnListString.UseVisualStyleBackColor = true;
            BtnListString.Click += BtnListString_Click;
            // 
            // LblAnzeige1
            // 
            LblAnzeige1.AutoSize = true;
            LblAnzeige1.Location = new Point(206, 87);
            LblAnzeige1.Name = "LblAnzeige1";
            LblAnzeige1.Size = new Size(38, 15);
            LblAnzeige1.TabIndex = 1;
            LblAnzeige1.Text = "label1";
            // 
            // CmdListDone
            // 
            CmdListDone.Location = new Point(418, 123);
            CmdListDone.Name = "CmdListDone";
            CmdListDone.Size = new Size(104, 47);
            CmdListDone.TabIndex = 2;
            CmdListDone.Text = "Anzeigen2";
            CmdListDone.UseVisualStyleBackColor = true;
            CmdListDone.Click += CmdListDone_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdListDone);
            Controls.Add(LblAnzeige1);
            Controls.Add(BtnListString);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnListString;
        private Label LblAnzeige1;
        private Button CmdListDone;
    }
}
