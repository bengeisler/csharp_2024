// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenAusgaben
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
            BtnAnzeigen1 = new Button();
            BtnAnzeigen2 = new Button();
            BtnAnzeigen3 = new Button();
            BtnAnzeigen4 = new Button();
            LblAnzeigen = new Label();
            SuspendLayout();
            // 
            // BtnAnzeigen1
            // 
            BtnAnzeigen1.Location = new Point(593, 40);
            BtnAnzeigen1.Name = "BtnAnzeigen1";
            BtnAnzeigen1.Size = new Size(177, 44);
            BtnAnzeigen1.TabIndex = 0;
            BtnAnzeigen1.Text = "Anzeigen 1";
            BtnAnzeigen1.UseVisualStyleBackColor = true;
            BtnAnzeigen1.Click += BtnAnzeigen1_Click;
            // 
            // BtnAnzeigen2
            // 
            BtnAnzeigen2.Location = new Point(592, 112);
            BtnAnzeigen2.Name = "BtnAnzeigen2";
            BtnAnzeigen2.Size = new Size(177, 44);
            BtnAnzeigen2.TabIndex = 1;
            BtnAnzeigen2.Text = "Anzeigen 2";
            BtnAnzeigen2.UseVisualStyleBackColor = true;
            BtnAnzeigen2.Click += BtnAnzeigen2_Click;
            // 
            // BtnAnzeigen3
            // 
            BtnAnzeigen3.Location = new Point(593, 183);
            BtnAnzeigen3.Name = "BtnAnzeigen3";
            BtnAnzeigen3.Size = new Size(177, 44);
            BtnAnzeigen3.TabIndex = 2;
            BtnAnzeigen3.Text = "Anzeigen 3";
            BtnAnzeigen3.UseVisualStyleBackColor = true;
            // 
            // BtnAnzeigen4
            // 
            BtnAnzeigen4.Location = new Point(592, 258);
            BtnAnzeigen4.Name = "BtnAnzeigen4";
            BtnAnzeigen4.Size = new Size(177, 44);
            BtnAnzeigen4.TabIndex = 3;
            BtnAnzeigen4.Text = "Anzeigen 4";
            BtnAnzeigen4.UseVisualStyleBackColor = true;
            // 
            // LblAnzeigen
            // 
            LblAnzeigen.AutoSize = true;
            LblAnzeigen.Location = new Point(43, 41);
            LblAnzeigen.Name = "LblAnzeigen";
            LblAnzeigen.Size = new Size(38, 15);
            LblAnzeigen.TabIndex = 4;
            LblAnzeigen.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAnzeigen);
            Controls.Add(BtnAnzeigen4);
            Controls.Add(BtnAnzeigen3);
            Controls.Add(BtnAnzeigen2);
            Controls.Add(BtnAnzeigen1);
            Name = "Form1";
            Text = "Ausgaben";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAnzeigen1;
        private Button BtnAnzeigen2;
        private Button BtnAnzeigen3;
        private Button BtnAnzeigen4;
        private Label LblAnzeigen;
    }
}
