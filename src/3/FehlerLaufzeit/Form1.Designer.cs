// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace FehlerLaufzeit
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
            TxtEingabe1 = new TextBox();
            TxtEingabe2 = new TextBox();
            BtnOhneException = new Button();
            BtnMitException = new Button();
            BtnMitErweitertem = new Button();
            LblAusgabe = new Label();
            BtnAusnahme = new Button();
            SuspendLayout();
            // 
            // TxtEingabe1
            // 
            TxtEingabe1.Location = new Point(12, 12);
            TxtEingabe1.Name = "TxtEingabe1";
            TxtEingabe1.Size = new Size(100, 23);
            TxtEingabe1.TabIndex = 0;
            // 
            // TxtEingabe2
            // 
            TxtEingabe2.Location = new Point(12, 41);
            TxtEingabe2.Name = "TxtEingabe2";
            TxtEingabe2.Size = new Size(100, 23);
            TxtEingabe2.TabIndex = 1;
            // 
            // BtnOhneException
            // 
            BtnOhneException.Location = new Point(165, 12);
            BtnOhneException.Name = "BtnOhneException";
            BtnOhneException.Size = new Size(206, 23);
            BtnOhneException.TabIndex = 2;
            BtnOhneException.Text = "Ohne Exception Handling";
            BtnOhneException.UseVisualStyleBackColor = true;
            BtnOhneException.Click += BtnOhneException_Click;
            // 
            // BtnMitException
            // 
            BtnMitException.Location = new Point(165, 41);
            BtnMitException.Name = "BtnMitException";
            BtnMitException.Size = new Size(206, 23);
            BtnMitException.TabIndex = 3;
            BtnMitException.Text = "Mit Exception Handling";
            BtnMitException.UseVisualStyleBackColor = true;
            BtnMitException.Click += BtnMitException_Click;
            // 
            // BtnMitErweitertem
            // 
            BtnMitErweitertem.Location = new Point(165, 70);
            BtnMitErweitertem.Name = "BtnMitErweitertem";
            BtnMitErweitertem.Size = new Size(206, 23);
            BtnMitErweitertem.TabIndex = 4;
            BtnMitErweitertem.Text = "Mit erweitertem Exception Handling";
            BtnMitErweitertem.UseVisualStyleBackColor = true;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(20, 119);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(38, 15);
            LblAusgabe.TabIndex = 5;
            LblAusgabe.Text = "label1";
            // 
            // BtnAusnahme
            // 
            BtnAusnahme.Location = new Point(165, 99);
            BtnAusnahme.Name = "BtnAusnahme";
            BtnAusnahme.Size = new Size(206, 23);
            BtnAusnahme.TabIndex = 6;
            BtnAusnahme.Text = "Ausnahme auslösen";
            BtnAusnahme.UseVisualStyleBackColor = true;
            BtnAusnahme.Click += BtnAusnahme_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 153);
            Controls.Add(BtnAusnahme);
            Controls.Add(LblAusgabe);
            Controls.Add(BtnMitErweitertem);
            Controls.Add(BtnMitException);
            Controls.Add(BtnOhneException);
            Controls.Add(TxtEingabe2);
            Controls.Add(TxtEingabe1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtEingabe1;
        private TextBox TxtEingabe2;
        private Button BtnOhneException;
        private Button BtnMitException;
        private Button BtnMitErweitertem;
        private Label LblAusgabe;
        private Button BtnAusnahme;
    }
}
