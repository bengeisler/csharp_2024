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
            Cmdbtn1 = new Button();
            Lbl1 = new Label();
            TxtEingabe = new TextBox();
            Cmdbtn2 = new Button();
            Btn3 = new Button();
            Cmdbtn4 = new Button();
            Cmdbtn5 = new Button();
            SuspendLayout();
            // 
            // Cmdbtn1
            // 
            Cmdbtn1.Location = new Point(67, 108);
            Cmdbtn1.Name = "Cmdbtn1";
            Cmdbtn1.Size = new Size(75, 23);
            Cmdbtn1.TabIndex = 0;
            Cmdbtn1.Text = "Anzeigen 1";
            Cmdbtn1.UseVisualStyleBackColor = true;
            Cmdbtn1.Click += Cmdbtn1_Click;
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Location = new Point(67, 207);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(38, 15);
            Lbl1.TabIndex = 1;
            Lbl1.Text = "label1";
            // 
            // TxtEingabe
            // 
            TxtEingabe.Location = new Point(67, 35);
            TxtEingabe.Name = "TxtEingabe";
            TxtEingabe.Size = new Size(100, 23);
            TxtEingabe.TabIndex = 2;
            // 
            // Cmdbtn2
            // 
            Cmdbtn2.Location = new Point(148, 108);
            Cmdbtn2.Name = "Cmdbtn2";
            Cmdbtn2.Size = new Size(75, 23);
            Cmdbtn2.TabIndex = 3;
            Cmdbtn2.Text = "Anzeigen 2";
            Cmdbtn2.UseVisualStyleBackColor = true;
            Cmdbtn2.Click += Cmdbtn2_Click;
            // 
            // Btn3
            // 
            Btn3.Location = new Point(229, 108);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(75, 23);
            Btn3.TabIndex = 4;
            Btn3.Text = "Anzeigen 3";
            Btn3.UseVisualStyleBackColor = true;
            Btn3.Click += Btn3_Click;
            // 
            // Cmdbtn4
            // 
            Cmdbtn4.Location = new Point(310, 108);
            Cmdbtn4.Name = "Cmdbtn4";
            Cmdbtn4.Size = new Size(75, 23);
            Cmdbtn4.TabIndex = 5;
            Cmdbtn4.Text = "Anzeigen 4 ";
            Cmdbtn4.UseVisualStyleBackColor = true;
            Cmdbtn4.Click += Cmdbtn4_Click;
            // 
            // Cmdbtn5
            // 
            Cmdbtn5.Location = new Point(391, 108);
            Cmdbtn5.Name = "Cmdbtn5";
            Cmdbtn5.Size = new Size(75, 23);
            Cmdbtn5.TabIndex = 6;
            Cmdbtn5.Text = "Anzeigen 5";
            Cmdbtn5.UseVisualStyleBackColor = true;
            Cmdbtn5.Click += Cmdbtn5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Cmdbtn5);
            Controls.Add(Cmdbtn4);
            Controls.Add(Btn3);
            Controls.Add(Cmdbtn2);
            Controls.Add(TxtEingabe);
            Controls.Add(Lbl1);
            Controls.Add(Cmdbtn1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cmdbtn1;
        private Label Lbl1;
        private TextBox TxtEingabe;
        private Button Cmdbtn2;
        private Button Btn3;
        private Button Cmdbtn4;
        private Button Cmdbtn5;
    }
}
