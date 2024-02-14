// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace ErweiterungTastaurundMaus
{
    partial class TastaurundMaus
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
            TxtEingabe = new TextBox();
            LblEingabe = new Label();
            PanMaus = new Panel();
            LblMaus = new Label();
            SuspendLayout();
            // 
            // TxtEingabe
            // 
            TxtEingabe.Location = new Point(90, 48);
            TxtEingabe.Name = "TxtEingabe";
            TxtEingabe.Size = new Size(165, 23);
            TxtEingabe.TabIndex = 0;
            TxtEingabe.KeyDown += TxtEingabe_KeyDown;
            // 
            // LblEingabe
            // 
            LblEingabe.AutoSize = true;
            LblEingabe.Location = new Point(90, 90);
            LblEingabe.Name = "LblEingabe";
            LblEingabe.Size = new Size(38, 15);
            LblEingabe.TabIndex = 1;
            LblEingabe.Text = "label1";
            // 
            // PanMaus
            // 
            PanMaus.BorderStyle = BorderStyle.FixedSingle;
            PanMaus.Location = new Point(90, 190);
            PanMaus.Name = "PanMaus";
            PanMaus.Size = new Size(200, 100);
            PanMaus.TabIndex = 2;
            PanMaus.MouseDown += PanMaus_MouseDown;
            // 
            // LblMaus
            // 
            LblMaus.AutoSize = true;
            LblMaus.Location = new Point(90, 337);
            LblMaus.Name = "LblMaus";
            LblMaus.Size = new Size(38, 15);
            LblMaus.TabIndex = 3;
            LblMaus.Text = "label2";
            // 
            // TastaurundMaus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblMaus);
            Controls.Add(PanMaus);
            Controls.Add(LblEingabe);
            Controls.Add(TxtEingabe);
            Name = "TastaurundMaus";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtEingabe;
        private Label LblEingabe;
        private Panel PanMaus;
        private Label LblMaus;
    }
}
