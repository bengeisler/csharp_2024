// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementTextBox
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
            BtnAnzeige = new Button();
            TxtEingabe = new TextBox();
            BtnRechnen = new Button();
            LblAusgabe = new Label();
            SuspendLayout();
            // 
            // BtnAnzeige
            // 
            BtnAnzeige.Location = new Point(207, 12);
            BtnAnzeige.Name = "BtnAnzeige";
            BtnAnzeige.Size = new Size(75, 23);
            BtnAnzeige.TabIndex = 0;
            BtnAnzeige.Text = "Anzeige";
            BtnAnzeige.UseVisualStyleBackColor = true;
            BtnAnzeige.Click += BtnAnzeige_Click;
            // 
            // TxtEingabe
            // 
            TxtEingabe.Location = new Point(12, 12);
            TxtEingabe.Name = "TxtEingabe";
            TxtEingabe.Size = new Size(100, 23);
            TxtEingabe.TabIndex = 1;
            // 
            // BtnRechnen
            // 
            BtnRechnen.Location = new Point(207, 41);
            BtnRechnen.Name = "BtnRechnen";
            BtnRechnen.Size = new Size(75, 23);
            BtnRechnen.TabIndex = 2;
            BtnRechnen.Text = "Rechnen";
            BtnRechnen.UseVisualStyleBackColor = true;
            BtnRechnen.Click += BtnRechnen_Click;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(12, 45);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(38, 15);
            LblAusgabe.TabIndex = 3;
            LblAusgabe.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAusgabe);
            Controls.Add(BtnRechnen);
            Controls.Add(TxtEingabe);
            Controls.Add(BtnAnzeige);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAnzeige;
        private TextBox TxtEingabe;
        private Button BtnRechnen;
        private Label LblAusgabe;
    }
}
