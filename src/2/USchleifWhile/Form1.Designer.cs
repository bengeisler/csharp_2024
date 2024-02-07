// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace USchleifWhile
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
            LblAnzeige = new Label();
            cmdAnzeigen = new Button();
            ChkEingabe = new TextBox();
            SuspendLayout();
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(44, 39);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(38, 15);
            LblAnzeige.TabIndex = 0;
            LblAnzeige.Text = "label1";
            // 
            // cmdAnzeigen
            // 
            cmdAnzeigen.Location = new Point(231, 84);
            cmdAnzeigen.Name = "cmdAnzeigen";
            cmdAnzeigen.Size = new Size(75, 23);
            cmdAnzeigen.TabIndex = 1;
            cmdAnzeigen.Text = "Anzeigen";
            cmdAnzeigen.UseVisualStyleBackColor = true;
            cmdAnzeigen.Click += cmdAnzeigen_Click;
            // 
            // ChkEingabe
            // 
            ChkEingabe.Location = new Point(206, 39);
            ChkEingabe.Name = "ChkEingabe";
            ChkEingabe.Size = new Size(100, 23);
            ChkEingabe.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ChkEingabe);
            Controls.Add(cmdAnzeigen);
            Controls.Add(LblAnzeige);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAnzeige;
        private Button cmdAnzeigen;
        private TextBox ChkEingabe;
    }
}
