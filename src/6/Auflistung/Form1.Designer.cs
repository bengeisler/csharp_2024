// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Auflistung
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
            ListBox1 = new ListBox();
            TxtEingabe = new TextBox();
            CmdHinzufügen = new Button();
            CmdLöschen = new Button();
            CmdAlleLöschen = new Button();
            CmdListeLaden = new Button();
            CmdSpeichern = new Button();
            CmdBeenden = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // ListBox1
            // 
            ListBox1.FormattingEnabled = true;
            ListBox1.ItemHeight = 15;
            ListBox1.Location = new Point(52, 54);
            ListBox1.Name = "ListBox1";
            ListBox1.Size = new Size(571, 244);
            ListBox1.TabIndex = 0;
            // 
            // TxtEingabe
            // 
            TxtEingabe.Location = new Point(52, 313);
            TxtEingabe.Name = "TxtEingabe";
            TxtEingabe.Size = new Size(571, 23);
            TxtEingabe.TabIndex = 1;
            // 
            // CmdHinzufügen
            // 
            CmdHinzufügen.Location = new Point(69, 384);
            CmdHinzufügen.Name = "CmdHinzufügen";
            CmdHinzufügen.Size = new Size(80, 23);
            CmdHinzufügen.TabIndex = 2;
            CmdHinzufügen.Text = "Hinzufügen";
            CmdHinzufügen.UseVisualStyleBackColor = true;
            CmdHinzufügen.Click += button1_Click;
            // 
            // CmdLöschen
            // 
            CmdLöschen.Location = new Point(193, 384);
            CmdLöschen.Name = "CmdLöschen";
            CmdLöschen.Size = new Size(75, 23);
            CmdLöschen.TabIndex = 3;
            CmdLöschen.Text = "Löschen";
            CmdLöschen.UseVisualStyleBackColor = true;
            // 
            // CmdAlleLöschen
            // 
            CmdAlleLöschen.Location = new Point(312, 384);
            CmdAlleLöschen.Name = "CmdAlleLöschen";
            CmdAlleLöschen.Size = new Size(75, 41);
            CmdAlleLöschen.TabIndex = 4;
            CmdAlleLöschen.Text = "Alle löschen";
            CmdAlleLöschen.UseVisualStyleBackColor = true;
            // 
            // CmdListeLaden
            // 
            CmdListeLaden.Location = new Point(528, 366);
            CmdListeLaden.Name = "CmdListeLaden";
            CmdListeLaden.Size = new Size(75, 23);
            CmdListeLaden.TabIndex = 5;
            CmdListeLaden.Text = "Liste laden";
            CmdListeLaden.UseVisualStyleBackColor = true;
            CmdListeLaden.Click += CmdListeLaden_Click;
            // 
            // CmdSpeichern
            // 
            CmdSpeichern.Location = new Point(528, 413);
            CmdSpeichern.Name = "CmdSpeichern";
            CmdSpeichern.Size = new Size(75, 23);
            CmdSpeichern.TabIndex = 6;
            CmdSpeichern.Text = "Speichern";
            CmdSpeichern.UseVisualStyleBackColor = true;
            CmdSpeichern.Click += button5_Click;
            // 
            // CmdBeenden
            // 
            CmdBeenden.Location = new Point(651, 413);
            CmdBeenden.Name = "CmdBeenden";
            CmdBeenden.Size = new Size(75, 23);
            CmdBeenden.TabIndex = 7;
            CmdBeenden.Text = "Beenden";
            CmdBeenden.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(407, 389);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(64, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Sortiert";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(CmdBeenden);
            Controls.Add(CmdSpeichern);
            Controls.Add(CmdListeLaden);
            Controls.Add(CmdAlleLöschen);
            Controls.Add(CmdLöschen);
            Controls.Add(CmdHinzufügen);
            Controls.Add(TxtEingabe);
            Controls.Add(ListBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListBox1;
        private TextBox TxtEingabe;
        private Button CmdHinzufügen;
        private Button CmdLöschen;
        private Button CmdAlleLöschen;
        private Button CmdListeLaden;
        private Button CmdSpeichern;
        private Button CmdBeenden;
        private CheckBox checkBox1;
    }
}
