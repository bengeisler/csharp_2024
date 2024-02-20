// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UVerein
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
            CmdÜbernahme = new Button();
            TxtAlter = new TextBox();
            TxtName = new TextBox();
            LstMitglieder = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ChkRot = new RadioButton();
            ChkBlau = new RadioButton();
            label4 = new Label();
            CmdMitgliedLöschen = new Button();
            CmdBeenden = new Button();
            LblFarbe = new Label();
            SuspendLayout();
            // 
            // CmdÜbernahme
            // 
            CmdÜbernahme.Location = new Point(127, 149);
            CmdÜbernahme.Name = "CmdÜbernahme";
            CmdÜbernahme.Size = new Size(88, 23);
            CmdÜbernahme.TabIndex = 0;
            CmdÜbernahme.Text = "Übernehmen";
            CmdÜbernahme.UseVisualStyleBackColor = true;
            CmdÜbernahme.Click += CmdÜbernahme_Click;
            // 
            // TxtAlter
            // 
            TxtAlter.Location = new Point(158, 36);
            TxtAlter.Name = "TxtAlter";
            TxtAlter.Size = new Size(100, 23);
            TxtAlter.TabIndex = 1;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(12, 36);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(100, 23);
            TxtName.TabIndex = 3;
            // 
            // LstMitglieder
            // 
            LstMitglieder.FormattingEnabled = true;
            LstMitglieder.ItemHeight = 15;
            LstMitglieder.Location = new Point(560, 36);
            LstMitglieder.Name = "LstMitglieder";
            LstMitglieder.Size = new Size(187, 304);
            LstMitglieder.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(603, 8);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 5;
            label1.Text = "Mitglieder";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 18);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 6;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 18);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 7;
            label3.Text = "Alter:";
            // 
            // ChkRot
            // 
            ChkRot.AutoSize = true;
            ChkRot.Location = new Point(319, 40);
            ChkRot.Name = "ChkRot";
            ChkRot.Size = new Size(43, 19);
            ChkRot.TabIndex = 8;
            ChkRot.TabStop = true;
            ChkRot.Text = "Rot";
            ChkRot.UseVisualStyleBackColor = true;
            // 
            // ChkBlau
            // 
            ChkBlau.AutoSize = true;
            ChkBlau.Location = new Point(388, 40);
            ChkBlau.Name = "ChkBlau";
            ChkBlau.Size = new Size(48, 19);
            ChkBlau.TabIndex = 9;
            ChkBlau.TabStop = true;
            ChkBlau.Text = "Blau";
            ChkBlau.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(329, 18);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 10;
            label4.Text = "Lieblingsfarbe";
            // 
            // CmdMitgliedLöschen
            // 
            CmdMitgliedLöschen.Location = new Point(98, 191);
            CmdMitgliedLöschen.Name = "CmdMitgliedLöschen";
            CmdMitgliedLöschen.Size = new Size(147, 23);
            CmdMitgliedLöschen.TabIndex = 11;
            CmdMitgliedLöschen.Text = "Mitglied löschen";
            CmdMitgliedLöschen.UseVisualStyleBackColor = true;
            CmdMitgliedLöschen.Click += CmdMitgliedLöschen_Click;
            // 
            // CmdBeenden
            // 
            CmdBeenden.Location = new Point(127, 325);
            CmdBeenden.Name = "CmdBeenden";
            CmdBeenden.Size = new Size(88, 23);
            CmdBeenden.TabIndex = 12;
            CmdBeenden.Text = "Beenden";
            CmdBeenden.UseVisualStyleBackColor = true;
            CmdBeenden.Click += CmdBeenden_Click;
            // 
            // LblFarbe
            // 
            LblFarbe.AutoSize = true;
            LblFarbe.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblFarbe.ForeColor = Color.Red;
            LblFarbe.Location = new Point(24, 253);
            LblFarbe.Name = "LblFarbe";
            LblFarbe.Size = new Size(63, 25);
            LblFarbe.TabIndex = 13;
            LblFarbe.Text = "label5";
            LblFarbe.Click += LblFarbe_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblFarbe);
            Controls.Add(CmdBeenden);
            Controls.Add(CmdMitgliedLöschen);
            Controls.Add(label4);
            Controls.Add(ChkBlau);
            Controls.Add(ChkRot);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LstMitglieder);
            Controls.Add(TxtName);
            Controls.Add(TxtAlter);
            Controls.Add(CmdÜbernahme);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdÜbernahme;
        private TextBox TxtAlter;
        private TextBox TxtName;
        private ListBox LstMitglieder;
        private Label label1;
        private Label label2;
        private Label label3;
        private RadioButton ChkRot;
        private RadioButton ChkBlau;
        private Label label4;
        private Button CmdMitgliedLöschen;
        private Button CmdBeenden;
        private Label LblFarbe;
    }
}
