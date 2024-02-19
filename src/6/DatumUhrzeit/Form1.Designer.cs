// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace DatumUhrzeit
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
            DatPicker = new DateTimePicker();
            LblAusgabe = new Label();
            SuspendLayout();
            // 
            // DatPicker
            // 
            DatPicker.Location = new Point(12, 12);
            DatPicker.Name = "DatPicker";
            DatPicker.ShowUpDown = true;
            DatPicker.Size = new Size(300, 31);
            DatPicker.TabIndex = 0;
            DatPicker.ValueChanged += DatPicker_ValueChanged;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(382, 17);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(59, 25);
            LblAusgabe.TabIndex = 1;
            LblAusgabe.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAusgabe);
            Controls.Add(DatPicker);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker DatPicker;
        private Label LblAusgabe;
    }
}
