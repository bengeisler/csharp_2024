// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace USteuerbetrag
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
            cmdBerechnen = new Button();
            LblAnzeigen = new Label();
            txtGehalt = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmdBerechnen
            // 
            cmdBerechnen.Location = new Point(12, 64);
            cmdBerechnen.Name = "cmdBerechnen";
            cmdBerechnen.Size = new Size(150, 23);
            cmdBerechnen.TabIndex = 0;
            cmdBerechnen.Text = "Berechnen mit If ... else";
            cmdBerechnen.UseVisualStyleBackColor = true;
            cmdBerechnen.Click += cmdBerechnen_Click;
            // 
            // LblAnzeigen
            // 
            LblAnzeigen.AutoSize = true;
            LblAnzeigen.Location = new Point(171, 38);
            LblAnzeigen.Name = "LblAnzeigen";
            LblAnzeigen.Size = new Size(38, 15);
            LblAnzeigen.TabIndex = 1;
            LblAnzeigen.Text = "label1";
            // 
            // txtGehalt
            // 
            txtGehalt.Location = new Point(12, 35);
            txtGehalt.Name = "txtGehalt";
            txtGehalt.Size = new Size(124, 23);
            txtGehalt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 3;
            label1.Text = "Gehalt:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtGehalt);
            Controls.Add(LblAnzeigen);
            Controls.Add(cmdBerechnen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdBerechnen;
        private Label LblAnzeigen;
        private TextBox txtGehalt;
        private Label label1;
    }
}
