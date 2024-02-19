// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace DialogeEingabeAusgabe
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
            CmdButton1 = new Button();
            LblAnzeige1 = new Label();
            CmdButton2 = new Button();
            CmdButton3 = new Button();
            CmdButton4 = new Button();
            SuspendLayout();
            // 
            // CmdButton1
            // 
            CmdButton1.Location = new Point(189, 46);
            CmdButton1.Name = "CmdButton1";
            CmdButton1.Size = new Size(75, 23);
            CmdButton1.TabIndex = 0;
            CmdButton1.Text = "Eingabe";
            CmdButton1.UseVisualStyleBackColor = true;
            CmdButton1.Click += CmdButton1_Click;
            // 
            // LblAnzeige1
            // 
            LblAnzeige1.AutoSize = true;
            LblAnzeige1.Location = new Point(120, 54);
            LblAnzeige1.Name = "LblAnzeige1";
            LblAnzeige1.Size = new Size(38, 15);
            LblAnzeige1.TabIndex = 1;
            LblAnzeige1.Text = "label1";
            // 
            // CmdButton2
            // 
            CmdButton2.Location = new Point(282, 87);
            CmdButton2.Name = "CmdButton2";
            CmdButton2.Size = new Size(75, 23);
            CmdButton2.TabIndex = 2;
            CmdButton2.Text = "Close";
            CmdButton2.UseVisualStyleBackColor = true;
            CmdButton2.Click += CmdButton2_Click;
            // 
            // CmdButton3
            // 
            CmdButton3.Location = new Point(282, 46);
            CmdButton3.Name = "CmdButton3";
            CmdButton3.Size = new Size(75, 23);
            CmdButton3.TabIndex = 3;
            CmdButton3.Text = "Info";
            CmdButton3.UseVisualStyleBackColor = true;
            CmdButton3.Click += CmdButton3_Click;
            // 
            // CmdButton4
            // 
            CmdButton4.Location = new Point(189, 87);
            CmdButton4.Name = "CmdButton4";
            CmdButton4.Size = new Size(75, 23);
            CmdButton4.TabIndex = 4;
            CmdButton4.Text = "Ja/Nein";
            CmdButton4.UseVisualStyleBackColor = true;
            CmdButton4.Click += CmdButton4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdButton4);
            Controls.Add(CmdButton3);
            Controls.Add(CmdButton2);
            Controls.Add(LblAnzeige1);
            Controls.Add(CmdButton1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdButton1;
        private Label LblAnzeige1;
        private Button CmdButton2;
        private Button CmdButton3;
        private Button CmdButton4;
    }
}
