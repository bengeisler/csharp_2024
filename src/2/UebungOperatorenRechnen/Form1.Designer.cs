// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UebungOperatorenRechnen
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
            CmdAusruck2 = new Button();
            CmdAusdruck3 = new Button();
            CmdAusruck4 = new Button();
            LblAusgabe = new Label();
            SuspendLayout();
            // 
            // CmdAusdruck1
            // 
            CmdAusdruck1.Location = new Point(334, 49);
            CmdAusdruck1.Name = "CmdAusdruck1";
            CmdAusdruck1.Size = new Size(75, 23);
            CmdAusdruck1.TabIndex = 0;
            CmdAusdruck1.Text = "Ausgabe 1";
            CmdAusdruck1.UseVisualStyleBackColor = true;
            CmdAusdruck1.Click += CmdAusdruck1_Click;
            // 
            // CmdAusruck2
            // 
            CmdAusruck2.Location = new Point(334, 97);
            CmdAusruck2.Name = "CmdAusruck2";
            CmdAusruck2.Size = new Size(75, 23);
            CmdAusruck2.TabIndex = 1;
            CmdAusruck2.Text = "Ausgabe 2";
            CmdAusruck2.UseVisualStyleBackColor = true;
            CmdAusruck2.Click += CmdAusruck2_Click;
            // 
            // CmdAusdruck3
            // 
            CmdAusdruck3.Location = new Point(334, 143);
            CmdAusdruck3.Name = "CmdAusdruck3";
            CmdAusdruck3.Size = new Size(75, 23);
            CmdAusdruck3.TabIndex = 2;
            CmdAusdruck3.Text = "Ausgabe 3";
            CmdAusdruck3.UseVisualStyleBackColor = true;
            CmdAusdruck3.Click += CmdAusdruck3_Click;
            // 
            // CmdAusruck4
            // 
            CmdAusruck4.Location = new Point(334, 193);
            CmdAusruck4.Name = "CmdAusruck4";
            CmdAusruck4.Size = new Size(75, 23);
            CmdAusruck4.TabIndex = 3;
            CmdAusruck4.Text = "Ausgabe 4";
            CmdAusruck4.UseVisualStyleBackColor = true;
            CmdAusruck4.Click += CmdAusruck4_Click;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(21, 57);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(53, 15);
            LblAusgabe.TabIndex = 4;
            LblAusgabe.Text = "Ausgabe";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAusgabe);
            Controls.Add(CmdAusruck4);
            Controls.Add(CmdAusdruck3);
            Controls.Add(CmdAusruck2);
            Controls.Add(CmdAusdruck1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAusdruck1;
        private Button CmdAusruck2;
        private Button CmdAusdruck3;
        private Button CmdAusruck4;
        private Label LblAusgabe;
    }
}
