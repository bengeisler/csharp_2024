// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UEnabled
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
            LstBox = new ListBox();
            cmdLoeschen = new Button();
            SuspendLayout();
            // 
            // LstBox
            // 
            LstBox.FormattingEnabled = true;
            LstBox.ItemHeight = 15;
            LstBox.Items.AddRange(new object[] { "Liechtenstein", "Malta", "Andorra", "San Marino", "Monaco" });
            LstBox.Location = new Point(32, 37);
            LstBox.Name = "LstBox";
            LstBox.Size = new Size(175, 184);
            LstBox.TabIndex = 0;
            LstBox.SelectedIndexChanged += LstBox_SelectedIndexChanged;
            // 
            // cmdLoeschen
            // 
            cmdLoeschen.Location = new Point(291, 52);
            cmdLoeschen.Name = "cmdLoeschen";
            cmdLoeschen.Size = new Size(146, 53);
            cmdLoeschen.TabIndex = 1;
            cmdLoeschen.Text = "&Löschen";
            cmdLoeschen.UseVisualStyleBackColor = true;
            cmdLoeschen.Click += cmdLoeschen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdLoeschen);
            Controls.Add(LstBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox LstBox;
        private Button cmdLoeschen;
    }
}
