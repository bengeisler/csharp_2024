// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace ULootozahlen
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
            CmdZiehung = new Button();
            Listbox1 = new ListBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // CmdZiehung
            // 
            CmdZiehung.Location = new Point(56, 27);
            CmdZiehung.Name = "CmdZiehung";
            CmdZiehung.Size = new Size(75, 23);
            CmdZiehung.TabIndex = 0;
            CmdZiehung.Text = "button1";
            CmdZiehung.UseVisualStyleBackColor = true;
            CmdZiehung.Click += CmdZiehung_Click;
            // 
            // Listbox1
            // 
            Listbox1.FormattingEnabled = true;
            Listbox1.ItemHeight = 15;
            Listbox1.Location = new Point(71, 78);
            Listbox1.Name = "Listbox1";
            Listbox1.Size = new Size(115, 124);
            Listbox1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(65, 255);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 23);
            textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(Listbox1);
            Controls.Add(CmdZiehung);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdZiehung;
        private ListBox Listbox1;
        private TextBox textBox1;
    }
}
