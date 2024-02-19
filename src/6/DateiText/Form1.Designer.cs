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
            TxtBox = new TextBox();
            BtnSchreiben = new Button();
            BtnAnhaengen = new Button();
            BtnLesen = new Button();
            LblAusgabe = new Label();
            BtnZeilenSchreiben = new Button();
            SuspendLayout();
            // 
            // TxtBox
            // 
            TxtBox.Location = new Point(26, 79);
            TxtBox.Multiline = true;
            TxtBox.Name = "TxtBox";
            TxtBox.Size = new Size(340, 125);
            TxtBox.TabIndex = 0;
            // 
            // BtnSchreiben
            // 
            BtnSchreiben.Location = new Point(26, 21);
            BtnSchreiben.Name = "BtnSchreiben";
            BtnSchreiben.Size = new Size(75, 23);
            BtnSchreiben.TabIndex = 1;
            BtnSchreiben.Text = "Schreiben";
            BtnSchreiben.UseVisualStyleBackColor = true;
            BtnSchreiben.Click += BtnSchreiben_Click;
            // 
            // BtnAnhaengen
            // 
            BtnAnhaengen.Location = new Point(152, 21);
            BtnAnhaengen.Name = "BtnAnhaengen";
            BtnAnhaengen.Size = new Size(75, 23);
            BtnAnhaengen.TabIndex = 2;
            BtnAnhaengen.Text = "Anhängen";
            BtnAnhaengen.UseVisualStyleBackColor = true;
            BtnAnhaengen.Click += BtnAnhaengen_Click;
            // 
            // BtnLesen
            // 
            BtnLesen.Location = new Point(291, 21);
            BtnLesen.Name = "BtnLesen";
            BtnLesen.Size = new Size(75, 23);
            BtnLesen.TabIndex = 3;
            BtnLesen.Text = "Lesen";
            BtnLesen.UseVisualStyleBackColor = true;
            BtnLesen.Click += BtnLesen_Click;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(26, 217);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(38, 15);
            LblAusgabe.TabIndex = 4;
            LblAusgabe.Text = "label1";
            // 
            // BtnZeilenSchreiben
            // 
            BtnZeilenSchreiben.Location = new Point(26, 50);
            BtnZeilenSchreiben.Name = "BtnZeilenSchreiben";
            BtnZeilenSchreiben.Size = new Size(101, 23);
            BtnZeilenSchreiben.TabIndex = 5;
            BtnZeilenSchreiben.Text = "Zeile Schreiben";
            BtnZeilenSchreiben.UseVisualStyleBackColor = true;
            BtnZeilenSchreiben.Click += BtnZeilenSchreiben_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 273);
            Controls.Add(BtnZeilenSchreiben);
            Controls.Add(LblAusgabe);
            Controls.Add(BtnLesen);
            Controls.Add(BtnAnhaengen);
            Controls.Add(BtnSchreiben);
            Controls.Add(TxtBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBox;
        private Button BtnSchreiben;
        private Button BtnAnhaengen;
        private Button BtnLesen;
        private Label LblAusgabe;
        private Button BtnZeilenSchreiben;
    }
}
