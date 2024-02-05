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
            CmdBerechnen = new Button();
            label1 = new Label();
            LblSteuerbetrag = new Label();
            txtGehalt = new TextBox();
            SuspendLayout();
            // 
            // CmdBerechnen
            // 
            CmdBerechnen.Location = new Point(108, 242);
            CmdBerechnen.Name = "CmdBerechnen";
            CmdBerechnen.Size = new Size(281, 51);
            CmdBerechnen.TabIndex = 0;
            CmdBerechnen.Text = "Berechnen mit if else";
            CmdBerechnen.UseVisualStyleBackColor = true;
            CmdBerechnen.Click += CmdBerechnen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 137);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Gehalt:";
            // 
            // LblSteuerbetrag
            // 
            LblSteuerbetrag.AutoSize = true;
            LblSteuerbetrag.Location = new Point(450, 197);
            LblSteuerbetrag.Name = "LblSteuerbetrag";
            LblSteuerbetrag.Size = new Size(77, 15);
            LblSteuerbetrag.TabIndex = 2;
            LblSteuerbetrag.Text = "Steuerbetrag:";
            LblSteuerbetrag.Click += label2_Click;
            // 
            // txtGehalt
            // 
            txtGehalt.Location = new Point(115, 162);
            txtGehalt.Name = "txtGehalt";
            txtGehalt.Size = new Size(206, 23);
            txtGehalt.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtGehalt);
            Controls.Add(LblSteuerbetrag);
            Controls.Add(label1);
            Controls.Add(CmdBerechnen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdBerechnen;
        private Label label1;
        private Label LblSteuerbetrag;
        private TextBox txtGehalt;
    }
}
