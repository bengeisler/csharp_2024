// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenAusgabe
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
            LblAnzeige = new Label();
            cmdAnzeigen1 = new Button();
            cmdAnzeigen2 = new Button();
            cmdAnzeigen3 = new Button();
            cmdAnzeigen4 = new Button();
            SuspendLayout();
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(93, 49);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(38, 15);
            LblAnzeige.TabIndex = 0;
            LblAnzeige.Text = "label1";
            // 
            // cmdAnzeigen1
            // 
            cmdAnzeigen1.Location = new Point(254, 41);
            cmdAnzeigen1.Name = "cmdAnzeigen1";
            cmdAnzeigen1.Size = new Size(75, 23);
            cmdAnzeigen1.TabIndex = 1;
            cmdAnzeigen1.Text = "Anzeigen 1";
            cmdAnzeigen1.UseVisualStyleBackColor = true;
            cmdAnzeigen1.Click += cmdAnzeigen1_Click;
            // 
            // cmdAnzeigen2
            // 
            cmdAnzeigen2.Location = new Point(254, 70);
            cmdAnzeigen2.Name = "cmdAnzeigen2";
            cmdAnzeigen2.Size = new Size(75, 23);
            cmdAnzeigen2.TabIndex = 2;
            cmdAnzeigen2.Text = "Anzeigen 2";
            cmdAnzeigen2.UseVisualStyleBackColor = true;
            cmdAnzeigen2.Click += cmdAnzeigen2_Click;
            // 
            // cmdAnzeigen3
            // 
            cmdAnzeigen3.Location = new Point(254, 99);
            cmdAnzeigen3.Name = "cmdAnzeigen3";
            cmdAnzeigen3.Size = new Size(75, 23);
            cmdAnzeigen3.TabIndex = 3;
            cmdAnzeigen3.Text = "Anzeigen 3";
            cmdAnzeigen3.UseVisualStyleBackColor = true;
            cmdAnzeigen3.Click += cmdAnzeigen3_Click;
            // 
            // cmdAnzeigen4
            // 
            cmdAnzeigen4.Location = new Point(254, 128);
            cmdAnzeigen4.Name = "cmdAnzeigen4";
            cmdAnzeigen4.Size = new Size(75, 23);
            cmdAnzeigen4.TabIndex = 4;
            cmdAnzeigen4.Text = "Anzeigen 4";
            cmdAnzeigen4.UseVisualStyleBackColor = true;
            cmdAnzeigen4.Click += cmdAnzeigen4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 215);
            Controls.Add(cmdAnzeigen4);
            Controls.Add(cmdAnzeigen3);
            Controls.Add(cmdAnzeigen2);
            Controls.Add(cmdAnzeigen1);
            Controls.Add(LblAnzeige);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAnzeige;
        private Button cmdAnzeigen1;
        private Button cmdAnzeigen2;
        private Button cmdAnzeigen3;
        private Button cmdAnzeigen4;
    }
}
