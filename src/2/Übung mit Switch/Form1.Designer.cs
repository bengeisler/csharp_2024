// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Übung_mit_Switch
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
            LblAnzeige1 = new Label();
            LblAnzeige2 = new Label();
            CmdAnzeigen1 = new Button();
            CmdAnzeigen2 = new Button();
            Numtext = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)Numtext).BeginInit();
            SuspendLayout();
            // 
            // LblAnzeige1
            // 
            LblAnzeige1.AutoSize = true;
            LblAnzeige1.Location = new Point(84, 40);
            LblAnzeige1.Name = "LblAnzeige1";
            LblAnzeige1.Size = new Size(44, 15);
            LblAnzeige1.TabIndex = 0;
            LblAnzeige1.Text = "Gehalt:";
            // 
            // LblAnzeige2
            // 
            LblAnzeige2.AutoSize = true;
            LblAnzeige2.Location = new Point(286, 120);
            LblAnzeige2.Name = "LblAnzeige2";
            LblAnzeige2.Size = new Size(38, 15);
            LblAnzeige2.TabIndex = 1;
            LblAnzeige2.Text = "label2";
            // 
            // CmdAnzeigen1
            // 
            CmdAnzeigen1.Location = new Point(596, 51);
            CmdAnzeigen1.Name = "CmdAnzeigen1";
            CmdAnzeigen1.Size = new Size(75, 23);
            CmdAnzeigen1.TabIndex = 2;
            CmdAnzeigen1.Text = "Berechnen";
            CmdAnzeigen1.UseVisualStyleBackColor = true;
            CmdAnzeigen1.Click += CmdAnzeigen1_Click;
            // 
            // CmdAnzeigen2
            // 
            CmdAnzeigen2.Location = new Point(596, 110);
            CmdAnzeigen2.Name = "CmdAnzeigen2";
            CmdAnzeigen2.Size = new Size(75, 23);
            CmdAnzeigen2.TabIndex = 3;
            CmdAnzeigen2.Text = "Cancle";
            CmdAnzeigen2.UseVisualStyleBackColor = true;
            // 
            // Numtext
            // 
            Numtext.Location = new Point(109, 147);
            Numtext.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            Numtext.Name = "Numtext";
            Numtext.Size = new Size(120, 23);
            Numtext.TabIndex = 4;
            Numtext.ValueChanged += Numtext_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Numtext);
            Controls.Add(CmdAnzeigen2);
            Controls.Add(CmdAnzeigen1);
            Controls.Add(LblAnzeige2);
            Controls.Add(LblAnzeige1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Numtext).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAnzeige1;
        private Label LblAnzeige2;
        private Button CmdAnzeigen1;
        private Button CmdAnzeigen2;
        private NumericUpDown Numtext;
    }
}
