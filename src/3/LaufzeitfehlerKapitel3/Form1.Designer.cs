// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace LaufzeitfehlerKapitel3
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
            Cmdohne = new Button();
            button2 = new Button();
            button3 = new Button();
            TxtEingabe1 = new TextBox();
            TxtEingabe2 = new TextBox();
            LblAusgabe = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // Cmdohne
            // 
            Cmdohne.Location = new Point(284, 92);
            Cmdohne.Name = "Cmdohne";
            Cmdohne.Size = new Size(233, 23);
            Cmdohne.TabIndex = 0;
            Cmdohne.Text = "Ohne exception Handling";
            Cmdohne.UseVisualStyleBackColor = true;
            Cmdohne.Click += Cmdohne_Click;
            // 
            // button2
            // 
            button2.Location = new Point(284, 135);
            button2.Name = "button2";
            button2.Size = new Size(233, 23);
            button2.TabIndex = 1;
            button2.Text = "Mit Exception Handling";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(284, 183);
            button3.Name = "button3";
            button3.Size = new Size(233, 23);
            button3.TabIndex = 2;
            button3.Text = "Mit erweitertem Exception handling";
            button3.UseVisualStyleBackColor = true;
            // 
            // TxtEingabe1
            // 
            TxtEingabe1.Location = new Point(105, 93);
            TxtEingabe1.Name = "TxtEingabe1";
            TxtEingabe1.Size = new Size(100, 23);
            TxtEingabe1.TabIndex = 3;
            // 
            // TxtEingabe2
            // 
            TxtEingabe2.Location = new Point(105, 136);
            TxtEingabe2.Name = "TxtEingabe2";
            TxtEingabe2.Size = new Size(100, 23);
            TxtEingabe2.TabIndex = 4;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(118, 189);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(38, 15);
            LblAusgabe.TabIndex = 5;
            LblAusgabe.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(284, 235);
            button1.Name = "button1";
            button1.Size = new Size(233, 23);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(LblAusgabe);
            Controls.Add(TxtEingabe2);
            Controls.Add(TxtEingabe1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Cmdohne);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cmdohne;
        private Button button2;
        private Button button3;
        private TextBox TxtEingabe1;
        private TextBox TxtEingabe2;
        private Label LblAusgabe;
        private Button button1;
    }
}
