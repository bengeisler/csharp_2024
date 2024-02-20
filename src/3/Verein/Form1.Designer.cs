// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Verein
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
            label1 = new Label();
            label2 = new Label();
            CmdÜbernehmen = new Button();
            CmdMitgliederLöschen = new Button();
            Beenden = new Button();
            LblFehlermeldung = new Label();
            label4 = new Label();
            RadioButtonRot = new RadioButton();
            RadioButtonBlau = new RadioButton();
            label5 = new Label();
            ListboxMitglieder = new ListBox();
            SuspendLayout();
            // 
            // TxtName
            // 
            TxtName.Location = new Point(30, 81);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(100, 23);
            TxtName.TabIndex = 0;
            // 
            // TxtAlter
            // 
            TxtAlter.Location = new Point(184, 82);
            TxtAlter.Name = "TxtAlter";
            TxtAlter.Size = new Size(100, 23);
            TxtAlter.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 48);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 51);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 3;
            label2.Text = "Alter:";
            // 
            // CmdÜbernehmen
            // 
            CmdÜbernehmen.Location = new Point(142, 178);
            CmdÜbernehmen.Name = "CmdÜbernehmen";
            CmdÜbernehmen.Size = new Size(100, 23);
            CmdÜbernehmen.TabIndex = 4;
            CmdÜbernehmen.Text = "Übernehmen";
            CmdÜbernehmen.UseVisualStyleBackColor = true;
            CmdÜbernehmen.Click += CmdÜbernehmen_Click;
            // 
            // CmdMitgliederLöschen
            // 
            CmdMitgliederLöschen.Location = new Point(88, 232);
            CmdMitgliederLöschen.Name = "CmdMitgliederLöschen";
            CmdMitgliederLöschen.Size = new Size(185, 23);
            CmdMitgliederLöschen.TabIndex = 5;
            CmdMitgliederLöschen.Text = "Mitglieder Löschen";
            CmdMitgliederLöschen.UseVisualStyleBackColor = true;
            CmdMitgliederLöschen.Click += CmdMitgliederLöschen_Click;
            // 
            // Beenden
            // 
            Beenden.Location = new Point(142, 378);
            Beenden.Name = "Beenden";
            Beenden.Size = new Size(75, 23);
            Beenden.TabIndex = 6;
            Beenden.Text = "Beenden";
            Beenden.UseVisualStyleBackColor = true;
            Beenden.Click += Beenden_Click;
            // 
            // LblFehlermeldung
            // 
            LblFehlermeldung.AutoSize = true;
            LblFehlermeldung.Location = new Point(142, 310);
            LblFehlermeldung.Name = "LblFehlermeldung";
            LblFehlermeldung.Size = new Size(38, 15);
            LblFehlermeldung.TabIndex = 7;
            LblFehlermeldung.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(346, 55);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 8;
            label4.Text = "Lieblingsfarbe";
            // 
            // RadioButtonRot
            // 
            RadioButtonRot.AutoSize = true;
            RadioButtonRot.Location = new Point(333, 86);
            RadioButtonRot.Name = "RadioButtonRot";
            RadioButtonRot.Size = new Size(43, 19);
            RadioButtonRot.TabIndex = 9;
            RadioButtonRot.TabStop = true;
            RadioButtonRot.Text = "Rot";
            RadioButtonRot.UseVisualStyleBackColor = true;
            // 
            // RadioButtonBlau
            // 
            RadioButtonBlau.AutoSize = true;
            RadioButtonBlau.Location = new Point(432, 86);
            RadioButtonBlau.Name = "RadioButtonBlau";
            RadioButtonBlau.Size = new Size(48, 19);
            RadioButtonBlau.TabIndex = 10;
            RadioButtonBlau.TabStop = true;
            RadioButtonBlau.Text = "Blau";
            RadioButtonBlau.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(642, 43);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 11;
            label5.Text = "Mitglieder";
            // 
            // ListboxMitglieder
            // 
            ListboxMitglieder.FormattingEnabled = true;
            ListboxMitglieder.ItemHeight = 15;
            ListboxMitglieder.Location = new Point(575, 78);
            ListboxMitglieder.Name = "ListboxMitglieder";
            ListboxMitglieder.Size = new Size(163, 319);
            ListboxMitglieder.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 468);
            Controls.Add(ListboxMitglieder);
            Controls.Add(label5);
            Controls.Add(RadioButtonBlau);
            Controls.Add(RadioButtonRot);
            Controls.Add(label4);
            Controls.Add(LblFehlermeldung);
            Controls.Add(Beenden);
            Controls.Add(CmdMitgliederLöschen);
            Controls.Add(CmdÜbernehmen);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Button CmdÜbernehmen;
        private Button CmdMitgliederLöschen;
        private Button Beenden;
        private Label LblFehlermeldung;
        private Label label4;
        private RadioButton RadioButtonRot;
        private RadioButton RadioButtonBlau;
        private Label label5;
        private ListBox ListboxMitglieder;
    }
}
