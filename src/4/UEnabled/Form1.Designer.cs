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
            Listbox1 = new ListBox();
            cmdLoeschen = new Button();
            SuspendLayout();
            // 
            // Listbox1
            // 
            Listbox1.FormattingEnabled = true;
            Listbox1.ItemHeight = 15;
            Listbox1.Items.AddRange(new object[] { "Liechtenstein", "Malta", "Andorra", "San Marino", "Monaco" });
            Listbox1.Location = new Point(71, 90);
            Listbox1.Name = "Listbox1";
            Listbox1.Size = new Size(201, 124);
            Listbox1.TabIndex = 0;
            Listbox1.SelectedIndexChanged += Listbox1_SelectedIndexChanged;
            // 
            // cmdLoeschen
            // 
            cmdLoeschen.Enabled = false;
            cmdLoeschen.Location = new Point(414, 138);
            cmdLoeschen.Name = "cmdLoeschen";
            cmdLoeschen.Size = new Size(75, 23);
            cmdLoeschen.TabIndex = 1;
            cmdLoeschen.Text = "Löschen";
            cmdLoeschen.UseVisualStyleBackColor = true;
            cmdLoeschen.Click += cmdLoeschen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdLoeschen);
            Controls.Add(Listbox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox Listbox1;
        private Button cmdLoeschen;
    }
}
