﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenDatentypen
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
            CmdLabel = new Label();
            CmdAnzeigen = new Button();
            SuspendLayout();
            // 
            // CmdLabel
            // 
            CmdLabel.AutoSize = true;
            CmdLabel.Location = new Point(94, 32);
            CmdLabel.Name = "CmdLabel";
            CmdLabel.Size = new Size(38, 15);
            CmdLabel.TabIndex = 0;
            CmdLabel.Text = "label1";
            // 
            // CmdAnzeigen
            // 
            CmdAnzeigen.Location = new Point(672, 32);
            CmdAnzeigen.Name = "CmdAnzeigen";
            CmdAnzeigen.Size = new Size(75, 23);
            CmdAnzeigen.TabIndex = 1;
            CmdAnzeigen.Text = "Aneigen";
            CmdAnzeigen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdAnzeigen);
            Controls.Add(CmdLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CmdLabel;
        private Button CmdAnzeigen;
    }
}