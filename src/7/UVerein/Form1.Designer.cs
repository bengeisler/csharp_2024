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
            label1 = new Label();
            TxtName = new TextBox();
            TxtAlter = new TextBox();
            label2 = new Label();
            label3 = new Label();
            OptRot = new RadioButton();
            OptBlau = new RadioButton();
            LstMitglieder = new ListBox();
            CmdHinzufügen = new Button();
            CmdLöschen = new Button();
            CmdBeenden = new Button();
            LblFehler = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(12, 37);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(150, 31);
            TxtName.TabIndex = 1;
            TxtName.TextChanged += FehlerRücksetzen;
            // 
            // TxtAlter
            // 
            TxtAlter.Location = new Point(180, 37);
            TxtAlter.Name = "TxtAlter";
            TxtAlter.Size = new Size(73, 31);
            TxtAlter.TabIndex = 3;
            TxtAlter.TextChanged += FehlerRücksetzen;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 9);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 2;
            label2.Text = "Alter";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(277, 10);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 4;
            label3.Text = "Lieblingsfarbe";
            // 
            // OptRot
            // 
            OptRot.AutoSize = true;
            OptRot.Location = new Point(277, 40);
            OptRot.Name = "OptRot";
            OptRot.Size = new Size(64, 29);
            OptRot.TabIndex = 5;
            OptRot.TabStop = true;
            OptRot.Text = "Rot";
            OptRot.UseVisualStyleBackColor = true;
            OptRot.CheckedChanged += FehlerRücksetzen;
            // 
            // OptBlau
            // 
            OptBlau.AutoSize = true;
            OptBlau.Location = new Point(356, 38);
            OptBlau.Name = "OptBlau";
            OptBlau.Size = new Size(70, 29);
            OptBlau.TabIndex = 6;
            OptBlau.TabStop = true;
            OptBlau.Text = "Blau";
            OptBlau.UseVisualStyleBackColor = true;
            OptBlau.CheckedChanged += FehlerRücksetzen;
            // 
            // LstMitglieder
            // 
            LstMitglieder.FormattingEnabled = true;
            LstMitglieder.ItemHeight = 25;
            LstMitglieder.Location = new Point(497, 73);
            LstMitglieder.Name = "LstMitglieder";
            LstMitglieder.Size = new Size(268, 329);
            LstMitglieder.TabIndex = 7;
            // 
            // CmdHinzufügen
            // 
            CmdHinzufügen.Location = new Point(12, 96);
            CmdHinzufügen.Name = "CmdHinzufügen";
            CmdHinzufügen.Size = new Size(112, 34);
            CmdHinzufügen.TabIndex = 8;
            CmdHinzufügen.Text = "Hinzufügen";
            CmdHinzufügen.UseVisualStyleBackColor = true;
            CmdHinzufügen.Click += CmdHinzufügen_Click;
            // 
            // CmdLöschen
            // 
            CmdLöschen.Location = new Point(130, 96);
            CmdLöschen.Name = "CmdLöschen";
            CmdLöschen.Size = new Size(112, 34);
            CmdLöschen.TabIndex = 9;
            CmdLöschen.Text = "Löschen";
            CmdLöschen.UseVisualStyleBackColor = true;
            CmdLöschen.Click += CmdLöschen_Click;
            // 
            // CmdBeenden
            // 
            CmdBeenden.Location = new Point(12, 209);
            CmdBeenden.Name = "CmdBeenden";
            CmdBeenden.Size = new Size(112, 34);
            CmdBeenden.TabIndex = 10;
            CmdBeenden.Text = "Beenden";
            CmdBeenden.UseVisualStyleBackColor = true;
            CmdBeenden.Click += CmdBeenden_Click;
            // 
            // LblFehler
            // 
            LblFehler.AutoSize = true;
            LblFehler.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblFehler.ForeColor = Color.Red;
            LblFehler.Location = new Point(12, 150);
            LblFehler.Name = "LblFehler";
            LblFehler.Size = new Size(0, 32);
            LblFehler.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(577, 34);
            label5.Name = "label5";
            label5.Size = new Size(133, 32);
            label5.TabIndex = 12;
            label5.Text = "Mitglieder";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 418);
            Controls.Add(label5);
            Controls.Add(LblFehler);
            Controls.Add(CmdBeenden);
            Controls.Add(CmdLöschen);
            Controls.Add(CmdHinzufügen);
            Controls.Add(LstMitglieder);
            Controls.Add(OptBlau);
            Controls.Add(OptRot);
            Controls.Add(label3);
            Controls.Add(TxtAlter);
            Controls.Add(label2);
            Controls.Add(TxtName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ein exklusiver Verein";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtName;
        private TextBox TxtAlter;
        private Label label2;
        private Label label3;
        private RadioButton OptRot;
        private RadioButton OptBlau;
        private ListBox LstMitglieder;
        private Button CmdHinzufügen;
        private Button CmdLöschen;
        private Button CmdBeenden;
        private Label LblFehler;
        private Label label5;
    }
}
