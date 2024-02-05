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
            TxtEingabe = new TextBox();
            cmdAnzeigen = new Button();
            cmdRechnen = new Button();
            LblAnzeigen = new Label();
            SuspendLayout();
            // 
            // TxtEingabe
            // 
            TxtEingabe.Location = new Point(12, 25);
            TxtEingabe.Name = "TxtEingabe";
            TxtEingabe.Size = new Size(178, 23);
            TxtEingabe.TabIndex = 0;
            TxtEingabe.Text = "hallo";
            // 
            // cmdAnzeigen
            // 
            cmdAnzeigen.Location = new Point(226, 25);
            cmdAnzeigen.Name = "cmdAnzeigen";
            cmdAnzeigen.Size = new Size(75, 23);
            cmdAnzeigen.TabIndex = 1;
            cmdAnzeigen.Text = "Anzeigen";
            cmdAnzeigen.UseVisualStyleBackColor = true;
            cmdAnzeigen.Click += cmdAnzeigen_Click;
            // 
            // cmdRechnen
            // 
            cmdRechnen.Location = new Point(226, 54);
            cmdRechnen.Name = "cmdRechnen";
            cmdRechnen.Size = new Size(75, 23);
            cmdRechnen.TabIndex = 2;
            cmdRechnen.Text = "Rechnen";
            cmdRechnen.UseVisualStyleBackColor = true;
            cmdRechnen.Click += cmdRechnen_Click;
            // 
            // LblAnzeigen
            // 
            LblAnzeigen.AutoSize = true;
            LblAnzeigen.Location = new Point(12, 62);
            LblAnzeigen.Name = "LblAnzeigen";
            LblAnzeigen.Size = new Size(38, 15);
            LblAnzeigen.TabIndex = 3;
            LblAnzeigen.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAnzeigen);
            Controls.Add(cmdRechnen);
            Controls.Add(cmdAnzeigen);
            Controls.Add(TxtEingabe);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtEingabe;
        private Button cmdAnzeigen;
        private Button cmdRechnen;
        private Label LblAnzeigen;
    }
}
