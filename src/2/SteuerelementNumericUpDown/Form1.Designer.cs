﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementNumericUpDown
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
            NumZahl = new NumericUpDown();
            LblAnzeige = new Label();
            ((System.ComponentModel.ISupportInitialize)NumZahl).BeginInit();
            SuspendLayout();
            // 
            // NumZahl
            // 
            NumZahl.DecimalPlaces = 1;
            NumZahl.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            NumZahl.Location = new Point(12, 12);
            NumZahl.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            NumZahl.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            NumZahl.Name = "NumZahl";
            NumZahl.Size = new Size(180, 31);
            NumZahl.TabIndex = 0;
            NumZahl.ValueChanged += NumZahl_ValueChanged;
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(293, 14);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(59, 25);
            LblAnzeige.TabIndex = 1;
            LblAnzeige.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 66);
            Controls.Add(LblAnzeige);
            Controls.Add(NumZahl);
            Name = "Form1";
            Text = "Zahlenauswahlfeld";
            ((System.ComponentModel.ISupportInitialize)NumZahl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown NumZahl;
        private Label LblAnzeige;
    }
}
