// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Übung
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
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            LblName = new Label();
            LblAlter = new Label();
            LblMitglieder = new Label();
            LblFarbe = new Label();
            LblError = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            LstBox = new ListBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(48, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(200, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(104, 205);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Übernehmen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(63, 234);
            button2.Name = "button2";
            button2.Size = new Size(155, 39);
            button2.TabIndex = 4;
            button2.Text = "Mitgleid löschen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(104, 375);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Beenden";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(48, 80);
            LblName.Name = "LblName";
            LblName.Size = new Size(39, 15);
            LblName.TabIndex = 6;
            LblName.Text = "Name";
            // 
            // LblAlter
            // 
            LblAlter.AutoSize = true;
            LblAlter.Location = new Point(200, 80);
            LblAlter.Name = "LblAlter";
            LblAlter.Size = new Size(32, 15);
            LblAlter.TabIndex = 7;
            LblAlter.Text = "Alter";
            // 
            // LblMitglieder
            // 
            LblMitglieder.AutoSize = true;
            LblMitglieder.Location = new Point(691, 80);
            LblMitglieder.Name = "LblMitglieder";
            LblMitglieder.Size = new Size(61, 15);
            LblMitglieder.TabIndex = 8;
            LblMitglieder.Text = "Mitglieder";
            // 
            // LblFarbe
            // 
            LblFarbe.AutoSize = true;
            LblFarbe.Location = new Point(346, 88);
            LblFarbe.Name = "LblFarbe";
            LblFarbe.Size = new Size(81, 15);
            LblFarbe.TabIndex = 9;
            LblFarbe.Text = "Lieblingsfarbe";
            // 
            // LblError
            // 
            LblError.AutoSize = true;
            LblError.Location = new Point(48, 318);
            LblError.Name = "LblError";
            LblError.Size = new Size(21, 15);
            LblError.TabIndex = 10;
            LblError.Text = "err";
            LblError.Click += LblError_Click;
            // 
            // radioButton1
            // 
            radioButton1.AccessibleRole = AccessibleRole.None;
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(346, 106);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(43, 19);
            radioButton1.TabIndex = 11;
            radioButton1.Text = "Rot";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(446, 106);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(48, 19);
            radioButton2.TabIndex = 12;
            radioButton2.Text = "Blau";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // LstBox
            // 
            LstBox.FormattingEnabled = true;
            LstBox.ItemHeight = 15;
            LstBox.Location = new Point(611, 104);
            LstBox.Name = "LstBox";
            LstBox.Size = new Size(177, 334);
            LstBox.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LstBox);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(LblError);
            Controls.Add(LblFarbe);
            Controls.Add(LblMitglieder);
            Controls.Add(LblAlter);
            Controls.Add(LblName);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label LblName;
        private Label LblAlter;
        private Label LblMitglieder;
        private Label LblFarbe;
        private Label LblError;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ListBox LstBox;
    }
}
