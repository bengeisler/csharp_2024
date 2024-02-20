// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace ULottozahlen
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
            BtnZiehen = new Button();
            LstBox = new ListBox();
            TxtZusatzZahl = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // BtnZiehen
            // 
            BtnZiehen.Location = new Point(78, 40);
            BtnZiehen.Name = "BtnZiehen";
            BtnZiehen.Size = new Size(75, 23);
            BtnZiehen.TabIndex = 0;
            BtnZiehen.Text = "Ziehen";
            BtnZiehen.UseVisualStyleBackColor = true;
            BtnZiehen.Click += BtnZiehen_Click;
            // 
            // LstBox
            // 
            LstBox.FormattingEnabled = true;
            LstBox.ItemHeight = 15;
            LstBox.Location = new Point(63, 69);
            LstBox.Name = "LstBox";
            LstBox.Size = new Size(120, 94);
            LstBox.TabIndex = 1;
            // 
            // TxtZusatzZahl
            // 
            TxtZusatzZahl.Location = new Point(63, 191);
            TxtZusatzZahl.Name = "TxtZusatzZahl";
            TxtZusatzZahl.Size = new Size(120, 23);
            TxtZusatzZahl.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 173);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 3;
            label1.Text = "Zusatzzahl:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 270);
            Controls.Add(label1);
            Controls.Add(TxtZusatzZahl);
            Controls.Add(LstBox);
            Controls.Add(BtnZiehen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnZiehen;
        private ListBox LstBox;
        private TextBox TxtZusatzZahl;
        private Label label1;
    }
}
