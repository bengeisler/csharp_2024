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
            CmdListString = new Button();
            lblAnzeige = new Label();
            CmdListLand = new Button();
            SuspendLayout();
            // 
            // CmdListString
            // 
            CmdListString.Location = new Point(74, 54);
            CmdListString.Name = "CmdListString";
            CmdListString.Size = new Size(75, 23);
            CmdListString.TabIndex = 0;
            CmdListString.Text = "button1";
            CmdListString.UseVisualStyleBackColor = true;
            CmdListString.Click += CmdListString_Click;
            // 
            // lblAnzeige
            // 
            lblAnzeige.AutoSize = true;
            lblAnzeige.Location = new Point(84, 127);
            lblAnzeige.Name = "lblAnzeige";
            lblAnzeige.Size = new Size(38, 15);
            lblAnzeige.TabIndex = 1;
            lblAnzeige.Text = "label1";
            // 
            // CmdListLand
            // 
            CmdListLand.Location = new Point(279, 65);
            CmdListLand.Name = "CmdListLand";
            CmdListLand.Size = new Size(75, 23);
            CmdListLand.TabIndex = 2;
            CmdListLand.Text = "List Land";
            CmdListLand.UseVisualStyleBackColor = true;
            CmdListLand.Click += CmdListLand_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 427);
            Controls.Add(CmdListLand);
            Controls.Add(lblAnzeige);
            Controls.Add(CmdListString);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdListString;
        private Label lblAnzeige;
        private Button CmdListLand;
    }
}
