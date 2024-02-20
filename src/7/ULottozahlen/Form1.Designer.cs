// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace ULottozahlen
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
            CmdZiehung = new Button();
            LstZahl = new ListBox();
            TxtZusatzzahl = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // CmdZiehung
            // 
            CmdZiehung.Location = new Point(154, 47);
            CmdZiehung.Name = "CmdZiehung";
            CmdZiehung.Size = new Size(78, 23);
            CmdZiehung.TabIndex = 0;
            CmdZiehung.Text = "Ziehung";
            CmdZiehung.UseVisualStyleBackColor = true;
            CmdZiehung.Click += CmdZiehung_Click;
            // 
            // LstZahl
            // 
            LstZahl.FormattingEnabled = true;
            LstZahl.ItemHeight = 15;
            LstZahl.Location = new Point(154, 89);
            LstZahl.Name = "LstZahl";
            LstZahl.Size = new Size(78, 109);
            LstZahl.TabIndex = 1;
            // 
            // TxtZusatzzahl
            // 
            TxtZusatzzahl.Location = new Point(154, 238);
            TxtZusatzzahl.Name = "TxtZusatzzahl";
            TxtZusatzzahl.Size = new Size(78, 23);
            TxtZusatzzahl.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 210);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 3;
            label1.Text = "Zusatzzahl:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(TxtZusatzzahl);
            Controls.Add(LstZahl);
            Controls.Add(CmdZiehung);
            Name = "Form1";
            Text = "Lottozahlen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdZiehung;
        private ListBox LstZahl;
        private TextBox TxtZusatzzahl;
        private Label label1;
    }
}
