// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenFor
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
            CmdAnzeigen = new Button();
            LblAnzeigen = new Label();
            CmdAnzeigen2 = new Button();
            LblAnzeigen2 = new Label();
            CmdAnzeigen3 = new Button();
            LblAnzeigen3 = new Label();
            CmdAnzeigen4 = new Button();
            LblAnzeige4 = new Label();
            SuspendLayout();
            // 
            // CmdAnzeigen
            // 
            CmdAnzeigen.Location = new Point(47, 40);
            CmdAnzeigen.Name = "CmdAnzeigen";
            CmdAnzeigen.Size = new Size(75, 23);
            CmdAnzeigen.TabIndex = 0;
            CmdAnzeigen.Text = "Anzeigen 1";
            CmdAnzeigen.UseVisualStyleBackColor = true;
            CmdAnzeigen.Click += CmdAnzeigen_Click;
            // 
            // LblAnzeigen
            // 
            LblAnzeigen.AutoSize = true;
            LblAnzeigen.Location = new Point(47, 103);
            LblAnzeigen.Name = "LblAnzeigen";
            LblAnzeigen.Size = new Size(38, 15);
            LblAnzeigen.TabIndex = 1;
            LblAnzeigen.Text = "label1";
            // 
            // CmdAnzeigen2
            // 
            CmdAnzeigen2.Location = new Point(177, 40);
            CmdAnzeigen2.Name = "CmdAnzeigen2";
            CmdAnzeigen2.Size = new Size(75, 23);
            CmdAnzeigen2.TabIndex = 2;
            CmdAnzeigen2.Text = "Anzeigen 2";
            CmdAnzeigen2.UseVisualStyleBackColor = true;
            CmdAnzeigen2.Click += CmdAnzeigen2_Click;
            // 
            // LblAnzeigen2
            // 
            LblAnzeigen2.AutoSize = true;
            LblAnzeigen2.Location = new Point(189, 103);
            LblAnzeigen2.Name = "LblAnzeigen2";
            LblAnzeigen2.Size = new Size(38, 15);
            LblAnzeigen2.TabIndex = 3;
            LblAnzeigen2.Text = "label2";
            // 
            // CmdAnzeigen3
            // 
            CmdAnzeigen3.Location = new Point(300, 40);
            CmdAnzeigen3.Name = "CmdAnzeigen3";
            CmdAnzeigen3.Size = new Size(75, 23);
            CmdAnzeigen3.TabIndex = 4;
            CmdAnzeigen3.Text = "Anzeigen 3";
            CmdAnzeigen3.UseVisualStyleBackColor = true;
            CmdAnzeigen3.Click += CmdAnzeigen3_Click;
            // 
            // LblAnzeigen3
            // 
            LblAnzeigen3.AutoSize = true;
            LblAnzeigen3.Location = new Point(313, 103);
            LblAnzeigen3.Name = "LblAnzeigen3";
            LblAnzeigen3.Size = new Size(38, 15);
            LblAnzeigen3.TabIndex = 5;
            LblAnzeigen3.Text = "label3";
            // 
            // CmdAnzeigen4
            // 
            CmdAnzeigen4.Location = new Point(416, 40);
            CmdAnzeigen4.Name = "CmdAnzeigen4";
            CmdAnzeigen4.Size = new Size(75, 23);
            CmdAnzeigen4.TabIndex = 6;
            CmdAnzeigen4.Text = "Anzeigen 4";
            CmdAnzeigen4.UseVisualStyleBackColor = true;
            CmdAnzeigen4.Click += CmdAnzeigen4_Click;
            // 
            // LblAnzeige4
            // 
            LblAnzeige4.AutoSize = true;
            LblAnzeige4.Location = new Point(433, 103);
            LblAnzeige4.Name = "LblAnzeige4";
            LblAnzeige4.Size = new Size(38, 15);
            LblAnzeige4.TabIndex = 7;
            LblAnzeige4.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAnzeige4);
            Controls.Add(CmdAnzeigen4);
            Controls.Add(LblAnzeigen3);
            Controls.Add(CmdAnzeigen3);
            Controls.Add(LblAnzeigen2);
            Controls.Add(CmdAnzeigen2);
            Controls.Add(LblAnzeigen);
            Controls.Add(CmdAnzeigen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAnzeigen;
        private Label LblAnzeigen;
        private Button CmdAnzeigen2;
        private Label LblAnzeigen2;
        private Button CmdAnzeigen3;
        private Label LblAnzeigen3;
        private Button CmdAnzeigen4;
        private Label LblAnzeige4;
    }
}
