// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace KlassenKonsturktoren
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
            cmdAnzeigen = new Button();
            lblAnzeigen = new Label();
            SuspendLayout();
            // 
            // cmdAnzeigen
            // 
            cmdAnzeigen.Location = new Point(271, 60);
            cmdAnzeigen.Name = "cmdAnzeigen";
            cmdAnzeigen.Size = new Size(75, 23);
            cmdAnzeigen.TabIndex = 0;
            cmdAnzeigen.Text = "Anzeigen";
            cmdAnzeigen.UseVisualStyleBackColor = true;
            cmdAnzeigen.Click += cmdAnzeigen_Click;
            // 
            // lblAnzeigen
            // 
            lblAnzeigen.AutoSize = true;
            lblAnzeigen.Location = new Point(56, 68);
            lblAnzeigen.Name = "lblAnzeigen";
            lblAnzeigen.Size = new Size(38, 15);
            lblAnzeigen.TabIndex = 1;
            lblAnzeigen.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAnzeigen);
            Controls.Add(cmdAnzeigen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdAnzeigen;
        private Label lblAnzeigen;
    }
}
