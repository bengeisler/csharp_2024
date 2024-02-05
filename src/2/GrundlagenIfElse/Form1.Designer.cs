// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenIfElse
{
    partial class GrundlagenIfElse
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
            NumZahl = new NumericUpDown();
            LblAnzeige = new Label();
            BtnAnzeigen1 = new Button();
            BtnAnzeigen2 = new Button();
            ((System.ComponentModel.ISupportInitialize)NumZahl).BeginInit();
            SuspendLayout();
            // 
            // NumZahl
            // 
            NumZahl.Location = new Point(12, 12);
            NumZahl.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            NumZahl.Name = "NumZahl";
            NumZahl.Size = new Size(120, 23);
            NumZahl.TabIndex = 0;
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(12, 56);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(38, 15);
            LblAnzeige.TabIndex = 1;
            LblAnzeige.Text = "label1";
            LblAnzeige.Click += label1_Click;
            // 
            // BtnAnzeigen1
            // 
            BtnAnzeigen1.Location = new Point(170, 12);
            BtnAnzeigen1.Name = "BtnAnzeigen1";
            BtnAnzeigen1.Size = new Size(75, 23);
            BtnAnzeigen1.TabIndex = 2;
            BtnAnzeigen1.Text = "Anzeigen 1";
            BtnAnzeigen1.UseVisualStyleBackColor = true;
            BtnAnzeigen1.Click += BtnAnzeigen1_Click;
            // 
            // BtnAnzeigen2
            // 
            BtnAnzeigen2.Location = new Point(170, 46);
            BtnAnzeigen2.Name = "BtnAnzeigen2";
            BtnAnzeigen2.Size = new Size(75, 25);
            BtnAnzeigen2.TabIndex = 3;
            BtnAnzeigen2.Text = "Anzeigen 2";
            BtnAnzeigen2.UseVisualStyleBackColor = true;
            BtnAnzeigen2.Click += BtnAnzeigen2_Click;
            // 
            // GrundlagenIfElse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 102);
            Controls.Add(BtnAnzeigen2);
            Controls.Add(BtnAnzeigen1);
            Controls.Add(LblAnzeige);
            Controls.Add(NumZahl);
            Name = "GrundlagenIfElse";
            Text = "GrundlagenIfElse";
            ((System.ComponentModel.ISupportInitialize)NumZahl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown NumZahl;
        private Label LblAnzeige;
        private Button BtnAnzeigen1;
        private Button BtnAnzeigen2;
    }
}
