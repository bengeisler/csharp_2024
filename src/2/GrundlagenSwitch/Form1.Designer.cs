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
            LblAusgabe = new Label();
            CmdAnzeige1 = new Button();
            txtStadt = new TextBox();
            CmdAnzeigen2 = new Button();
            CmdAnzeigen3 = new Button();
            CmdAnzeigen4 = new Button();
            CmdAnzeigen5 = new Button();
            SuspendLayout();
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(12, 93);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(38, 15);
            LblAusgabe.TabIndex = 0;
            LblAusgabe.Text = "label1";
            // 
            // CmdAnzeige1
            // 
            CmdAnzeige1.Location = new Point(12, 41);
            CmdAnzeige1.Name = "CmdAnzeige1";
            CmdAnzeige1.Size = new Size(75, 23);
            CmdAnzeige1.TabIndex = 1;
            CmdAnzeige1.Text = "Anzeigen1";
            CmdAnzeige1.UseVisualStyleBackColor = true;
            CmdAnzeige1.Click += CmdAnzeige1_Click;
            // 
            // txtStadt
            // 
            txtStadt.Location = new Point(12, 12);
            txtStadt.Name = "txtStadt";
            txtStadt.Size = new Size(100, 23);
            txtStadt.TabIndex = 2;
            // 
            // CmdAnzeigen2
            // 
            CmdAnzeigen2.Location = new Point(93, 41);
            CmdAnzeigen2.Name = "CmdAnzeigen2";
            CmdAnzeigen2.Size = new Size(75, 23);
            CmdAnzeigen2.TabIndex = 3;
            CmdAnzeigen2.Text = "Anzeigen2";
            CmdAnzeigen2.UseVisualStyleBackColor = true;
            CmdAnzeigen2.Click += CmdAnzeigen2_Click;
            // 
            // CmdAnzeigen3
            // 
            CmdAnzeigen3.Location = new Point(186, 41);
            CmdAnzeigen3.Name = "CmdAnzeigen3";
            CmdAnzeigen3.Size = new Size(75, 23);
            CmdAnzeigen3.TabIndex = 4;
            CmdAnzeigen3.Text = "Anzeigen3";
            CmdAnzeigen3.UseVisualStyleBackColor = true;
            CmdAnzeigen3.Click += CmdAnzeigen3_Click;
            // 
            // CmdAnzeigen4
            // 
            CmdAnzeigen4.Location = new Point(290, 41);
            CmdAnzeigen4.Name = "CmdAnzeigen4";
            CmdAnzeigen4.Size = new Size(75, 23);
            CmdAnzeigen4.TabIndex = 5;
            CmdAnzeigen4.Text = "Anzeigen4";
            CmdAnzeigen4.UseVisualStyleBackColor = true;
            CmdAnzeigen4.Click += CmdAnzeigen4_Click;
            // 
            // CmdAnzeigen5
            // 
            CmdAnzeigen5.Location = new Point(383, 41);
            CmdAnzeigen5.Name = "CmdAnzeigen5";
            CmdAnzeigen5.Size = new Size(75, 23);
            CmdAnzeigen5.TabIndex = 6;
            CmdAnzeigen5.Text = "Anzeigen5";
            CmdAnzeigen5.UseVisualStyleBackColor = true;
            CmdAnzeigen5.Click += CmdAnzeigen5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdAnzeigen5);
            Controls.Add(CmdAnzeigen4);
            Controls.Add(CmdAnzeigen3);
            Controls.Add(CmdAnzeigen2);
            Controls.Add(txtStadt);
            Controls.Add(CmdAnzeige1);
            Controls.Add(LblAusgabe);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAusgabe;
        private Button CmdAnzeige1;
        private TextBox txtStadt;
        private Button CmdAnzeigen2;
        private Button CmdAnzeigen3;
        private Button CmdAnzeigen4;
        private Button CmdAnzeigen5;
    }
}
