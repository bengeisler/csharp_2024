// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementNummericUpDown
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
            LblAnzeige = new Label();
            NumZahl = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)NumZahl).BeginInit();
            SuspendLayout();
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(590, 64);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(38, 15);
            LblAnzeige.TabIndex = 0;
            LblAnzeige.Text = "label1";
            // 
            // NumZahl
            // 
            NumZahl.Location = new Point(397, 64);
            NumZahl.Name = "NumZahl";
            NumZahl.Size = new Size(120, 23);
            NumZahl.TabIndex = 2;
            NumZahl.ValueChanged += NumZahl_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NumZahl);
            Controls.Add(LblAnzeige);
            Name = "Form1";
            Text = "Zahlenauswahlfeld";
            ((System.ComponentModel.ISupportInitialize)NumZahl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAnzeige;
        private NumericUpDown NumZahl;
    }
}
