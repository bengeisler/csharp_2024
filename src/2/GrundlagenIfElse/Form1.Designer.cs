// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenIfElse
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            LblAnzeige = new Label();
            CmdAnzeigen1 = new Button();
            txtAusgabe = new NumericUpDown();
            CmdAnzeigen2 = new Button();
            ((System.ComponentModel.ISupportInitialize)txtAusgabe).BeginInit();
            SuspendLayout();
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(279, 150);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(38, 15);
            LblAnzeige.TabIndex = 0;
            LblAnzeige.Text = "label1";
            // 
            // CmdAnzeigen1
            // 
            CmdAnzeigen1.Location = new Point(471, 98);
            CmdAnzeigen1.Name = "CmdAnzeigen1";
            CmdAnzeigen1.Size = new Size(113, 90);
            CmdAnzeigen1.TabIndex = 1;
            CmdAnzeigen1.Text = "Anzeigen 1";
            CmdAnzeigen1.UseVisualStyleBackColor = true;
            CmdAnzeigen1.Click += CmdAnzeigen1_Click;
            // 
            // txtAusgabe
            // 
            txtAusgabe.Location = new Point(279, 98);
            txtAusgabe.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            txtAusgabe.Name = "txtAusgabe";
            txtAusgabe.Size = new Size(120, 23);
            txtAusgabe.TabIndex = 2;
            // 
            // CmdAnzeigen2
            // 
            CmdAnzeigen2.Location = new Point(471, 243);
            CmdAnzeigen2.Name = "CmdAnzeigen2";
            CmdAnzeigen2.Size = new Size(116, 70);
            CmdAnzeigen2.TabIndex = 3;
            CmdAnzeigen2.Text = "Anzeigen 2";
            CmdAnzeigen2.UseVisualStyleBackColor = true;
            CmdAnzeigen2.Click += CmdAnzeigen2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdAnzeigen2);
            Controls.Add(txtAusgabe);
            Controls.Add(CmdAnzeigen1);
            Controls.Add(LblAnzeige);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)txtAusgabe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label LblAnzeige;
        private Button CmdAnzeigen1;
        private NumericUpDown txtAusgabe;
        private Button CmdAnzeigen2;
    }
}
