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
            lblAnzeigen = new Label();
            btnSchließen = new Button();
            chkOk = new CheckBox();
            SuspendLayout();
            // 
            // lblAnzeigen
            // 
            lblAnzeigen.AutoSize = true;
            lblAnzeigen.Location = new Point(12, 9);
            lblAnzeigen.Name = "lblAnzeigen";
            lblAnzeigen.Size = new Size(38, 15);
            lblAnzeigen.TabIndex = 0;
            lblAnzeigen.Text = "label1";
            // 
            // btnSchließen
            // 
            btnSchließen.Location = new Point(12, 38);
            btnSchließen.Name = "btnSchließen";
            btnSchließen.Size = new Size(75, 23);
            btnSchließen.TabIndex = 1;
            btnSchließen.Text = "button1";
            btnSchließen.UseVisualStyleBackColor = true;
            btnSchließen.Click += btnSchließen_Click;
            // 
            // chkOk
            // 
            chkOk.AutoSize = true;
            chkOk.Location = new Point(143, 14);
            chkOk.Name = "chkOk";
            chkOk.Size = new Size(41, 19);
            chkOk.TabIndex = 2;
            chkOk.Text = "Ok";
            chkOk.UseVisualStyleBackColor = true;
            chkOk.CheckedChanged += chkOk_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkOk);
            Controls.Add(btnSchließen);
            Controls.Add(lblAnzeigen);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAnzeigen;
        private Button btnSchließen;
        private CheckBox chkOk;
    }
}
