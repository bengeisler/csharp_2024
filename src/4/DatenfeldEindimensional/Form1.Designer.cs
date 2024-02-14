// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace DatenfeldEindimensional
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
            LstWerte = new ListBox();
            cmdAnzeigen = new Label();
            LblAusgabe = new Label();
            cmdAnzeigen2 = new Label();
            cmdAnzeigen3 = new Button();
            SuspendLayout();
            // 
            // LstWerte
            // 
            LstWerte.FormattingEnabled = true;
            LstWerte.ItemHeight = 15;
            LstWerte.Location = new Point(12, 43);
            LstWerte.Name = "LstWerte";
            LstWerte.Size = new Size(120, 94);
            LstWerte.TabIndex = 0;
            // 
            // cmdAnzeigen
            // 
            cmdAnzeigen.AutoSize = true;
            cmdAnzeigen.Location = new Point(182, 43);
            cmdAnzeigen.Name = "cmdAnzeigen";
            cmdAnzeigen.Size = new Size(62, 15);
            cmdAnzeigen.TabIndex = 1;
            cmdAnzeigen.Text = "Anzeigen1";
            cmdAnzeigen.Click += cmdAnzeigen_Click;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(12, 153);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(38, 15);
            LblAusgabe.TabIndex = 3;
            LblAusgabe.Text = "label2";
            LblAusgabe.Click += LblAusgabe_Click;
            // 
            // cmdAnzeigen2
            // 
            cmdAnzeigen2.AutoSize = true;
            cmdAnzeigen2.Location = new Point(182, 82);
            cmdAnzeigen2.Name = "cmdAnzeigen2";
            cmdAnzeigen2.Size = new Size(62, 15);
            cmdAnzeigen2.TabIndex = 4;
            cmdAnzeigen2.Text = "Anzeigen2";
            cmdAnzeigen2.Click += cmdAnzeigen2_Click;
            // 
            // cmdAnzeigen3
            // 
            cmdAnzeigen3.Location = new Point(182, 114);
            cmdAnzeigen3.Name = "cmdAnzeigen3";
            cmdAnzeigen3.Size = new Size(75, 23);
            cmdAnzeigen3.TabIndex = 5;
            cmdAnzeigen3.Text = "Anzeigen3";
            cmdAnzeigen3.UseVisualStyleBackColor = true;
            cmdAnzeigen3.Click += cmdAnzeigen3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdAnzeigen3);
            Controls.Add(cmdAnzeigen2);
            Controls.Add(LblAusgabe);
            Controls.Add(cmdAnzeigen);
            Controls.Add(LstWerte);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LstWerte;
        private Label cmdAnzeigen;
        private Label LblAusgabe;
        private Label cmdAnzeigen2;
        private Button cmdAnzeigen3;
    }
}
