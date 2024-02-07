// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace FehlerLaufzeit
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
            TxtEingabe1 = new TextBox();
            TxtEingabe2 = new TextBox();
            CmdOhne = new Button();
            CmdMit = new Button();
            CmdErweitert = new Button();
            LblAnzeige = new Label();
            SuspendLayout();
            // 
            // TxtEingabe1
            // 
            TxtEingabe1.Location = new Point(12, 12);
            TxtEingabe1.Name = "TxtEingabe1";
            TxtEingabe1.Size = new Size(150, 31);
            TxtEingabe1.TabIndex = 0;
            // 
            // TxtEingabe2
            // 
            TxtEingabe2.Location = new Point(12, 49);
            TxtEingabe2.Name = "TxtEingabe2";
            TxtEingabe2.Size = new Size(150, 31);
            TxtEingabe2.TabIndex = 1;
            // 
            // CmdOhne
            // 
            CmdOhne.Location = new Point(233, 10);
            CmdOhne.Name = "CmdOhne";
            CmdOhne.Size = new Size(319, 34);
            CmdOhne.TabIndex = 2;
            CmdOhne.Text = "Ohne Exception Handling";
            CmdOhne.UseVisualStyleBackColor = true;
            CmdOhne.Click += CmdOhne_Click;
            // 
            // CmdMit
            // 
            CmdMit.Location = new Point(233, 50);
            CmdMit.Name = "CmdMit";
            CmdMit.Size = new Size(319, 34);
            CmdMit.TabIndex = 3;
            CmdMit.Text = "Mit Exception Handling";
            CmdMit.UseVisualStyleBackColor = true;
            CmdMit.Click += CmdMit_Click;
            // 
            // CmdErweitert
            // 
            CmdErweitert.Location = new Point(233, 90);
            CmdErweitert.Name = "CmdErweitert";
            CmdErweitert.Size = new Size(319, 34);
            CmdErweitert.TabIndex = 4;
            CmdErweitert.Text = "Mit erweitertem Exception Handling";
            CmdErweitert.UseVisualStyleBackColor = true;
            CmdErweitert.Click += CmdErweitert_Click;
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(12, 95);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(59, 25);
            LblAnzeige.TabIndex = 5;
            LblAnzeige.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 142);
            Controls.Add(LblAnzeige);
            Controls.Add(CmdErweitert);
            Controls.Add(CmdMit);
            Controls.Add(CmdOhne);
            Controls.Add(TxtEingabe2);
            Controls.Add(TxtEingabe1);
            Name = "Form1";
            Text = "Laufzeitfehler";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtEingabe1;
        private TextBox TxtEingabe2;
        private Button CmdOhne;
        private Button CmdMit;
        private Button CmdErweitert;
        private Label LblAnzeige;
    }
}
