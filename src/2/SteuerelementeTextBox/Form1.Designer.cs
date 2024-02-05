// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementeTextBox
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
            txtEingabe = new TextBox();
            LblANzeige = new Label();
            SuspendLayout();
            // 
            // CmdAnzeigen
            // 
            CmdAnzeigen.Location = new Point(422, 80);
            CmdAnzeigen.Name = "CmdAnzeigen";
            CmdAnzeigen.Size = new Size(75, 23);
            CmdAnzeigen.TabIndex = 0;
            CmdAnzeigen.Text = "Anzeigen";
            CmdAnzeigen.UseVisualStyleBackColor = true;
            // 
            // CmdRechnen
            // 
            CmdRechnen.Location = new Point(422, 124);
            CmdRechnen.Name = "CmdRechnen";
            CmdRechnen.Size = new Size(75, 23);
            CmdRechnen.TabIndex = 1;
            CmdRechnen.Text = "Rechnen";
            CmdRechnen.UseVisualStyleBackColor = true;
            CmdRechnen.Click += CmdRechnen_Click;
            // 
            // txtEingabe
            // 
            txtEingabe.Location = new Point(60, 58);
            txtEingabe.Name = "txtEingabe";
            txtEingabe.Size = new Size(100, 23);
            txtEingabe.TabIndex = 2;
            // 
            // LblANzeige
            // 
            LblANzeige.AutoSize = true;
            LblANzeige.Location = new Point(68, 120);
            LblANzeige.Name = "LblANzeige";
            LblANzeige.Size = new Size(38, 15);
            LblANzeige.TabIndex = 3;
            LblANzeige.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblANzeige);
            Controls.Add(txtEingabe);
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
        private TextBox txtEingabe;
        private Label LblANzeige;
    }
}
