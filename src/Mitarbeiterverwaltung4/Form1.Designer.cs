// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Mitarbeiterverwaltung4
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            personalNrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            abteilungsNrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vornameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stellenbezeichnungDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adresseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            plzDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ortDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mitarbeiterBindingSource = new BindingSource(components);
            groupBox2 = new GroupBox();
            dataGridView2 = new DataGridView();
            abteilungsNrDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            bezeichnungDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            abteilungBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtVorname = new TextBox();
            TxtNachname = new TextBox();
            CmdAbteilunghinzufügen = new Button();
            CmdMitarbeiterausgewählteAbteilungübernehmen = new Button();
            CmdAbteilungbearbeiten = new Button();
            CmdAlleAnzeigen = new Button();
            CmdFiltern = new Button();
            CmdNachVornamesortieren = new Button();
            CmdNachNameSortieren = new Button();
            LblausgewählteAbteilung = new Label();
            LblEinkauf = new Label();
            CmdAbteilunglöschen = new Button();
            CmdHinzufügen = new Button();
            CmdLöschen = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mitarbeiterBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)abteilungBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1084, 251);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mitarbeiter";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { personalNrDataGridViewTextBoxColumn, abteilungsNrDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, vornameDataGridViewTextBoxColumn, stellenbezeichnungDataGridViewTextBoxColumn, adresseDataGridViewTextBoxColumn, plzDataGridViewTextBoxColumn, ortDataGridViewTextBoxColumn, telefonDataGridViewTextBoxColumn });
            dataGridView1.DataSource = mitarbeiterBindingSource;
            dataGridView1.Location = new Point(3, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1087, 301);
            dataGridView1.TabIndex = 0;
            // 
            // personalNrDataGridViewTextBoxColumn
            // 
            personalNrDataGridViewTextBoxColumn.DataPropertyName = "PersonalNr";
            personalNrDataGridViewTextBoxColumn.HeaderText = "PersonalNr";
            personalNrDataGridViewTextBoxColumn.Name = "personalNrDataGridViewTextBoxColumn";
            // 
            // abteilungsNrDataGridViewTextBoxColumn
            // 
            abteilungsNrDataGridViewTextBoxColumn.DataPropertyName = "AbteilungsNr";
            abteilungsNrDataGridViewTextBoxColumn.HeaderText = "AbteilungsNr";
            abteilungsNrDataGridViewTextBoxColumn.Name = "abteilungsNrDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // vornameDataGridViewTextBoxColumn
            // 
            vornameDataGridViewTextBoxColumn.DataPropertyName = "Vorname";
            vornameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            vornameDataGridViewTextBoxColumn.Name = "vornameDataGridViewTextBoxColumn";
            // 
            // stellenbezeichnungDataGridViewTextBoxColumn
            // 
            stellenbezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Stellenbezeichnung";
            stellenbezeichnungDataGridViewTextBoxColumn.HeaderText = "Stellenbezeichnung";
            stellenbezeichnungDataGridViewTextBoxColumn.Name = "stellenbezeichnungDataGridViewTextBoxColumn";
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            // 
            // plzDataGridViewTextBoxColumn
            // 
            plzDataGridViewTextBoxColumn.DataPropertyName = "Plz";
            plzDataGridViewTextBoxColumn.HeaderText = "Plz";
            plzDataGridViewTextBoxColumn.Name = "plzDataGridViewTextBoxColumn";
            // 
            // ortDataGridViewTextBoxColumn
            // 
            ortDataGridViewTextBoxColumn.DataPropertyName = "Ort";
            ortDataGridViewTextBoxColumn.HeaderText = "Ort";
            ortDataGridViewTextBoxColumn.Name = "ortDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // mitarbeiterBindingSource
            // 
            mitarbeiterBindingSource.DataSource = typeof(Models.Mitarbeiter);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Location = new Point(12, 442);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1084, 266);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Abteilungen";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { abteilungsNrDataGridViewTextBoxColumn1, bezeichnungDataGridViewTextBoxColumn });
            dataGridView2.DataSource = abteilungBindingSource;
            dataGridView2.Location = new Point(3, 19);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(1075, 288);
            dataGridView2.TabIndex = 0;
            // 
            // abteilungsNrDataGridViewTextBoxColumn1
            // 
            abteilungsNrDataGridViewTextBoxColumn1.DataPropertyName = "AbteilungsNr";
            abteilungsNrDataGridViewTextBoxColumn1.HeaderText = "AbteilungsNr";
            abteilungsNrDataGridViewTextBoxColumn1.Name = "abteilungsNrDataGridViewTextBoxColumn1";
            // 
            // bezeichnungDataGridViewTextBoxColumn
            // 
            bezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Bezeichnung";
            bezeichnungDataGridViewTextBoxColumn.HeaderText = "Bezeichnung";
            bezeichnungDataGridViewTextBoxColumn.Name = "bezeichnungDataGridViewTextBoxColumn";
            // 
            // abteilungBindingSource
            // 
            abteilungBindingSource.DataSource = typeof(Models.Abteilung);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 329);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 2;
            label1.Text = "Nachname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 363);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 3;
            label2.Text = "Vorname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 725);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 4;
            label3.Text = "AusgewählteAbteilun";
            // 
            // TxtVorname
            // 
            TxtVorname.Location = new Point(116, 360);
            TxtVorname.Name = "TxtVorname";
            TxtVorname.Size = new Size(100, 23);
            TxtVorname.TabIndex = 5;
            // 
            // TxtNachname
            // 
            TxtNachname.Location = new Point(116, 326);
            TxtNachname.Name = "TxtNachname";
            TxtNachname.Size = new Size(100, 23);
            TxtNachname.TabIndex = 6;
            // 
            // CmdAbteilunghinzufügen
            // 
            CmdAbteilunghinzufügen.Location = new Point(15, 755);
            CmdAbteilunghinzufügen.Name = "CmdAbteilunghinzufügen";
            CmdAbteilunghinzufügen.Size = new Size(166, 23);
            CmdAbteilunghinzufügen.TabIndex = 7;
            CmdAbteilunghinzufügen.Text = "Abteilung hinzufügen";
            CmdAbteilunghinzufügen.UseVisualStyleBackColor = true;
            // 
            // CmdMitarbeiterausgewählteAbteilungübernehmen
            // 
            CmdMitarbeiterausgewählteAbteilungübernehmen.Location = new Point(679, 355);
            CmdMitarbeiterausgewählteAbteilungübernehmen.Name = "CmdMitarbeiterausgewählteAbteilungübernehmen";
            CmdMitarbeiterausgewählteAbteilungübernehmen.Size = new Size(316, 23);
            CmdMitarbeiterausgewählteAbteilungübernehmen.TabIndex = 8;
            CmdMitarbeiterausgewählteAbteilungübernehmen.Text = "MitArbeiter in ausgewählte Abteilung übernehmen";
            CmdMitarbeiterausgewählteAbteilungübernehmen.UseVisualStyleBackColor = true;
            // 
            // CmdAbteilungbearbeiten
            // 
            CmdAbteilungbearbeiten.Location = new Point(15, 798);
            CmdAbteilungbearbeiten.Name = "CmdAbteilungbearbeiten";
            CmdAbteilungbearbeiten.Size = new Size(144, 23);
            CmdAbteilungbearbeiten.TabIndex = 9;
            CmdAbteilungbearbeiten.Text = "Abteilung bearbeiten";
            CmdAbteilungbearbeiten.UseVisualStyleBackColor = true;
            // 
            // CmdAlleAnzeigen
            // 
            CmdAlleAnzeigen.Location = new Point(194, 403);
            CmdAlleAnzeigen.Name = "CmdAlleAnzeigen";
            CmdAlleAnzeigen.Size = new Size(108, 23);
            CmdAlleAnzeigen.TabIndex = 11;
            CmdAlleAnzeigen.Text = "Alle anzeigen";
            CmdAlleAnzeigen.UseVisualStyleBackColor = true;
            // 
            // CmdFiltern
            // 
            CmdFiltern.Location = new Point(96, 403);
            CmdFiltern.Name = "CmdFiltern";
            CmdFiltern.Size = new Size(75, 23);
            CmdFiltern.TabIndex = 12;
            CmdFiltern.Text = "Filtern";
            CmdFiltern.UseVisualStyleBackColor = true;
            // 
            // CmdNachVornamesortieren
            // 
            CmdNachVornamesortieren.Location = new Point(271, 363);
            CmdNachVornamesortieren.Name = "CmdNachVornamesortieren";
            CmdNachVornamesortieren.Size = new Size(190, 23);
            CmdNachVornamesortieren.TabIndex = 13;
            CmdNachVornamesortieren.Text = "Nach Vorname sortieren";
            CmdNachVornamesortieren.UseVisualStyleBackColor = true;
            // 
            // CmdNachNameSortieren
            // 
            CmdNachNameSortieren.Location = new Point(271, 329);
            CmdNachNameSortieren.Name = "CmdNachNameSortieren";
            CmdNachNameSortieren.Size = new Size(190, 23);
            CmdNachNameSortieren.TabIndex = 14;
            CmdNachNameSortieren.Text = "Nach Nachname sortieren";
            CmdNachNameSortieren.UseVisualStyleBackColor = true;
            CmdNachNameSortieren.Click += CmdNachNameSortieren_Click;
            // 
            // LblausgewählteAbteilung
            // 
            LblausgewählteAbteilung.AutoSize = true;
            LblausgewählteAbteilung.Location = new Point(167, 725);
            LblausgewählteAbteilung.Name = "LblausgewählteAbteilung";
            LblausgewählteAbteilung.Size = new Size(38, 15);
            LblausgewählteAbteilung.TabIndex = 15;
            LblausgewählteAbteilung.Text = "label4";
            // 
            // LblEinkauf
            // 
            LblEinkauf.AutoSize = true;
            LblEinkauf.Location = new Point(249, 725);
            LblEinkauf.Name = "LblEinkauf";
            LblEinkauf.Size = new Size(38, 15);
            LblEinkauf.TabIndex = 16;
            LblEinkauf.Text = "label5";
            // 
            // CmdAbteilunglöschen
            // 
            CmdAbteilunglöschen.Location = new Point(15, 838);
            CmdAbteilunglöschen.Name = "CmdAbteilunglöschen";
            CmdAbteilunglöschen.Size = new Size(144, 23);
            CmdAbteilunglöschen.TabIndex = 17;
            CmdAbteilunglöschen.Text = "Abteilung löschen";
            CmdAbteilunglöschen.UseVisualStyleBackColor = true;
            // 
            // CmdHinzufügen
            // 
            CmdHinzufügen.Location = new Point(342, 26);
            CmdHinzufügen.Name = "CmdHinzufügen";
            CmdHinzufügen.Size = new Size(102, 23);
            CmdHinzufügen.TabIndex = 18;
            CmdHinzufügen.Text = "Hinzufügen";
            CmdHinzufügen.UseVisualStyleBackColor = true;
            // 
            // CmdLöschen
            // 
            CmdLöschen.Location = new Point(531, 26);
            CmdLöschen.Name = "CmdLöschen";
            CmdLöschen.Size = new Size(75, 23);
            CmdLöschen.TabIndex = 19;
            CmdLöschen.Text = "Löschen";
            CmdLöschen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 891);
            Controls.Add(CmdLöschen);
            Controls.Add(CmdHinzufügen);
            Controls.Add(CmdAbteilunglöschen);
            Controls.Add(LblEinkauf);
            Controls.Add(LblausgewählteAbteilung);
            Controls.Add(CmdNachNameSortieren);
            Controls.Add(CmdNachVornamesortieren);
            Controls.Add(CmdFiltern);
            Controls.Add(CmdAlleAnzeigen);
            Controls.Add(CmdAbteilungbearbeiten);
            Controls.Add(CmdMitarbeiterausgewählteAbteilungübernehmen);
            Controls.Add(CmdAbteilunghinzufügen);
            Controls.Add(TxtNachname);
            Controls.Add(TxtVorname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mitarbeiterBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)abteilungBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private DataGridView dataGridView2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtVorname;
        private TextBox TxtNachname;
        private Button CmdAbteilunghinzufügen;
        private Button CmdMitarbeiterausgewählteAbteilungübernehmen;
        private Button CmdAbteilungbearbeiten;
        private Button CmdAlleAnzeigen;
        private Button CmdFiltern;
        private Button CmdNachVornamesortieren;
        private Button CmdNachNameSortieren;
        private Label LblausgewählteAbteilung;
        private Label LblEinkauf;
        private Button CmdAbteilunglöschen;
        private BindingSource mitarbeiterBindingSource;
        private BindingSource abteilungBindingSource;
        private DataGridViewTextBoxColumn personalNrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn abteilungsNrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vornameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stellenbezeichnungDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn plzDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ortDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn abteilungsNrDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn;
        private Button CmdHinzufügen;
        private Button CmdLöschen;
    }
}
