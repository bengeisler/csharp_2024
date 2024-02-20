// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace EinExclusiverVerein
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
            LblName = new Label();
            Lblalter = new Label();
            LblLieblingsfarbe = new Label();
            LblMitglieder = new Label();
            TxtName = new TextBox();
            TxtAlter = new TextBox();
            RadioRot = new RadioButton();
            RadioBlau = new RadioButton();
            LstMitglieder = new ListBox();
            CmdÜbernahme = new Button();
            CmdMitgliedLöschen = new Button();
            cmd_Beenden = new Button();
            LblFehler = new Label();
            SuspendLayout();
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(38, 39);
            LblName.Name = "LblName";
            LblName.Size = new Size(39, 15);
            LblName.TabIndex = 0;
            LblName.Text = "Name";
            // 
            // Lblalter
            // 
            Lblalter.AutoSize = true;
            Lblalter.Location = new Point(166, 39);
            Lblalter.Name = "Lblalter";
            Lblalter.Size = new Size(32, 15);
            Lblalter.TabIndex = 1;
            Lblalter.Text = "Alter";
            // 
            // LblLieblingsfarbe
            // 
            LblLieblingsfarbe.AutoSize = true;
            LblLieblingsfarbe.Location = new Point(269, 39);
            LblLieblingsfarbe.Name = "LblLieblingsfarbe";
            LblLieblingsfarbe.Size = new Size(81, 15);
            LblLieblingsfarbe.TabIndex = 2;
            LblLieblingsfarbe.Text = "Lieblingsfarbe";
            // 
            // LblMitglieder
            // 
            LblMitglieder.AutoSize = true;
            LblMitglieder.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblMitglieder.Location = new Point(636, 39);
            LblMitglieder.Name = "LblMitglieder";
            LblMitglieder.Size = new Size(107, 30);
            LblMitglieder.TabIndex = 3;
            LblMitglieder.Text = "Mitglieder";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(38, 73);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(67, 23);
            TxtName.TabIndex = 4;
            // 
            // TxtAlter
            // 
            TxtAlter.Location = new Point(144, 73);
            TxtAlter.Name = "TxtAlter";
            TxtAlter.Size = new Size(85, 23);
            TxtAlter.TabIndex = 5;
            // 
            // RadioRot
            // 
            RadioRot.AutoSize = true;
            RadioRot.Location = new Point(269, 77);
            RadioRot.Name = "RadioRot";
            RadioRot.Size = new Size(43, 19);
            RadioRot.TabIndex = 6;
            RadioRot.TabStop = true;
            RadioRot.Text = "Rot";
            RadioRot.UseVisualStyleBackColor = true;
            // 
            // RadioBlau
            // 
            RadioBlau.AutoSize = true;
            RadioBlau.Location = new Point(410, 77);
            RadioBlau.Name = "RadioBlau";
            RadioBlau.Size = new Size(48, 19);
            RadioBlau.TabIndex = 7;
            RadioBlau.TabStop = true;
            RadioBlau.Text = "Blau";
            RadioBlau.UseVisualStyleBackColor = true;
            // 
            // LstMitglieder
            // 
            LstMitglieder.FormattingEnabled = true;
            LstMitglieder.ItemHeight = 15;
            LstMitglieder.Location = new Point(622, 87);
            LstMitglieder.Name = "LstMitglieder";
            LstMitglieder.Size = new Size(120, 289);
            LstMitglieder.TabIndex = 8;
            // 
            // CmdÜbernahme
            // 
            CmdÜbernahme.Location = new Point(109, 185);
            CmdÜbernahme.Name = "CmdÜbernahme";
            CmdÜbernahme.Size = new Size(120, 23);
            CmdÜbernahme.TabIndex = 9;
            CmdÜbernahme.Text = "Übernahme";
            CmdÜbernahme.UseVisualStyleBackColor = true;
            CmdÜbernahme.Click += CmdÜbernahme_Click;
            // 
            // CmdMitgliedLöschen
            // 
            CmdMitgliedLöschen.Location = new Point(109, 246);
            CmdMitgliedLöschen.Name = "CmdMitgliedLöschen";
            CmdMitgliedLöschen.Size = new Size(132, 23);
            CmdMitgliedLöschen.TabIndex = 10;
            CmdMitgliedLöschen.Text = "Mitglied löschen";
            CmdMitgliedLöschen.UseVisualStyleBackColor = true;
            CmdMitgliedLöschen.Click += CmdMitgliedLöschen_Click;
            // 
            // cmd_Beenden
            // 
            cmd_Beenden.Location = new Point(109, 353);
            cmd_Beenden.Name = "cmd_Beenden";
            cmd_Beenden.Size = new Size(75, 23);
            cmd_Beenden.TabIndex = 11;
            cmd_Beenden.Text = "Beenden";
            cmd_Beenden.UseVisualStyleBackColor = true;
            cmd_Beenden.Click += cmd_Beenden_Click;
            // 
            // LblFehler
            // 
            LblFehler.AutoSize = true;
            LblFehler.Location = new Point(109, 292);
            LblFehler.Name = "LblFehler";
            LblFehler.Size = new Size(38, 15);
            LblFehler.TabIndex = 12;
            LblFehler.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblFehler);
            Controls.Add(cmd_Beenden);
            Controls.Add(CmdMitgliedLöschen);
            Controls.Add(CmdÜbernahme);
            Controls.Add(LstMitglieder);
            Controls.Add(RadioBlau);
            Controls.Add(RadioRot);
            Controls.Add(TxtAlter);
            Controls.Add(TxtName);
            Controls.Add(LblMitglieder);
            Controls.Add(LblLieblingsfarbe);
            Controls.Add(Lblalter);
            Controls.Add(LblName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblName;
        private Label Lblalter;
        private Label LblLieblingsfarbe;
        private Label LblMitglieder;
        private TextBox TxtName;
        private TextBox TxtAlter;
        private RadioButton RadioRot;
        private RadioButton RadioBlau;
        private ListBox LstMitglieder;
        private Button CmdÜbernahme;
        private Button CmdMitgliedLöschen;
        private Button cmd_Beenden;
        private Label LblFehler;
    }
}
