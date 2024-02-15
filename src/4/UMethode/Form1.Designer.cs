// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UMethode
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
            btnAnzeigen1 = new Button();
            LblAusgabe1 = new Label();
            LblAusgabe2 = new Label();
            SuspendLayout();
            // 
            // btnAnzeigen1
            // 
            btnAnzeigen1.Location = new Point(172, 9);
            btnAnzeigen1.Name = "btnAnzeigen1";
            btnAnzeigen1.Size = new Size(75, 23);
            btnAnzeigen1.TabIndex = 0;
            btnAnzeigen1.Text = "Anzeigen 1";
            btnAnzeigen1.UseVisualStyleBackColor = true;
            btnAnzeigen1.Click += btnAnzeigen1_Click;
            // 
            // LblAusgabe1
            // 
            LblAusgabe1.AutoSize = true;
            LblAusgabe1.Location = new Point(12, 9);
            LblAusgabe1.Name = "LblAusgabe1";
            LblAusgabe1.Size = new Size(38, 15);
            LblAusgabe1.TabIndex = 1;
            LblAusgabe1.Text = "label1";
            // 
            // LblAusgabe2
            // 
            LblAusgabe2.AutoSize = true;
            LblAusgabe2.Location = new Point(12, 39);
            LblAusgabe2.Name = "LblAusgabe2";
            LblAusgabe2.Size = new Size(38, 15);
            LblAusgabe2.TabIndex = 2;
            LblAusgabe2.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAusgabe2);
            Controls.Add(LblAusgabe1);
            Controls.Add(btnAnzeigen1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAnzeigen1;
        private Label LblAusgabe1;
        private Label LblAusgabe2;
    }
}
