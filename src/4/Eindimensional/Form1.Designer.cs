// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Eindimensional
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
            lstWerte = new ListBox();
            btnAnzeigen1 = new Button();
            btnAnzeigen2 = new Button();
            LblAusgabe = new Label();
            btnAnzeigen3 = new Button();
            SuspendLayout();
            // 
            // lstWerte
            // 
            lstWerte.FormattingEnabled = true;
            lstWerte.ItemHeight = 15;
            lstWerte.Location = new Point(12, 12);
            lstWerte.Name = "lstWerte";
            lstWerte.Size = new Size(120, 94);
            lstWerte.TabIndex = 0;
            // 
            // btnAnzeigen1
            // 
            btnAnzeigen1.Location = new Point(153, 12);
            btnAnzeigen1.Name = "btnAnzeigen1";
            btnAnzeigen1.Size = new Size(75, 23);
            btnAnzeigen1.TabIndex = 1;
            btnAnzeigen1.Text = "Anzeigen 1";
            btnAnzeigen1.UseVisualStyleBackColor = true;
            btnAnzeigen1.Click += btnAnzeigen1_Click;
            // 
            // btnAnzeigen2
            // 
            btnAnzeigen2.Location = new Point(153, 41);
            btnAnzeigen2.Name = "btnAnzeigen2";
            btnAnzeigen2.Size = new Size(75, 23);
            btnAnzeigen2.TabIndex = 2;
            btnAnzeigen2.Text = "Anzeigen 2";
            btnAnzeigen2.UseVisualStyleBackColor = true;
            btnAnzeigen2.Click += btnAnzeigen2_Click;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(12, 125);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(38, 15);
            LblAusgabe.TabIndex = 3;
            LblAusgabe.Text = "label1";
            // 
            // btnAnzeigen3
            // 
            btnAnzeigen3.Location = new Point(153, 70);
            btnAnzeigen3.Name = "btnAnzeigen3";
            btnAnzeigen3.Size = new Size(75, 23);
            btnAnzeigen3.TabIndex = 4;
            btnAnzeigen3.Text = "Anzeigen 3";
            btnAnzeigen3.UseVisualStyleBackColor = true;
            btnAnzeigen3.Click += btnAnzeigen3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 172);
            Controls.Add(btnAnzeigen3);
            Controls.Add(LblAusgabe);
            Controls.Add(btnAnzeigen2);
            Controls.Add(btnAnzeigen1);
            Controls.Add(lstWerte);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstWerte;
        private Button btnAnzeigen1;
        private Button btnAnzeigen2;
        private Label LblAusgabe;
        private Button btnAnzeigen3;
    }
}
