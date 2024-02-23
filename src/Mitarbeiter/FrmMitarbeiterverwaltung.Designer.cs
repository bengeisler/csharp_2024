// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Mitarbeiter
{
    partial class FrmMitarbeiterverwaltung
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
            components = new System.ComponentModel.Container();
            CmdMitarbeiterHinzufügen = new Button();
            CmdMitarbeiterLöschen = new Button();
            dataGridView1 = new DataGridView();
            mitarbeiterBindingSource = new BindingSource(components);
            personalNrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            abteilungsNrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vornameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stellenbezeichnungDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adresseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            plzDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ortDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtNachname = new TextBox();
            TxtVorname = new TextBox();
            CmdFiltern = new Button();
            CmdAlleAnzeigen = new Button();
            CmdNachNachnameSortieren = new Button();
            CmdNachVornameSortieren = new Button();
            CmdMitarbeiterInAbteilungÜbernehmen = new Button();
            label4 = new Label();
            dataGridView2 = new DataGridView();
            abteilungBindingSource = new BindingSource(components);
            abteilungsNrDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            bezeichnungDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            label5 = new Label();
            TxtAbteilungsnummer = new TextBox();
            TxtAbteilungsbezeichnung = new TextBox();
            CmdAbteilungHinzufügen = new Button();
            CmdAbteilungBearbeiten = new Button();
            CmdAbteilungLöschen = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mitarbeiterBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)abteilungBindingSource).BeginInit();
            SuspendLayout();
            // 
            // CmdMitarbeiterHinzufügen
            // 
            CmdMitarbeiterHinzufügen.Location = new Point(516, 315);
            CmdMitarbeiterHinzufügen.Name = "CmdMitarbeiterHinzufügen";
            CmdMitarbeiterHinzufügen.Size = new Size(236, 34);
            CmdMitarbeiterHinzufügen.TabIndex = 0;
            CmdMitarbeiterHinzufügen.Text = "Mitarbeiter hinzufügen";
            CmdMitarbeiterHinzufügen.UseVisualStyleBackColor = true;
            // 
            // CmdMitarbeiterLöschen
            // 
            CmdMitarbeiterLöschen.Location = new Point(516, 351);
            CmdMitarbeiterLöschen.Name = "CmdMitarbeiterLöschen";
            CmdMitarbeiterLöschen.Size = new Size(236, 34);
            CmdMitarbeiterLöschen.TabIndex = 1;
            CmdMitarbeiterLöschen.Text = "Mitarbeiter löschen";
            CmdMitarbeiterLöschen.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { personalNrDataGridViewTextBoxColumn, abteilungsNrDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, vornameDataGridViewTextBoxColumn, stellenbezeichnungDataGridViewTextBoxColumn, adresseDataGridViewTextBoxColumn, plzDataGridViewTextBoxColumn, ortDataGridViewTextBoxColumn, telefonDataGridViewTextBoxColumn });
            dataGridView1.DataSource = mitarbeiterBindingSource;
            dataGridView1.Location = new Point(12, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1422, 225);
            dataGridView1.TabIndex = 2;
            // 
            // mitarbeiterBindingSource
            // 
            mitarbeiterBindingSource.DataSource = typeof(Models.Mitarbeiter);
            // 
            // personalNrDataGridViewTextBoxColumn
            // 
            personalNrDataGridViewTextBoxColumn.DataPropertyName = "PersonalNr";
            personalNrDataGridViewTextBoxColumn.HeaderText = "PersonalNr";
            personalNrDataGridViewTextBoxColumn.MinimumWidth = 8;
            personalNrDataGridViewTextBoxColumn.Name = "personalNrDataGridViewTextBoxColumn";
            personalNrDataGridViewTextBoxColumn.ReadOnly = true;
            personalNrDataGridViewTextBoxColumn.Width = 150;
            // 
            // abteilungsNrDataGridViewTextBoxColumn
            // 
            abteilungsNrDataGridViewTextBoxColumn.DataPropertyName = "AbteilungsNr";
            abteilungsNrDataGridViewTextBoxColumn.HeaderText = "AbteilungsNr";
            abteilungsNrDataGridViewTextBoxColumn.MinimumWidth = 8;
            abteilungsNrDataGridViewTextBoxColumn.Name = "abteilungsNrDataGridViewTextBoxColumn";
            abteilungsNrDataGridViewTextBoxColumn.ReadOnly = true;
            abteilungsNrDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // vornameDataGridViewTextBoxColumn
            // 
            vornameDataGridViewTextBoxColumn.DataPropertyName = "Vorname";
            vornameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            vornameDataGridViewTextBoxColumn.MinimumWidth = 8;
            vornameDataGridViewTextBoxColumn.Name = "vornameDataGridViewTextBoxColumn";
            vornameDataGridViewTextBoxColumn.ReadOnly = true;
            vornameDataGridViewTextBoxColumn.Width = 150;
            // 
            // stellenbezeichnungDataGridViewTextBoxColumn
            // 
            stellenbezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Stellenbezeichnung";
            stellenbezeichnungDataGridViewTextBoxColumn.HeaderText = "Stellenbezeichnung";
            stellenbezeichnungDataGridViewTextBoxColumn.MinimumWidth = 8;
            stellenbezeichnungDataGridViewTextBoxColumn.Name = "stellenbezeichnungDataGridViewTextBoxColumn";
            stellenbezeichnungDataGridViewTextBoxColumn.ReadOnly = true;
            stellenbezeichnungDataGridViewTextBoxColumn.Width = 150;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            adresseDataGridViewTextBoxColumn.MinimumWidth = 8;
            adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            adresseDataGridViewTextBoxColumn.ReadOnly = true;
            adresseDataGridViewTextBoxColumn.Width = 150;
            // 
            // plzDataGridViewTextBoxColumn
            // 
            plzDataGridViewTextBoxColumn.DataPropertyName = "Plz";
            plzDataGridViewTextBoxColumn.HeaderText = "Plz";
            plzDataGridViewTextBoxColumn.MinimumWidth = 8;
            plzDataGridViewTextBoxColumn.Name = "plzDataGridViewTextBoxColumn";
            plzDataGridViewTextBoxColumn.ReadOnly = true;
            plzDataGridViewTextBoxColumn.Width = 150;
            // 
            // ortDataGridViewTextBoxColumn
            // 
            ortDataGridViewTextBoxColumn.DataPropertyName = "Ort";
            ortDataGridViewTextBoxColumn.HeaderText = "Ort";
            ortDataGridViewTextBoxColumn.MinimumWidth = 8;
            ortDataGridViewTextBoxColumn.Name = "ortDataGridViewTextBoxColumn";
            ortDataGridViewTextBoxColumn.ReadOnly = true;
            ortDataGridViewTextBoxColumn.Width = 150;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            telefonDataGridViewTextBoxColumn.MinimumWidth = 8;
            telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            telefonDataGridViewTextBoxColumn.ReadOnly = true;
            telefonDataGridViewTextBoxColumn.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(143, 32);
            label1.TabIndex = 3;
            label1.Text = "Mitarbeiter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 320);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 4;
            label2.Text = "Nachname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 356);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 5;
            label3.Text = "Vorname";
            // 
            // TxtNachname
            // 
            TxtNachname.Location = new Point(150, 317);
            TxtNachname.Name = "TxtNachname";
            TxtNachname.Size = new Size(309, 31);
            TxtNachname.TabIndex = 6;
            // 
            // TxtVorname
            // 
            TxtVorname.Location = new Point(150, 353);
            TxtVorname.Name = "TxtVorname";
            TxtVorname.Size = new Size(309, 31);
            TxtVorname.TabIndex = 7;
            // 
            // CmdFiltern
            // 
            CmdFiltern.Location = new Point(150, 390);
            CmdFiltern.Name = "CmdFiltern";
            CmdFiltern.Size = new Size(98, 34);
            CmdFiltern.TabIndex = 8;
            CmdFiltern.Text = "Filtern";
            CmdFiltern.UseVisualStyleBackColor = true;
            // 
            // CmdAlleAnzeigen
            // 
            CmdAlleAnzeigen.Location = new Point(298, 390);
            CmdAlleAnzeigen.Name = "CmdAlleAnzeigen";
            CmdAlleAnzeigen.Size = new Size(161, 34);
            CmdAlleAnzeigen.TabIndex = 9;
            CmdAlleAnzeigen.Text = "Alle anzeigen";
            CmdAlleAnzeigen.UseVisualStyleBackColor = true;
            // 
            // CmdNachNachnameSortieren
            // 
            CmdNachNachnameSortieren.Location = new Point(819, 314);
            CmdNachNachnameSortieren.Name = "CmdNachNachnameSortieren";
            CmdNachNachnameSortieren.Size = new Size(259, 34);
            CmdNachNachnameSortieren.TabIndex = 10;
            CmdNachNachnameSortieren.Text = "Nach Nachname sortieren";
            CmdNachNachnameSortieren.UseVisualStyleBackColor = true;
            // 
            // CmdNachVornameSortieren
            // 
            CmdNachVornameSortieren.Location = new Point(819, 351);
            CmdNachVornameSortieren.Name = "CmdNachVornameSortieren";
            CmdNachVornameSortieren.Size = new Size(259, 34);
            CmdNachVornameSortieren.TabIndex = 11;
            CmdNachVornameSortieren.Text = "Nach Vorname sortieren";
            CmdNachVornameSortieren.UseVisualStyleBackColor = true;
            // 
            // CmdMitarbeiterInAbteilungÜbernehmen
            // 
            CmdMitarbeiterInAbteilungÜbernehmen.Location = new Point(1146, 313);
            CmdMitarbeiterInAbteilungÜbernehmen.Name = "CmdMitarbeiterInAbteilungÜbernehmen";
            CmdMitarbeiterInAbteilungÜbernehmen.Size = new Size(288, 66);
            CmdMitarbeiterInAbteilungÜbernehmen.TabIndex = 12;
            CmdMitarbeiterInAbteilungÜbernehmen.Text = "Mitarbeiter in ausgewählte Abteilung übernehmen";
            CmdMitarbeiterInAbteilungÜbernehmen.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 445);
            label4.Name = "label4";
            label4.Size = new Size(155, 32);
            label4.TabIndex = 13;
            label4.Text = "Abteilungen";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { abteilungsNrDataGridViewTextBoxColumn1, bezeichnungDataGridViewTextBoxColumn });
            dataGridView2.DataSource = abteilungBindingSource;
            dataGridView2.Location = new Point(12, 484);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(1422, 225);
            dataGridView2.TabIndex = 14;
            // 
            // abteilungBindingSource
            // 
            abteilungBindingSource.DataSource = typeof(Models.Abteilung);
            // 
            // abteilungsNrDataGridViewTextBoxColumn1
            // 
            abteilungsNrDataGridViewTextBoxColumn1.DataPropertyName = "AbteilungsNr";
            abteilungsNrDataGridViewTextBoxColumn1.HeaderText = "AbteilungsNr";
            abteilungsNrDataGridViewTextBoxColumn1.MinimumWidth = 8;
            abteilungsNrDataGridViewTextBoxColumn1.Name = "abteilungsNrDataGridViewTextBoxColumn1";
            abteilungsNrDataGridViewTextBoxColumn1.ReadOnly = true;
            abteilungsNrDataGridViewTextBoxColumn1.Width = 150;
            // 
            // bezeichnungDataGridViewTextBoxColumn
            // 
            bezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Bezeichnung";
            bezeichnungDataGridViewTextBoxColumn.HeaderText = "Bezeichnung";
            bezeichnungDataGridViewTextBoxColumn.MinimumWidth = 8;
            bezeichnungDataGridViewTextBoxColumn.Name = "bezeichnungDataGridViewTextBoxColumn";
            bezeichnungDataGridViewTextBoxColumn.ReadOnly = true;
            bezeichnungDataGridViewTextBoxColumn.Width = 150;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 725);
            label5.Name = "label5";
            label5.Size = new Size(199, 25);
            label5.TabIndex = 15;
            label5.Text = "Ausgewählte Abteilung:";
            // 
            // TxtAbteilungsnummer
            // 
            TxtAbteilungsnummer.Location = new Point(221, 722);
            TxtAbteilungsnummer.Name = "TxtAbteilungsnummer";
            TxtAbteilungsnummer.ReadOnly = true;
            TxtAbteilungsnummer.Size = new Size(41, 31);
            TxtAbteilungsnummer.TabIndex = 16;
            // 
            // TxtAbteilungsbezeichnung
            // 
            TxtAbteilungsbezeichnung.Location = new Point(268, 722);
            TxtAbteilungsbezeichnung.Name = "TxtAbteilungsbezeichnung";
            TxtAbteilungsbezeichnung.ReadOnly = true;
            TxtAbteilungsbezeichnung.Size = new Size(257, 31);
            TxtAbteilungsbezeichnung.TabIndex = 17;
            // 
            // CmdAbteilungHinzufügen
            // 
            CmdAbteilungHinzufügen.Location = new Point(714, 720);
            CmdAbteilungHinzufügen.Name = "CmdAbteilungHinzufügen";
            CmdAbteilungHinzufügen.Size = new Size(236, 34);
            CmdAbteilungHinzufügen.TabIndex = 18;
            CmdAbteilungHinzufügen.Text = "Abteilung hinzufügen";
            CmdAbteilungHinzufügen.UseVisualStyleBackColor = true;
            // 
            // CmdAbteilungBearbeiten
            // 
            CmdAbteilungBearbeiten.Location = new Point(956, 720);
            CmdAbteilungBearbeiten.Name = "CmdAbteilungBearbeiten";
            CmdAbteilungBearbeiten.Size = new Size(236, 34);
            CmdAbteilungBearbeiten.TabIndex = 19;
            CmdAbteilungBearbeiten.Text = "Abteilung bearbeiten";
            CmdAbteilungBearbeiten.UseVisualStyleBackColor = true;
            // 
            // CmdAbteilungLöschen
            // 
            CmdAbteilungLöschen.Location = new Point(1198, 720);
            CmdAbteilungLöschen.Name = "CmdAbteilungLöschen";
            CmdAbteilungLöschen.Size = new Size(236, 34);
            CmdAbteilungLöschen.TabIndex = 20;
            CmdAbteilungLöschen.Text = "Abteilung löschen";
            CmdAbteilungLöschen.UseVisualStyleBackColor = true;
            // 
            // FrmMitarbeiterverwaltung
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1455, 763);
            Controls.Add(CmdAbteilungLöschen);
            Controls.Add(CmdAbteilungBearbeiten);
            Controls.Add(CmdAbteilungHinzufügen);
            Controls.Add(TxtAbteilungsbezeichnung);
            Controls.Add(TxtAbteilungsnummer);
            Controls.Add(label5);
            Controls.Add(dataGridView2);
            Controls.Add(label4);
            Controls.Add(CmdMitarbeiterInAbteilungÜbernehmen);
            Controls.Add(CmdNachVornameSortieren);
            Controls.Add(CmdNachNachnameSortieren);
            Controls.Add(CmdAlleAnzeigen);
            Controls.Add(CmdFiltern);
            Controls.Add(TxtVorname);
            Controls.Add(TxtNachname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(CmdMitarbeiterLöschen);
            Controls.Add(CmdMitarbeiterHinzufügen);
            Name = "FrmMitarbeiterverwaltung";
            Text = "Mitarbeiterverwaltung";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mitarbeiterBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)abteilungBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdMitarbeiterHinzufügen;
        private Button CmdMitarbeiterLöschen;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn personalNrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn abteilungsNrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vornameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stellenbezeichnungDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn plzDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ortDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private BindingSource mitarbeiterBindingSource;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtNachname;
        private TextBox TxtVorname;
        private Button CmdFiltern;
        private Button CmdAlleAnzeigen;
        private Button CmdNachNachnameSortieren;
        private Button CmdNachVornameSortieren;
        private Button CmdMitarbeiterInAbteilungÜbernehmen;
        private Label label4;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn abteilungsNrDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn;
        private BindingSource abteilungBindingSource;
        private Label label5;
        private TextBox TxtAbteilungsnummer;
        private TextBox TxtAbteilungsbezeichnung;
        private Button CmdAbteilungHinzufügen;
        private Button CmdAbteilungBearbeiten;
        private Button CmdAbteilungLöschen;
    }
}
