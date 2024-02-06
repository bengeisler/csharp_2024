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
            label1 = new Label();
            TxtGehalt = new TextBox();
            LblSteuerbetrag = new Label();
            CmdRechnen = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 9);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Gehalt";
            // 
            // TxtGehalt
            // 
            TxtGehalt.Location = new Point(35, 27);
            TxtGehalt.Name = "TxtGehalt";
            TxtGehalt.Size = new Size(100, 23);
            TxtGehalt.TabIndex = 1;
            // 
            // LblSteuerbetrag
            // 
            LblSteuerbetrag.AutoSize = true;
            LblSteuerbetrag.Location = new Point(285, 35);
            LblSteuerbetrag.Name = "LblSteuerbetrag";
            LblSteuerbetrag.Size = new Size(38, 15);
            LblSteuerbetrag.TabIndex = 2;
            LblSteuerbetrag.Text = "label2";
            // 
            // CmdRechnen
            // 
            CmdRechnen.Location = new Point(35, 67);
            CmdRechnen.Name = "CmdRechnen";
            CmdRechnen.Size = new Size(150, 23);
            CmdRechnen.TabIndex = 3;
            CmdRechnen.Text = "Berechnen mit if ... else";
            CmdRechnen.UseVisualStyleBackColor = true;
            CmdRechnen.Click += CmdRechnen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdRechnen);
            Controls.Add(LblSteuerbetrag);
            Controls.Add(TxtGehalt);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtGehalt;
        private Label LblSteuerbetrag;
        private Button CmdRechnen;
    }
}
