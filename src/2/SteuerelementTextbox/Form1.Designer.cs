// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementTextbox
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
            TxtBox = new TextBox();
            LblAnzeigen = new Label();
            CmdAnzeigen1 = new Button();
            CmdAnzeigen2 = new Button();
            SuspendLayout();
            // 
            // TxtBox
            // 
            TxtBox.Location = new Point(12, 12);
            TxtBox.Multiline = true;
            TxtBox.Name = "TxtBox";
            TxtBox.ScrollBars = ScrollBars.Vertical;
            TxtBox.Size = new Size(250, 30);
            TxtBox.TabIndex = 0;
            // 
            // LblAnzeigen
            // 
            LblAnzeigen.AutoSize = true;
            LblAnzeigen.Location = new Point(12, 93);
            LblAnzeigen.Name = "LblAnzeigen";
            LblAnzeigen.Size = new Size(56, 15);
            LblAnzeigen.TabIndex = 1;
            LblAnzeigen.Text = "Anzeigen";
            // 
            // CmdAnzeigen1
            // 
            CmdAnzeigen1.Location = new Point(455, 11);
            CmdAnzeigen1.Name = "CmdAnzeigen1";
            CmdAnzeigen1.Size = new Size(75, 23);
            CmdAnzeigen1.TabIndex = 2;
            CmdAnzeigen1.Text = "Anzeigen";
            CmdAnzeigen1.UseVisualStyleBackColor = true;
            CmdAnzeigen1.Click += CmdAnzeigen1_Click;
            // 
            // CmdAnzeigen2
            // 
            CmdAnzeigen2.Location = new Point(455, 44);
            CmdAnzeigen2.Name = "CmdAnzeigen2";
            CmdAnzeigen2.Size = new Size(75, 23);
            CmdAnzeigen2.TabIndex = 3;
            CmdAnzeigen2.Text = "Rechnen";
            CmdAnzeigen2.UseVisualStyleBackColor = true;
            CmdAnzeigen2.Click += CmdAnzeigen2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 277);
            Controls.Add(CmdAnzeigen2);
            Controls.Add(CmdAnzeigen1);
            Controls.Add(LblAnzeigen);
            Controls.Add(TxtBox);
            Name = "Form1";
            Text = "TextBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBox;
        private Label LblAnzeigen;
        private Button CmdAnzeigen1;
        private Button CmdAnzeigen2;
    }
}
