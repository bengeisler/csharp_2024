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
            BtnAnzeigen1 = new Button();
            BtnAnzeigen2 = new Button();
            BtnAnzeigen3 = new Button();
            BtnAnzeigen4 = new Button();
            LblAnzeige = new Label();
            SuspendLayout();
            // 
            // BtnAnzeigen1
            // 
            BtnAnzeigen1.Location = new Point(231, 12);
            BtnAnzeigen1.Name = "BtnAnzeigen1";
            BtnAnzeigen1.Size = new Size(112, 34);
            BtnAnzeigen1.TabIndex = 0;
            BtnAnzeigen1.Text = "Anzeigen 1";
            BtnAnzeigen1.UseVisualStyleBackColor = true;
            BtnAnzeigen1.Click += BtnAnzeigen1_Click;
            // 
            // BtnAnzeigen2
            // 
            BtnAnzeigen2.Location = new Point(231, 52);
            BtnAnzeigen2.Name = "BtnAnzeigen2";
            BtnAnzeigen2.Size = new Size(112, 34);
            BtnAnzeigen2.TabIndex = 1;
            BtnAnzeigen2.Text = "Anzeigen 2";
            BtnAnzeigen2.UseVisualStyleBackColor = true;
            BtnAnzeigen2.Click += BtnAnzeigen2_Click;
            // 
            // BtnAnzeigen3
            // 
            BtnAnzeigen3.Location = new Point(231, 92);
            BtnAnzeigen3.Name = "BtnAnzeigen3";
            BtnAnzeigen3.Size = new Size(112, 34);
            BtnAnzeigen3.TabIndex = 2;
            BtnAnzeigen3.Text = "Anzeigen 3";
            BtnAnzeigen3.UseVisualStyleBackColor = true;
            // 
            // BtnAnzeigen4
            // 
            BtnAnzeigen4.Location = new Point(231, 133);
            BtnAnzeigen4.Name = "BtnAnzeigen4";
            BtnAnzeigen4.Size = new Size(112, 34);
            BtnAnzeigen4.TabIndex = 3;
            BtnAnzeigen4.Text = "Anzeigen 4";
            BtnAnzeigen4.UseVisualStyleBackColor = true;
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(12, 9);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(59, 25);
            LblAnzeige.TabIndex = 4;
            LblAnzeige.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 194);
            Controls.Add(LblAnzeige);
            Controls.Add(BtnAnzeigen4);
            Controls.Add(BtnAnzeigen3);
            Controls.Add(BtnAnzeigen2);
            Controls.Add(BtnAnzeigen1);
            Name = "Form1";
            Text = "Anzeigen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAnzeigen1;
        private Button BtnAnzeigen2;
        private Button BtnAnzeigen3;
        private Button BtnAnzeigen4;
        private Label LblAnzeige;
    }
}
