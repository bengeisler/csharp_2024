﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace IfElse
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
            Numtext = new NumericUpDown();
            LblAnzeige = new Label();
            CmdAnzeige1 = new Button();
            AmdAnzeigen2 = new Button();
            ((System.ComponentModel.ISupportInitialize)Numtext).BeginInit();
            SuspendLayout();
            // 
            // Numtext
            // 
            Numtext.Location = new Point(12, 12);
            Numtext.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            Numtext.Name = "Numtext";
            Numtext.Size = new Size(120, 23);
            Numtext.TabIndex = 0;
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(203, 14);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(38, 15);
            LblAnzeige.TabIndex = 1;
            LblAnzeige.Text = "label1";
            // 
            // CmdAnzeige1
            // 
            CmdAnzeige1.Location = new Point(449, 28);
            CmdAnzeige1.Name = "CmdAnzeige1";
            CmdAnzeige1.Size = new Size(75, 23);
            CmdAnzeige1.TabIndex = 2;
            CmdAnzeige1.Text = "Anzeige1";
            CmdAnzeige1.UseVisualStyleBackColor = true;
            CmdAnzeige1.Click += CmdAnzeige1_Click;
            // 
            // AmdAnzeigen2
            // 
            AmdAnzeigen2.Location = new Point(449, 66);
            AmdAnzeigen2.Name = "AmdAnzeigen2";
            AmdAnzeigen2.Size = new Size(75, 23);
            AmdAnzeigen2.TabIndex = 3;
            AmdAnzeigen2.Text = "Anzeige2";
            AmdAnzeigen2.UseVisualStyleBackColor = true;
            AmdAnzeigen2.Click += AmdAnzeigen2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AmdAnzeigen2);
            Controls.Add(CmdAnzeige1);
            Controls.Add(LblAnzeige);
            Controls.Add(Numtext);
            Name = "Form1";
            Text = "If Else";
            ((System.ComponentModel.ISupportInitialize)Numtext).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown Numtext;
        private Label LblAnzeige;
        private Button CmdAnzeige1;
        private Button AmdAnzeigen2;
    }
}