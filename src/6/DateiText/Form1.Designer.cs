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
            CmdLesen = new Button();
            LblSchreiben = new Label();
            cmdZeile = new Button();
            SuspendLayout();
            // 
            // TxtEingabe
            // 
            TxtEingabe.Location = new Point(50, 66);
            TxtEingabe.Multiline = true;
            TxtEingabe.Name = "TxtEingabe";
            TxtEingabe.Size = new Size(363, 122);
            TxtEingabe.TabIndex = 0;
            // 
            // CmdSchreiben
            // 
            CmdSchreiben.Location = new Point(59, 12);
            CmdSchreiben.Name = "CmdSchreiben";
            CmdSchreiben.Size = new Size(75, 23);
            CmdSchreiben.TabIndex = 1;
            CmdSchreiben.Text = "Schreiben";
            CmdSchreiben.UseVisualStyleBackColor = true;
            CmdSchreiben.Click += CmdSchreiben_Click;
            // 
            // CmdAnhängen
            // 
            CmdAnhängen.Location = new Point(202, 12);
            CmdAnhängen.Name = "CmdAnhängen";
            CmdAnhängen.Size = new Size(75, 23);
            CmdAnhängen.TabIndex = 2;
            CmdAnhängen.Text = "Anhängen";
            CmdAnhängen.UseVisualStyleBackColor = true;
            CmdAnhängen.Click += CmdAnhängen_Click;
            // 
            // CmdLesen
            // 
            CmdLesen.Location = new Point(329, 12);
            CmdLesen.Name = "CmdLesen";
            CmdLesen.Size = new Size(75, 23);
            CmdLesen.TabIndex = 3;
            CmdLesen.Text = "Lesen";
            CmdLesen.UseVisualStyleBackColor = true;
            CmdLesen.Click += CmdLesen_Click;
            // 
            // LblSchreiben
            // 
            LblSchreiben.AutoSize = true;
            LblSchreiben.Location = new Point(59, 212);
            LblSchreiben.Name = "LblSchreiben";
            LblSchreiben.Size = new Size(38, 15);
            LblSchreiben.TabIndex = 4;
            LblSchreiben.Text = "label1";
            // 
            // cmdZeile
            // 
            cmdZeile.Location = new Point(59, 37);
            cmdZeile.Name = "cmdZeile";
            cmdZeile.Size = new Size(132, 23);
            cmdZeile.TabIndex = 5;
            cmdZeile.Text = "Zeilenweise schreiben";
            cmdZeile.UseVisualStyleBackColor = true;
            cmdZeile.Click += cmdZeile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdZeile);
            Controls.Add(LblSchreiben);
            Controls.Add(CmdLesen);
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
        private Button CmdLesen;
        private Label LblSchreiben;
        private Button cmdZeile;
    }
}
