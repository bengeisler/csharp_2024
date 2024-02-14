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
            lstbox = new ListBox();
            btnloeschen = new Button();
            SuspendLayout();
            // 
            // lstbox
            // 
            lstbox.FormattingEnabled = true;
            lstbox.ItemHeight = 15;
            lstbox.Items.AddRange(new object[] { "Liechtenstein", "Malta", "Andorra", "San Marino", "Monaco" });
            lstbox.Location = new Point(12, 12);
            lstbox.Name = "lstbox";
            lstbox.Size = new Size(120, 94);
            lstbox.TabIndex = 0;
            lstbox.SelectedIndexChanged += lstbox_SelectedIndexChanged;
            // 
            // btnloeschen
            // 
            btnloeschen.Enabled = false;
            btnloeschen.Location = new Point(152, 12);
            btnloeschen.Name = "btnloeschen";
            btnloeschen.Size = new Size(75, 23);
            btnloeschen.TabIndex = 1;
            btnloeschen.Text = "Löschen";
            btnloeschen.UseVisualStyleBackColor = true;
            btnloeschen.Click += btnloeschen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnloeschen);
            Controls.Add(lstbox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstbox;
        private Button btnloeschen;
    }
}
