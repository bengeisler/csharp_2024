// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SchleifenFor
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
            CmdAnzeige1 = new Button();
            CmdAnzeige2 = new Button();
            LabelAnzeige1 = new Label();
            labelAnzeige2 = new Label();
            LabelAnzeige3 = new Label();
            SuspendLayout();
            // 
            // CmdAnzeige1
            // 
            CmdAnzeige1.Location = new Point(258, 89);
            CmdAnzeige1.Name = "CmdAnzeige1";
            CmdAnzeige1.Size = new Size(75, 23);
            CmdAnzeige1.TabIndex = 0;
            CmdAnzeige1.Text = "Anzeige1";
            CmdAnzeige1.UseVisualStyleBackColor = true;
            CmdAnzeige1.Click += CmdAnzeige1_Click;
            // 
            // CmdAnzeige2
            // 
            CmdAnzeige2.Location = new Point(258, 138);
            CmdAnzeige2.Name = "CmdAnzeige2";
            CmdAnzeige2.Size = new Size(75, 23);
            CmdAnzeige2.TabIndex = 1;
            CmdAnzeige2.Text = "Anzeige2";
            CmdAnzeige2.UseVisualStyleBackColor = true;
            // 
            // LabelAnzeige1
            // 
            LabelAnzeige1.AutoSize = true;
            LabelAnzeige1.Location = new Point(48, 56);
            LabelAnzeige1.Name = "LabelAnzeige1";
            LabelAnzeige1.Size = new Size(38, 15);
            LabelAnzeige1.TabIndex = 2;
            LabelAnzeige1.Text = "label1";
            // 
            // labelAnzeige2
            // 
            labelAnzeige2.AutoSize = true;
            labelAnzeige2.Location = new Point(46, 225);
            labelAnzeige2.Name = "labelAnzeige2";
            labelAnzeige2.Size = new Size(38, 15);
            labelAnzeige2.TabIndex = 3;
            labelAnzeige2.Text = "label2";
            // 
            // LabelAnzeige3
            // 
            LabelAnzeige3.AutoSize = true;
            LabelAnzeige3.Location = new Point(46, 263);
            LabelAnzeige3.Name = "LabelAnzeige3";
            LabelAnzeige3.Size = new Size(38, 15);
            LabelAnzeige3.TabIndex = 4;
            LabelAnzeige3.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LabelAnzeige3);
            Controls.Add(labelAnzeige2);
            Controls.Add(LabelAnzeige1);
            Controls.Add(CmdAnzeige2);
            Controls.Add(CmdAnzeige1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAnzeige1;
        private Button CmdAnzeige2;
        private Label LabelAnzeige1;
        private Label labelAnzeige2;
        private Label LabelAnzeige3;
    }
}
