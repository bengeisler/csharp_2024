// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace DatenfelderEindimensional
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
            LstWerte = new ListBox();
            CmdAnzeigen2 = new Button();
            LblAusgabe = new Label();
            CmdAnzeige3 = new Button();
            SuspendLayout();
            // 
            // CmdAnzeigen1
            // 
            CmdAnzeigen1.Location = new Point(231, 50);
            CmdAnzeigen1.Name = "CmdAnzeigen1";
            CmdAnzeigen1.Size = new Size(75, 23);
            CmdAnzeigen1.TabIndex = 0;
            CmdAnzeigen1.Text = "Anzeigen1";
            CmdAnzeigen1.UseVisualStyleBackColor = true;
            CmdAnzeigen1.Click += CmdAnzeigen1_Click;
            // 
            // LstWerte
            // 
            LstWerte.FormattingEnabled = true;
            LstWerte.ItemHeight = 15;
            LstWerte.Location = new Point(35, 52);
            LstWerte.Name = "LstWerte";
            LstWerte.Size = new Size(138, 94);
            LstWerte.TabIndex = 1;
            // 
            // CmdAnzeigen2
            // 
            CmdAnzeigen2.Location = new Point(231, 79);
            CmdAnzeigen2.Name = "CmdAnzeigen2";
            CmdAnzeigen2.Size = new Size(75, 23);
            CmdAnzeigen2.TabIndex = 2;
            CmdAnzeigen2.Text = "Anzeigen2";
            CmdAnzeigen2.UseVisualStyleBackColor = true;
            CmdAnzeigen2.Click += CmdAnzeigen2_Click;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(244, 155);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(38, 15);
            LblAusgabe.TabIndex = 3;
            LblAusgabe.Text = "label1";
            // 
            // CmdAnzeige3
            // 
            CmdAnzeige3.Location = new Point(231, 108);
            CmdAnzeige3.Name = "CmdAnzeige3";
            CmdAnzeige3.Size = new Size(75, 23);
            CmdAnzeige3.TabIndex = 4;
            CmdAnzeige3.Text = "Anzeigen3";
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
            Controls.Add(CmdAnzeigen2);
            Controls.Add(LstWerte);
            Controls.Add(CmdAnzeigen1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAnzeigen1;
        private ListBox LstWerte;
        private Button CmdAnzeigen2;
        private Label LblAusgabe;
        private Button CmdAnzeige3;
    }
}
