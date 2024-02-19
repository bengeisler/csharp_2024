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
            txtEingabe = new TextBox();
            btnAnzeigen = new Button();
            SuspendLayout();
            // 
            // txtEingabe
            // 
            txtEingabe.Location = new Point(25, 12);
            txtEingabe.Name = "txtEingabe";
            txtEingabe.Size = new Size(107, 23);
            txtEingabe.TabIndex = 0;
            // 
            // btnAnzeigen
            // 
            btnAnzeigen.Location = new Point(25, 41);
            btnAnzeigen.Name = "btnAnzeigen";
            btnAnzeigen.Size = new Size(107, 60);
            btnAnzeigen.TabIndex = 1;
            btnAnzeigen.Text = "Unterformular aufrufen";
            btnAnzeigen.UseVisualStyleBackColor = true;
            btnAnzeigen.Click += btnAnzeigen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAnzeigen);
            Controls.Add(txtEingabe);
            Name = "Form1";
            Text = "Hauptformular (1)";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEingabe;
        private Button btnAnzeigen;
    }
}
