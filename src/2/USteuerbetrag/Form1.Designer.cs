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
            button1 = new Button();
            label1 = new Label();
            TxtGehalt = new TextBox();
            LblSteuerbetrag = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 87);
            button1.Name = "button1";
            button1.Size = new Size(215, 34);
            button1.TabIndex = 0;
            button1.Text = "Berechnen mit if...else";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 1;
            label1.Text = "Gehalt:";
            // 
            // TxtGehalt
            // 
            TxtGehalt.Location = new Point(12, 37);
            TxtGehalt.Name = "TxtGehalt";
            TxtGehalt.Size = new Size(150, 31);
            TxtGehalt.TabIndex = 2;
            // 
            // LblSteuerbetrag
            // 
            LblSteuerbetrag.AutoSize = true;
            LblSteuerbetrag.Location = new Point(168, 40);
            LblSteuerbetrag.Name = "LblSteuerbetrag";
            LblSteuerbetrag.Size = new Size(59, 25);
            LblSteuerbetrag.TabIndex = 3;
            LblSteuerbetrag.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 144);
            Controls.Add(LblSteuerbetrag);
            Controls.Add(TxtGehalt);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "USteuerbetrag";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox TxtGehalt;
        private Label LblSteuerbetrag;
    }
}
