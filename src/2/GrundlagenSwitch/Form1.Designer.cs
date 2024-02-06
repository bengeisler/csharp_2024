// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenSwitch
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
            TxtStadt = new TextBox();
            CmdAnzeigen2 = new Button();
            CmdAnzeigen3 = new Button();
            CmdAnzeigen4 = new Button();
            CmdAnzeigen5 = new Button();
            CmdAnzeigen6 = new Button();
            SuspendLayout();
            // 
            // CmdAnzeigen1
            // 
            CmdAnzeigen1.Location = new Point(516, 99);
            CmdAnzeigen1.Name = "CmdAnzeigen1";
            CmdAnzeigen1.Size = new Size(173, 57);
            CmdAnzeigen1.TabIndex = 0;
            CmdAnzeigen1.Text = "Anzeigen 1";
            CmdAnzeigen1.UseVisualStyleBackColor = true;
            CmdAnzeigen1.Click += CmdAnzeigen1_Click;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(396, 64);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(38, 15);
            LblAusgabe.TabIndex = 1;
            LblAusgabe.Text = "label1";
            // 
            // TxtStadt
            // 
            TxtStadt.Location = new Point(516, 23);
            TxtStadt.Name = "TxtStadt";
            TxtStadt.Size = new Size(100, 23);
            TxtStadt.TabIndex = 2;
            // 
            // CmdAnzeigen2
            // 
            CmdAnzeigen2.Location = new Point(514, 164);
            CmdAnzeigen2.Name = "CmdAnzeigen2";
            CmdAnzeigen2.Size = new Size(175, 37);
            CmdAnzeigen2.TabIndex = 3;
            CmdAnzeigen2.Text = "Anzeigen 2";
            CmdAnzeigen2.UseVisualStyleBackColor = true;
            CmdAnzeigen2.Click += CmdAnzeigen2_Click;
            // 
            // CmdAnzeigen3
            // 
            CmdAnzeigen3.Location = new Point(516, 224);
            CmdAnzeigen3.Name = "CmdAnzeigen3";
            CmdAnzeigen3.Size = new Size(173, 50);
            CmdAnzeigen3.TabIndex = 4;
            CmdAnzeigen3.Text = "Anzeigen 3";
            CmdAnzeigen3.UseVisualStyleBackColor = true;
            CmdAnzeigen3.Click += CmdAnzeigen3_Click;
            // 
            // CmdAnzeigen4
            // 
            CmdAnzeigen4.Location = new Point(514, 300);
            CmdAnzeigen4.Name = "CmdAnzeigen4";
            CmdAnzeigen4.Size = new Size(177, 50);
            CmdAnzeigen4.TabIndex = 5;
            CmdAnzeigen4.Text = "Anzeigen 4";
            CmdAnzeigen4.UseVisualStyleBackColor = true;
            CmdAnzeigen4.Click += CmdAnzeigen4_Click;
            // 
            // CmdAnzeigen5
            // 
            CmdAnzeigen5.Location = new Point(517, 373);
            CmdAnzeigen5.Name = "CmdAnzeigen5";
            CmdAnzeigen5.Size = new Size(174, 47);
            CmdAnzeigen5.TabIndex = 6;
            CmdAnzeigen5.Text = "Anzeigen 5";
            CmdAnzeigen5.UseVisualStyleBackColor = true;
            CmdAnzeigen5.Click += CmdAnzeigen5_Click;
            // 
            // CmdAnzeigen6
            // 
            CmdAnzeigen6.Location = new Point(282, 373);
            CmdAnzeigen6.Name = "CmdAnzeigen6";
            CmdAnzeigen6.Size = new Size(131, 41);
            CmdAnzeigen6.TabIndex = 7;
            CmdAnzeigen6.Text = "Anzeigen 6";
            CmdAnzeigen6.UseVisualStyleBackColor = true;
            CmdAnzeigen6.Click += CmdAnzeigen6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdAnzeigen6);
            Controls.Add(CmdAnzeigen5);
            Controls.Add(CmdAnzeigen4);
            Controls.Add(CmdAnzeigen3);
            Controls.Add(CmdAnzeigen2);
            Controls.Add(TxtStadt);
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
        private TextBox TxtStadt;
        private Button CmdAnzeigen2;
        private Button CmdAnzeigen3;
        private Button CmdAnzeigen4;
        private Button CmdAnzeigen5;
        private Button CmdAnzeigen6;
    }
}
