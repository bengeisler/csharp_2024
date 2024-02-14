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
            LblAnzeige = new Label();
            CmdOhneHandling = new Button();
            CmdMitExceptionHandling = new Button();
            CmdMiterweitertenExceptionHandling = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(27, 238);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(38, 15);
            LblAnzeige.TabIndex = 0;
            LblAnzeige.Text = "label1";
            // 
            // CmdOhneHandling
            // 
            CmdOhneHandling.Location = new Point(285, 21);
            CmdOhneHandling.Name = "CmdOhneHandling";
            CmdOhneHandling.Size = new Size(174, 23);
            CmdOhneHandling.TabIndex = 1;
            CmdOhneHandling.Text = "Ohne Exception Handling";
            CmdOhneHandling.UseVisualStyleBackColor = true;
            CmdOhneHandling.Click += CmdOhneHandling_Click;
            // 
            // CmdMitExceptionHandling
            // 
            CmdMitExceptionHandling.Location = new Point(285, 61);
            CmdMitExceptionHandling.Name = "CmdMitExceptionHandling";
            CmdMitExceptionHandling.Size = new Size(184, 23);
            CmdMitExceptionHandling.TabIndex = 2;
            CmdMitExceptionHandling.Text = "Mit Exception Handling";
            CmdMitExceptionHandling.UseVisualStyleBackColor = true;
            CmdMitExceptionHandling.Click += CmdMitExceptionHandling_Click;
            // 
            // CmdMiterweitertenExceptionHandling
            // 
            CmdMiterweitertenExceptionHandling.Location = new Point(285, 106);
            CmdMiterweitertenExceptionHandling.Name = "CmdMiterweitertenExceptionHandling";
            CmdMiterweitertenExceptionHandling.Size = new Size(184, 23);
            CmdMiterweitertenExceptionHandling.TabIndex = 3;
            CmdMiterweitertenExceptionHandling.Text = "Mit erweiterten Exception Handling";
            CmdMiterweitertenExceptionHandling.UseVisualStyleBackColor = true;
            CmdMiterweitertenExceptionHandling.Click += CmdMiterweitertenExceptionHandling_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(47, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(47, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 311);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(CmdMiterweitertenExceptionHandling);
            Controls.Add(CmdMitExceptionHandling);
            Controls.Add(CmdOhneHandling);
            Controls.Add(LblAnzeige);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAnzeige;
        private Button CmdOhneHandling;
        private Button CmdMitExceptionHandling;
        private Button CmdMiterweitertenExceptionHandling;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
