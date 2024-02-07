// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementComboBox
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
            CmbWerkzeuge.Location = new Point(12, 12);
            CmbWerkzeuge.Name = "CmbWerkzeuge";
            CmbWerkzeuge.Size = new Size(182, 33);
            CmbWerkzeuge.TabIndex = 0;
            CmbWerkzeuge.SelectedIndexChanged += CmbWerkzeuge_SelectedIndexChanged;
            // 
            // CmdAnzeigen
            // 
            CmdAnzeigen.Location = new Point(232, 12);
            CmdAnzeigen.Name = "CmdAnzeigen";
            CmdAnzeigen.Size = new Size(112, 34);
            CmdAnzeigen.TabIndex = 1;
            CmdAnzeigen.Text = "Anzeigen";
            CmdAnzeigen.UseVisualStyleBackColor = true;
            CmdAnzeigen.Click += CmdAnzeigen_Click;
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(372, 15);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(59, 25);
            LblAnzeige.TabIndex = 2;
            LblAnzeige.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 75);
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
