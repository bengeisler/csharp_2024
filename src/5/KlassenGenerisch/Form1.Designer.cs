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
            cmdListland = new Button();
            SuspendLayout();
            // 
            // CmdListString
            // 
            CmdListString.Location = new Point(65, 29);
            CmdListString.Name = "CmdListString";
            CmdListString.Size = new Size(75, 23);
            CmdListString.TabIndex = 0;
            CmdListString.Text = "ListString";
            CmdListString.UseVisualStyleBackColor = true;
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(65, 89);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(38, 15);
            LblAnzeige.TabIndex = 1;
            LblAnzeige.Text = "label1";
            // 
            // cmdListland
            // 
            cmdListland.Location = new Point(222, 29);
            cmdListland.Name = "cmdListland";
            cmdListland.Size = new Size(75, 23);
            cmdListland.TabIndex = 2;
            cmdListland.Text = "List Land";
            cmdListland.UseVisualStyleBackColor = true;
            cmdListland.Click += cmdListland_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdListland);
            Controls.Add(LblAnzeige);
            Controls.Add(CmdListString);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdListString;
        private Label LblAnzeige;
        private Button cmdListland;
    }
}
