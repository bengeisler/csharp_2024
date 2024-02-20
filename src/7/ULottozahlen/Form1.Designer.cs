// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace ULottozahlen
{
    partial class FrmLottozahlen
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
            Lbl = new Label();
            SuspendLayout();
            // 
            // CmdZiehung
            // 
            CmdZiehung.Location = new Point(323, 47);
            CmdZiehung.Name = "CmdZiehung";
            CmdZiehung.Size = new Size(75, 23);
            CmdZiehung.TabIndex = 0;
            CmdZiehung.Text = "Ziehung";
            CmdZiehung.UseVisualStyleBackColor = true;
            CmdZiehung.Click += CmdZiehung_Click;
            // 
            // LstLottozahlen
            // 
            LstLottozahlen.FormattingEnabled = true;
            LstLottozahlen.ItemHeight = 15;
            LstLottozahlen.Location = new Point(301, 96);
            LstLottozahlen.Name = "LstLottozahlen";
            LstLottozahlen.Size = new Size(120, 184);
            LstLottozahlen.TabIndex = 1;
            // 
            // TxtZusatzzahl
            // 
            TxtZusatzzahl.Location = new Point(310, 372);
            TxtZusatzzahl.Name = "TxtZusatzzahl";
            TxtZusatzzahl.Size = new Size(100, 23);
            TxtZusatzzahl.TabIndex = 2;
            // 
            // Lbl
            // 
            Lbl.AutoSize = true;
            Lbl.Location = new Point(340, 316);
            Lbl.Name = "Lbl";
            Lbl.Size = new Size(38, 15);
            Lbl.TabIndex = 3;
            Lbl.Text = "label1";
            // 
            // FrmLottozahlen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Lbl);
            Controls.Add(TxtZusatzzahl);
            Controls.Add(LstLottozahlen);
            Controls.Add(CmdZiehung);
            Name = "FrmLottozahlen";
            Text = "Lottozahlen";
            Load += FrmLottozahlen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdZiehung;
        private ListBox LstLottozahlen;
        private TextBox TxtZusatzzahl;
        private Label Lbl;
    }
}
