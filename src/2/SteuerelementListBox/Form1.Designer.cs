// Licensed to the .NET Foundation under one or more agreements.
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
            CmdAnzeigen2 = new Button();
            SuspendLayout();
            // 
            // LstSpeisen
            // 
            LstSpeisen.FormattingEnabled = true;
            LstSpeisen.ItemHeight = 25;
            LstSpeisen.Location = new Point(12, 12);
            LstSpeisen.Name = "LstSpeisen";
            LstSpeisen.Size = new Size(180, 129);
            LstSpeisen.TabIndex = 0;
            LstSpeisen.SelectedIndexChanged += LstSpeisen_SelectedIndexChanged;
            // 
            // CmdAnzeigen
            // 
            CmdAnzeigen.Location = new Point(12, 158);
            CmdAnzeigen.Name = "CmdAnzeigen";
            CmdAnzeigen.Size = new Size(112, 34);
            CmdAnzeigen.TabIndex = 1;
            CmdAnzeigen.Text = "Anzeigen 1";
            CmdAnzeigen.UseVisualStyleBackColor = true;
            CmdAnzeigen.Click += CmdAnzeigen_Click;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(228, 12);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(59, 25);
            LblAusgabe.TabIndex = 2;
            LblAusgabe.Text = "label1";
            // 
            // CmdAnzeigen2
            // 
            CmdAnzeigen2.Location = new Point(12, 198);
            CmdAnzeigen2.Name = "CmdAnzeigen2";
            CmdAnzeigen2.Size = new Size(112, 34);
            CmdAnzeigen2.TabIndex = 3;
            CmdAnzeigen2.Text = "Anzeigen 2";
            CmdAnzeigen2.UseVisualStyleBackColor = true;
            CmdAnzeigen2.Click += CmdAnzeigen2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdAnzeigen2);
            Controls.Add(LblAusgabe);
            Controls.Add(CmdAnzeigen);
            Controls.Add(LstSpeisen);
            Name = "Form1";
            Text = "ListBox";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LstSpeisen;
        private Button CmdAnzeigen;
        private Label LblAusgabe;
        private Button CmdAnzeigen2;
    }
}
