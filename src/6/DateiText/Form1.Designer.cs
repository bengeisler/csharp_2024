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
            CmdSchreiben = new Button();
            CmdAnhängen = new Button();
            CmdLesen = new Button();
            TxtEingabe = new TextBox();
            LblAusgabe = new Label();
            CmdZeilenSchreiben = new Button();
            SuspendLayout();
            // 
            // CmdSchreiben
            // 
            CmdSchreiben.Location = new Point(12, 12);
            CmdSchreiben.Name = "CmdSchreiben";
            CmdSchreiben.Size = new Size(112, 34);
            CmdSchreiben.TabIndex = 0;
            CmdSchreiben.Text = "Schreiben";
            CmdSchreiben.UseVisualStyleBackColor = true;
            CmdSchreiben.Click += CmdSchreiben_Click;
            // 
            // CmdAnhängen
            // 
            CmdAnhängen.Location = new Point(331, 12);
            CmdAnhängen.Name = "CmdAnhängen";
            CmdAnhängen.Size = new Size(112, 34);
            CmdAnhängen.TabIndex = 1;
            CmdAnhängen.Text = "Anhängen";
            CmdAnhängen.UseVisualStyleBackColor = true;
            CmdAnhängen.Click += CmdAnhängen_Click;
            // 
            // CmdLesen
            // 
            CmdLesen.Location = new Point(458, 12);
            CmdLesen.Name = "CmdLesen";
            CmdLesen.Size = new Size(112, 34);
            CmdLesen.TabIndex = 2;
            CmdLesen.Text = "Lesen";
            CmdLesen.UseVisualStyleBackColor = true;
            CmdLesen.Click += CmdLesen_Click;
            // 
            // TxtEingabe
            // 
            TxtEingabe.Location = new Point(12, 89);
            TxtEingabe.Multiline = true;
            TxtEingabe.Name = "TxtEingabe";
            TxtEingabe.Size = new Size(568, 217);
            TxtEingabe.TabIndex = 3;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(18, 309);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(59, 25);
            LblAusgabe.TabIndex = 4;
            LblAusgabe.Text = "label1";
            // 
            // CmdZeilenSchreiben
            // 
            CmdZeilenSchreiben.Location = new Point(12, 49);
            CmdZeilenSchreiben.Name = "CmdZeilenSchreiben";
            CmdZeilenSchreiben.Size = new Size(207, 34);
            CmdZeilenSchreiben.TabIndex = 5;
            CmdZeilenSchreiben.Text = "Zeilenweise schreiben";
            CmdZeilenSchreiben.UseVisualStyleBackColor = true;
            CmdZeilenSchreiben.Click += CmdZeilenSchreiben_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 347);
            Controls.Add(CmdZeilenSchreiben);
            Controls.Add(LblAusgabe);
            Controls.Add(TxtEingabe);
            Controls.Add(CmdLesen);
            Controls.Add(CmdAnhängen);
            Controls.Add(CmdSchreiben);
            Name = "Form1";
            Text = "Datei schreiben und lesen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdSchreiben;
        private Button CmdAnhängen;
        private Button CmdLesen;
        private TextBox TxtEingabe;
        private Label LblAusgabe;
        private Button CmdZeilenSchreiben;
    }
}
