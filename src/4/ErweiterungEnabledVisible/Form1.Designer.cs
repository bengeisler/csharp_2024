// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace ErweiterungEnabledVisible
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
            LstStädte = new ListBox();
            cmdLöschen = new Button();
            SuspendLayout();
            // 
            // LstStädte
            // 
            LstStädte.FormattingEnabled = true;
            LstStädte.ItemHeight = 15;
            LstStädte.Items.AddRange(new object[] { "Liechtenstein", "Malta", "Andorra", "San Marino", "Monaco" });
            LstStädte.Location = new Point(43, 30);
            LstStädte.Name = "LstStädte";
            LstStädte.Size = new Size(120, 94);
            LstStädte.TabIndex = 0;
            LstStädte.SelectedIndexChanged += LstStädte_SelectedIndexChanged;
            // 
            // cmdLöschen
            // 
            cmdLöschen.Location = new Point(219, 30);
            cmdLöschen.Name = "cmdLöschen";
            cmdLöschen.Size = new Size(75, 23);
            cmdLöschen.TabIndex = 1;
            cmdLöschen.Text = "&löschen";
            cmdLöschen.UseVisualStyleBackColor = true;
            cmdLöschen.Click += cmdLöschen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdLöschen);
            Controls.Add(LstStädte);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox LstStädte;
        private Button cmdLöschen;
    }
}
