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
            TxtName = new TextBox();
            TxtAlter = new TextBox();
            optRot = new RadioButton();
            optBlau = new RadioButton();
            BtnÜbernehmen = new Button();
            BtnLöschen = new Button();
            BtnBeenden = new Button();
            LblAusgabe = new Label();
            LblName = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            LstBox = new ListBox();
            SuspendLayout();
            // 
            // TxtName
            // 
            TxtName.Location = new Point(47, 52);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(100, 23);
            TxtName.TabIndex = 0;
            // 
            // TxtAlter
            // 
            TxtAlter.Location = new Point(165, 52);
            TxtAlter.Name = "TxtAlter";
            TxtAlter.Size = new Size(40, 23);
            TxtAlter.TabIndex = 1;
            // 
            // optRot
            // 
            optRot.AutoSize = true;
            optRot.Location = new Point(227, 53);
            optRot.Name = "optRot";
            optRot.Size = new Size(43, 19);
            optRot.TabIndex = 2;
            optRot.TabStop = true;
            optRot.Text = "Rot";
            optRot.UseVisualStyleBackColor = true;
            // 
            // optBlau
            // 
            optBlau.AutoSize = true;
            optBlau.Location = new Point(289, 53);
            optBlau.Name = "optBlau";
            optBlau.Size = new Size(48, 19);
            optBlau.TabIndex = 3;
            optBlau.TabStop = true;
            optBlau.Text = "Blau";
            optBlau.UseVisualStyleBackColor = true;
            // 
            // BtnÜbernehmen
            // 
            BtnÜbernehmen.Location = new Point(146, 149);
            BtnÜbernehmen.Name = "BtnÜbernehmen";
            BtnÜbernehmen.Size = new Size(98, 23);
            BtnÜbernehmen.TabIndex = 4;
            BtnÜbernehmen.Text = "Übernehme";
            BtnÜbernehmen.UseVisualStyleBackColor = true;
            BtnÜbernehmen.Click += BtnÜbernehmen_Click;
            // 
            // BtnLöschen
            // 
            BtnLöschen.Location = new Point(136, 178);
            BtnLöschen.Name = "BtnLöschen";
            BtnLöschen.Size = new Size(117, 23);
            BtnLöschen.TabIndex = 5;
            BtnLöschen.Text = "Mitglied löschen";
            BtnLöschen.UseVisualStyleBackColor = true;
            BtnLöschen.Click += BtnLöschen_Click;
            // 
            // BtnBeenden
            // 
            BtnBeenden.Location = new Point(165, 391);
            BtnBeenden.Name = "BtnBeenden";
            BtnBeenden.Size = new Size(75, 23);
            BtnBeenden.TabIndex = 6;
            BtnBeenden.Text = "Beenden";
            BtnBeenden.UseVisualStyleBackColor = true;
            BtnBeenden.Click += BtnBeenden_Click;
            // 
            // LblAusgabe
            // 
            LblAusgabe.AutoSize = true;
            LblAusgabe.Location = new Point(24, 236);
            LblAusgabe.Name = "LblAusgabe";
            LblAusgabe.Size = new Size(38, 15);
            LblAusgabe.TabIndex = 7;
            LblAusgabe.Text = "label1";
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(47, 24);
            LblName.Name = "LblName";
            LblName.Size = new Size(42, 15);
            LblName.TabIndex = 8;
            LblName.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 24);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 9;
            label3.Text = "Alter:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 24);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 10;
            label4.Text = "Lieblingsfarbe";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(522, 24);
            label5.Name = "label5";
            label5.Size = new Size(81, 21);
            label5.TabIndex = 11;
            label5.Text = "Mitglieder";
            // 
            // LstBox
            // 
            LstBox.FormattingEnabled = true;
            LstBox.ItemHeight = 15;
            LstBox.Location = new Point(478, 52);
            LstBox.Name = "LstBox";
            LstBox.Size = new Size(159, 364);
            LstBox.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LstBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(LblName);
            Controls.Add(LblAusgabe);
            Controls.Add(BtnBeenden);
            Controls.Add(BtnLöschen);
            Controls.Add(BtnÜbernehmen);
            Controls.Add(optBlau);
            Controls.Add(optRot);
            Controls.Add(TxtAlter);
            Controls.Add(TxtName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtName;
        private TextBox TxtAlter;
        private RadioButton optRot;
        private RadioButton optBlau;
        private Button BtnÜbernehmen;
        private Button BtnLöschen;
        private Button BtnBeenden;
        private Label LblAusgabe;
        private Label LblName;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox LstBox;
    }
}
