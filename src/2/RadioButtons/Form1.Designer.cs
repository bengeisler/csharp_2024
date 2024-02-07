// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace RadioButtons
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
            optRot = new RadioButton();
            optGruen = new RadioButton();
            optBlau = new RadioButton();
            CmdPruefen = new Button();
            CmdAuswahlRot = new Button();
            lblPruefen = new Label();
            lblAuswaehlen = new Label();
            SuspendLayout();
            // 
            // optRot
            // 
            optRot.AutoSize = true;
            optRot.Location = new Point(617, 139);
            optRot.Name = "optRot";
            optRot.Size = new Size(43, 19);
            optRot.TabIndex = 0;
            optRot.TabStop = true;
            optRot.Text = "Rot";
            optRot.UseVisualStyleBackColor = true;
            optRot.CheckedChanged += optFarbe_CheckedChanged;
            // 
            // optGruen
            // 
            optGruen.AutoSize = true;
            optGruen.Location = new Point(617, 175);
            optGruen.Name = "optGruen";
            optGruen.Size = new Size(51, 19);
            optGruen.TabIndex = 1;
            optGruen.TabStop = true;
            optGruen.Text = "Grün";
            optGruen.UseVisualStyleBackColor = true;
            optGruen.CheckedChanged += optFarbe_CheckedChanged;
            // 
            // optBlau
            // 
            optBlau.AutoSize = true;
            optBlau.Location = new Point(617, 217);
            optBlau.Name = "optBlau";
            optBlau.Size = new Size(48, 19);
            optBlau.TabIndex = 2;
            optBlau.TabStop = true;
            optBlau.Text = "Blau";
            optBlau.UseVisualStyleBackColor = true;
            optBlau.CheckedChanged += optFarbe_CheckedChanged;
            // 
            // CmdPruefen
            // 
            CmdPruefen.Location = new Point(617, 77);
            CmdPruefen.Name = "CmdPruefen";
            CmdPruefen.Size = new Size(111, 26);
            CmdPruefen.TabIndex = 3;
            CmdPruefen.Text = "Prüfen";
            CmdPruefen.UseVisualStyleBackColor = true;
            CmdPruefen.Click += CmdPruefen_Click;
            // 
            // CmdAuswahlRot
            // 
            CmdAuswahlRot.Location = new Point(617, 276);
            CmdAuswahlRot.Name = "CmdAuswahlRot";
            CmdAuswahlRot.Size = new Size(111, 26);
            CmdAuswahlRot.TabIndex = 4;
            CmdAuswahlRot.Text = "Rot auswählen";
            CmdAuswahlRot.UseVisualStyleBackColor = true;
            CmdAuswahlRot.Click += CmdAuswahlRot_Click;
            // 
            // lblPruefen
            // 
            lblPruefen.AutoSize = true;
            lblPruefen.Location = new Point(48, 77);
            lblPruefen.Name = "lblPruefen";
            lblPruefen.Size = new Size(38, 15);
            lblPruefen.TabIndex = 5;
            lblPruefen.Text = "label1";
            // 
            // lblAuswaehlen
            // 
            lblAuswaehlen.AutoSize = true;
            lblAuswaehlen.Location = new Point(48, 287);
            lblAuswaehlen.Name = "lblAuswaehlen";
            lblAuswaehlen.Size = new Size(38, 15);
            lblAuswaehlen.TabIndex = 6;
            lblAuswaehlen.Text = "label2";
            lblAuswaehlen.Click += lblAuswaehlen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAuswaehlen);
            Controls.Add(lblPruefen);
            Controls.Add(CmdAuswahlRot);
            Controls.Add(CmdPruefen);
            Controls.Add(optBlau);
            Controls.Add(optGruen);
            Controls.Add(optRot);
            Name = "Form1";
            Text = "RadioButtons";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton optRot;
        private RadioButton optGruen;
        private RadioButton optBlau;
        private Button CmdPruefen;
        private Button CmdAuswahlRot;
        private Label lblPruefen;
        private Label lblAuswaehlen;
    }
}
