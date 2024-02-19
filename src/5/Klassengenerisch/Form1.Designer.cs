// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Klassengenerisch
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
            btnListString = new Button();
            lblAnzeigen1 = new Label();
            btnListLand = new Button();
            lblAnzeigen2 = new Label();
            SuspendLayout();
            // 
            // btnListString
            // 
            btnListString.Location = new Point(39, 29);
            btnListString.Name = "btnListString";
            btnListString.Size = new Size(75, 23);
            btnListString.TabIndex = 0;
            btnListString.Text = "List String";
            btnListString.UseVisualStyleBackColor = true;
            btnListString.Click += btnListString_Click;
            // 
            // lblAnzeigen1
            // 
            lblAnzeigen1.AutoSize = true;
            lblAnzeigen1.Location = new Point(58, 85);
            lblAnzeigen1.Name = "lblAnzeigen1";
            lblAnzeigen1.Size = new Size(38, 15);
            lblAnzeigen1.TabIndex = 1;
            lblAnzeigen1.Text = "label1";
            // 
            // btnListLand
            // 
            btnListLand.Location = new Point(167, 29);
            btnListLand.Name = "btnListLand";
            btnListLand.Size = new Size(75, 23);
            btnListLand.TabIndex = 2;
            btnListLand.Text = "List Land";
            btnListLand.UseVisualStyleBackColor = true;
            btnListLand.Click += btnListLand_Click;
            // 
            // lblAnzeigen2
            // 
            lblAnzeigen2.AutoSize = true;
            lblAnzeigen2.Location = new Point(504, 85);
            lblAnzeigen2.Name = "lblAnzeigen2";
            lblAnzeigen2.Size = new Size(38, 15);
            lblAnzeigen2.TabIndex = 3;
            lblAnzeigen2.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAnzeigen2);
            Controls.Add(btnListLand);
            Controls.Add(lblAnzeigen1);
            Controls.Add(btnListString);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListString;
        private Label lblAnzeigen1;
        private Button btnListLand;
        private Label lblAnzeigen2;
    }
}
