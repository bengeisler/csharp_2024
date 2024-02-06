// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementRadioButton
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
            CmdButton1 = new Button();
            CmdButton2 = new Button();
            LblAnzeige1 = new Label();
            LblAnzeige2 = new Label();
            OptRot1 = new RadioButton();
            OptRot2 = new RadioButton();
            OptRot3 = new RadioButton();
            SuspendLayout();
            // 
            // CmdButton1
            // 
            CmdButton1.Location = new Point(662, 69);
            CmdButton1.Name = "CmdButton1";
            CmdButton1.Size = new Size(75, 23);
            CmdButton1.TabIndex = 0;
            CmdButton1.Text = "Prüfen";
            CmdButton1.UseVisualStyleBackColor = true;
            CmdButton1.Click += CmdButton1_Click;
            // 
            // CmdButton2
            // 
            CmdButton2.Location = new Point(653, 339);
            CmdButton2.Name = "CmdButton2";
            CmdButton2.Size = new Size(105, 23);
            CmdButton2.TabIndex = 1;
            CmdButton2.Text = "Rot auswählen";
            CmdButton2.UseVisualStyleBackColor = true;
            // 
            // LblAnzeige1
            // 
            LblAnzeige1.AutoSize = true;
            LblAnzeige1.Location = new Point(87, 69);
            LblAnzeige1.Name = "LblAnzeige1";
            LblAnzeige1.Size = new Size(38, 15);
            LblAnzeige1.TabIndex = 2;
            LblAnzeige1.Text = "label1";
            // 
            // LblAnzeige2
            // 
            LblAnzeige2.AutoSize = true;
            LblAnzeige2.Location = new Point(87, 289);
            LblAnzeige2.Name = "LblAnzeige2";
            LblAnzeige2.Size = new Size(38, 15);
            LblAnzeige2.TabIndex = 3;
            LblAnzeige2.Text = "label2";
            // 
            // OptRot1
            // 
            OptRot1.AutoSize = true;
            OptRot1.Location = new Point(653, 129);
            OptRot1.Name = "OptRot1";
            OptRot1.Size = new Size(43, 19);
            OptRot1.TabIndex = 4;
            OptRot1.TabStop = true;
            OptRot1.Text = "Rot";
            OptRot1.UseVisualStyleBackColor = true;
            // 
            // OptRot2
            // 
            OptRot2.AutoSize = true;
            OptRot2.Location = new Point(653, 201);
            OptRot2.Name = "OptRot2";
            OptRot2.Size = new Size(51, 19);
            OptRot2.TabIndex = 5;
            OptRot2.TabStop = true;
            OptRot2.Text = "Grün";
            OptRot2.UseVisualStyleBackColor = true;
            // 
            // OptRot3
            // 
            OptRot3.AutoSize = true;
            OptRot3.Location = new Point(653, 289);
            OptRot3.Name = "OptRot3";
            OptRot3.Size = new Size(48, 19);
            OptRot3.TabIndex = 6;
            OptRot3.TabStop = true;
            OptRot3.Text = "Blau";
            OptRot3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OptRot3);
            Controls.Add(OptRot2);
            Controls.Add(OptRot1);
            Controls.Add(LblAnzeige2);
            Controls.Add(LblAnzeige1);
            Controls.Add(CmdButton2);
            Controls.Add(CmdButton1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdButton1;
        private Button CmdButton2;
        private Label LblAnzeige1;
        private Label LblAnzeige2;
        private RadioButton OptRot1;
        private RadioButton OptRot2;
        private RadioButton OptRot3;
    }
}
