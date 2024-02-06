// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementCheckBox
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
            ChkBox = new CheckBox();
            BtnPruefen = new Button();
            BtnUmschalter = new Button();
            LblAnzeige1 = new Label();
            LblAnzeige2 = new Label();
            SuspendLayout();
            // 
            // ChkBox
            // 
            ChkBox.AutoSize = true;
            ChkBox.Location = new Point(124, 65);
            ChkBox.Name = "ChkBox";
            ChkBox.Size = new Size(68, 19);
            ChkBox.TabIndex = 0;
            ChkBox.Text = "Schalter";
            ChkBox.UseVisualStyleBackColor = true;
            ChkBox.CheckedChanged += ChkBox_CheckedChanged;
            // 
            // BtnPruefen
            // 
            BtnPruefen.Location = new Point(117, 36);
            BtnPruefen.Name = "BtnPruefen";
            BtnPruefen.Size = new Size(75, 23);
            BtnPruefen.TabIndex = 1;
            BtnPruefen.Text = "Prüfen";
            BtnPruefen.UseVisualStyleBackColor = true;
            BtnPruefen.Click += BtnPruefen_Click;
            // 
            // BtnUmschalter
            // 
            BtnUmschalter.Location = new Point(117, 90);
            BtnUmschalter.Name = "BtnUmschalter";
            BtnUmschalter.Size = new Size(75, 23);
            BtnUmschalter.TabIndex = 2;
            BtnUmschalter.Text = "Umschalter";
            BtnUmschalter.UseVisualStyleBackColor = true;
            BtnUmschalter.Click += BtnUmschalter_Click;
            // 
            // LblAnzeige1
            // 
            LblAnzeige1.AutoSize = true;
            LblAnzeige1.Location = new Point(12, 36);
            LblAnzeige1.Name = "LblAnzeige1";
            LblAnzeige1.Size = new Size(38, 15);
            LblAnzeige1.TabIndex = 3;
            LblAnzeige1.Text = "label1";
            // 
            // LblAnzeige2
            // 
            LblAnzeige2.AutoSize = true;
            LblAnzeige2.Location = new Point(12, 94);
            LblAnzeige2.Name = "LblAnzeige2";
            LblAnzeige2.Size = new Size(38, 15);
            LblAnzeige2.TabIndex = 4;
            LblAnzeige2.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAnzeige2);
            Controls.Add(LblAnzeige1);
            Controls.Add(BtnUmschalter);
            Controls.Add(BtnPruefen);
            Controls.Add(ChkBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ChkBox;
        private Button BtnPruefen;
        private Button BtnUmschalter;
        private Label LblAnzeige1;
        private Label LblAnzeige2;
    }
}
