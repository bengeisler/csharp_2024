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
            LblAusgabe = new Label();
            TxtBox = new TextBox();
            CmdZeilenweiseSchreiben = new Button();
            SuspendLayout();
            // 
            // CmdSchreiben
            // 
            CmdSchreiben.Location = new Point(67, 62);
            CmdSchreiben.Name = "CmdSchreiben";
            CmdSchreiben.Size = new Size(75, 23);
            CmdSchreiben.TabIndex = 0;
            CmdSchreiben.Text = "Schreiben";
            CmdSchreiben.UseVisualStyleBackColor = true;
            CmdSchreiben.Click += CmdSchreiben_Click;
            // 
            // CmdAnhaengen
            // 
            CmdAnhaengen.Location = new Point(241, 62);
            CmdAnhaengen.Name = "CmdAnhaengen";
            CmdAnhaengen.Size = new Size(75, 23);
            CmdAnhaengen.TabIndex = 1;
            CmdAnhaengen.Text = "Anhängen";
            CmdAnhaengen.UseVisualStyleBackColor = true;
            CmdAnhaengen.Click += CmdAnhaengen_Click;
            // 
            // CmdLesen
            // 
            CmdLesen.Location = new Point(416, 62);
            CmdLesen.Name = "CmdLesen";
            CmdLesen.Size = new Size(75, 23);
            CmdLesen.TabIndex = 2;
            CmdLesen.Text = "Lesen";
            CmdLesen.UseVisualStyleBackColor = true;
            CmdLesen.Click += CmdLesen_Click;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(71, 341);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(38, 15);
            LblAusgabe.TabIndex = 3;
            LblAusgabe.Text = "label1";
            // 
            // TxtBox
            // 
            TxtBox.Location = new Point(73, 133);
            TxtBox.Multiline = true;
            TxtBox.Name = "TxtBox";
            TxtBox.Size = new Size(395, 130);
            TxtBox.TabIndex = 4;
            TxtBox.TextChanged += TxtBox_TextChanged;
            // 
            // CmdZeilenweiseSchreiben
            // 
            CmdZeilenweiseSchreiben.Location = new Point(81, 104);
            CmdZeilenweiseSchreiben.Name = "CmdZeilenweiseSchreiben";
            CmdZeilenweiseSchreiben.Size = new Size(75, 23);
            CmdZeilenweiseSchreiben.TabIndex = 5;
            CmdZeilenweiseSchreiben.Text = "ZeilenweiseSchreiben";
            CmdZeilenweiseSchreiben.UseVisualStyleBackColor = true;
            CmdZeilenweiseSchreiben.Click += CmdZeilenweiseSchreiben_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdZeilenweiseSchreiben);
            Controls.Add(TxtBox);
            Controls.Add(LblAusgabe);
            Controls.Add(CmdLesen);
            Controls.Add(CmdAnhaengen);
            Controls.Add(CmdSchreiben);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdSchreiben;
        private Button CmdAnhaengen;
        private Button CmdLesen;
        private Label LblAusgabe;
        private TextBox TxtBox;
        private Button CmdZeilenweiseSchreiben;
    }
}
