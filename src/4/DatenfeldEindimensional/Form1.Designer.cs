// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace DatenfeldEindimensional
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
            LstWerte = new ListBox();
            CmdButton1 = new Button();
            LbAnzeige2 = new Button();
            LblAusgabe = new Label();
            CmdAnzeige3 = new Button();
            SuspendLayout();
            // 
            // LstWerte
            // 
            LstWerte.FormattingEnabled = true;
            LstWerte.ItemHeight = 15;
            LstWerte.Location = new Point(42, 54);
            LstWerte.Name = "LstWerte";
            LstWerte.Size = new Size(120, 94);
            LstWerte.TabIndex = 0;
            // 
            // CmdButton1
            // 
            CmdButton1.Location = new Point(259, 54);
            CmdButton1.Name = "CmdButton1";
            CmdButton1.Size = new Size(75, 23);
            CmdButton1.TabIndex = 1;
            CmdButton1.Text = "Anzeigen 1";
            CmdButton1.UseVisualStyleBackColor = true;
            CmdButton1.Click += CmdButton1_Click;
            // 
            // LbAnzeige2
            // 
            LbAnzeige2.Location = new Point(259, 83);
            LbAnzeige2.Name = "LbAnzeige2";
            LbAnzeige2.Size = new Size(75, 23);
            LbAnzeige2.TabIndex = 2;
            LbAnzeige2.Text = "Anzeige 2";
            LbAnzeige2.UseVisualStyleBackColor = true;
            LbAnzeige2.Click += LbAnzeige2_Click;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(248, 259);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(38, 15);
            LblAusgabe.TabIndex = 3;
            LblAusgabe.Text = "label1";
            // 
            // CmdAnzeige3
            // 
            CmdAnzeige3.Location = new Point(259, 112);
            CmdAnzeige3.Name = "CmdAnzeige3";
            CmdAnzeige3.Size = new Size(75, 23);
            CmdAnzeige3.TabIndex = 4;
            CmdAnzeige3.Text = "Anzeige 3";
            CmdAnzeige3.UseVisualStyleBackColor = true;
            CmdAnzeige3.Click += CmdAnzeige3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdAnzeige3);
            Controls.Add(LblAusgabe);
            Controls.Add(LbAnzeige2);
            Controls.Add(CmdButton1);
            Controls.Add(LstWerte);
            Name = "Form1";
            Text = "Datenfeld, eindimensioanal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LstWerte;
        private Button CmdButton1;
        private Button LbAnzeige2;
        private Label LblAusgabe;
        private Button CmdAnzeige3;
    }
}
