// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace TastaturundMaus
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
            TxtEingabe = new TextBox();
            LblMaus = new Label();
            SuspendLayout();
            // 
            // PanMaus
            // 
            PanMaus.BorderStyle = BorderStyle.FixedSingle;
            PanMaus.Location = new Point(39, 141);
            PanMaus.Name = "PanMaus";
            PanMaus.Size = new Size(200, 100);
            PanMaus.TabIndex = 0;
            PanMaus.MouseDown += PanMaus_MouseDown;
            // 
            // LblEingabe
            // 
            LblEingabe.AutoSize = true;
            LblEingabe.Location = new Point(39, 83);
            LblEingabe.Name = "LblEingabe";
            LblEingabe.Size = new Size(38, 15);
            LblEingabe.TabIndex = 1;
            LblEingabe.Text = "label1";
            // 
            // TxtEingabe
            // 
            TxtEingabe.Location = new Point(39, 33);
            TxtEingabe.Name = "TxtEingabe";
            TxtEingabe.Size = new Size(100, 23);
            TxtEingabe.TabIndex = 2;
            TxtEingabe.KeyDown += TxtEingabe_KeyDown;
            // 
            // LblMaus
            // 
            LblMaus.AutoSize = true;
            LblMaus.Location = new Point(39, 286);
            LblMaus.Name = "LblMaus";
            LblMaus.Size = new Size(38, 15);
            LblMaus.TabIndex = 3;
            LblMaus.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 381);
            Controls.Add(LblMaus);
            Controls.Add(TxtEingabe);
            Controls.Add(LblEingabe);
            Controls.Add(PanMaus);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanMaus;
        private Label LblEingabe;
        private TextBox TxtEingabe;
        private Label LblMaus;
    }
}
