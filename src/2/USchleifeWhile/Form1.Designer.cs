// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace USchleifeWhile
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
            BtnAnzeigen = new Button();
            LblAnzeigen = new Label();
            txtBox = new TextBox();
            SuspendLayout();
            // 
            // BtnAnzeigen
            // 
            BtnAnzeigen.Location = new Point(131, 63);
            BtnAnzeigen.Name = "BtnAnzeigen";
            BtnAnzeigen.Size = new Size(75, 23);
            BtnAnzeigen.TabIndex = 0;
            BtnAnzeigen.Text = "Anzeigen";
            BtnAnzeigen.UseVisualStyleBackColor = true;
            BtnAnzeigen.Click += BtnAnzeigen_Click;
            // 
            // LblAnzeigen
            // 
            LblAnzeigen.AutoSize = true;
            LblAnzeigen.Location = new Point(34, 27);
            LblAnzeigen.Name = "LblAnzeigen";
            LblAnzeigen.Size = new Size(38, 15);
            LblAnzeigen.TabIndex = 1;
            LblAnzeigen.Text = "label1";
            // 
            // txtBox
            // 
            txtBox.Location = new Point(131, 24);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(100, 23);
            txtBox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBox);
            Controls.Add(LblAnzeigen);
            Controls.Add(BtnAnzeigen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAnzeigen;
        private Label LblAnzeigen;
        private TextBox txtBox;
    }
}
