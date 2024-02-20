// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Eine_Liste
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
            ListBox = new ListBox();
            TxtEingabe = new TextBox();
            cmdHinzufügen = new Button();
            cmdLöschen = new Button();
            cmdAlleLöschen = new Button();
            cmdBeenden = new Button();
            cmdListeladen = new Button();
            cmdSpeichern = new Button();
            ChkSortiert = new CheckBox();
            SuspendLayout();
            // 
            // ListBox
            // 
            ListBox.FormattingEnabled = true;
            ListBox.ItemHeight = 15;
            ListBox.Location = new Point(12, 47);
            ListBox.Name = "ListBox";
            ListBox.Size = new Size(612, 229);
            ListBox.TabIndex = 0;
            // 
            // TxtEingabe
            // 
            TxtEingabe.Location = new Point(12, 297);
            TxtEingabe.Name = "TxtEingabe";
            TxtEingabe.Size = new Size(602, 23);
            TxtEingabe.TabIndex = 1;
            // 
            // cmdHinzufügen
            // 
            cmdHinzufügen.Location = new Point(12, 338);
            cmdHinzufügen.Name = "cmdHinzufügen";
            cmdHinzufügen.Size = new Size(75, 23);
            cmdHinzufügen.TabIndex = 2;
            cmdHinzufügen.Text = "Hinzufügen";
            cmdHinzufügen.UseVisualStyleBackColor = true;
            cmdHinzufügen.Click += cmdHinzufügen_Click;
            // 
            // cmdLöschen
            // 
            cmdLöschen.Location = new Point(117, 338);
            cmdLöschen.Name = "cmdLöschen";
            cmdLöschen.Size = new Size(75, 23);
            cmdLöschen.TabIndex = 3;
            cmdLöschen.Text = "Löschen";
            cmdLöschen.UseVisualStyleBackColor = true;
            cmdLöschen.Click += cmdLöschen_Click;
            // 
            // cmdAlleLöschen
            // 
            cmdAlleLöschen.Location = new Point(260, 338);
            cmdAlleLöschen.Name = "cmdAlleLöschen";
            cmdAlleLöschen.Size = new Size(122, 23);
            cmdAlleLöschen.TabIndex = 4;
            cmdAlleLöschen.Text = "Alle löschen";
            cmdAlleLöschen.UseVisualStyleBackColor = true;
            cmdAlleLöschen.Click += cmdAlleLöschen_Click;
            // 
            // cmdBeenden
            // 
            cmdBeenden.Location = new Point(539, 338);
            cmdBeenden.Name = "cmdBeenden";
            cmdBeenden.Size = new Size(75, 23);
            cmdBeenden.TabIndex = 5;
            cmdBeenden.Text = "Beenden";
            cmdBeenden.UseVisualStyleBackColor = true;
            cmdBeenden.Click += cmdBeenden_Click;
            // 
            // cmdListeladen
            // 
            cmdListeladen.Location = new Point(430, 338);
            cmdListeladen.Name = "cmdListeladen";
            cmdListeladen.Size = new Size(75, 23);
            cmdListeladen.TabIndex = 6;
            cmdListeladen.Text = "Liste laden";
            cmdListeladen.UseVisualStyleBackColor = true;
            cmdListeladen.Click += cmdListeladen_Click;
            // 
            // cmdSpeichern
            // 
            cmdSpeichern.Location = new Point(430, 381);
            cmdSpeichern.Name = "cmdSpeichern";
            cmdSpeichern.Size = new Size(85, 23);
            cmdSpeichern.TabIndex = 7;
            cmdSpeichern.Text = "Speichern";
            cmdSpeichern.UseVisualStyleBackColor = true;
            cmdSpeichern.Click += cmdSpeichern_Click;
            // 
            // ChkSortiert
            // 
            ChkSortiert.AutoSize = true;
            ChkSortiert.Location = new Point(312, 385);
            ChkSortiert.Name = "ChkSortiert";
            ChkSortiert.Size = new Size(64, 19);
            ChkSortiert.TabIndex = 8;
            ChkSortiert.Text = "Sortiert";
            ChkSortiert.UseVisualStyleBackColor = true;
            ChkSortiert.CheckedChanged += ChkSortiert_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ChkSortiert);
            Controls.Add(cmdSpeichern);
            Controls.Add(cmdListeladen);
            Controls.Add(cmdBeenden);
            Controls.Add(cmdAlleLöschen);
            Controls.Add(cmdLöschen);
            Controls.Add(cmdHinzufügen);
            Controls.Add(TxtEingabe);
            Controls.Add(ListBox);
            Name = "Form1";
            Text = "Auflistung";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListBox;
        private TextBox TxtEingabe;
        private Button cmdHinzufügen;
        private Button cmdLöschen;
        private Button cmdAlleLöschen;
        private Button cmdBeenden;
        private Button cmdListeladen;
        private Button cmdSpeichern;
        private CheckBox ChkSortiert;
    }
}
