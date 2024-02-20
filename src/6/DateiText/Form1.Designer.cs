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
            CmdAnhaengen = new Button();
            CmdLesen = new Button();
            TxtEingabe = new TextBox();
            LblAnzeige = new Label();
            CmdReihenweise = new Button();
            SuspendLayout();
            // 
            // CmdSchreiben
            // 
            CmdSchreiben.Location = new Point(78, 48);
            CmdSchreiben.Name = "CmdSchreiben";
            CmdSchreiben.Size = new Size(75, 23);
            CmdSchreiben.TabIndex = 0;
            CmdSchreiben.Text = "Schreiben";
            CmdSchreiben.UseVisualStyleBackColor = true;
            CmdSchreiben.Click += CmdSchreiben_Click;
            // 
            // CmdAnhaengen
            // 
            CmdAnhaengen.Location = new Point(198, 48);
            CmdAnhaengen.Name = "CmdAnhaengen";
            CmdAnhaengen.Size = new Size(75, 23);
            CmdAnhaengen.TabIndex = 1;
            CmdAnhaengen.Text = "Anhängen";
            CmdAnhaengen.UseVisualStyleBackColor = true;
            CmdAnhaengen.Click += CmdAnhaengen_Click;
            // 
            // CmdLesen
            // 
            CmdLesen.Location = new Point(325, 48);
            CmdLesen.Name = "CmdLesen";
            CmdLesen.Size = new Size(75, 23);
            CmdLesen.TabIndex = 2;
            CmdLesen.Text = "Lesen";
            CmdLesen.UseVisualStyleBackColor = true;
            CmdLesen.Click += CmdLesen_Click;
            // 
            // TxtEingabe
            // 
            TxtEingabe.Location = new Point(78, 129);
            TxtEingabe.Multiline = true;
            TxtEingabe.Name = "TxtEingabe";
            TxtEingabe.Size = new Size(358, 167);
            TxtEingabe.TabIndex = 3;
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(78, 354);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(38, 15);
            LblAnzeige.TabIndex = 4;
            LblAnzeige.Text = "label1";
            // 
            // CmdReihenweise
            // 
            CmdReihenweise.Location = new Point(440, 48);
            CmdReihenweise.Name = "CmdReihenweise";
            CmdReihenweise.Size = new Size(104, 23);
            CmdReihenweise.TabIndex = 5;
            CmdReihenweise.Text = "Reihenweise";
            CmdReihenweise.UseVisualStyleBackColor = true;
            CmdReihenweise.Click += CmdReihenweise_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 411);
            Controls.Add(CmdReihenweise);
            Controls.Add(LblAnzeige);
            Controls.Add(TxtEingabe);
            Controls.Add(CmdLesen);
            Controls.Add(CmdAnhaengen);
            Controls.Add(CmdSchreiben);
            Name = "Form1";
            Text = "Datei schreiben und lesen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdSchreiben;
        private Button CmdAnhaengen;
        private Button CmdLesen;
        private TextBox TxtEingabe;
        private Label LblAnzeige;
        private Button CmdReihenweise;
    }
}
