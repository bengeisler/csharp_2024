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
            LblAnzeige = new Label();
            CmdListLand = new Button();
            SuspendLayout();
            // 
            // CmdListString
            // 
            CmdListString.Location = new Point(12, 12);
            CmdListString.Name = "CmdListString";
            CmdListString.Size = new Size(112, 34);
            CmdListString.TabIndex = 0;
            CmdListString.Text = "List String";
            CmdListString.UseVisualStyleBackColor = true;
            CmdListString.Click += CmdListString_Click;
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(12, 68);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(59, 25);
            LblAnzeige.TabIndex = 1;
            LblAnzeige.Text = "label1";
            // 
            // CmdListLand
            // 
            CmdListLand.Location = new Point(215, 12);
            CmdListLand.Name = "CmdListLand";
            CmdListLand.Size = new Size(112, 34);
            CmdListLand.TabIndex = 2;
            CmdListLand.Text = "List Land";
            CmdListLand.UseVisualStyleBackColor = true;
            CmdListLand.Click += CmdListLand_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdListLand);
            Controls.Add(LblAnzeige);
            Controls.Add(CmdListString);
            Name = "Form1";
            Text = "Generische Datentypen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdListString;
        private Label LblAnzeige;
        private Button CmdListLand;
    }
}
