// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace ÜbungListeEA
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
            TxtBox2 = new TextBox();
            ChkBox = new CheckBox();
            CmdButton1 = new Button();
            CmdButton2 = new Button();
            CmdButton3 = new Button();
            CmdButton4 = new Button();
            CmdButton5 = new Button();
            CmdButton6 = new Button();
            LstBox = new ListBox();
            SuspendLayout();
            // 
            // TxtBox2
            // 
            TxtBox2.Location = new Point(12, 309);
            TxtBox2.Name = "TxtBox2";
            TxtBox2.Size = new Size(635, 23);
            TxtBox2.TabIndex = 0;
            // 
            // ChkBox
            // 
            ChkBox.AutoSize = true;
            ChkBox.Location = new Point(382, 381);
            ChkBox.Name = "ChkBox";
            ChkBox.Size = new Size(64, 19);
            ChkBox.TabIndex = 2;
            ChkBox.Text = "Sortiert";
            ChkBox.UseVisualStyleBackColor = true;
            ChkBox.CheckedChanged += ChkBox_CheckedChanged;
            // 
            // CmdButton1
            // 
            CmdButton1.Location = new Point(13, 374);
            CmdButton1.Name = "CmdButton1";
            CmdButton1.Size = new Size(87, 30);
            CmdButton1.TabIndex = 3;
            CmdButton1.Text = "Hinzufügen";
            CmdButton1.UseVisualStyleBackColor = true;
            CmdButton1.Click += CmdButton1_Click;
            // 
            // CmdButton2
            // 
            CmdButton2.Location = new Point(106, 374);
            CmdButton2.Name = "CmdButton2";
            CmdButton2.Size = new Size(87, 30);
            CmdButton2.TabIndex = 4;
            CmdButton2.Text = "Löschen";
            CmdButton2.UseVisualStyleBackColor = true;
            CmdButton2.Click += CmdButton2_Click;
            // 
            // CmdButton3
            // 
            CmdButton3.Location = new Point(199, 374);
            CmdButton3.Name = "CmdButton3";
            CmdButton3.Size = new Size(87, 30);
            CmdButton3.TabIndex = 5;
            CmdButton3.Text = "Alleslöschen";
            CmdButton3.UseVisualStyleBackColor = true;
            CmdButton3.Click += CmdButton3_Click;
            // 
            // CmdButton4
            // 
            CmdButton4.Location = new Point(468, 338);
            CmdButton4.Name = "CmdButton4";
            CmdButton4.Size = new Size(87, 30);
            CmdButton4.TabIndex = 6;
            CmdButton4.Text = "Liste Laden";
            CmdButton4.UseVisualStyleBackColor = true;
            CmdButton4.Click += CmdButton4_Click;
            // 
            // CmdButton5
            // 
            CmdButton5.Location = new Point(468, 374);
            CmdButton5.Name = "CmdButton5";
            CmdButton5.Size = new Size(87, 30);
            CmdButton5.TabIndex = 7;
            CmdButton5.Text = "Speichern";
            CmdButton5.UseVisualStyleBackColor = true;
            CmdButton5.Click += CmdButton5_Click;
            // 
            // CmdButton6
            // 
            CmdButton6.Location = new Point(561, 374);
            CmdButton6.Name = "CmdButton6";
            CmdButton6.Size = new Size(87, 30);
            CmdButton6.TabIndex = 8;
            CmdButton6.Text = "Beenden";
            CmdButton6.UseVisualStyleBackColor = true;
            CmdButton6.Click += CmdButton6_Click;
            // 
            // LstBox
            // 
            LstBox.FormattingEnabled = true;
            LstBox.ItemHeight = 15;
            LstBox.Location = new Point(12, 12);
            LstBox.Name = "LstBox";
            LstBox.Size = new Size(634, 289);
            LstBox.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 414);
            Controls.Add(LstBox);
            Controls.Add(CmdButton6);
            Controls.Add(CmdButton5);
            Controls.Add(CmdButton4);
            Controls.Add(CmdButton3);
            Controls.Add(CmdButton2);
            Controls.Add(CmdButton1);
            Controls.Add(ChkBox);
            Controls.Add(TxtBox2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBox2;
        private CheckBox ChkBox;
        private Button CmdButton1;
        private Button CmdButton2;
        private Button CmdButton3;
        private Button CmdButton4;
        private Button CmdButton5;
        private Button CmdButton6;
        private ListBox LstBox;
    }
}
