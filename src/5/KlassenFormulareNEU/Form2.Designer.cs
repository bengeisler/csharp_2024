// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace KlassenFormulareNEU
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblAnzeige = new Label();
            CmdSchließen = new Button();
            CheckOk = new CheckBox();
            CmdAbbrechen = new Button();
            SuspendLayout();
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(45, 36);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(38, 15);
            LblAnzeige.TabIndex = 0;
            LblAnzeige.Text = "label1";
            // 
            // CmdSchließen
            // 
            CmdSchließen.Location = new Point(45, 84);
            CmdSchließen.Name = "CmdSchließen";
            CmdSchließen.Size = new Size(75, 23);
            CmdSchließen.TabIndex = 1;
            CmdSchließen.Text = "Schließen";
            CmdSchließen.UseVisualStyleBackColor = true;
            CmdSchließen.Click += CmdSchließen_Click;
            // 
            // CheckOk
            // 
            CheckOk.AutoSize = true;
            CheckOk.Location = new Point(205, 92);
            CheckOk.Name = "CheckOk";
            CheckOk.Size = new Size(41, 19);
            CheckOk.TabIndex = 2;
            CheckOk.Text = "Ok";
            CheckOk.UseVisualStyleBackColor = true;
            // 
            // CmdAbbrechen
            // 
            CmdAbbrechen.Location = new Point(74, 130);
            CmdAbbrechen.Name = "CmdAbbrechen";
            CmdAbbrechen.Size = new Size(75, 23);
            CmdAbbrechen.TabIndex = 3;
            CmdAbbrechen.Text = "Abbrechen";
            CmdAbbrechen.UseVisualStyleBackColor = true;
            CmdAbbrechen.Click += CmdAbbrechen_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdAbbrechen);
            Controls.Add(CheckOk);
            Controls.Add(CmdSchließen);
            Controls.Add(LblAnzeige);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAnzeige;
        private Button CmdSchließen;
        private CheckBox CheckOk;
        private Button CmdAbbrechen;
    }
}