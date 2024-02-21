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
            groupBox1 = new GroupBox();
            CmdSortieren = new Button();
            DatDatum = new DateTimePicker();
            bestellungBindingSource = new BindingSource(components);
            label6 = new Label();
            label5 = new Label();
            TxtPreis = new TextBox();
            label4 = new Label();
            TxtBestelltext = new TextBox();
            label3 = new Label();
            TxtKundenNr = new TextBox();
            label2 = new Label();
            TxtBestellNr = new TextBox();
            label1 = new Label();
            CmdNachKundeFiltern = new Button();
            CmdAlleBestellungen = new Button();
            CmdKundeÜbernehmen = new Button();
            dataGridView1 = new DataGridView();
            bestellNrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kundenNrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            textDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            preisDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            datumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            TxtAusgewählterKunde = new TextBox();
            kundeBindingSource = new BindingSource(components);
            label7 = new Label();
            dataGridView2 = new DataGridView();
            kundenNrDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adresseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            plzDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ortDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CmdSpeichern = new Button();
            CmdHinzufügen = new Button();
            CmdLöschen = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bestellungBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kundeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CmdSortieren);
            groupBox1.Controls.Add(DatDatum);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(TxtPreis);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TxtBestelltext);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtKundenNr);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtBestellNr);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(CmdNachKundeFiltern);
            groupBox1.Controls.Add(CmdAlleBestellungen);
            groupBox1.Controls.Add(CmdKundeÜbernehmen);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1026, 432);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bestellungen:";
            // 
            // CmdSortieren
            // 
            CmdSortieren.Location = new Point(218, 30);
            CmdSortieren.Name = "CmdSortieren";
            CmdSortieren.Size = new Size(206, 34);
            CmdSortieren.TabIndex = 15;
            CmdSortieren.Text = "Nach Preis sortieren";
            CmdSortieren.UseVisualStyleBackColor = true;
            CmdSortieren.Click += CmdSortieren_Click;
            // 
            // DatDatum
            // 
            DatDatum.DataBindings.Add(new Binding("Value", bestellungBindingSource, "Datum", true));
            DatDatum.Location = new Point(714, 360);
            DatDatum.Name = "DatDatum";
            DatDatum.Size = new Size(300, 31);
            DatDatum.TabIndex = 14;
            // 
            // bestellungBindingSource
            // 
            bestellungBindingSource.DataSource = typeof(Models.Bestellung);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(633, 363);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 13;
            label6.Text = "Datum";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(870, 397);
            label5.Name = "label5";
            label5.Size = new Size(48, 25);
            label5.TabIndex = 12;
            label5.Text = "Euro";
            // 
            // TxtPreis
            // 
            TxtPreis.CausesValidation = false;
            TxtPreis.DataBindings.Add(new Binding("Text", bestellungBindingSource, "Preis", true));
            TxtPreis.Location = new Point(714, 394);
            TxtPreis.Name = "TxtPreis";
            TxtPreis.Size = new Size(150, 31);
            TxtPreis.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(640, 401);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 10;
            label4.Text = "Preis";
            // 
            // TxtBestelltext
            // 
            TxtBestelltext.DataBindings.Add(new Binding("Text", bestellungBindingSource, "Text", true));
            TxtBestelltext.Location = new Point(389, 397);
            TxtBestelltext.Name = "TxtBestelltext";
            TxtBestelltext.Size = new Size(245, 31);
            TxtBestelltext.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(287, 394);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 8;
            label3.Text = "Bestelltext";
            // 
            // TxtKundenNr
            // 
            TxtKundenNr.DataBindings.Add(new Binding("Text", bestellungBindingSource, "KundenNr", true));
            TxtKundenNr.Location = new Point(389, 360);
            TxtKundenNr.Name = "TxtKundenNr";
            TxtKundenNr.ReadOnly = true;
            TxtKundenNr.Size = new Size(150, 31);
            TxtKundenNr.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(287, 363);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 6;
            label2.Text = "Kunden Nr";
            // 
            // TxtBestellNr
            // 
            TxtBestellNr.DataBindings.Add(new Binding("DataContext", bestellungBindingSource, "BestellNr", true));
            TxtBestellNr.DataBindings.Add(new Binding("Text", bestellungBindingSource, "BestellNr", true));
            TxtBestellNr.Location = new Point(98, 360);
            TxtBestellNr.Name = "TxtBestellNr";
            TxtBestellNr.ReadOnly = true;
            TxtBestellNr.Size = new Size(150, 31);
            TxtBestellNr.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 363);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 4;
            label1.Text = "Bestell Nr";
            // 
            // CmdNachKundeFiltern
            // 
            CmdNachKundeFiltern.Location = new Point(825, 30);
            CmdNachKundeFiltern.Name = "CmdNachKundeFiltern";
            CmdNachKundeFiltern.Size = new Size(189, 34);
            CmdNachKundeFiltern.TabIndex = 3;
            CmdNachKundeFiltern.Text = "Nach Kunde filtern";
            CmdNachKundeFiltern.UseVisualStyleBackColor = true;
            CmdNachKundeFiltern.Click += CmdNachKundeFiltern_Click;
            // 
            // CmdAlleBestellungen
            // 
            CmdAlleBestellungen.Location = new Point(603, 30);
            CmdAlleBestellungen.Name = "CmdAlleBestellungen";
            CmdAlleBestellungen.Size = new Size(216, 34);
            CmdAlleBestellungen.TabIndex = 2;
            CmdAlleBestellungen.Text = "Alle Bestellungen";
            CmdAlleBestellungen.UseVisualStyleBackColor = true;
            CmdAlleBestellungen.Click += CmdAlleBestellungen_Click;
            // 
            // CmdKundeÜbernehmen
            // 
            CmdKundeÜbernehmen.Location = new Point(6, 30);
            CmdKundeÜbernehmen.Name = "CmdKundeÜbernehmen";
            CmdKundeÜbernehmen.Size = new Size(206, 34);
            CmdKundeÜbernehmen.TabIndex = 1;
            CmdKundeÜbernehmen.Text = "Kunde übernehmen";
            CmdKundeÜbernehmen.UseVisualStyleBackColor = true;
            CmdKundeÜbernehmen.Click += CmdKundeÜbernehmen_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.CausesValidation = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { bestellNrDataGridViewTextBoxColumn, kundenNrDataGridViewTextBoxColumn, textDataGridViewTextBoxColumn, preisDataGridViewTextBoxColumn, datumDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bestellungBindingSource;
            dataGridView1.Location = new Point(0, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1014, 269);
            dataGridView1.TabIndex = 0;
            // 
            // bestellNrDataGridViewTextBoxColumn
            // 
            bestellNrDataGridViewTextBoxColumn.DataPropertyName = "BestellNr";
            bestellNrDataGridViewTextBoxColumn.HeaderText = "BestellNr";
            bestellNrDataGridViewTextBoxColumn.MinimumWidth = 8;
            bestellNrDataGridViewTextBoxColumn.Name = "bestellNrDataGridViewTextBoxColumn";
            bestellNrDataGridViewTextBoxColumn.ReadOnly = true;
            bestellNrDataGridViewTextBoxColumn.Width = 150;
            // 
            // kundenNrDataGridViewTextBoxColumn
            // 
            kundenNrDataGridViewTextBoxColumn.DataPropertyName = "KundenNr";
            kundenNrDataGridViewTextBoxColumn.HeaderText = "KundenNr";
            kundenNrDataGridViewTextBoxColumn.MinimumWidth = 8;
            kundenNrDataGridViewTextBoxColumn.Name = "kundenNrDataGridViewTextBoxColumn";
            kundenNrDataGridViewTextBoxColumn.ReadOnly = true;
            kundenNrDataGridViewTextBoxColumn.Width = 150;
            // 
            // textDataGridViewTextBoxColumn
            // 
            textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            textDataGridViewTextBoxColumn.HeaderText = "Text";
            textDataGridViewTextBoxColumn.MinimumWidth = 8;
            textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            textDataGridViewTextBoxColumn.ReadOnly = true;
            textDataGridViewTextBoxColumn.Width = 150;
            // 
            // preisDataGridViewTextBoxColumn
            // 
            preisDataGridViewTextBoxColumn.DataPropertyName = "Preis";
            preisDataGridViewTextBoxColumn.HeaderText = "Preis";
            preisDataGridViewTextBoxColumn.MinimumWidth = 8;
            preisDataGridViewTextBoxColumn.Name = "preisDataGridViewTextBoxColumn";
            preisDataGridViewTextBoxColumn.ReadOnly = true;
            preisDataGridViewTextBoxColumn.Width = 150;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            datumDataGridViewTextBoxColumn.MinimumWidth = 8;
            datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            datumDataGridViewTextBoxColumn.ReadOnly = true;
            datumDataGridViewTextBoxColumn.Width = 150;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TxtAusgewählterKunde);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Location = new Point(12, 492);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1026, 296);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kunden";
            // 
            // TxtAusgewählterKunde
            // 
            TxtAusgewählterKunde.DataBindings.Add(new Binding("Text", kundeBindingSource, "KundenNr", true));
            TxtAusgewählterKunde.Location = new Point(151, 259);
            TxtAusgewählterKunde.Name = "TxtAusgewählterKunde";
            TxtAusgewählterKunde.ReadOnly = true;
            TxtAusgewählterKunde.Size = new Size(150, 31);
            TxtAusgewählterKunde.TabIndex = 16;
            // 
            // kundeBindingSource
            // 
            kundeBindingSource.DataSource = typeof(Models.Kunde);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 262);
            label7.Name = "label7";
            label7.Size = new Size(139, 25);
            label7.TabIndex = 15;
            label7.Text = "Kundennummer";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { kundenNrDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn, adresseDataGridViewTextBoxColumn, plzDataGridViewTextBoxColumn, ortDataGridViewTextBoxColumn, telefonDataGridViewTextBoxColumn });
            dataGridView2.DataSource = kundeBindingSource;
            dataGridView2.Location = new Point(6, 30);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(1008, 225);
            dataGridView2.TabIndex = 0;
            // 
            // kundenNrDataGridViewTextBoxColumn1
            // 
            kundenNrDataGridViewTextBoxColumn1.DataPropertyName = "KundenNr";
            kundenNrDataGridViewTextBoxColumn1.HeaderText = "KundenNr";
            kundenNrDataGridViewTextBoxColumn1.MinimumWidth = 8;
            kundenNrDataGridViewTextBoxColumn1.Name = "kundenNrDataGridViewTextBoxColumn1";
            kundenNrDataGridViewTextBoxColumn1.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            adresseDataGridViewTextBoxColumn.MinimumWidth = 8;
            adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            adresseDataGridViewTextBoxColumn.Width = 150;
            // 
            // plzDataGridViewTextBoxColumn
            // 
            plzDataGridViewTextBoxColumn.DataPropertyName = "Plz";
            plzDataGridViewTextBoxColumn.HeaderText = "Plz";
            plzDataGridViewTextBoxColumn.MinimumWidth = 8;
            plzDataGridViewTextBoxColumn.Name = "plzDataGridViewTextBoxColumn";
            plzDataGridViewTextBoxColumn.Width = 150;
            // 
            // ortDataGridViewTextBoxColumn
            // 
            ortDataGridViewTextBoxColumn.DataPropertyName = "Ort";
            ortDataGridViewTextBoxColumn.HeaderText = "Ort";
            ortDataGridViewTextBoxColumn.MinimumWidth = 8;
            ortDataGridViewTextBoxColumn.Name = "ortDataGridViewTextBoxColumn";
            ortDataGridViewTextBoxColumn.Width = 150;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            telefonDataGridViewTextBoxColumn.MinimumWidth = 8;
            telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            telefonDataGridViewTextBoxColumn.Width = 150;
            // 
            // CmdSpeichern
            // 
            CmdSpeichern.Location = new Point(389, 12);
            CmdSpeichern.Name = "CmdSpeichern";
            CmdSpeichern.Size = new Size(112, 34);
            CmdSpeichern.TabIndex = 2;
            CmdSpeichern.Text = "Speichern";
            CmdSpeichern.UseVisualStyleBackColor = true;
            CmdSpeichern.Click += CmdSpeichern_Click;
            // 
            // CmdHinzufügen
            // 
            CmdHinzufügen.Location = new Point(271, 12);
            CmdHinzufügen.Name = "CmdHinzufügen";
            CmdHinzufügen.Size = new Size(112, 34);
            CmdHinzufügen.TabIndex = 3;
            CmdHinzufügen.Text = "Hinzufügen";
            CmdHinzufügen.UseVisualStyleBackColor = true;
            CmdHinzufügen.Click += CmdHinzufügen_Click;
            // 
            // CmdLöschen
            // 
            CmdLöschen.Location = new Point(507, 12);
            CmdLöschen.Name = "CmdLöschen";
            CmdLöschen.Size = new Size(112, 34);
            CmdLöschen.TabIndex = 4;
            CmdLöschen.Text = "Löschen";
            CmdLöschen.UseVisualStyleBackColor = true;
            CmdLöschen.Click += CmdLöschen_Click;
            // 
            // FrmBestellungen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 800);
            Controls.Add(CmdLöschen);
            Controls.Add(CmdHinzufügen);
            Controls.Add(CmdSpeichern);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmBestellungen";
            Text = "Form1";
            Load += FrmBestellungen_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bestellungBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kundeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private BindingSource bestellungBindingSource;
        private DataGridViewTextBoxColumn bestellNrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kundenNrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn preisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private Button CmdNachKundeFiltern;
        private Button CmdAlleBestellungen;
        private Button CmdKundeÜbernehmen;
        private DateTimePicker DatDatum;
        private Label label6;
        private Label label5;
        private TextBox TxtPreis;
        private Label label4;
        private TextBox TxtBestelltext;
        private Label label3;
        private TextBox TxtKundenNr;
        private Label label2;
        private TextBox TxtBestellNr;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox TxtAusgewählterKunde;
        private BindingSource kundeBindingSource;
        private Label label7;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn kundenNrDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn plzDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ortDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private Button CmdSpeichern;
        private Button CmdHinzufügen;
        private Button CmdLöschen;
        private Button CmdSortieren;
    }
}
