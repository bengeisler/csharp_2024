// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace ErweiterungTastaturMaus
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
            PanMaus = new Panel();
            LblEingabe = new Label();
            LblMaus = new Label();
            TxtEingabe = new TextBox();
            SuspendLayout();
            // 
            // PanMaus
            // 
            PanMaus.BorderStyle = BorderStyle.FixedSingle;
            PanMaus.Location = new Point(33, 96);
            PanMaus.Name = "PanMaus";
            PanMaus.Size = new Size(212, 157);
            PanMaus.TabIndex = 0;
            // 
            // LblEingabe
            // 
            LblEingabe.AutoSize = true;
            LblEingabe.Location = new Point(33, 67);
            LblEingabe.Name = "LblEingabe";
            LblEingabe.Size = new Size(38, 15);
            LblEingabe.TabIndex = 0;
            LblEingabe.Text = "label1";
            // 
            // LblMaus
            // 
            LblMaus.AutoSize = true;
            LblMaus.Location = new Point(33, 279);
            LblMaus.Name = "LblMaus";
            LblMaus.Size = new Size(38, 15);
            LblMaus.TabIndex = 1;
            LblMaus.Text = "label2";
            // 
            // TxtEingabe
            // 
            TxtEingabe.Location = new Point(33, 26);
            TxtEingabe.Name = "TxtEingabe";
            TxtEingabe.Size = new Size(160, 23);
            TxtEingabe.TabIndex = 2;
            TxtEingabe.KeyDown += TxtEingabe_KeyDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtEingabe);
            Controls.Add(LblMaus);
            Controls.Add(LblEingabe);
            Controls.Add(PanMaus);
            Name = "Form1";
            Text = "Form1";
            MouseDown += Form1_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanMaus;
        private Label LblEingabe;
        private Label LblMaus;
        private TextBox TxtEingabe;
    }
}
