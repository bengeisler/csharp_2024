// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Ugueltigkeit
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
            CmdAnzeige1 = new Button();
            CmdAnzeigen2 = new Button();
            LblAusgabe = new Label();
            SuspendLayout();
            // 
            // CmdAnzeige1
            // 
            CmdAnzeige1.Location = new Point(293, 50);
            CmdAnzeige1.Name = "CmdAnzeige1";
            CmdAnzeige1.Size = new Size(117, 53);
            CmdAnzeige1.TabIndex = 0;
            CmdAnzeige1.Text = "Anzeigen 1";
            CmdAnzeige1.UseVisualStyleBackColor = true;
            CmdAnzeige1.Click += CmdAnzeige1_Click;
            // 
            // CmdAnzeigen2
            // 
            CmdAnzeigen2.Location = new Point(293, 122);
            CmdAnzeigen2.Name = "CmdAnzeigen2";
            CmdAnzeigen2.Size = new Size(117, 53);
            CmdAnzeigen2.TabIndex = 1;
            CmdAnzeigen2.Text = "Anzeigen 2";
            CmdAnzeigen2.UseVisualStyleBackColor = true;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(34, 39);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(38, 15);
            LblAusgabe.TabIndex = 2;
            LblAusgabe.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAusgabe);
            Controls.Add(CmdAnzeigen2);
            Controls.Add(CmdAnzeige1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAnzeige1;
        private Button CmdAnzeigen2;
        private Label LblAusgabe;
    }
}
