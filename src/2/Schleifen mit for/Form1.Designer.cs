// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Schleifen_mit_for
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            LblAnzeige1 = new Label();
            LblAnzeige2 = new Label();
            LblAnzeige3 = new Label();
            LblAnzeige4 = new Label();
            LblAnzeige5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(60, 50);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Anzeigen 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(178, 50);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Anzeigen 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(296, 50);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Anzeigen 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(418, 50);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "Anzeigen 4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(536, 50);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 4;
            button5.Text = "Anzeigen 5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // LblAnzeige1
            // 
            LblAnzeige1.AutoSize = true;
            LblAnzeige1.Location = new Point(73, 178);
            LblAnzeige1.Name = "LblAnzeige1";
            LblAnzeige1.Size = new Size(38, 15);
            LblAnzeige1.TabIndex = 5;
            LblAnzeige1.Text = "label1";
            // 
            // LblAnzeige2
            // 
            LblAnzeige2.AutoSize = true;
            LblAnzeige2.Location = new Point(196, 178);
            LblAnzeige2.Name = "LblAnzeige2";
            LblAnzeige2.Size = new Size(38, 15);
            LblAnzeige2.TabIndex = 6;
            LblAnzeige2.Text = "label2";
            // 
            // LblAnzeige3
            // 
            LblAnzeige3.AutoSize = true;
            LblAnzeige3.Location = new Point(307, 178);
            LblAnzeige3.Name = "LblAnzeige3";
            LblAnzeige3.Size = new Size(38, 15);
            LblAnzeige3.TabIndex = 7;
            LblAnzeige3.Text = "label3";
            // 
            // LblAnzeige4
            // 
            LblAnzeige4.AutoSize = true;
            LblAnzeige4.Location = new Point(429, 178);
            LblAnzeige4.Name = "LblAnzeige4";
            LblAnzeige4.Size = new Size(38, 15);
            LblAnzeige4.TabIndex = 8;
            LblAnzeige4.Text = "label4";
            // 
            // LblAnzeige5
            // 
            LblAnzeige5.AutoSize = true;
            LblAnzeige5.Location = new Point(545, 178);
            LblAnzeige5.Name = "LblAnzeige5";
            LblAnzeige5.Size = new Size(38, 15);
            LblAnzeige5.TabIndex = 9;
            LblAnzeige5.Text = "label5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAnzeige5);
            Controls.Add(LblAnzeige4);
            Controls.Add(LblAnzeige3);
            Controls.Add(LblAnzeige2);
            Controls.Add(LblAnzeige1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label LblAnzeige1;
        private Label LblAnzeige2;
        private Label LblAnzeige3;
        private Label LblAnzeige4;
        private Label LblAnzeige5;
    }
}
