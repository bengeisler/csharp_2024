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
            CmdAnzeigen1 = new Button();
            CmdAnzeigen2 = new Button();
            LblAusgabe = new Label();
            CmdAnzeigen3 = new Button();
            SuspendLayout();
            // 
            // LstWerte
            // 
            LstWerte.FormattingEnabled = true;
            LstWerte.ItemHeight = 25;
            LstWerte.Location = new Point(12, 12);
            LstWerte.Name = "LstWerte";
            LstWerte.Size = new Size(180, 129);
            LstWerte.TabIndex = 0;
            // 
            // CmdAnzeigen1
            // 
            CmdAnzeigen1.Location = new Point(214, 12);
            CmdAnzeigen1.Name = "CmdAnzeigen1";
            CmdAnzeigen1.Size = new Size(112, 34);
            CmdAnzeigen1.TabIndex = 1;
            CmdAnzeigen1.Text = "Anzeigen 1";
            CmdAnzeigen1.UseVisualStyleBackColor = true;
            CmdAnzeigen1.Click += CmdAnzeigen1_Click;
            // 
            // CmdAnzeigen2
            // 
            CmdAnzeigen2.Location = new Point(214, 52);
            CmdAnzeigen2.Name = "CmdAnzeigen2";
            CmdAnzeigen2.Size = new Size(112, 34);
            CmdAnzeigen2.TabIndex = 2;
            CmdAnzeigen2.Text = "Anzeigen 2";
            CmdAnzeigen2.UseVisualStyleBackColor = true;
            CmdAnzeigen2.Click += CmdAnzeigen2_Click;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(12, 161);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(59, 25);
            LblAusgabe.TabIndex = 3;
            LblAusgabe.Text = "label1";
            // 
            // CmdAnzeigen3
            // 
            CmdAnzeigen3.Location = new Point(214, 92);
            CmdAnzeigen3.Name = "CmdAnzeigen3";
            CmdAnzeigen3.Size = new Size(112, 34);
            CmdAnzeigen3.TabIndex = 4;
            CmdAnzeigen3.Text = "Anzeigen 3";
            CmdAnzeigen3.UseVisualStyleBackColor = true;
            CmdAnzeigen3.Click += CmdAnzeigen3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 220);
            Controls.Add(CmdAnzeigen3);
            Controls.Add(LblAusgabe);
            Controls.Add(CmdAnzeigen2);
            Controls.Add(CmdAnzeigen1);
            Controls.Add(LstWerte);
            Name = "Form1";
            Text = "Datenfeld Eindimensional";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LstWerte;
        private Button CmdAnzeigen1;
        private Button CmdAnzeigen2;
        private Label LblAusgabe;
        private Button CmdAnzeigen3;
    }
}
