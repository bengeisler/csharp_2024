// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementeCheckBox
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
            LblSchalter1 = new Label();
            Lblschalter2 = new Label();
            ChkSchalter = new CheckBox();
            CmdUmschalten = new Button();
            Cmdpruefen = new Button();
            SuspendLayout();
            // 
            // LblSchalter1
            // 
            LblSchalter1.AutoSize = true;
            LblSchalter1.Location = new Point(66, 71);
            LblSchalter1.Name = "LblSchalter1";
            LblSchalter1.Size = new Size(38, 15);
            LblSchalter1.TabIndex = 0;
            LblSchalter1.Text = "label1";
            // 
            // Lblschalter2
            // 
            Lblschalter2.AutoSize = true;
            Lblschalter2.Location = new Point(82, 136);
            Lblschalter2.Name = "Lblschalter2";
            Lblschalter2.Size = new Size(38, 15);
            Lblschalter2.TabIndex = 1;
            Lblschalter2.Text = "label2";
            // 
            // ChkSchalter
            // 
            ChkSchalter.AutoSize = true;
            ChkSchalter.Location = new Point(303, 136);
            ChkSchalter.Name = "ChkSchalter";
            ChkSchalter.Size = new Size(68, 19);
            ChkSchalter.TabIndex = 2;
            ChkSchalter.Text = "Schalter";
            ChkSchalter.UseVisualStyleBackColor = true;
            // 
            // CmdUmschalten
            // 
            CmdUmschalten.Location = new Point(297, 61);
            CmdUmschalten.Name = "CmdUmschalten";
            CmdUmschalten.Size = new Size(75, 23);
            CmdUmschalten.TabIndex = 3;
            CmdUmschalten.Text = "Umschalten";
            CmdUmschalten.UseVisualStyleBackColor = true;
            CmdUmschalten.Click += CmdUmschalten_Click;
            // 
            // Cmdpruefen
            // 
            Cmdpruefen.Location = new Point(303, 180);
            Cmdpruefen.Name = "Cmdpruefen";
            Cmdpruefen.Size = new Size(75, 23);
            Cmdpruefen.TabIndex = 4;
            Cmdpruefen.Text = "Prüfen";
            Cmdpruefen.UseVisualStyleBackColor = true;
            Cmdpruefen.Click += Cmdpruefen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Cmdpruefen);
            Controls.Add(CmdUmschalten);
            Controls.Add(ChkSchalter);
            Controls.Add(Lblschalter2);
            Controls.Add(LblSchalter1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblSchalter1;
        private Label Lblschalter2;
        private CheckBox ChkSchalter;
        private Button CmdUmschalten;
        private Button Cmdpruefen;
    }
}
