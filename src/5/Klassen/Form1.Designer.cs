// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Klassen
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
            Lblanzeige = new Label();
            cmdAnzeigen = new Button();
            SuspendLayout();
            // 
            // Lblanzeige
            // 
            Lblanzeige.AutoSize = true;
            Lblanzeige.Location = new Point(36, 21);
            Lblanzeige.Name = "Lblanzeige";
            Lblanzeige.Size = new Size(38, 15);
            Lblanzeige.TabIndex = 0;
            Lblanzeige.Text = "label1";
            // 
            // cmdAnzeigen
            // 
            cmdAnzeigen.Location = new Point(353, 21);
            cmdAnzeigen.Name = "cmdAnzeigen";
            cmdAnzeigen.Size = new Size(75, 23);
            cmdAnzeigen.TabIndex = 1;
            cmdAnzeigen.Text = "Anzeigen";
            cmdAnzeigen.UseVisualStyleBackColor = true;
            cmdAnzeigen.Click += cmdAnzeigen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 267);
            Controls.Add(cmdAnzeigen);
            Controls.Add(Lblanzeige);
            Name = "Form1";
            Text = "Klasse Objekt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lblanzeige;
        private Button cmdAnzeigen;
    }
}
