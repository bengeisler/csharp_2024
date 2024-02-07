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
            CmdAnzeigen1 = new Button();
            Lblausgabe = new Label();
            txtAusgabe = new TextBox();
            CmdAnzeige2 = new Button();
            CmdAnzeige3 = new Button();
            CmdAnzeige4 = new Button();
            CmdAnzeige5 = new Button();
            SuspendLayout();
            // 
            // CmdAnzeigen1
            // 
            CmdAnzeigen1.Location = new Point(63, 76);
            CmdAnzeigen1.Name = "CmdAnzeigen1";
            CmdAnzeigen1.Size = new Size(75, 23);
            CmdAnzeigen1.TabIndex = 0;
            CmdAnzeigen1.Text = "Anzeigen1";
            CmdAnzeigen1.UseVisualStyleBackColor = true;
            CmdAnzeigen1.Click += CmdAnzeigen1_Click;
            // 
            // Lblausgabe
            // 
            Lblausgabe.AutoSize = true;
            Lblausgabe.Location = new Point(81, 134);
            Lblausgabe.Name = "Lblausgabe";
            Lblausgabe.Size = new Size(38, 15);
            Lblausgabe.TabIndex = 1;
            Lblausgabe.Text = "label1";
            // 
            // txtAusgabe
            // 
            txtAusgabe.Location = new Point(44, 35);
            txtAusgabe.Name = "txtAusgabe";
            txtAusgabe.Size = new Size(100, 23);
            txtAusgabe.TabIndex = 2;
            // 
            // CmdAnzeige2
            // 
            CmdAnzeige2.Location = new Point(205, 84);
            CmdAnzeige2.Name = "CmdAnzeige2";
            CmdAnzeige2.Size = new Size(75, 23);
            CmdAnzeige2.TabIndex = 3;
            CmdAnzeige2.Text = "Anzeige2";
            CmdAnzeige2.UseVisualStyleBackColor = true;
            CmdAnzeige2.Click += CmdAnzeige2_Click;
            // 
            // CmdAnzeige3
            // 
            CmdAnzeige3.Location = new Point(236, 48);
            CmdAnzeige3.Name = "CmdAnzeige3";
            CmdAnzeige3.Size = new Size(75, 23);
            CmdAnzeige3.TabIndex = 4;
            CmdAnzeige3.Text = "Anzeige3";
            CmdAnzeige3.UseVisualStyleBackColor = true;
            CmdAnzeige3.Click += CmdAnzeige3_Click;
            // 
            // CmdAnzeige4
            // 
            CmdAnzeige4.Location = new Point(468, 319);
            CmdAnzeige4.Name = "CmdAnzeige4";
            CmdAnzeige4.Size = new Size(75, 23);
            CmdAnzeige4.TabIndex = 5;
            CmdAnzeige4.Text = "Anzeige4";
            CmdAnzeige4.UseVisualStyleBackColor = true;
            CmdAnzeige4.Click += CmdAnzeige4_Click;
            // 
            // CmdAnzeige5
            // 
            CmdAnzeige5.Location = new Point(325, 204);
            CmdAnzeige5.Name = "CmdAnzeige5";
            CmdAnzeige5.Size = new Size(75, 23);
            CmdAnzeige5.TabIndex = 6;
            CmdAnzeige5.Text = "Anzeige5";
            CmdAnzeige5.UseVisualStyleBackColor = true;
            CmdAnzeige5.Click += CmdAnzeige5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdAnzeige5);
            Controls.Add(CmdAnzeige4);
            Controls.Add(CmdAnzeige3);
            Controls.Add(CmdAnzeige2);
            Controls.Add(txtAusgabe);
            Controls.Add(Lblausgabe);
            Controls.Add(CmdAnzeigen1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAnzeigen1;
        private Label Lblausgabe;
        private TextBox txtAusgabe;
        private Button CmdAnzeige2;
        private Button CmdAnzeige3;
        private Button CmdAnzeige4;
        private Button CmdAnzeige5;
    }
}
