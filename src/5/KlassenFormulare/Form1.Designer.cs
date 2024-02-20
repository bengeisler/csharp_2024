// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace KlassenFormulare
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
            cmdAufrufen = new Button();
            txtEingabe = new TextBox();
            SuspendLayout();
            // 
            // cmdAufrufen
            // 
            cmdAufrufen.Location = new Point(33, 65);
            cmdAufrufen.Name = "cmdAufrufen";
            cmdAufrufen.Size = new Size(144, 23);
            cmdAufrufen.TabIndex = 0;
            cmdAufrufen.Text = "Formular 2 aufrufen";
            cmdAufrufen.UseVisualStyleBackColor = true;
            cmdAufrufen.Click += cmdAufrufen_Click;
            // 
            // txtEingabe
            // 
            txtEingabe.Location = new Point(33, 22);
            txtEingabe.Name = "txtEingabe";
            txtEingabe.Size = new Size(100, 23);
            txtEingabe.TabIndex = 1;
            
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEingabe);
            Controls.Add(cmdAufrufen);
            Name = "Form1";
            Text = "Hauptformlar(1)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdAufrufen;
        private TextBox txtEingabe;
    }
}
