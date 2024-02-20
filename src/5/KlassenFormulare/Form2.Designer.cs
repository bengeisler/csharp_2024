// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace KlassenFormulare
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblAnzeige = new Label();
            cmdSchließen = new Button();
            cmdschliesen = new Button();
            SuspendLayout();
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(12, 16);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(38, 15);
            LblAnzeige.TabIndex = 0;
            LblAnzeige.Text = "label1";
            // 
            // cmdSchließen
            // 
            cmdSchließen.Location = new Point(107, 12);
            cmdSchließen.Name = "cmdSchließen";
            cmdSchließen.Size = new Size(75, 23);
            cmdSchließen.TabIndex = 1;
            cmdSchließen.Text = "Schließen";
            cmdSchließen.UseVisualStyleBackColor = true;
            cmdSchließen.Click += cmdSchließen_Click;
            // 
            // cmdschliesen
            // 
            cmdschliesen.Location = new Point(220, 93);
            cmdschliesen.Name = "cmdschliesen";
            cmdschliesen.Size = new Size(75, 23);
            cmdschliesen.TabIndex = 2;
            cmdschliesen.Text = "button1";
            cmdschliesen.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdschliesen);
            Controls.Add(cmdSchließen);
            Controls.Add(LblAnzeige);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAnzeige;
        private Button cmdSchließen;
        private Button cmdschliesen;
    }
}