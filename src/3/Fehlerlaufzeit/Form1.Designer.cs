// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Fehlerlaufzeit
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
            TxtOhne = new TextBox();
            TxtMit = new TextBox();
            CmdOhne = new Button();
            CmdMit = new Button();
            Cmderweitern = new Button();
            LblAnzeige = new Label();
            SuspendLayout();
            // 
            // TxtOhne
            // 
            TxtOhne.Location = new Point(63, 64);
            TxtOhne.Name = "TxtOhne";
            TxtOhne.Size = new Size(100, 23);
            TxtOhne.TabIndex = 0;
            // 
            // TxtMit
            // 
            TxtMit.Location = new Point(63, 93);
            TxtMit.Name = "TxtMit";
            TxtMit.Size = new Size(100, 23);
            TxtMit.TabIndex = 1;
            // 
            // CmdOhne
            // 
            CmdOhne.Location = new Point(219, 64);
            CmdOhne.Name = "CmdOhne";
            CmdOhne.Size = new Size(255, 23);
            CmdOhne.TabIndex = 2;
            CmdOhne.Text = "Ohne exception Handling";
            CmdOhne.UseVisualStyleBackColor = true;
            CmdOhne.Click += CmdOhne_Click;
            // 
            // CmdMit
            // 
            CmdMit.Location = new Point(219, 93);
            CmdMit.Name = "CmdMit";
            CmdMit.Size = new Size(255, 23);
            CmdMit.TabIndex = 3;
            CmdMit.Text = "Mit Exception Handling";
            CmdMit.UseVisualStyleBackColor = true;
            CmdMit.Click += CmdMit_Click;
            // 
            // Cmderweitern
            // 
            Cmderweitern.Location = new Point(219, 122);
            Cmderweitern.Name = "Cmderweitern";
            Cmderweitern.Size = new Size(255, 23);
            Cmderweitern.TabIndex = 4;
            Cmderweitern.Text = "Mit erweitertem Exception Handling";
            Cmderweitern.UseVisualStyleBackColor = true;
            Cmderweitern.Click += Cmderweitern_Click;
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(61, 126);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(38, 15);
            LblAnzeige.TabIndex = 5;
            LblAnzeige.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAnzeige);
            Controls.Add(Cmderweitern);
            Controls.Add(CmdMit);
            Controls.Add(CmdOhne);
            Controls.Add(TxtMit);
            Controls.Add(TxtOhne);
            Name = "Form1";
            Text = "Laufzeitfehler";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtOhne;
        private TextBox TxtMit;
        private Button CmdOhne;
        private Button CmdMit;
        private Button Cmderweitern;
        private Label LblAnzeige;
    }
}
