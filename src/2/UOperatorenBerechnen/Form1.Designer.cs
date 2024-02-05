// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UOperatorenBerechnen
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
            CmdAusdruck1 = new Button();
            CmdAusdruck2 = new Button();
            CmdAusdruck3 = new Button();
            CmdAusdruck4 = new Button();
            LblAnzeigen = new Label();
            SuspendLayout();
            // 
            // CmdAusdruck1
            // 
            CmdAusdruck1.Location = new Point(569, 20);
            CmdAusdruck1.Name = "CmdAusdruck1";
            CmdAusdruck1.Size = new Size(172, 55);
            CmdAusdruck1.TabIndex = 0;
            CmdAusdruck1.Text = "Ausdruck 1";
            CmdAusdruck1.UseVisualStyleBackColor = true;
            CmdAusdruck1.Click += CmdAusdruck1_Click;
            // 
            // CmdAusdruck2
            // 
            CmdAusdruck2.Location = new Point(569, 112);
            CmdAusdruck2.Name = "CmdAusdruck2";
            CmdAusdruck2.Size = new Size(172, 55);
            CmdAusdruck2.TabIndex = 1;
            CmdAusdruck2.Text = "Ausdruck 2";
            CmdAusdruck2.UseVisualStyleBackColor = true;
            CmdAusdruck2.Click += CmdAusdruck2_Click;
            // 
            // CmdAusdruck3
            // 
            CmdAusdruck3.Location = new Point(569, 216);
            CmdAusdruck3.Name = "CmdAusdruck3";
            CmdAusdruck3.Size = new Size(172, 55);
            CmdAusdruck3.TabIndex = 2;
            CmdAusdruck3.Text = "Ausdruck 3";
            CmdAusdruck3.UseVisualStyleBackColor = true;
            CmdAusdruck3.Click += CmdAusdruck3_Click;
            // 
            // CmdAusdruck4
            // 
            CmdAusdruck4.Location = new Point(569, 316);
            CmdAusdruck4.Name = "CmdAusdruck4";
            CmdAusdruck4.Size = new Size(172, 55);
            CmdAusdruck4.TabIndex = 3;
            CmdAusdruck4.Text = "Ausdruck 4";
            CmdAusdruck4.UseVisualStyleBackColor = true;
            CmdAusdruck4.Click += CmdAusdruck4_Click;
            // 
            // LblAnzeigen
            // 
            LblAnzeigen.AutoSize = true;
            LblAnzeigen.Location = new Point(229, 60);
            LblAnzeigen.Name = "LblAnzeigen";
            LblAnzeigen.Size = new Size(38, 15);
            LblAnzeigen.TabIndex = 4;
            LblAnzeigen.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAnzeigen);
            Controls.Add(CmdAusdruck4);
            Controls.Add(CmdAusdruck3);
            Controls.Add(CmdAusdruck2);
            Controls.Add(CmdAusdruck1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAusdruck1;
        private Button CmdAusdruck2;
        private Button CmdAusdruck3;
        private Button CmdAusdruck4;
        private Label LblAnzeigen;
    }
}
