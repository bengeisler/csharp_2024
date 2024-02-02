// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenGueltigkeit
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
            CmdAnzeige2 = new Button();
            LblAnzeige = new Label();
            SuspendLayout();
            // 
            // CmdAnzeige1
            // 
            CmdAnzeige1.Location = new Point(311, 65);
            CmdAnzeige1.Name = "CmdAnzeige1";
            CmdAnzeige1.Size = new Size(75, 23);
            CmdAnzeige1.TabIndex = 0;
            CmdAnzeige1.Text = "Anzeigen1";
            CmdAnzeige1.UseVisualStyleBackColor = true;
            CmdAnzeige1.Click += CmdAnzeige1_Click;
            // 
            // CmdAnzeige2
            // 
            CmdAnzeige2.Location = new Point(311, 94);
            CmdAnzeige2.Name = "CmdAnzeige2";
            CmdAnzeige2.Size = new Size(75, 23);
            CmdAnzeige2.TabIndex = 1;
            CmdAnzeige2.Text = "Anzeigen2";
            CmdAnzeige2.UseVisualStyleBackColor = true;
            CmdAnzeige2.Click += CmdAnzeige2_Click;
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(39, 69);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(38, 15);
            LblAnzeige.TabIndex = 2;
            LblAnzeige.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 303);
            Controls.Add(LblAnzeige);
            Controls.Add(CmdAnzeige2);
            Controls.Add(CmdAnzeige1);
            Name = "Form1";
            Text = "Gültigkeitsbereich";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAnzeige1;
        private Button CmdAnzeige2;
        private Label LblAnzeige;
    }
}
