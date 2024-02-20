// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace WinFormsApp1
{
    partial class CmdButton2
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
            LblAnzeige1 = new Label();
            CmdButton1 = new Button();
            CmdButton3 = new Button();
            button2 = new Button();
            TxtBox2 = new TextBox();
            TxtBox1 = new TextBox();
            CmdButton4 = new Button();
            SuspendLayout();
            // 
            // LblAnzeige1
            // 
            LblAnzeige1.AutoSize = true;
            LblAnzeige1.Location = new Point(121, 151);
            LblAnzeige1.Name = "LblAnzeige1";
            LblAnzeige1.Size = new Size(38, 15);
            LblAnzeige1.TabIndex = 0;
            LblAnzeige1.Text = "label1";
            // 
            // CmdButton1
            // 
            CmdButton1.Location = new Point(563, 40);
            CmdButton1.Name = "CmdButton1";
            CmdButton1.Size = new Size(75, 23);
            CmdButton1.TabIndex = 1;
            CmdButton1.Text = "button1";
            CmdButton1.UseVisualStyleBackColor = true;
            CmdButton1.Click += CmdButton1_Click;
            // 
            // CmdButton3
            // 
            CmdButton3.Location = new Point(563, 98);
            CmdButton3.Name = "CmdButton3";
            CmdButton3.Size = new Size(75, 23);
            CmdButton3.TabIndex = 2;
            CmdButton3.Text = "button1";
            CmdButton3.UseVisualStyleBackColor = true;
            CmdButton3.Click += CmdButton3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(563, 69);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TxtBox2
            // 
            TxtBox2.Location = new Point(121, 99);
            TxtBox2.Name = "TxtBox2";
            TxtBox2.Size = new Size(100, 23);
            TxtBox2.TabIndex = 4;
            // 
            // TxtBox1
            // 
            TxtBox1.Location = new Point(121, 59);
            TxtBox1.Name = "TxtBox1";
            TxtBox1.Size = new Size(100, 23);
            TxtBox1.TabIndex = 5;
            // 
            // CmdButton4
            // 
            CmdButton4.Location = new Point(563, 127);
            CmdButton4.Name = "CmdButton4";
            CmdButton4.Size = new Size(75, 23);
            CmdButton4.TabIndex = 6;
            CmdButton4.Text = "Ausnahme auslösen";
            CmdButton4.UseVisualStyleBackColor = true;
            CmdButton4.Click += CmdButton4_Click;
            // 
            // CmdButton2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdButton4);
            Controls.Add(TxtBox1);
            Controls.Add(TxtBox2);
            Controls.Add(button2);
            Controls.Add(CmdButton3);
            Controls.Add(CmdButton1);
            Controls.Add(LblAnzeige1);
            Name = "CmdButton2";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAnzeige1;
        private Button CmdButton1;
        private Button CmdButton3;
        private Button button2;
        private TextBox TxtBox2;
        private TextBox TxtBox1;
        private Button CmdButton4;
    }
}
