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
            CmdUebernehmen = new Button();
            CmdLoeschen = new Button();
            CmdBeenden = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            LstMitglieder = new ListBox();
            TxtName = new TextBox();
            TxtAlter = new TextBox();
            OptRot = new RadioButton();
            OptBlau = new RadioButton();
            LblAnzeige = new Label();
            SuspendLayout();
            // 
            // CmdUebernehmen
            // 
            CmdUebernehmen.Location = new Point(348, 223);
            CmdUebernehmen.Name = "CmdUebernehmen";
            CmdUebernehmen.Size = new Size(114, 23);
            CmdUebernehmen.TabIndex = 0;
            CmdUebernehmen.Text = "Übernehme";
            CmdUebernehmen.UseVisualStyleBackColor = true;
            CmdUebernehmen.Click += CmdUebernehmen_Click;
            // 
            // CmdLoeschen
            // 
            CmdLoeschen.Location = new Point(332, 277);
            CmdLoeschen.Name = "CmdLoeschen";
            CmdLoeschen.Size = new Size(148, 23);
            CmdLoeschen.TabIndex = 1;
            CmdLoeschen.Text = "Mitglied löschen";
            CmdLoeschen.UseVisualStyleBackColor = true;
            CmdLoeschen.Click += button2_Click;
            // 
            // CmdBeenden
            // 
            CmdBeenden.Location = new Point(371, 393);
            CmdBeenden.Name = "CmdBeenden";
            CmdBeenden.Size = new Size(75, 23);
            CmdBeenden.TabIndex = 2;
            CmdBeenden.Text = "Beenden";
            CmdBeenden.UseVisualStyleBackColor = true;
            CmdBeenden.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 35);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 35);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 4;
            label2.Text = "Alter:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(332, 35);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 5;
            label3.Text = "Lieblingsfarbe";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label4.Location = new Point(604, 35);
            label4.Name = "label4";
            label4.Size = new Size(153, 37);
            label4.TabIndex = 6;
            label4.Text = "Mitglieder";
            // 
            // LstMitglieder
            // 
            LstMitglieder.FormattingEnabled = true;
            LstMitglieder.ItemHeight = 15;
            LstMitglieder.Location = new Point(604, 116);
            LstMitglieder.Name = "LstMitglieder";
            LstMitglieder.Size = new Size(167, 304);
            LstMitglieder.TabIndex = 7;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(37, 87);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(100, 23);
            TxtName.TabIndex = 8;
            // 
            // TxtAlter
            // 
            TxtAlter.Location = new Point(173, 87);
            TxtAlter.Name = "TxtAlter";
            TxtAlter.Size = new Size(38, 23);
            TxtAlter.TabIndex = 9;
            // 
            // OptRot
            // 
            OptRot.AutoSize = true;
            OptRot.Location = new Point(315, 87);
            OptRot.Name = "OptRot";
            OptRot.Size = new Size(43, 19);
            OptRot.TabIndex = 10;
            OptRot.TabStop = true;
            OptRot.Text = "Rot";
            OptRot.UseVisualStyleBackColor = true;
            // 
            // OptBlau
            // 
            OptBlau.AutoSize = true;
            OptBlau.Location = new Point(376, 88);
            OptBlau.Name = "OptBlau";
            OptBlau.Size = new Size(48, 19);
            OptBlau.TabIndex = 11;
            OptBlau.TabStop = true;
            OptBlau.Text = "Blau";
            OptBlau.UseVisualStyleBackColor = true;
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(258, 339);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(38, 15);
            LblAnzeige.TabIndex = 12;
            LblAnzeige.Text = "label5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblAnzeige);
            Controls.Add(OptBlau);
            Controls.Add(OptRot);
            Controls.Add(TxtAlter);
            Controls.Add(TxtName);
            Controls.Add(LstMitglieder);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CmdBeenden);
            Controls.Add(CmdLoeschen);
            Controls.Add(CmdUebernehmen);
            Name = "Form1";
            Text = "Ein exklusiver Verein";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdUebernehmen;
        private Button CmdLoeschen;
        private Button CmdBeenden;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox LstMitglieder;
        private TextBox TxtName;
        private TextBox TxtAlter;
        private RadioButton OptRot;
        private RadioButton OptBlau;
        private Label LblAnzeige;
    }
}
