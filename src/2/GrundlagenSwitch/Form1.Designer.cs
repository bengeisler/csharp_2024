// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenSwitch
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
            LblAnzeige = new Label();
            TxtEingabe = new TextBox();
            BtnAnzeigen2 = new Button();
            BtnAnzeigen3 = new Button();
            button1 = new Button();
            BtnAnzeigen5 = new Button();
            SuspendLayout();
            // 
            // BtnAnzeigen1
            // 
            BtnAnzeigen1.Location = new Point(12, 41);
            BtnAnzeigen1.Name = "BtnAnzeigen1";
            BtnAnzeigen1.Size = new Size(75, 23);
            BtnAnzeigen1.TabIndex = 0;
            BtnAnzeigen1.Text = "Anzeigen 1";
            BtnAnzeigen1.UseVisualStyleBackColor = true;
            BtnAnzeigen1.Click += BtnAnzeigen1_Click;
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(12, 77);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(38, 15);
            LblAnzeige.TabIndex = 1;
            LblAnzeige.Text = "label1";
            // 
            // TxtEingabe
            // 
            TxtEingabe.Location = new Point(12, 12);
            TxtEingabe.Name = "TxtEingabe";
            TxtEingabe.Size = new Size(100, 23);
            TxtEingabe.TabIndex = 2;
            // 
            // BtnAnzeigen2
            // 
            BtnAnzeigen2.Location = new Point(93, 41);
            BtnAnzeigen2.Name = "BtnAnzeigen2";
            BtnAnzeigen2.Size = new Size(75, 23);
            BtnAnzeigen2.TabIndex = 3;
            BtnAnzeigen2.Text = "Anzeigen 2";
            BtnAnzeigen2.UseVisualStyleBackColor = true;
            BtnAnzeigen2.Click += BtnAnzeigen2_Click;
            // 
            // BtnAnzeigen3
            // 
            BtnAnzeigen3.Location = new Point(174, 41);
            BtnAnzeigen3.Name = "BtnAnzeigen3";
            BtnAnzeigen3.Size = new Size(75, 23);
            BtnAnzeigen3.TabIndex = 4;
            BtnAnzeigen3.Text = "Anzeigen 3";
            BtnAnzeigen3.UseVisualStyleBackColor = true;
            BtnAnzeigen3.Click += BtnAnzeigen3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(255, 41);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Anzeigen 4";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BtnAnzeigen5
            // 
            BtnAnzeigen5.Location = new Point(336, 41);
            BtnAnzeigen5.Name = "BtnAnzeigen5";
            BtnAnzeigen5.Size = new Size(75, 23);
            BtnAnzeigen5.TabIndex = 6;
            BtnAnzeigen5.Text = "Anzeigen 5";
            BtnAnzeigen5.UseVisualStyleBackColor = true;
            BtnAnzeigen5.Click += BtnAnzeigen5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 153);
            Controls.Add(BtnAnzeigen5);
            Controls.Add(button1);
            Controls.Add(BtnAnzeigen3);
            Controls.Add(BtnAnzeigen2);
            Controls.Add(TxtEingabe);
            Controls.Add(LblAnzeige);
            Controls.Add(BtnAnzeigen1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAnzeigen1;
        private Label LblAnzeige;
        private TextBox TxtEingabe;
        private Button BtnAnzeigen2;
        private Button BtnAnzeigen3;
        private Button button1;
        private Button BtnAnzeigen5;
    }
}
