// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Tastatur_und_Maus
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
            Pan = new Panel();
            Lbl1 = new Label();
            Lbl2 = new Label();
            TxtBox = new TextBox();
            SuspendLayout();
            // 
            // Pan
            // 
            Pan.BorderStyle = BorderStyle.FixedSingle;
            Pan.Location = new Point(12, 107);
            Pan.Name = "Pan";
            Pan.Size = new Size(200, 100);
            Pan.TabIndex = 0;
            Pan.MouseDown += Pan_MouseDown;
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Location = new Point(12, 79);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(38, 15);
            Lbl1.TabIndex = 0;
            Lbl1.Text = "label1";
            // 
            // Lbl2
            // 
            Lbl2.AutoSize = true;
            Lbl2.Location = new Point(12, 220);
            Lbl2.Name = "Lbl2";
            Lbl2.Size = new Size(38, 15);
            Lbl2.TabIndex = 1;
            Lbl2.Text = "label2";
            // 
            // TxtBox
            // 
            TxtBox.Location = new Point(12, 38);
            TxtBox.Name = "TxtBox";
            TxtBox.Size = new Size(100, 23);
            TxtBox.TabIndex = 2;
            TxtBox.KeyDown += TxtBox_KeyDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Lbl1);
            Controls.Add(Lbl2);
            Controls.Add(TxtBox);
            Controls.Add(Pan);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Pan;
        private Label Lbl1;
        private Label Lbl2;
        private TextBox TxtBox;
    }
}
