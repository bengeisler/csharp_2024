// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelemntComboBox
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
            CmbWerkzeuge = new ComboBox();
            CmdAnzeigen = new Button();
            LblAnzeige = new Label();
            SuspendLayout();
            // 
            // CmbWerkzeuge
            // 
            CmbWerkzeuge.FormattingEnabled = true;
            CmbWerkzeuge.Location = new Point(0, 0);
            CmbWerkzeuge.Name = "CmbWerkzeuge";
            CmbWerkzeuge.Size = new Size(121, 23);
            CmbWerkzeuge.TabIndex = 0;
            CmbWerkzeuge.SelectedIndexChanged += CmbWerkzeuge_SelectedIndexChanged;
            // 
            // CmdAnzeigen
            // 
            CmdAnzeigen.Location = new Point(142, 0);
            CmdAnzeigen.Name = "CmdAnzeigen";
            CmdAnzeigen.Size = new Size(75, 23);
            CmdAnzeigen.TabIndex = 1;
            CmdAnzeigen.Text = "Anzeigen";
            CmdAnzeigen.UseVisualStyleBackColor = true;
            CmdAnzeigen.Click += CmdAnzeigen_Click;
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(251, 4);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(38, 15);
            LblAnzeige.TabIndex = 2;
            LblAnzeige.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAnzeige);
            Controls.Add(CmdAnzeigen);
            Controls.Add(CmbWerkzeuge);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CmbWerkzeuge;
        private Button CmdAnzeigen;
        private Label LblAnzeige;
    }
}
