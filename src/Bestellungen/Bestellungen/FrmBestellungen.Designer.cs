// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Bestellungen
{
    partial class FrmBestellungen
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
            DateGripView1 = new DataGridView();
            bestellNrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kundenNrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            textDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            preisDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            datumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bestellungBindingSource = new BindingSource(components);
            GrpBesstelung = new GroupBox();
            CMdHinzufügen = new Button();
            CmdPreisSortieren = new Button();
            CmdSpeichern = new Button();
            TxtPReis = new TextBox();
            TxtBestelltext = new TextBox();
            TxtKundenNr = new TextBox();
            TxtBestellNr = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            LblPreis = new Label();
            LblDatum = new Label();
            LblBestellText = new Label();
            LblKundenNr = new Label();
            LblBestellNr = new Label();
            cmdNachKundefiltern = new Button();
            CmdBestellungen = new Button();
            CmdÜbernehmen = new Button();
            GrpKunden = new GroupBox();
            dataGridView1 = new DataGridView();
            kundenNrDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adresseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            plzDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ortDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bestellungsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kundeBindingSource = new BindingSource(components);
            LblKundennummer = new Label();
            TxtKundennummer = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DateGripView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bestellungBindingSource).BeginInit();
            GrpBesstelung.SuspendLayout();
            GrpKunden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kundeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // DateGripView1
            // 
            DateGripView1.AllowUserToAddRows = false;
            DateGripView1.AllowUserToDeleteRows = false;
            DateGripView1.AutoGenerateColumns = false;
            DateGripView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DateGripView1.Columns.AddRange(new DataGridViewColumn[] { bestellNrDataGridViewTextBoxColumn, kundenNrDataGridViewTextBoxColumn, textDataGridViewTextBoxColumn, preisDataGridViewTextBoxColumn, datumDataGridViewTextBoxColumn });
            DateGripView1.DataSource = bestellungBindingSource;
            DateGripView1.Location = new Point(18, 55);
            DateGripView1.Name = "DateGripView1";
            DateGripView1.ReadOnly = true;
            DateGripView1.Size = new Size(665, 150);
            DateGripView1.TabIndex = 0;
            // 
            // bestellNrDataGridViewTextBoxColumn
            // 
            bestellNrDataGridViewTextBoxColumn.DataPropertyName = "BestellNr";
            bestellNrDataGridViewTextBoxColumn.HeaderText = "BestellNr";
            bestellNrDataGridViewTextBoxColumn.Name = "bestellNrDataGridViewTextBoxColumn";
            bestellNrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kundenNrDataGridViewTextBoxColumn
            // 
            kundenNrDataGridViewTextBoxColumn.DataPropertyName = "KundenNr";
            kundenNrDataGridViewTextBoxColumn.HeaderText = "KundenNr";
            kundenNrDataGridViewTextBoxColumn.Name = "kundenNrDataGridViewTextBoxColumn";
            kundenNrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // textDataGridViewTextBoxColumn
            // 
            textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            textDataGridViewTextBoxColumn.HeaderText = "Text";
            textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            textDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // preisDataGridViewTextBoxColumn
            // 
            preisDataGridViewTextBoxColumn.DataPropertyName = "Preis";
            preisDataGridViewTextBoxColumn.HeaderText = "Preis";
            preisDataGridViewTextBoxColumn.Name = "preisDataGridViewTextBoxColumn";
            preisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bestellungBindingSource
            // 
            bestellungBindingSource.DataSource = typeof(Models.Bestellung);
            // 
            // GrpBesstelung
            // 
            GrpBesstelung.Controls.Add(CMdHinzufügen);
            GrpBesstelung.Controls.Add(CmdPreisSortieren);
            GrpBesstelung.Controls.Add(CmdSpeichern);
            GrpBesstelung.Controls.Add(TxtPReis);
            GrpBesstelung.Controls.Add(TxtBestelltext);
            GrpBesstelung.Controls.Add(TxtKundenNr);
            GrpBesstelung.Controls.Add(TxtBestellNr);
            GrpBesstelung.Controls.Add(dateTimePicker1);
            GrpBesstelung.Controls.Add(LblPreis);
            GrpBesstelung.Controls.Add(LblDatum);
            GrpBesstelung.Controls.Add(LblBestellText);
            GrpBesstelung.Controls.Add(LblKundenNr);
            GrpBesstelung.Controls.Add(LblBestellNr);
            GrpBesstelung.Controls.Add(cmdNachKundefiltern);
            GrpBesstelung.Controls.Add(CmdBestellungen);
            GrpBesstelung.Controls.Add(CmdÜbernehmen);
            GrpBesstelung.Controls.Add(DateGripView1);
            GrpBesstelung.Location = new Point(124, 26);
            GrpBesstelung.Name = "GrpBesstelung";
            GrpBesstelung.Size = new Size(729, 283);
            GrpBesstelung.TabIndex = 1;
            GrpBesstelung.TabStop = false;
            GrpBesstelung.Text = "Bestellung";
            // 
            // CMdHinzufügen
            // 
            CMdHinzufügen.Location = new Point(85, -7);
            CMdHinzufügen.Name = "CMdHinzufügen";
            CMdHinzufügen.Size = new Size(75, 23);
            CMdHinzufügen.TabIndex = 17;
            CMdHinzufügen.Text = "Hinzufügen";
            CMdHinzufügen.UseVisualStyleBackColor = true;
            CMdHinzufügen.Click += CMdHinzufügen_Click;
            // 
            // CmdPreisSortieren
            // 
            CmdPreisSortieren.Location = new Point(177, 29);
            CmdPreisSortieren.Name = "CmdPreisSortieren";
            CmdPreisSortieren.Size = new Size(75, 23);
            CmdPreisSortieren.TabIndex = 16;
            CmdPreisSortieren.Text = "PreisSortieren";
            CmdPreisSortieren.UseVisualStyleBackColor = true;
            CmdPreisSortieren.Click += CmdPreisSortieren_Click;
            // 
            // CmdSpeichern
            // 
            CmdSpeichern.Location = new Point(177, 0);
            CmdSpeichern.Name = "CmdSpeichern";
            CmdSpeichern.Size = new Size(75, 23);
            CmdSpeichern.TabIndex = 15;
            CmdSpeichern.Text = "Speichern";
            CmdSpeichern.UseVisualStyleBackColor = true;
            CmdSpeichern.Click += CmdSpeichern_Click;
            // 
            // TxtPReis
            // 
            TxtPReis.CausesValidation = false;
            TxtPReis.DataBindings.Add(new Binding("DataContext", bestellungBindingSource, "Preis", true));
            TxtPReis.DataBindings.Add(new Binding("Text", bestellungBindingSource, "Preis", true));
            TxtPReis.Location = new Point(545, 248);
            TxtPReis.Name = "TxtPReis";
            TxtPReis.Size = new Size(100, 23);
            TxtPReis.TabIndex = 14;
            // 
            // TxtBestelltext
            // 
            TxtBestelltext.DataBindings.Add(new Binding("DataContext", bestellungBindingSource, "Text", true));
            TxtBestelltext.DataBindings.Add(new Binding("Text", bestellungBindingSource, "Text", true));
            TxtBestelltext.Location = new Point(258, 254);
            TxtBestelltext.Name = "TxtBestelltext";
            TxtBestelltext.Size = new Size(100, 23);
            TxtBestelltext.TabIndex = 13;
            // 
            // TxtKundenNr
            // 
            TxtKundenNr.DataBindings.Add(new Binding("DataContext", bestellungBindingSource, "KundenNr", true));
            TxtKundenNr.DataBindings.Add(new Binding("Text", bestellungBindingSource, "KundenNr", true));
            TxtKundenNr.Location = new Point(258, 211);
            TxtKundenNr.Name = "TxtKundenNr";
            TxtKundenNr.Size = new Size(100, 23);
            TxtKundenNr.TabIndex = 12;
            // 
            // TxtBestellNr
            // 
            TxtBestellNr.DataBindings.Add(new Binding("DataContext", bestellungBindingSource, "BestellNr", true));
            TxtBestellNr.DataBindings.Add(new Binding("Text", bestellungBindingSource, "BestellNr", true));
            TxtBestellNr.Location = new Point(85, 221);
            TxtBestellNr.Name = "TxtBestellNr";
            TxtBestellNr.Size = new Size(100, 23);
            TxtBestellNr.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(506, 218);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // LblPreis
            // 
            LblPreis.AutoSize = true;
            LblPreis.Location = new Point(411, 251);
            LblPreis.Name = "LblPreis";
            LblPreis.Size = new Size(32, 15);
            LblPreis.TabIndex = 9;
            LblPreis.Text = "Preis";
            // 
            // LblDatum
            // 
            LblDatum.AutoSize = true;
            LblDatum.Location = new Point(411, 224);
            LblDatum.Name = "LblDatum";
            LblDatum.Size = new Size(43, 15);
            LblDatum.TabIndex = 8;
            LblDatum.Text = "Datum";
            // 
            // LblBestellText
            // 
            LblBestellText.AutoSize = true;
            LblBestellText.Location = new Point(191, 251);
            LblBestellText.Name = "LblBestellText";
            LblBestellText.Size = new Size(61, 15);
            LblBestellText.TabIndex = 7;
            LblBestellText.Text = "Bestelltext";
            // 
            // LblKundenNr
            // 
            LblKundenNr.AutoSize = true;
            LblKundenNr.Location = new Point(191, 224);
            LblKundenNr.Name = "LblKundenNr";
            LblKundenNr.Size = new Size(61, 15);
            LblKundenNr.TabIndex = 6;
            LblKundenNr.Text = "KundenNr";
            // 
            // LblBestellNr
            // 
            LblBestellNr.AutoSize = true;
            LblBestellNr.Location = new Point(18, 224);
            LblBestellNr.Name = "LblBestellNr";
            LblBestellNr.Size = new Size(57, 15);
            LblBestellNr.TabIndex = 5;
            LblBestellNr.Text = "Bestell Nr";
            // 
            // cmdNachKundefiltern
            // 
            cmdNachKundefiltern.Location = new Point(528, 22);
            cmdNachKundefiltern.Name = "cmdNachKundefiltern";
            cmdNachKundefiltern.Size = new Size(138, 23);
            cmdNachKundefiltern.TabIndex = 4;
            cmdNachKundefiltern.Text = "nach kunde filtern";
            cmdNachKundefiltern.UseVisualStyleBackColor = true;
            cmdNachKundefiltern.Click += cmdNachKundefiltern_Click;
            // 
            // CmdBestellungen
            // 
            CmdBestellungen.Location = new Point(309, 22);
            CmdBestellungen.Name = "CmdBestellungen";
            CmdBestellungen.Size = new Size(140, 23);
            CmdBestellungen.TabIndex = 3;
            CmdBestellungen.Text = "Alle BEstellungen";
            CmdBestellungen.UseVisualStyleBackColor = true;
            CmdBestellungen.Click += CmdBestellungen_Click;
            // 
            // CmdÜbernehmen
            // 
            CmdÜbernehmen.Location = new Point(18, 22);
            CmdÜbernehmen.Name = "CmdÜbernehmen";
            CmdÜbernehmen.Size = new Size(119, 23);
            CmdÜbernehmen.TabIndex = 2;
            CmdÜbernehmen.Text = "KundeÜbernehmen";
            CmdÜbernehmen.UseVisualStyleBackColor = true;
            CmdÜbernehmen.Click += CmdÜbernehmen_Click;
            // 
            // GrpKunden
            // 
            GrpKunden.Controls.Add(dataGridView1);
            GrpKunden.Location = new Point(45, 366);
            GrpKunden.Name = "GrpKunden";
            GrpKunden.Size = new Size(868, 154);
            GrpKunden.TabIndex = 2;
            GrpKunden.TabStop = false;
            GrpKunden.Text = "Kunden";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { kundenNrDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn, adresseDataGridViewTextBoxColumn, plzDataGridViewTextBoxColumn, ortDataGridViewTextBoxColumn, telefonDataGridViewTextBoxColumn, bestellungsDataGridViewTextBoxColumn });
            dataGridView1.DataSource = kundeBindingSource;
            dataGridView1.Location = new Point(6, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(779, 150);
            dataGridView1.TabIndex = 0;
            // 
            // kundenNrDataGridViewTextBoxColumn1
            // 
            kundenNrDataGridViewTextBoxColumn1.DataPropertyName = "KundenNr";
            kundenNrDataGridViewTextBoxColumn1.HeaderText = "KundenNr";
            kundenNrDataGridViewTextBoxColumn1.Name = "kundenNrDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
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
            // bestellungsDataGridViewTextBoxColumn
            // 
            bestellungsDataGridViewTextBoxColumn.DataPropertyName = "Bestellungs";
            bestellungsDataGridViewTextBoxColumn.HeaderText = "Bestellungs";
            bestellungsDataGridViewTextBoxColumn.Name = "bestellungsDataGridViewTextBoxColumn";
            // 
            // kundeBindingSource
            // 
            kundeBindingSource.DataSource = typeof(Models.Kunde);
            // 
            // LblKundennummer
            // 
            LblKundennummer.AutoSize = true;
            LblKundennummer.Location = new Point(51, 556);
            LblKundennummer.Name = "LblKundennummer";
            LblKundennummer.Size = new Size(94, 15);
            LblKundennummer.TabIndex = 3;
            LblKundennummer.Text = "Kundennummer";
            // 
            // TxtKundennummer
            // 
            TxtKundennummer.DataBindings.Add(new Binding("DataContext", kundeBindingSource, "KundenNr", true));
            TxtKundennummer.DataBindings.Add(new Binding("Text", kundeBindingSource, "KundenNr", true));
            TxtKundennummer.Location = new Point(161, 556);
            TxtKundennummer.Name = "TxtKundennummer";
            TxtKundennummer.Size = new Size(100, 23);
            TxtKundennummer.TabIndex = 4;
            // 
            // FrmBestellungen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 614);
            Controls.Add(TxtKundennummer);
            Controls.Add(LblKundennummer);
            Controls.Add(GrpKunden);
            Controls.Add(GrpBesstelung);
            Name = "FrmBestellungen";
            Load += FrmBestellungen_Load;
            ((System.ComponentModel.ISupportInitialize)DateGripView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bestellungBindingSource).EndInit();
            GrpBesstelung.ResumeLayout(false);
            GrpBesstelung.PerformLayout();
            GrpKunden.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kundeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DateGripView1;
        private GroupBox GrpBesstelung;
        private BindingSource bestellungBindingSource;
        private DataGridViewTextBoxColumn bestellNrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kundenNrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn preisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private TextBox TxtBestelltext;
        private TextBox TxtKundenNr;
        private TextBox TxtBestellNr;
        private DateTimePicker dateTimePicker1;
        private Label LblPreis;
        private Label LblDatum;
        private Label LblBestellText;
        private Label LblKundenNr;
        private Label LblBestellNr;
        private Button cmdNachKundefiltern;
        private Button CmdBestellungen;
        private Button CmdÜbernehmen;
        private TextBox TxtPReis;
        private GroupBox GrpKunden;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn kundenNrDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn plzDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ortDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bestellungsDataGridViewTextBoxColumn;
        private BindingSource kundeBindingSource;
        private Label LblKundennummer;
        private TextBox TxtKundennummer;
        private Button CmdSpeichern;
        private Button CmdPreisSortieren;
        private Button CMdHinzufügen;
    }
}
