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
            LstStaaten = new ListBox();
            CmdLöschen = new Button();
            SuspendLayout();
            // 
            // LstStaaten
            // 
            LstStaaten.FormattingEnabled = true;
            LstStaaten.ItemHeight = 25;
            LstStaaten.Items.AddRange(new object[] { "Liechtenstein", "Malta", "Andorra", "San Marino", "Monaco" });
            LstStaaten.Location = new Point(12, 12);
            LstStaaten.Name = "LstStaaten";
            LstStaaten.Size = new Size(180, 129);
            LstStaaten.TabIndex = 0;
            LstStaaten.SelectedIndexChanged += LstStaaten_SelectedIndexChanged;
            // 
            // CmdLöschen
            // 
            CmdLöschen.Enabled = false;
            CmdLöschen.Location = new Point(213, 12);
            CmdLöschen.Name = "CmdLöschen";
            CmdLöschen.Size = new Size(112, 34);
            CmdLöschen.TabIndex = 1;
            CmdLöschen.Text = "Löschen";
            CmdLöschen.UseVisualStyleBackColor = true;
            CmdLöschen.Click += CmdLöschen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 173);
            Controls.Add(CmdLöschen);
            Controls.Add(LstStaaten);
            Name = "Form1";
            Text = "Enabled";
            ResumeLayout(false);
        }

        #endregion

        private ListBox LstStaaten;
        private Button CmdLöschen;
    }
}
