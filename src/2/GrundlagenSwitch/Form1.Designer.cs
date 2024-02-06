// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenSwitch
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
            TextStadt = new TextBox();
            CmdButton = new Button();
            LblAusgabe = new Label();
            CmdButton1 = new Button();
            CmdButton2 = new Button();
            CmdButton3 = new Button();
            CmdButton4 = new Button();
            SuspendLayout();
            // 
            // TextStadt
            // 
            TextStadt.Location = new Point(83, 73);
            TextStadt.Name = "TextStadt";
            TextStadt.Size = new Size(100, 23);
            TextStadt.TabIndex = 0;
            // 
            // CmdButton
            // 
            CmdButton.Location = new Point(83, 102);
            CmdButton.Name = "CmdButton";
            CmdButton.Size = new Size(75, 23);
            CmdButton.TabIndex = 1;
            CmdButton.Text = "Anzeigen";
            CmdButton.UseVisualStyleBackColor = true;
            CmdButton.Click += CmdButton_Click;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(83, 178);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(42, 15);
            LblAusgabe.TabIndex = 2;
            LblAusgabe.Text = "XXXXX";
            // 
            // CmdButton1
            // 
            CmdButton1.Location = new Point(164, 102);
            CmdButton1.Name = "CmdButton1";
            CmdButton1.Size = new Size(75, 23);
            CmdButton1.TabIndex = 3;
            CmdButton1.Text = "Random";
            CmdButton1.UseVisualStyleBackColor = true;
            CmdButton1.Click += CmdButton1_Click;
            // 
            // CmdButton2
            // 
            CmdButton2.Location = new Point(83, 131);
            CmdButton2.Name = "CmdButton2";
            CmdButton2.Size = new Size(75, 23);
            CmdButton2.TabIndex = 4;
            CmdButton2.Text = "Suche stadt";
            CmdButton2.UseVisualStyleBackColor = true;
            CmdButton2.Click += CmdButton2_Click;
            // 
            // CmdButton3
            // 
            CmdButton3.Location = new Point(164, 131);
            CmdButton3.Name = "CmdButton3";
            CmdButton3.Size = new Size(75, 23);
            CmdButton3.TabIndex = 5;
            CmdButton3.Text = "Würfeln";
            CmdButton3.UseVisualStyleBackColor = true;
            CmdButton3.Click += CmdButton3_Click;
            // 
            // CmdButton4
            // 
            CmdButton4.Location = new Point(245, 102);
            CmdButton4.Name = "CmdButton4";
            CmdButton4.Size = new Size(75, 23);
            CmdButton4.TabIndex = 6;
            CmdButton4.Text = "button1";
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
            Controls.Add(CmdButton1);
            Controls.Add(LblAusgabe);
            Controls.Add(CmdButton);
            Controls.Add(TextStadt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextStadt;
        private Button CmdButton;
        private Label LblAusgabe;
        private Button CmdButton1;
        private Button CmdButton2;
        private Button CmdButton3;
        private Button CmdButton4;
    }
}
