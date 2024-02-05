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
            TxtGehalt = new TextBox();
            LblSteuer = new Label();
            CmdBerechnen = new Button();
            LblGehalt = new Label();
            SuspendLayout();
            // 
            // TxtGehalt
            // 
            TxtGehalt.Location = new Point(97, 90);
            TxtGehalt.Name = "TxtGehalt";
            TxtGehalt.Size = new Size(247, 23);
            TxtGehalt.TabIndex = 0;
            // 
            // LblSteuer
            // 
            LblSteuer.AutoSize = true;
            LblSteuer.Location = new Point(371, 98);
            LblSteuer.Name = "LblSteuer";
            LblSteuer.Size = new Size(80, 15);
            LblSteuer.TabIndex = 1;
            LblSteuer.Text = "Steuerbetrag: ";
            // 
            // CmdBerechnen
            // 
            CmdBerechnen.Location = new Point(97, 197);
            CmdBerechnen.Name = "CmdBerechnen";
            CmdBerechnen.Size = new Size(143, 23);
            CmdBerechnen.TabIndex = 2;
            CmdBerechnen.Text = "Berechnen mi if .. else";
            CmdBerechnen.UseVisualStyleBackColor = true;
            CmdBerechnen.Click += CmdBerechnen_Click;
            // 
            // LblGehalt
            // 
            LblGehalt.AutoSize = true;
            LblGehalt.Location = new Point(94, 54);
            LblGehalt.Name = "LblGehalt";
            LblGehalt.Size = new Size(44, 15);
            LblGehalt.TabIndex = 3;
            LblGehalt.Text = "Gehalt:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblGehalt);
            Controls.Add(CmdBerechnen);
            Controls.Add(LblSteuer);
            Controls.Add(TxtGehalt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtGehalt;
        private Label LblSteuer;
        private Button CmdBerechnen;
        private Label LblGehalt;
    }
}
