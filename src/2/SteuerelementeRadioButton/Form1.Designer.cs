// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementeRadioButton
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
            Cmdpruefen = new Button();
            CmdAuswahl = new Button();
            OptRot = new RadioButton();
            OptGruen = new RadioButton();
            OptBlau = new RadioButton();
            Lblpruefen = new Label();
            LblAuswahl = new Label();
            SuspendLayout();
            // 
            // Cmdpruefen
            // 
            Cmdpruefen.Location = new Point(291, 55);
            Cmdpruefen.Name = "Cmdpruefen";
            Cmdpruefen.Size = new Size(75, 23);
            Cmdpruefen.TabIndex = 0;
            Cmdpruefen.Text = "Prüfen";
            Cmdpruefen.UseVisualStyleBackColor = true;
            Cmdpruefen.Click += Cmdpruefen_Click;
            // 
            // CmdAuswahl
            // 
            CmdAuswahl.Location = new Point(291, 211);
            CmdAuswahl.Name = "CmdAuswahl";
            CmdAuswahl.Size = new Size(75, 23);
            CmdAuswahl.TabIndex = 1;
            CmdAuswahl.Text = "button2";
            CmdAuswahl.UseVisualStyleBackColor = true;
            // 
            // OptRot
            // 
            OptRot.AutoSize = true;
            OptRot.Location = new Point(225, 85);
            OptRot.Name = "OptRot";
            OptRot.Size = new Size(43, 19);
            OptRot.TabIndex = 2;
            OptRot.TabStop = true;
            OptRot.Text = "Rot";
            OptRot.UseVisualStyleBackColor = true;
            OptRot.CheckedChanged += OptRot_CheckedChanged;
            // 
            // OptGruen
            // 
            OptGruen.AutoSize = true;
            OptGruen.Location = new Point(225, 124);
            OptGruen.Name = "OptGruen";
            OptGruen.Size = new Size(51, 19);
            OptGruen.TabIndex = 3;
            OptGruen.TabStop = true;
            OptGruen.Text = "Grün";
            OptGruen.UseVisualStyleBackColor = true;
            // 
            // OptBlau
            // 
            OptBlau.AutoSize = true;
            OptBlau.Location = new Point(225, 166);
            OptBlau.Name = "OptBlau";
            OptBlau.Size = new Size(48, 19);
            OptBlau.TabIndex = 4;
            OptBlau.TabStop = true;
            OptBlau.Text = "Blau";
            OptBlau.UseVisualStyleBackColor = true;
            // 
            // Lblpruefen
            // 
            Lblpruefen.AutoSize = true;
            Lblpruefen.Location = new Point(45, 44);
            Lblpruefen.Name = "Lblpruefen";
            Lblpruefen.Size = new Size(38, 15);
            Lblpruefen.TabIndex = 5;
            Lblpruefen.Text = "label1";
            // 
            // LblAuswahl
            // 
            LblAuswahl.AutoSize = true;
            LblAuswahl.Location = new Point(55, 193);
            LblAuswahl.Name = "LblAuswahl";
            LblAuswahl.Size = new Size(38, 15);
            LblAuswahl.TabIndex = 6;
            LblAuswahl.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAuswahl);
            Controls.Add(Lblpruefen);
            Controls.Add(OptBlau);
            Controls.Add(OptGruen);
            Controls.Add(OptRot);
            Controls.Add(CmdAuswahl);
            Controls.Add(Cmdpruefen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cmdpruefen;
        private Button CmdAuswahl;
        private RadioButton OptRot;
        private RadioButton OptGruen;
        private RadioButton OptBlau;
        private Label Lblpruefen;
        private Label LblAuswahl;
    }
}
