// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Methoden
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
            CmdAnzeigen1 = new Button();
            LblAusgabe = new Label();
            CmdAnzeigen2 = new Button();
            CmdAnzeige3 = new Button();
            CmdAnzeigen4 = new Button();
            CmdAnzeige6 = new Button();
            CmdAnzeigen7 = new Button();
            CmdAnzeige8 = new Button();
            SuspendLayout();
            // 
            // CmdAnzeigen1
            // 
            CmdAnzeigen1.Location = new Point(267, 27);
            CmdAnzeigen1.Name = "CmdAnzeigen1";
            CmdAnzeigen1.Size = new Size(75, 23);
            CmdAnzeigen1.TabIndex = 0;
            CmdAnzeigen1.Text = "Anzeigen1";
            CmdAnzeigen1.UseVisualStyleBackColor = true;
            CmdAnzeigen1.Click += CmdAnzeigen1_Click;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(69, 32);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(38, 15);
            LblAusgabe.TabIndex = 1;
            LblAusgabe.Text = "label1";
            // 
            // CmdAnzeigen2
            // 
            CmdAnzeigen2.Location = new Point(267, 68);
            CmdAnzeigen2.Name = "CmdAnzeigen2";
            CmdAnzeigen2.Size = new Size(75, 23);
            CmdAnzeigen2.TabIndex = 2;
            CmdAnzeigen2.Text = "Anzeigen2";
            CmdAnzeigen2.UseVisualStyleBackColor = true;
            CmdAnzeigen2.Click += CmdAnzeigen2_Click;
            // 
            // CmdAnzeige3
            // 
            CmdAnzeige3.Location = new Point(267, 112);
            CmdAnzeige3.Name = "CmdAnzeige3";
            CmdAnzeige3.Size = new Size(75, 23);
            CmdAnzeige3.TabIndex = 3;
            CmdAnzeige3.Text = "Anzeigen3";
            CmdAnzeige3.UseVisualStyleBackColor = true;
            // 
            // CmdAnzeigen4
            // 
            CmdAnzeigen4.Location = new Point(267, 160);
            CmdAnzeigen4.Name = "CmdAnzeigen4";
            CmdAnzeigen4.Size = new Size(75, 23);
            CmdAnzeigen4.TabIndex = 4;
            CmdAnzeigen4.Text = "Anzeige4";
            CmdAnzeigen4.UseVisualStyleBackColor = true;
            CmdAnzeigen4.Click += CmdAnzeigen4_Click;
            // 
            // CmdAnzeige6
            // 
            CmdAnzeige6.Location = new Point(267, 205);
            CmdAnzeige6.Name = "CmdAnzeige6";
            CmdAnzeige6.Size = new Size(75, 23);
            CmdAnzeige6.TabIndex = 5;
            CmdAnzeige6.Text = "Anzeigen6";
            CmdAnzeige6.UseVisualStyleBackColor = true;
            CmdAnzeige6.Click += CmdAnzeige6_Click;
            // 
            // CmdAnzeigen7
            // 
            CmdAnzeigen7.Location = new Point(267, 245);
            CmdAnzeigen7.Name = "CmdAnzeigen7";
            CmdAnzeigen7.Size = new Size(75, 23);
            CmdAnzeigen7.TabIndex = 6;
            CmdAnzeigen7.Text = "Anzeige7";
            CmdAnzeigen7.UseVisualStyleBackColor = true;
            CmdAnzeigen7.Click += CmdAnzeigen7_Click;
            // 
            // CmdAnzeige8
            // 
            CmdAnzeige8.Location = new Point(286, 290);
            CmdAnzeige8.Name = "CmdAnzeige8";
            CmdAnzeige8.Size = new Size(75, 23);
            CmdAnzeige8.TabIndex = 7;
            CmdAnzeige8.Text = "Anzeigen8";
            CmdAnzeige8.UseVisualStyleBackColor = true;
            CmdAnzeige8.Click += CmdAnzeige8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdAnzeige8);
            Controls.Add(CmdAnzeigen7);
            Controls.Add(CmdAnzeige6);
            Controls.Add(CmdAnzeigen4);
            Controls.Add(CmdAnzeige3);
            Controls.Add(CmdAnzeigen2);
            Controls.Add(LblAusgabe);
            Controls.Add(CmdAnzeigen1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAnzeigen1;
        private Label LblAusgabe;
        private Button CmdAnzeigen2;
        private Button CmdAnzeige3;
        private Button CmdAnzeigen4;
        private Button CmdAnzeige6;
        private Button CmdAnzeigen7;
        private Button CmdAnzeige8;
    }
}
