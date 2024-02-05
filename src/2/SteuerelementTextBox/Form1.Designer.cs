// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementTextBox
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
            CmdRechnen = new Button();
            TxtEingabe = new TextBox();
            LblAnzeige = new Label();
            SuspendLayout();
            // 
            // CmdAnzeigen
            // 
            CmdAnzeigen.Location = new Point(528, 86);
            CmdAnzeigen.Name = "CmdAnzeigen";
            CmdAnzeigen.Size = new Size(75, 23);
            CmdAnzeigen.TabIndex = 0;
            CmdAnzeigen.Text = "Anzeigen";
            CmdAnzeigen.UseVisualStyleBackColor = true;
            CmdAnzeigen.Click += CmdAnzeigen_Click;
            // 
            // CmdRechnen
            // 
            CmdRechnen.Location = new Point(528, 115);
            CmdRechnen.Name = "CmdRechnen";
            CmdRechnen.Size = new Size(75, 23);
            CmdRechnen.TabIndex = 1;
            CmdRechnen.Text = "Rechnen";
            CmdRechnen.UseVisualStyleBackColor = true;
            CmdRechnen.Click += CmdRechnen_Click;
            // 
            // TxtEingabe
            // 
            TxtEingabe.Location = new Point(72, 86);
            TxtEingabe.Name = "TxtEingabe";
            TxtEingabe.Size = new Size(100, 23);
            TxtEingabe.TabIndex = 2;
            TxtEingabe.Text = "Hallo Welt!";
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(87, 123);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(38, 15);
            LblAnzeige.TabIndex = 3;
            LblAnzeige.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 371);
            Controls.Add(LblAnzeige);
            Controls.Add(TxtEingabe);
            Controls.Add(CmdRechnen);
            Controls.Add(CmdAnzeigen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAnzeigen;
        private Button CmdRechnen;
        private TextBox TxtEingabe;
        private Label LblAnzeige;
    }
}
