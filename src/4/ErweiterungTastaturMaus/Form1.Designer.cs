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
            txtEingabe = new TextBox();
            lblEingabe = new Label();
            panel1 = new Panel();
            lbl2 = new Label();
            SuspendLayout();
            // 
            // txtEingabe
            // 
            txtEingabe.Location = new Point(21, 32);
            txtEingabe.Name = "txtEingabe";
            txtEingabe.Size = new Size(100, 23);
            txtEingabe.TabIndex = 0;
            txtEingabe.KeyDown += txtEingabe_KeyDown;
            // 
            // lblEingabe
            // 
            lblEingabe.AutoSize = true;
            lblEingabe.Location = new Point(21, 84);
            lblEingabe.Name = "lblEingabe";
            lblEingabe.Size = new Size(38, 15);
            lblEingabe.TabIndex = 1;
            lblEingabe.Text = "label1";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(21, 132);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 99);
            panel1.TabIndex = 2;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(26, 255);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(38, 15);
            lbl2.TabIndex = 3;
            lbl2.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl2);
            Controls.Add(panel1);
            Controls.Add(lblEingabe);
            Controls.Add(txtEingabe);
            Name = "Form1";
            Text = "Tastatur und Maus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEingabe;
        private Label lblEingabe;
        private Panel panel1;
        private Label lbl2;
    }
}
