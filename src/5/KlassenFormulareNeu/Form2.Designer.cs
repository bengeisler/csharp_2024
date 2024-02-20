// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace KlassenFormulareNeu
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
            chku = new CheckBox();
            CmdAbrechen = new Button();
            SuspendLayout();
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(87, 109);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(38, 15);
            LblAnzeige.TabIndex = 0;
            LblAnzeige.Text = "label1";
            // 
            // CmdSchließen
            // 
            CmdSchließen.Location = new Point(485, 119);
            CmdSchließen.Name = "CmdSchließen";
            CmdSchließen.Size = new Size(75, 23);
            CmdSchließen.TabIndex = 1;
            CmdSchließen.Text = "Schließen";
            CmdSchließen.UseVisualStyleBackColor = true;
            CmdSchließen.Click += CmdSchließen_Click;
            // 
            // chku
            // 
            chku.AutoSize = true;
            chku.Location = new Point(263, 109);
            chku.Name = "chku";
            chku.Size = new Size(42, 19);
            chku.TabIndex = 2;
            chku.Text = "OK";
            chku.UseVisualStyleBackColor = true;
            // 
            // CmdAbrechen
            // 
            CmdAbrechen.Location = new Point(485, 165);
            CmdAbrechen.Name = "CmdAbrechen";
            CmdAbrechen.Size = new Size(75, 23);
            CmdAbrechen.TabIndex = 3;
            CmdAbrechen.Text = "Abrechen";
            CmdAbrechen.UseVisualStyleBackColor = true;
            CmdAbrechen.Click += CmdAbrechen_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdAbrechen);
            Controls.Add(chku);
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
        private CheckBox chku;
        private Button CmdAbrechen;
    }
}