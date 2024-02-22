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
            GrpBestellungen = new GroupBox();
            CmdHinzufügen = new Button();
            CmdPreisSortieren = new Button();
            CmdLöschen = new Button();
            CmdSpeichern = new Button();
            DatDatum = new DateTimePicker();
            bestellungBindingSource = new BindingSource(components);
            label6 = new Label();
            TxtPreis = new TextBox();
            TxtBestellNr = new TextBox();
            TxtKundenNr = new TextBox();
            TxtBestelltext = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            CmdFiltern = new Button();
            CmdBestellungen = new Button();
            CmdÜbernehmen = new Button();
            dataGridView1 = new DataGridView();
            bestellNrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kundenNrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            textDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            preisDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            datumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bindingSource1 = new BindingSource(components);
            GrpKunden = new GroupBox();
            TxtAusgewählterKunde = new TextBox();
            kundeBindingSource1 = new BindingSource(components);
            label7 = new Label();
            dataGridView2 = new DataGridView();
            kundenNrDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adresseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            plzDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ortDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kundeBindingSource = new BindingSource(components);
            GrpBestellungen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bestellungBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            GrpKunden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kundeBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kundeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // GrpBestellungen
            // 
            GrpBestellungen.Controls.Add(CmdHinzufügen);
            GrpBestellungen.Controls.Add(CmdPreisSortieren);
            GrpBestellungen.Controls.Add(CmdLöschen);
            GrpBestellungen.Controls.Add(CmdSpeichern);
            GrpBestellungen.Controls.Add(DatDatum);
            GrpBestellungen.Controls.Add(label6);
            GrpBestellungen.Controls.Add(TxtPreis);
            GrpBestellungen.Controls.Add(TxtBestellNr);
            GrpBestellungen.Controls.Add(TxtKundenNr);
            GrpBestellungen.Controls.Add(TxtBestelltext);
            GrpBestellungen.Controls.Add(label5);
            GrpBestellungen.Controls.Add(label4);
            GrpBestellungen.Controls.Add(label3);
            GrpBestellungen.Controls.Add(label2);
            GrpBestellungen.Controls.Add(label1);
            GrpBestellungen.Controls.Add(CmdFiltern);
            GrpBestellungen.Controls.Add(CmdBestellungen);
            GrpBestellungen.Controls.Add(CmdÜbernehmen);
            GrpBestellungen.Controls.Add(dataGridView1);
            GrpBestellungen.Location = new Point(12, 12);
            GrpBestellungen.Name = "GrpBestellungen";
            GrpBestellungen.Size = new Size(776, 348);
            GrpBestellungen.TabIndex = 0;
            GrpBestellungen.TabStop = false;
            GrpBestellungen.Text = "Bestellungen";
            // 
            // CmdHinzufügen
            // 
            CmdHinzufügen.Location = new Point(350, 0);
            CmdHinzufügen.Name = "CmdHinzufügen";
            CmdHinzufügen.Size = new Size(135, 23);
            CmdHinzufügen.TabIndex = 20;
            CmdHinzufügen.Text = "Hinzufügen";
            CmdHinzufügen.UseVisualStyleBackColor = true;
            CmdHinzufügen.Click += CmdHinzufügen_Click;
            // 
            // CmdPreisSortieren
            // 
            CmdPreisSortieren.Location = new Point(185, 39);
            CmdPreisSortieren.Name = "CmdPreisSortieren";
            CmdPreisSortieren.Size = new Size(135, 23);
            CmdPreisSortieren.TabIndex = 19;
            CmdPreisSortieren.Text = "Preis sortieren";
            CmdPreisSortieren.UseVisualStyleBackColor = true;
            CmdPreisSortieren.Click += CmdPreisSortieren_Click;
            // 
            // CmdLöschen
            // 
            CmdLöschen.Location = new Point(185, 0);
            CmdLöschen.Name = "CmdLöschen";
            CmdLöschen.Size = new Size(135, 23);
            CmdLöschen.TabIndex = 18;
            CmdLöschen.Text = "Löschen";
            CmdLöschen.UseVisualStyleBackColor = true;
            CmdLöschen.Click += CmdLöschen_Click;
            // 
            // CmdSpeichern
            // 
            CmdSpeichern.Location = new Point(516, 0);
            CmdSpeichern.Name = "CmdSpeichern";
            CmdSpeichern.Size = new Size(135, 23);
            CmdSpeichern.TabIndex = 17;
            CmdSpeichern.Text = "Speichern";
            CmdSpeichern.UseVisualStyleBackColor = true;
            CmdSpeichern.Click += CmdSpeichern_Click;
            // 
            // DatDatum
            // 
            DatDatum.DataBindings.Add(new Binding("DataContext", bestellungBindingSource, "Datum", true));
            DatDatum.DataBindings.Add(new Binding("Text", bestellungBindingSource, "Datum", true));
            DatDatum.Location = new Point(451, 277);
            DatDatum.Name = "DatDatum";
            DatDatum.Size = new Size(200, 23);
            DatDatum.TabIndex = 16;
            // 
            // bestellungBindingSource
            // 
            bestellungBindingSource.DataSource = typeof(Models.Bestellung);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(557, 311);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 15;
            label6.Text = "Euro";
            // 
            // TxtPreis
            // 
            TxtPreis.CausesValidation = false;
            TxtPreis.DataBindings.Add(new Binding("DataContext", bestellungBindingSource, "Preis", true));
            TxtPreis.DataBindings.Add(new Binding("Text", bestellungBindingSource, "Preis", true));
            TxtPreis.Location = new Point(451, 308);
            TxtPreis.Name = "TxtPreis";
            TxtPreis.Size = new Size(100, 23);
            TxtPreis.TabIndex = 14;
            // 
            // TxtBestellNr
            // 
            TxtBestellNr.DataBindings.Add(new Binding("DataContext", bestellungBindingSource, "BestellNr", true));
            TxtBestellNr.DataBindings.Add(new Binding("Text", bestellungBindingSource, "BestellNr", true));
            TxtBestellNr.Location = new Point(72, 277);
            TxtBestellNr.Name = "TxtBestellNr";
            TxtBestellNr.Size = new Size(121, 23);
            TxtBestellNr.TabIndex = 13;
            // 
            // TxtKundenNr
            // 
            TxtKundenNr.DataBindings.Add(new Binding("DataContext", bestellungBindingSource, "KundenNr", true));
            TxtKundenNr.DataBindings.Add(new Binding("Text", bestellungBindingSource, "KundenNr", true));
            TxtKundenNr.Location = new Point(272, 277);
            TxtKundenNr.Name = "TxtKundenNr";
            TxtKundenNr.Size = new Size(120, 23);
            TxtKundenNr.TabIndex = 12;
            // 
            // TxtBestelltext
            // 
            TxtBestelltext.DataBindings.Add(new Binding("DataContext", bestellungBindingSource, "Text", true));
            TxtBestelltext.DataBindings.Add(new Binding("Text", bestellungBindingSource, "Text", true));
            TxtBestelltext.Location = new Point(272, 308);
            TxtBestelltext.Name = "TxtBestelltext";
            TxtBestelltext.Size = new Size(120, 23);
            TxtBestelltext.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(407, 280);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 9;
            label5.Text = "Datum:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(407, 311);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 8;
            label4.Text = "Preis";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(199, 311);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 7;
            label3.Text = "Bestelltext:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 280);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 6;
            label2.Text = "Kunden Nr.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 280);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 5;
            label1.Text = "Bestell Nr.";
            // 
            // CmdFiltern
            // 
            CmdFiltern.Location = new Point(516, 39);
            CmdFiltern.Name = "CmdFiltern";
            CmdFiltern.Size = new Size(135, 23);
            CmdFiltern.TabIndex = 4;
            CmdFiltern.Text = "Nach Kunde filtern";
            CmdFiltern.UseVisualStyleBackColor = true;
            CmdFiltern.Click += CmdFiltern_Click;
            // 
            // CmdBestellungen
            // 
            CmdBestellungen.Location = new Point(350, 39);
            CmdBestellungen.Name = "CmdBestellungen";
            CmdBestellungen.Size = new Size(135, 23);
            CmdBestellungen.TabIndex = 3;
            CmdBestellungen.Text = "Alle Bestellungen";
            CmdBestellungen.UseVisualStyleBackColor = true;
            CmdBestellungen.Click += CmdBestellungen_Click;
            // 
            // CmdÜbernehmen
            // 
            CmdÜbernehmen.Location = new Point(20, 39);
            CmdÜbernehmen.Name = "CmdÜbernehmen";
            CmdÜbernehmen.Size = new Size(135, 23);
            CmdÜbernehmen.TabIndex = 2;
            CmdÜbernehmen.Text = "Kunde übernehmen";
            CmdÜbernehmen.UseVisualStyleBackColor = true;
            CmdÜbernehmen.Click += CmdÜbernehmen_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { bestellNrDataGridViewTextBoxColumn, kundenNrDataGridViewTextBoxColumn, textDataGridViewTextBoxColumn, preisDataGridViewTextBoxColumn, datumDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bestellungBindingSource;
            dataGridView1.Location = new Point(0, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(675, 176);
            dataGridView1.TabIndex = 1;
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
            // GrpKunden
            // 
            GrpKunden.Controls.Add(TxtAusgewählterKunde);
            GrpKunden.Controls.Add(label7);
            GrpKunden.Controls.Add(dataGridView2);
            GrpKunden.Location = new Point(18, 366);
            GrpKunden.Name = "GrpKunden";
            GrpKunden.Size = new Size(770, 305);
            GrpKunden.TabIndex = 17;
            GrpKunden.TabStop = false;
            GrpKunden.Text = "Kunden";
            // 
            // TxtAusgewählterKunde
            // 
            TxtAusgewählterKunde.DataBindings.Add(new Binding("DataContext", kundeBindingSource1, "KundenNr", true));
            TxtAusgewählterKunde.DataBindings.Add(new Binding("Text", kundeBindingSource1, "KundenNr", true));
            TxtAusgewählterKunde.Location = new Point(114, 188);
            TxtAusgewählterKunde.Name = "TxtAusgewählterKunde";
            TxtAusgewählterKunde.Size = new Size(100, 23);
            TxtAusgewählterKunde.TabIndex = 7;
            // 
            // kundeBindingSource1
            // 
            kundeBindingSource1.DataSource = typeof(Models.Kunde);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 191);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 6;
            label7.Text = "Kundennummer";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { kundenNrDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn, adresseDataGridViewTextBoxColumn, plzDataGridViewTextBoxColumn, ortDataGridViewTextBoxColumn, telefonDataGridViewTextBoxColumn });
            dataGridView2.DataSource = kundeBindingSource1;
            dataGridView2.Location = new Point(6, 22);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(663, 150);
            dataGridView2.TabIndex = 0;
            // 
            // kundenNrDataGridViewTextBoxColumn1
            // 
            kundenNrDataGridViewTextBoxColumn1.DataPropertyName = "KundenNr";
            kundenNrDataGridViewTextBoxColumn1.HeaderText = "KundenNr";
            kundenNrDataGridViewTextBoxColumn1.Name = "kundenNrDataGridViewTextBoxColumn1";
            kundenNrDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            adresseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plzDataGridViewTextBoxColumn
            // 
            plzDataGridViewTextBoxColumn.DataPropertyName = "Plz";
            plzDataGridViewTextBoxColumn.HeaderText = "Plz";
            plzDataGridViewTextBoxColumn.Name = "plzDataGridViewTextBoxColumn";
            plzDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ortDataGridViewTextBoxColumn
            // 
            ortDataGridViewTextBoxColumn.DataPropertyName = "Ort";
            ortDataGridViewTextBoxColumn.HeaderText = "Ort";
            ortDataGridViewTextBoxColumn.Name = "ortDataGridViewTextBoxColumn";
            ortDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kundeBindingSource
            // 
            kundeBindingSource.DataSource = typeof(Models.Kunde);
            // 
            // FrmBestellungen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 671);
            Controls.Add(GrpKunden);
            Controls.Add(GrpBestellungen);
            Name = "FrmBestellungen";
            Text = "Form1";
            Load += FrmBestellungen_Load;
            GrpBestellungen.ResumeLayout(false);
            GrpBestellungen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bestellungBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            GrpKunden.ResumeLayout(false);
            GrpKunden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kundeBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)kundeBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GrpBestellungen;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn bestellNrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kundenNrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn preisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private BindingSource bestellungBindingSource;
        private BindingSource bindingSource1;
        private Button CmdFiltern;
        private Button CmdBestellungen;
        private Button CmdÜbernehmen;
        private TextBox TxtPreis;
        private TextBox TxtBestellNr;
        private TextBox TxtKundenNr;
        private TextBox TxtBestelltext;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker DatDatum;
        private Label label6;
        private GroupBox GrpKunden;
        private DataGridView dataGridView2;
        private BindingSource kundeBindingSource1;
        private BindingSource kundeBindingSource;
        private TextBox TxtAusgewählterKunde;
        private Label label7;
        private DataGridViewTextBoxColumn kundenNrDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn plzDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ortDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private Button CmdSpeichern;
        private Button CmdLöschen;
        private Button CmdPreisSortieren;
        private Button CmdHinzufügen;
    }
}
