// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace KlassenFormulare
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Lblanzeige1 = new Label();
            CmdButton1 = new Button();
            ChkBox = new CheckBox();
            SuspendLayout();
            // 
            // Lblanzeige1
            // 
            Lblanzeige1.AutoSize = true;
            Lblanzeige1.Location = new Point(225, 119);
            Lblanzeige1.Name = "Lblanzeige1";
            Lblanzeige1.Size = new Size(38, 15);
            Lblanzeige1.TabIndex = 0;
            Lblanzeige1.Text = "check";
            // 
            // CmdButton1
            // 
            CmdButton1.Location = new Point(209, 148);
            CmdButton1.Name = "CmdButton1";
            CmdButton1.Size = new Size(75, 23);
            CmdButton1.TabIndex = 1;
            CmdButton1.Text = "Schließen";
            CmdButton1.UseVisualStyleBackColor = true;
            CmdButton1.Click += CmdButton1_Click;
            // 
            // ChkBox
            // 
            ChkBox.AutoSize = true;
            ChkBox.Location = new Point(317, 119);
            ChkBox.Name = "ChkBox";
            ChkBox.Size = new Size(42, 19);
            ChkBox.TabIndex = 2;
            ChkBox.Text = "OK";
            ChkBox.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ChkBox);
            Controls.Add(CmdButton1);
            Controls.Add(Lblanzeige1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lblanzeige1;
        private Button CmdButton1;
        private CheckBox ChkBox;
    }
}