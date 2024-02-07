// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace USchleifeWhile
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
            textBox1 = new TextBox();
            CmdAnzeige = new Button();
            LbLAnzeige = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(619, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // CmdAnzeige
            // 
            CmdAnzeige.Location = new Point(619, 128);
            CmdAnzeige.Name = "CmdAnzeige";
            CmdAnzeige.Size = new Size(75, 23);
            CmdAnzeige.TabIndex = 1;
            CmdAnzeige.Text = "Anzeigen";
            CmdAnzeige.UseVisualStyleBackColor = true;
            CmdAnzeige.Click += button1_Click;
            // 
            // LbLAnzeige
            // 
            LbLAnzeige.AutoSize = true;
            LbLAnzeige.Location = new Point(146, 76);
            LbLAnzeige.Name = "LbLAnzeige";
            LbLAnzeige.Size = new Size(0, 15);
            LbLAnzeige.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 76);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(LbLAnzeige);
            Controls.Add(CmdAnzeige);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button CmdAnzeige;
        private Label LbLAnzeige;
        private Label label1;
    }
}
