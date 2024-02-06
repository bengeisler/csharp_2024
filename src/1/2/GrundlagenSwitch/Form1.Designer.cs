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
            cmdAnzeigen = new Button();
            LblAnzeige = new Label();
            TxtStadt = new TextBox();
            cmdAnzeigen2 = new Button();
            cmdAnzeigen3 = new Button();
            cmdAnzeigen4 = new Button();
            cmdAnzeigen5 = new Button();
            SuspendLayout();
            // 
            // cmdAnzeigen
            // 
            cmdAnzeigen.Location = new Point(25, 41);
            cmdAnzeigen.Name = "cmdAnzeigen";
            cmdAnzeigen.Size = new Size(75, 23);
            cmdAnzeigen.TabIndex = 0;
            cmdAnzeigen.Text = "Anzeigen 1";
            cmdAnzeigen.UseVisualStyleBackColor = true;
            cmdAnzeigen.Click += cmdAnzeigen_Click;
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(25, 87);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(38, 15);
            LblAnzeige.TabIndex = 1;
            LblAnzeige.Text = "label1";
            // 
            // TxtStadt
            // 
            TxtStadt.Location = new Point(25, 12);
            TxtStadt.Name = "TxtStadt";
            TxtStadt.Size = new Size(154, 23);
            TxtStadt.TabIndex = 2;
            // 
            // cmdAnzeigen2
            // 
            cmdAnzeigen2.Location = new Point(117, 41);
            cmdAnzeigen2.Name = "cmdAnzeigen2";
            cmdAnzeigen2.Size = new Size(75, 23);
            cmdAnzeigen2.TabIndex = 3;
            cmdAnzeigen2.Text = "Anzeigen 2";
            cmdAnzeigen2.UseVisualStyleBackColor = true;
            cmdAnzeigen2.Click += cmdAnzeigen2_Click;
            // 
            // cmdAnzeigen3
            // 
            cmdAnzeigen3.Location = new Point(211, 41);
            cmdAnzeigen3.Name = "cmdAnzeigen3";
            cmdAnzeigen3.Size = new Size(75, 23);
            cmdAnzeigen3.TabIndex = 4;
            cmdAnzeigen3.Text = "Anzeigen 3";
            cmdAnzeigen3.UseVisualStyleBackColor = true;
            cmdAnzeigen3.Click += cmdAnzeigen3_Click;
            // 
            // cmdAnzeigen4
            // 
            cmdAnzeigen4.Location = new Point(301, 41);
            cmdAnzeigen4.Name = "cmdAnzeigen4";
            cmdAnzeigen4.Size = new Size(75, 23);
            cmdAnzeigen4.TabIndex = 5;
            cmdAnzeigen4.Text = "Anzeigen 4";
            cmdAnzeigen4.UseVisualStyleBackColor = true;
            cmdAnzeigen4.Click += cmdAnzeigen4_Click;
            // 
            // cmdAnzeigen5
            // 
            cmdAnzeigen5.Location = new Point(393, 41);
            cmdAnzeigen5.Name = "cmdAnzeigen5";
            cmdAnzeigen5.Size = new Size(75, 23);
            cmdAnzeigen5.TabIndex = 6;
            cmdAnzeigen5.Text = "Anzeigen 5";
            cmdAnzeigen5.UseVisualStyleBackColor = true;
            cmdAnzeigen5.Click += cmdAnzeigen5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdAnzeigen5);
            Controls.Add(cmdAnzeigen4);
            Controls.Add(cmdAnzeigen3);
            Controls.Add(cmdAnzeigen2);
            Controls.Add(TxtStadt);
            Controls.Add(LblAnzeige);
            Controls.Add(cmdAnzeigen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdAnzeigen;
        private Label LblAnzeige;
        private TextBox TxtStadt;
        private Button cmdAnzeigen2;
        private Button cmdAnzeigen3;
        private Button cmdAnzeigen4;
        private Button cmdAnzeigen5;
    }
}
