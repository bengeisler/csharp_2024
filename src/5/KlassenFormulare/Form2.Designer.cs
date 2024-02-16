// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace KlassenFormulare
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
            ChkOk = new CheckBox();
            CmdAbbrechen = new Button();
            SuspendLayout();
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(12, 11);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(59, 25);
            LblAnzeige.TabIndex = 0;
            LblAnzeige.Text = "label1";
            // 
            // CmdSchließen
            // 
            CmdSchließen.Location = new Point(12, 54);
            CmdSchließen.Name = "CmdSchließen";
            CmdSchließen.Size = new Size(112, 34);
            CmdSchließen.TabIndex = 1;
            CmdSchließen.Text = "Schließen";
            CmdSchließen.UseVisualStyleBackColor = true;
            CmdSchließen.Click += CmdSchließen_Click;
            // 
            // ChkOk
            // 
            ChkOk.AutoSize = true;
            ChkOk.Location = new Point(215, 11);
            ChkOk.Name = "ChkOk";
            ChkOk.Size = new Size(61, 29);
            ChkOk.TabIndex = 2;
            ChkOk.Text = "Ok";
            ChkOk.UseVisualStyleBackColor = true;
            // 
            // CmdAbbrechen
            // 
            CmdAbbrechen.Location = new Point(149, 54);
            CmdAbbrechen.Name = "CmdAbbrechen";
            CmdAbbrechen.Size = new Size(112, 34);
            CmdAbbrechen.TabIndex = 3;
            CmdAbbrechen.Text = "Abbrechen";
            CmdAbbrechen.UseVisualStyleBackColor = true;
            CmdAbbrechen.Click += CmdAbbrechen_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdAbbrechen);
            Controls.Add(ChkOk);
            Controls.Add(CmdSchließen);
            Controls.Add(LblAnzeige);
            Name = "Form2";
            Text = "Unterformular";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAnzeige;
        private Button CmdSchließen;
        private CheckBox ChkOk;
        private Button CmdAbbrechen;
    }
}
