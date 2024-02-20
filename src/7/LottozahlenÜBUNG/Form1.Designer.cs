// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace LottozahlenÜBUNG
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
            components = new System.ComponentModel.Container();
            cmdZiehung = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            LstBox = new ListBox();
            TxtBox = new TextBox();
            SuspendLayout();
            // 
            // cmdZiehung
            // 
            cmdZiehung.Location = new Point(112, 31);
            cmdZiehung.Name = "cmdZiehung";
            cmdZiehung.Size = new Size(75, 23);
            cmdZiehung.TabIndex = 0;
            cmdZiehung.Text = "Ziehung";
            cmdZiehung.UseVisualStyleBackColor = true;
            cmdZiehung.Click += cmdZiehung_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // LstBox
            // 
            LstBox.FormattingEnabled = true;
            LstBox.ItemHeight = 15;
            LstBox.Location = new Point(112, 84);
            LstBox.Name = "LstBox";
            LstBox.Size = new Size(120, 94);
            LstBox.TabIndex = 2;
            // 
            // TxtBox
            // 
            TxtBox.Location = new Point(112, 196);
            TxtBox.Name = "TxtBox";
            TxtBox.Size = new Size(100, 23);
            TxtBox.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtBox);
            Controls.Add(LstBox);
            Controls.Add(cmdZiehung);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdZiehung;
        private ContextMenuStrip contextMenuStrip1;
        private ListBox LstBox;
        private TextBox TxtBox;
    }
}
