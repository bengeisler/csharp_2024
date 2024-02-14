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
            TxtEingabe = new TextBox();
            LblEingabe = new Label();
            LblMaus = new Label();
            SuspendLayout();
            // 
            // PanMaus
            // 
            PanMaus.BorderStyle = BorderStyle.FixedSingle;
            PanMaus.Location = new Point(12, 97);
            PanMaus.Name = "PanMaus";
            PanMaus.Size = new Size(300, 150);
            PanMaus.TabIndex = 0;
            PanMaus.MouseDown += PanMaus_MouseDown;
            // 
            // TxtEingabe
            // 
            TxtEingabe.Location = new Point(12, 12);
            TxtEingabe.Name = "TxtEingabe";
            TxtEingabe.Size = new Size(150, 31);
            TxtEingabe.TabIndex = 1;
            TxtEingabe.KeyDown += TxtEingabe_KeyDown;
            // 
            // LblEingabe
            // 
            LblEingabe.AutoSize = true;
            LblEingabe.Location = new Point(12, 59);
            LblEingabe.Name = "LblEingabe";
            LblEingabe.Size = new Size(59, 25);
            LblEingabe.TabIndex = 2;
            LblEingabe.Text = "label1";
            // 
            // LblMaus
            // 
            LblMaus.AutoSize = true;
            LblMaus.Location = new Point(12, 262);
            LblMaus.Name = "LblMaus";
            LblMaus.Size = new Size(59, 25);
            LblMaus.TabIndex = 3;
            LblMaus.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 311);
            Controls.Add(LblMaus);
            Controls.Add(LblEingabe);
            Controls.Add(TxtEingabe);
            Controls.Add(PanMaus);
            Name = "Form1";
            Text = "Tastatur und Maus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanMaus;
        private TextBox TxtEingabe;
        private Label LblEingabe;
        private Label LblMaus;
    }
}
