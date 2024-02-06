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
            BtnBerechnung = new Button();
            label1 = new Label();
            LblAnzeige1 = new Label();
            TxtEingabe = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // BtnBerechnung
            // 
            BtnBerechnung.Location = new Point(12, 56);
            BtnBerechnung.Name = "BtnBerechnung";
            BtnBerechnung.Size = new Size(173, 23);
            BtnBerechnung.TabIndex = 0;
            BtnBerechnung.Text = "Berechnung mit if ... else";
            BtnBerechnung.UseVisualStyleBackColor = true;
            BtnBerechnung.Click += BtnBerechnung_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Gehalt:";
            // 
            // LblAnzeige1
            // 
            LblAnzeige1.AutoSize = true;
            LblAnzeige1.Location = new Point(147, 30);
            LblAnzeige1.Name = "LblAnzeige1";
            LblAnzeige1.Size = new Size(38, 15);
            LblAnzeige1.TabIndex = 2;
            LblAnzeige1.Text = "label2";
            // 
            // TxtEingabe
            // 
            TxtEingabe.Location = new Point(12, 27);
            TxtEingabe.Name = "TxtEingabe";
            TxtEingabe.Size = new Size(100, 23);
            TxtEingabe.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(12, 85);
            button1.Name = "button1";
            button1.Size = new Size(173, 23);
            button1.TabIndex = 4;
            button1.Text = "Berechnen mit switch";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(TxtEingabe);
            Controls.Add(LblAnzeige1);
            Controls.Add(label1);
            Controls.Add(BtnBerechnung);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBerechnung;
        private Label label1;
        private Label LblAnzeige1;
        private TextBox TxtEingabe;
        private Button button1;
    }
}
