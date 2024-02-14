// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace DatenfeldEinDimensional
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
            CmdAnzeige2 = new Button();
            LblAusgabe = new Label();
            cmdAnzeigen3 = new Button();
            SuspendLayout();
            // 
            // LstWerte
            // 
            LstWerte.FormattingEnabled = true;
            LstWerte.ItemHeight = 15;
            LstWerte.Location = new Point(284, 24);
            LstWerte.Name = "LstWerte";
            LstWerte.Size = new Size(121, 139);
            LstWerte.TabIndex = 0;
            // 
            // CmdAnzeigen1
            // 
            CmdAnzeigen1.Location = new Point(472, 24);
            CmdAnzeigen1.Name = "CmdAnzeigen1";
            CmdAnzeigen1.Size = new Size(159, 46);
            CmdAnzeigen1.TabIndex = 1;
            CmdAnzeigen1.Text = "Anzeigen 1";
            CmdAnzeigen1.UseVisualStyleBackColor = true;
            CmdAnzeigen1.Click += CmdAnzeigen1_Click;
            // 
            // CmdAnzeige2
            // 
            CmdAnzeige2.Location = new Point(472, 104);
            CmdAnzeige2.Name = "CmdAnzeige2";
            CmdAnzeige2.Size = new Size(159, 46);
            CmdAnzeige2.TabIndex = 2;
            CmdAnzeige2.Text = "Anzeigen 2";
            CmdAnzeige2.UseVisualStyleBackColor = true;
            CmdAnzeige2.Click += CmdAnzeige2_Click;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(472, 186);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(38, 15);
            LblAusgabe.TabIndex = 3;
            LblAusgabe.Text = "label1";
            // 
            // cmdAnzeigen3
            // 
            cmdAnzeigen3.Location = new Point(472, 258);
            cmdAnzeigen3.Name = "cmdAnzeigen3";
            cmdAnzeigen3.Size = new Size(159, 46);
            cmdAnzeigen3.TabIndex = 4;
            cmdAnzeigen3.Text = "Anzeigen 3";
            cmdAnzeigen3.UseVisualStyleBackColor = true;
            cmdAnzeigen3.Click += cmdAnzeigen3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdAnzeigen3);
            Controls.Add(LblAusgabe);
            Controls.Add(CmdAnzeige2);
            Controls.Add(CmdAnzeigen1);
            Controls.Add(LstWerte);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LstWerte;
        private Button CmdAnzeigen1;
        private Button CmdAnzeige2;
        private Label LblAusgabe;
        private Button cmdAnzeigen3;
    }
}
