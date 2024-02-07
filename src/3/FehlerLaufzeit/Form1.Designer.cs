// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace FehlerLaufzeit
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
            TxtBox1 = new TextBox();
            TxtBox2 = new TextBox();
            Cmd1 = new Button();
            Cmd2 = new Button();
            Cmd3 = new Button();
            LblAnzeige = new Label();
            SuspendLayout();
            // 
            // TxtBox1
            // 
            TxtBox1.Location = new Point(52, 28);
            TxtBox1.Name = "TxtBox1";
            TxtBox1.Size = new Size(188, 23);
            TxtBox1.TabIndex = 0;
            // 
            // TxtBox2
            // 
            TxtBox2.Location = new Point(52, 81);
            TxtBox2.Name = "TxtBox2";
            TxtBox2.Size = new Size(188, 23);
            TxtBox2.TabIndex = 1;
            // 
            // Cmd1
            // 
            Cmd1.Location = new Point(364, 28);
            Cmd1.Name = "Cmd1";
            Cmd1.Size = new Size(285, 33);
            Cmd1.TabIndex = 2;
            Cmd1.Text = "Ohne Exception Handlung";
            Cmd1.UseVisualStyleBackColor = true;
            Cmd1.Click += Cmd1_Click;
            // 
            // Cmd2
            // 
            Cmd2.Location = new Point(364, 81);
            Cmd2.Name = "Cmd2";
            Cmd2.Size = new Size(285, 33);
            Cmd2.TabIndex = 3;
            Cmd2.Text = "Mit Exception Handlung";
            Cmd2.UseVisualStyleBackColor = true;
            Cmd2.Click += Cmd2_Click;
            // 
            // Cmd3
            // 
            Cmd3.Location = new Point(364, 136);
            Cmd3.Name = "Cmd3";
            Cmd3.Size = new Size(285, 33);
            Cmd3.TabIndex = 4;
            Cmd3.Text = "Mit erweitertem Exception Handlung";
            Cmd3.UseVisualStyleBackColor = true;
            Cmd3.Click += Cmd3_Click;
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(52, 154);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(38, 15);
            LblAnzeige.TabIndex = 5;
            LblAnzeige.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 205);
            Controls.Add(LblAnzeige);
            Controls.Add(Cmd3);
            Controls.Add(Cmd2);
            Controls.Add(Cmd1);
            Controls.Add(TxtBox2);
            Controls.Add(TxtBox1);
            Name = "Form1";
            Text = "Laufzeitfehler";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBox1;
        private TextBox TxtBox2;
        private Button Cmd1;
        private Button Cmd2;
        private Button Cmd3;
        private Label LblAnzeige;
    }
}
