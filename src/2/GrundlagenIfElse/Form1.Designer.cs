﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenIfElse
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
            LblAusgabe = new Label();
            CmdAnzeigen1 = new Button();
            CmdAnzeigen2 = new Button();
            ((System.ComponentModel.ISupportInitialize)NumZahl).BeginInit();
            SuspendLayout();
            // 
            // NumZahl
            // 
            NumZahl.Location = new Point(12, 12);
            NumZahl.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            NumZahl.Name = "NumZahl";
            NumZahl.Size = new Size(180, 31);
            NumZahl.TabIndex = 0;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(15, 64);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(59, 25);
            LblAusgabe.TabIndex = 1;
            LblAusgabe.Text = "label1";
            // 
            // CmdAnzeigen1
            // 
            CmdAnzeigen1.Location = new Point(288, 12);
            CmdAnzeigen1.Name = "CmdAnzeigen1";
            CmdAnzeigen1.Size = new Size(112, 34);
            CmdAnzeigen1.TabIndex = 2;
            CmdAnzeigen1.Text = "Anzeigen 1";
            CmdAnzeigen1.UseVisualStyleBackColor = true;
            CmdAnzeigen1.Click += CmdAnzeigen1_Click;
            // 
            // CmdAnzeigen2
            // 
            CmdAnzeigen2.Location = new Point(288, 55);
            CmdAnzeigen2.Name = "CmdAnzeigen2";
            CmdAnzeigen2.Size = new Size(112, 34);
            CmdAnzeigen2.TabIndex = 3;
            CmdAnzeigen2.Text = "Anzeigen 2";
            CmdAnzeigen2.UseVisualStyleBackColor = true;
            CmdAnzeigen2.Click += CmdAnzeigen2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 143);
            Controls.Add(CmdAnzeigen2);
            Controls.Add(CmdAnzeigen1);
            Controls.Add(LblAusgabe);
            Controls.Add(NumZahl);
            Name = "Form1";
            Text = "Grundlagen If Else";
            ((System.ComponentModel.ISupportInitialize)NumZahl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown NumZahl;
        private Label LblAusgabe;
        private Button CmdAnzeigen1;
        private Button CmdAnzeigen2;
    }
}
