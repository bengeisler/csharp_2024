// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace WhileÜbung
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
            LblAnzeige1 = new Label();
            CmdButton1 = new Button();
            Num = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)Num).BeginInit();
            SuspendLayout();
            // 
            // LblAnzeige1
            // 
            LblAnzeige1.AutoSize = true;
            LblAnzeige1.Location = new Point(287, 205);
            LblAnzeige1.Name = "LblAnzeige1";
            LblAnzeige1.Size = new Size(38, 15);
            LblAnzeige1.TabIndex = 0;
            LblAnzeige1.Text = "label1";
            // 
            // CmdButton1
            // 
            CmdButton1.Location = new Point(563, 65);
            CmdButton1.Name = "CmdButton1";
            CmdButton1.Size = new Size(75, 23);
            CmdButton1.TabIndex = 1;
            CmdButton1.Text = "button1";
            CmdButton1.UseVisualStyleBackColor = true;
            CmdButton1.Click += CmdButton1_Click;
            // 
            // Num
            // 
            Num.Location = new Point(311, 67);
            Num.Name = "Num";
            Num.Size = new Size(120, 23);
            Num.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Num);
            Controls.Add(CmdButton1);
            Controls.Add(LblAnzeige1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Num).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAnzeige1;
        private Button CmdButton1;
        private NumericUpDown Num;
    }
}
