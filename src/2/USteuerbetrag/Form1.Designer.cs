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
            CmdIfElse = new Button();
            LblAnzeigen = new Label();
            label2 = new Label();
            TxtEingabe = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)TxtEingabe).BeginInit();
            SuspendLayout();
            // 
            // CmdIfElse
            // 
            CmdIfElse.Location = new Point(307, 291);
            CmdIfElse.Name = "CmdIfElse";
            CmdIfElse.Size = new Size(290, 49);
            CmdIfElse.TabIndex = 0;
            CmdIfElse.Text = "Berechnen mit if ...else";
            CmdIfElse.UseVisualStyleBackColor = true;
            CmdIfElse.Click += CmdIfElse_Click;
            // 
            // LblAnzeigen
            // 
            LblAnzeigen.AutoSize = true;
            LblAnzeigen.Location = new Point(576, 201);
            LblAnzeigen.Name = "LblAnzeigen";
            LblAnzeigen.Size = new Size(38, 15);
            LblAnzeigen.TabIndex = 1;
            LblAnzeigen.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(312, 140);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 3;
            label2.Text = "Gehalt:";
            // 
            // TxtEingabe
            // 
            TxtEingabe.Location = new Point(312, 201);
            TxtEingabe.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            TxtEingabe.Name = "TxtEingabe";
            TxtEingabe.Size = new Size(120, 23);
            TxtEingabe.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtEingabe);
            Controls.Add(label2);
            Controls.Add(LblAnzeigen);
            Controls.Add(CmdIfElse);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)TxtEingabe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdIfElse;
        private Label LblAnzeigen;
        private Label label2;
        private NumericUpDown TxtEingabe;
    }
}
