// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace klassenGenerisch
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
            CmdListsring = new Button();
            LblAnzeige = new Label();
            CmdListLand = new Button();
            SuspendLayout();
            // 
            // CmdListsring
            // 
            CmdListsring.Location = new Point(56, 63);
            CmdListsring.Name = "CmdListsring";
            CmdListsring.Size = new Size(75, 23);
            CmdListsring.TabIndex = 0;
            CmdListsring.Text = "ListString";
            CmdListsring.UseVisualStyleBackColor = true;
            CmdListsring.Click += CmdListsring_Click;
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(69, 137);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(38, 15);
            LblAnzeige.TabIndex = 1;
            LblAnzeige.Text = "label1";
            // 
            // CmdListLand
            // 
            CmdListLand.Location = new Point(56, 25);
            CmdListLand.Name = "CmdListLand";
            CmdListLand.Size = new Size(75, 23);
            CmdListLand.TabIndex = 2;
            CmdListLand.Text = "Land";
            CmdListLand.UseVisualStyleBackColor = true;
            CmdListLand.Click += CmdListLand_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdListLand);
            Controls.Add(LblAnzeige);
            Controls.Add(CmdListsring);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdListsring;
        private Label LblAnzeige;
        private Button CmdListLand;
    }
}
