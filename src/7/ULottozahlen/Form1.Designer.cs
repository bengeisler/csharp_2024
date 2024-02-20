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
            LstLottozahlen = new ListBox();
            TxtZusatzzahl = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // CmdZiehung
            // 
            CmdZiehung.Location = new Point(106, 12);
            CmdZiehung.Name = "CmdZiehung";
            CmdZiehung.Size = new Size(112, 34);
            CmdZiehung.TabIndex = 0;
            CmdZiehung.Text = "Ziehung";
            CmdZiehung.UseVisualStyleBackColor = true;
            CmdZiehung.Click += CmdZiehung_Click;
            // 
            // LstLottozahlen
            // 
            LstLottozahlen.FormattingEnabled = true;
            LstLottozahlen.ItemHeight = 25;
            LstLottozahlen.Location = new Point(106, 52);
            LstLottozahlen.Name = "LstLottozahlen";
            LstLottozahlen.Size = new Size(112, 179);
            LstLottozahlen.TabIndex = 1;
            // 
            // TxtZusatzzahl
            // 
            TxtZusatzzahl.Location = new Point(106, 280);
            TxtZusatzzahl.Name = "TxtZusatzzahl";
            TxtZusatzzahl.Size = new Size(112, 31);
            TxtZusatzzahl.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 252);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 3;
            label1.Text = "Zusatzzahl";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 373);
            Controls.Add(label1);
            Controls.Add(TxtZusatzzahl);
            Controls.Add(LstLottozahlen);
            Controls.Add(CmdZiehung);
            Name = "Form1";
            Text = "Lottozahlen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdZiehung;
        private ListBox LstLottozahlen;
        private TextBox TxtZusatzzahl;
        private Label label1;
    }
}
