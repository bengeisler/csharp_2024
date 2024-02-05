// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UOperatorenVergleich
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
            cmdAnzeige1 = new Button();
            cmdAnzeige2 = new Button();
            LblAnzeigen = new Label();
            cmdAnzeigen3 = new Button();
            cmdAnzeigen4 = new Button();
            SuspendLayout();
            // 
            // cmdAnzeige1
            // 
            cmdAnzeige1.Location = new Point(392, 15);
            cmdAnzeige1.Name = "cmdAnzeige1";
            cmdAnzeige1.Size = new Size(75, 23);
            cmdAnzeige1.TabIndex = 0;
            cmdAnzeige1.Text = "Anzeigen1";
            cmdAnzeige1.UseVisualStyleBackColor = true;
            cmdAnzeige1.Click += cmdAnzeige1_Click;
            // 
            // cmdAnzeige2
            // 
            cmdAnzeige2.Location = new Point(392, 44);
            cmdAnzeige2.Name = "cmdAnzeige2";
            cmdAnzeige2.Size = new Size(75, 23);
            cmdAnzeige2.TabIndex = 1;
            cmdAnzeige2.Text = "Anzeigen2";
            cmdAnzeige2.UseVisualStyleBackColor = true;
            cmdAnzeige2.Click += cmdAnzeige2_Click;
            // 
            // LblAnzeigen
            // 
            LblAnzeigen.AutoSize = true;
            LblAnzeigen.Location = new Point(21, 19);
            LblAnzeigen.Name = "LblAnzeigen";
            LblAnzeigen.Size = new Size(38, 15);
            LblAnzeigen.TabIndex = 2;
            LblAnzeigen.Text = "label1";
            // 
            // cmdAnzeigen3
            // 
            cmdAnzeigen3.Location = new Point(392, 67);
            cmdAnzeigen3.Name = "cmdAnzeigen3";
            cmdAnzeigen3.Size = new Size(75, 23);
            cmdAnzeigen3.TabIndex = 3;
            cmdAnzeigen3.Text = "Anzeigen3";
            cmdAnzeigen3.UseVisualStyleBackColor = true;
            cmdAnzeigen3.Click += cmdAnzeigen3_Click;
            // 
            // cmdAnzeigen4
            // 
            cmdAnzeigen4.Location = new Point(392, 96);
            cmdAnzeigen4.Name = "cmdAnzeigen4";
            cmdAnzeigen4.Size = new Size(75, 23);
            cmdAnzeigen4.TabIndex = 4;
            cmdAnzeigen4.Text = "Anzeigen4";
            cmdAnzeigen4.UseVisualStyleBackColor = true;
            cmdAnzeigen4.Click += cmdAnzeigen4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdAnzeigen4);
            Controls.Add(cmdAnzeigen3);
            Controls.Add(LblAnzeigen);
            Controls.Add(cmdAnzeige2);
            Controls.Add(cmdAnzeige1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdAnzeige1;
        private Button cmdAnzeige2;
        private Label LblAnzeigen;
        private Button cmdAnzeigen3;
        private Button cmdAnzeigen4;
    }
}
