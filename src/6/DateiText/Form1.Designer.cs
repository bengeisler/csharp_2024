// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace DateiText
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
            TxtEingabe = new TextBox();
            CmdSchreiben = new Button();
            CmdAnhängen = new Button();
            cmdLesen = new Button();
            LblAusgabe = new Label();
            cmdZeilenWeisenSchreiben = new Button();
            SuspendLayout();
            // 
            // TxtEingabe
            // 
            TxtEingabe.Location = new Point(22, 72);
            TxtEingabe.Multiline = true;
            TxtEingabe.Name = "TxtEingabe";
            TxtEingabe.Size = new Size(430, 112);
            TxtEingabe.TabIndex = 0;
            // 
            // CmdSchreiben
            // 
            CmdSchreiben.Location = new Point(32, 12);
            CmdSchreiben.Name = "CmdSchreiben";
            CmdSchreiben.Size = new Size(75, 23);
            CmdSchreiben.TabIndex = 1;
            CmdSchreiben.Text = "Schreiben";
            CmdSchreiben.UseVisualStyleBackColor = true;
            CmdSchreiben.Click += CmdSchreiben_Click;
            // 
            // CmdAnhängen
            // 
            CmdAnhängen.Location = new Point(185, 12);
            CmdAnhängen.Name = "CmdAnhängen";
            CmdAnhängen.Size = new Size(75, 23);
            CmdAnhängen.TabIndex = 2;
            CmdAnhängen.Text = "Anhängen";
            CmdAnhängen.UseVisualStyleBackColor = true;
            CmdAnhängen.Click += CmdAnhängen_Click;
            // 
            // cmdLesen
            // 
            cmdLesen.Location = new Point(377, 12);
            cmdLesen.Name = "cmdLesen";
            cmdLesen.Size = new Size(75, 23);
            cmdLesen.TabIndex = 3;
            cmdLesen.Text = "Lesen";
            cmdLesen.UseVisualStyleBackColor = true;
            cmdLesen.Click += cmdLesen_Click;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(22, 224);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(38, 15);
            LblAusgabe.TabIndex = 4;
            LblAusgabe.Text = "label1";
            // 
            // cmdZeilenWeisenSchreiben
            // 
            cmdZeilenWeisenSchreiben.Location = new Point(32, 43);
            cmdZeilenWeisenSchreiben.Name = "cmdZeilenWeisenSchreiben";
            cmdZeilenWeisenSchreiben.Size = new Size(147, 23);
            cmdZeilenWeisenSchreiben.TabIndex = 5;
            cmdZeilenWeisenSchreiben.Text = "ZeilenweiseSchreiben";
            cmdZeilenWeisenSchreiben.UseVisualStyleBackColor = true;
            cmdZeilenWeisenSchreiben.Click += cmdZeilenWeisenSchreiben_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdZeilenWeisenSchreiben);
            Controls.Add(LblAusgabe);
            Controls.Add(cmdLesen);
            Controls.Add(CmdAnhängen);
            Controls.Add(CmdSchreiben);
            Controls.Add(TxtEingabe);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtEingabe;
        private Button CmdSchreiben;
        private Button CmdAnhängen;
        private Button cmdLesen;
        private Label LblAusgabe;
        private Button cmdZeilenWeisenSchreiben;
    }
}
