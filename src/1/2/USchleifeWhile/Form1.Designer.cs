// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace USchleifeWhile
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
            LblAnzeigen1 = new Label();
            txtZahl = new TextBox();
            SuspendLayout();
            // 
            // cmdAnzeigen
            // 
            cmdAnzeigen.Location = new Point(178, 51);
            cmdAnzeigen.Name = "cmdAnzeigen";
            cmdAnzeigen.Size = new Size(75, 23);
            cmdAnzeigen.TabIndex = 0;
            cmdAnzeigen.Text = "Anzeigen";
            cmdAnzeigen.UseVisualStyleBackColor = true;
            cmdAnzeigen.Click += cmdAnzeigen_Click;
            // 
            // LblAnzeigen1
            // 
            LblAnzeigen1.AutoSize = true;
            LblAnzeigen1.Location = new Point(32, 20);
            LblAnzeigen1.Name = "LblAnzeigen1";
            LblAnzeigen1.Size = new Size(38, 15);
            LblAnzeigen1.TabIndex = 1;
            LblAnzeigen1.Text = "label1";
            // 
            // txtZahl
            // 
            txtZahl.Location = new Point(178, 12);
            txtZahl.Name = "txtZahl";
            txtZahl.Size = new Size(140, 23);
            txtZahl.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtZahl);
            Controls.Add(LblAnzeigen1);
            Controls.Add(cmdAnzeigen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdAnzeigen;
        private Label LblAnzeigen1;
        private TextBox txtZahl;
    }
}
