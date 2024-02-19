// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace ÜbungListe
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
            LstBox = new ListBox();
            TxtEingabe = new TextBox();
            CmdHinzufügen = new Button();
            CmdLöschen = new Button();
            CmdAlleLöschen = new Button();
            CmdSpeichern = new Button();
            CmdLaden = new Button();
            CmdBeenden = new Button();
            chkSortiert = new CheckBox();
            SuspendLayout();
            // 
            // LstBox
            // 
            LstBox.FormattingEnabled = true;
            LstBox.ItemHeight = 15;
            LstBox.Location = new Point(24, 12);
            LstBox.Name = "LstBox";
            LstBox.Size = new Size(666, 319);
            LstBox.TabIndex = 0;
            // 
            // TxtEingabe
            // 
            TxtEingabe.Location = new Point(24, 354);
            TxtEingabe.Name = "TxtEingabe";
            TxtEingabe.Size = new Size(666, 23);
            TxtEingabe.TabIndex = 1;
            // 
            // CmdHinzufügen
            // 
            CmdHinzufügen.Location = new Point(24, 430);
            CmdHinzufügen.Name = "CmdHinzufügen";
            CmdHinzufügen.Size = new Size(81, 23);
            CmdHinzufügen.TabIndex = 2;
            CmdHinzufügen.Text = "Hinzufügen";
            CmdHinzufügen.UseVisualStyleBackColor = true;
            CmdHinzufügen.Click += CmdHinzufügen_Click;
            // 
            // CmdLöschen
            // 
            CmdLöschen.Location = new Point(139, 430);
            CmdLöschen.Name = "CmdLöschen";
            CmdLöschen.Size = new Size(85, 23);
            CmdLöschen.TabIndex = 3;
            CmdLöschen.Text = "Löschen";
            CmdLöschen.UseVisualStyleBackColor = true;
            CmdLöschen.Click += CmdLöschen_Click;
            // 
            // CmdAlleLöschen
            // 
            CmdAlleLöschen.Location = new Point(260, 430);
            CmdAlleLöschen.Name = "CmdAlleLöschen";
            CmdAlleLöschen.Size = new Size(84, 23);
            CmdAlleLöschen.TabIndex = 4;
            CmdAlleLöschen.Text = "Alle löschen";
            CmdAlleLöschen.UseVisualStyleBackColor = true;
            CmdAlleLöschen.Click += CmdAlleLöschen_Click;
            // 
            // CmdSpeichern
            // 
            CmdSpeichern.Location = new Point(493, 430);
            CmdSpeichern.Name = "CmdSpeichern";
            CmdSpeichern.Size = new Size(84, 23);
            CmdSpeichern.TabIndex = 5;
            CmdSpeichern.Text = "Speichern";
            CmdSpeichern.UseVisualStyleBackColor = true;
            CmdSpeichern.Click += CmdSpeichern_Click;
            // 
            // CmdLaden
            // 
            CmdLaden.Location = new Point(493, 401);
            CmdLaden.Name = "CmdLaden";
            CmdLaden.Size = new Size(84, 23);
            CmdLaden.TabIndex = 6;
            CmdLaden.Text = "Listen laden";
            CmdLaden.UseVisualStyleBackColor = true;
            CmdLaden.Click += CmdLaden_Click;
            // 
            // CmdBeenden
            // 
            CmdBeenden.Location = new Point(615, 430);
            CmdBeenden.Name = "CmdBeenden";
            CmdBeenden.Size = new Size(75, 23);
            CmdBeenden.TabIndex = 7;
            CmdBeenden.Text = "Beenden";
            CmdBeenden.UseVisualStyleBackColor = true;
            CmdBeenden.Click += CmdBeenden_Click;
            // 
            // chkSortiert
            // 
            chkSortiert.AutoSize = true;
            chkSortiert.Location = new Point(377, 433);
            chkSortiert.Name = "chkSortiert";
            chkSortiert.Size = new Size(64, 19);
            chkSortiert.TabIndex = 8;
            chkSortiert.Text = "Sortiert";
            chkSortiert.UseVisualStyleBackColor = true;
            chkSortiert.CheckedChanged += chkSortiert_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 688);
            Controls.Add(chkSortiert);
            Controls.Add(CmdBeenden);
            Controls.Add(CmdLaden);
            Controls.Add(CmdSpeichern);
            Controls.Add(CmdAlleLöschen);
            Controls.Add(CmdLöschen);
            Controls.Add(CmdHinzufügen);
            Controls.Add(TxtEingabe);
            Controls.Add(LstBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LstBox;
        private TextBox TxtEingabe;
        private Button CmdHinzufügen;
        private Button CmdLöschen;
        private Button CmdAlleLöschen;
        private Button CmdSpeichern;
        private Button CmdLaden;
        private Button CmdBeenden;
        private CheckBox chkSortiert;
    }
}
