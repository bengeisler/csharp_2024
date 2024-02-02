// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UDatentypen
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
            LblName = new Label();
            cmdAnzeigen = new Button();
            SuspendLayout();
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(63, 63);
            LblName.Name = "LblName";
            LblName.Size = new Size(38, 15);
            LblName.TabIndex = 0;
            LblName.Text = "label1";
            // 
            // cmdAnzeigen
            // 
            cmdAnzeigen.Location = new Point(484, 63);
            cmdAnzeigen.Name = "cmdAnzeigen";
            cmdAnzeigen.Size = new Size(168, 37);
            cmdAnzeigen.TabIndex = 2;
            cmdAnzeigen.Text = "Anzeigen";
            cmdAnzeigen.UseVisualStyleBackColor = true;
            cmdAnzeigen.Click += cmdAnzeigen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdAnzeigen);
            Controls.Add(LblName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblName;
        private Button cmdAnzeigen;
    }
}
