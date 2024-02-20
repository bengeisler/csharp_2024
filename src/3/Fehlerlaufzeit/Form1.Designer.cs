// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Fehlerlaufzeit
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
            cmdOhne = new Button();
            cmdErweitert = new Button();
            cmdMit = new Button();
            txt1 = new TextBox();
            txt2 = new TextBox();
            LblAusgabe = new Label();
            CmdAusloesen = new Button();
            SuspendLayout();
            // 
            // cmdOhne
            // 
            cmdOhne.Location = new Point(323, 27);
            cmdOhne.Name = "cmdOhne";
            cmdOhne.Size = new Size(223, 23);
            cmdOhne.TabIndex = 0;
            cmdOhne.Text = "Ohne Excepition Handling";
            cmdOhne.UseVisualStyleBackColor = true;
            cmdOhne.Click += cmdOhne_Click;
            // 
            // cmdErweitert
            // 
            cmdErweitert.Location = new Point(323, 116);
            cmdErweitert.Name = "cmdErweitert";
            cmdErweitert.Size = new Size(223, 23);
            cmdErweitert.TabIndex = 2;
            cmdErweitert.Text = "Mit erweitertem Exception Handling";
            cmdErweitert.UseVisualStyleBackColor = true;
            cmdErweitert.Click += cmdErweitert_Click;
            // 
            // cmdMit
            // 
            cmdMit.Location = new Point(323, 71);
            cmdMit.Name = "cmdMit";
            cmdMit.Size = new Size(223, 23);
            cmdMit.TabIndex = 3;
            cmdMit.Text = "Mit Exception Handling";
            cmdMit.UseVisualStyleBackColor = true;
            cmdMit.Click += cmdMit_Click;
            // 
            // txt1
            // 
            txt1.Location = new Point(58, 28);
            txt1.Name = "txt1";
            txt1.Size = new Size(162, 23);
            txt1.TabIndex = 4;
            // 
            // txt2
            // 
            txt2.Location = new Point(58, 72);
            txt2.Name = "txt2";
            txt2.Size = new Size(162, 23);
            txt2.TabIndex = 5;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(58, 135);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(0, 15);
            LblAusgabe.TabIndex = 6;
            // 
            // CmdAusloesen
            // 
            CmdAusloesen.Location = new Point(323, 169);
            CmdAusloesen.Name = "CmdAusloesen";
            CmdAusloesen.Size = new Size(223, 23);
            CmdAusloesen.TabIndex = 7;
            CmdAusloesen.Text = "Auslösen";
            CmdAusloesen.UseVisualStyleBackColor = true;
            CmdAusloesen.Click += CmdAusloesen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdAusloesen);
            Controls.Add(LblAusgabe);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(cmdMit);
            Controls.Add(cmdErweitert);
            Controls.Add(cmdOhne);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdOhne;
        private Button cmdErweitert;
        private Button cmdMit;
        private TextBox txt1;
        private TextBox txt2;
        private Label LblAusgabe;
        private Button CmdAusloesen;
    }
}
