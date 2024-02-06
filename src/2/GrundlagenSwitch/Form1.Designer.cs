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
            TxtStadt = new TextBox();
            LblAusgabe = new Label();
            CmdAnzeigen2 = new Button();
            CmdAnzeigen3 = new Button();
            CmdAnzeigen4 = new Button();
            CmdAnzeigen5 = new Button();
            SuspendLayout();
            // 
            // CmdAnzeigen1
            // 
            CmdAnzeigen1.Location = new Point(12, 49);
            CmdAnzeigen1.Name = "CmdAnzeigen1";
            CmdAnzeigen1.Size = new Size(112, 34);
            CmdAnzeigen1.TabIndex = 0;
            CmdAnzeigen1.Text = "Anzeigen 1";
            CmdAnzeigen1.UseVisualStyleBackColor = true;
            CmdAnzeigen1.Click += CmdAnzeigen1_Click;
            // 
            // TxtStadt
            // 
            TxtStadt.Location = new Point(12, 12);
            TxtStadt.Name = "TxtStadt";
            TxtStadt.Size = new Size(150, 31);
            TxtStadt.TabIndex = 1;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(12, 127);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(59, 25);
            LblAusgabe.TabIndex = 2;
            LblAusgabe.Text = "label1";
            // 
            // CmdAnzeigen2
            // 
            CmdAnzeigen2.Location = new Point(130, 49);
            CmdAnzeigen2.Name = "CmdAnzeigen2";
            CmdAnzeigen2.Size = new Size(112, 34);
            CmdAnzeigen2.TabIndex = 3;
            CmdAnzeigen2.Text = "Anzeigen 2";
            CmdAnzeigen2.UseVisualStyleBackColor = true;
            CmdAnzeigen2.Click += CmdAnzeigen2_Click;
            // 
            // CmdAnzeigen3
            // 
            CmdAnzeigen3.Location = new Point(248, 49);
            CmdAnzeigen3.Name = "CmdAnzeigen3";
            CmdAnzeigen3.Size = new Size(112, 34);
            CmdAnzeigen3.TabIndex = 4;
            CmdAnzeigen3.Text = "Anzeigen 3";
            CmdAnzeigen3.UseVisualStyleBackColor = true;
            CmdAnzeigen3.Click += CmdAnzeigen3_Click;
            // 
            // CmdAnzeigen4
            // 
            CmdAnzeigen4.Location = new Point(366, 49);
            CmdAnzeigen4.Name = "CmdAnzeigen4";
            CmdAnzeigen4.Size = new Size(112, 34);
            CmdAnzeigen4.TabIndex = 5;
            CmdAnzeigen4.Text = "Anzeigen 4";
            CmdAnzeigen4.UseVisualStyleBackColor = true;
            CmdAnzeigen4.Click += CmdAnzeigen4_Click;
            // 
            // CmdAnzeigen5
            // 
            CmdAnzeigen5.Location = new Point(484, 49);
            CmdAnzeigen5.Name = "CmdAnzeigen5";
            CmdAnzeigen5.Size = new Size(112, 34);
            CmdAnzeigen5.TabIndex = 6;
            CmdAnzeigen5.Text = "Anzeigen 5";
            CmdAnzeigen5.UseVisualStyleBackColor = true;
            CmdAnzeigen5.Click += CmdAnzeigen5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdAnzeigen5);
            Controls.Add(CmdAnzeigen4);
            Controls.Add(CmdAnzeigen3);
            Controls.Add(CmdAnzeigen2);
            Controls.Add(LblAusgabe);
            Controls.Add(TxtStadt);
            Controls.Add(CmdAnzeigen1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAnzeigen1;
        private TextBox TxtStadt;
        private Label LblAusgabe;
        private Button CmdAnzeigen2;
        private Button CmdAnzeigen3;
        private Button CmdAnzeigen4;
        private Button CmdAnzeigen5;
    }
}
