// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementTextbox
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
            TxtEingbe = new TextBox();
            CmdAnzeigen = new Button();
            CmdRechnen = new Button();
            LblAusgabe = new Label();
            SuspendLayout();
            // 
            // TxtEingbe
            // 
            TxtEingbe.Location = new Point(71, 66);
            TxtEingbe.Name = "TxtEingbe";
            TxtEingbe.Size = new Size(227, 23);
            TxtEingbe.TabIndex = 0;
            // 
            // CmdAnzeigen
            // 
            CmdAnzeigen.Location = new Point(391, 66);
            CmdAnzeigen.Name = "CmdAnzeigen";
            CmdAnzeigen.Size = new Size(119, 23);
            CmdAnzeigen.TabIndex = 1;
            CmdAnzeigen.Text = "Anzeigen";
            CmdAnzeigen.UseVisualStyleBackColor = true;
            CmdAnzeigen.Click += CmdAnzeigen_Click;
            // 
            // CmdRechnen
            // 
            CmdRechnen.Location = new Point(391, 108);
            CmdRechnen.Name = "CmdRechnen";
            CmdRechnen.Size = new Size(119, 23);
            CmdRechnen.TabIndex = 2;
            CmdRechnen.Text = "Rechnen";
            CmdRechnen.UseVisualStyleBackColor = true;
            CmdRechnen.Click += CmdRechnen_Click;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(98, 285);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(38, 15);
            LblAusgabe.TabIndex = 3;
            LblAusgabe.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAusgabe);
            Controls.Add(CmdRechnen);
            Controls.Add(CmdAnzeigen);
            Controls.Add(TxtEingbe);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtEingbe;
        private Button CmdAnzeigen;
        private Button CmdRechnen;
        private Label LblAusgabe;
    }
}
