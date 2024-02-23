// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Mitarbeiterverwaltung
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
            TxtNachname = new TextBox();
            TxtVorname = new TextBox();
            label2 = new Label();
            label1 = new Label();
            CmdMitarbeiterÜbernehmen = new Button();
            CmdNachnameSortieren = new Button();
            CmdVornameSortieren = new Button();
            CmdFilter = new Button();
            CmdAlleAnzeigen = new Button();
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
            CmdHinzufügen = new Button();
            CmdLöschen = new Button();
            TxtAbteilungsNr = new TextBox();
            TxtBezeichnung = new TextBox();
            CmdAbteilungLöschen = new Button();
            CmdAbteilungBearbeiten = new Button();
            CmdAbteilungHinzufügen = new Button();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            abteilungsNrDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            bezeichnungDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            abteilungBindingSource = new BindingSource(components);
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
            groupBox1.Controls.Add(TxtNachname);
            groupBox1.Controls.Add(TxtVorname);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(CmdMitarbeiterÜbernehmen);
            groupBox1.Controls.Add(CmdNachnameSortieren);
            groupBox1.Controls.Add(CmdVornameSortieren);
            groupBox1.Controls.Add(CmdFilter);
            groupBox1.Controls.Add(CmdAlleAnzeigen);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1055, 437);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mitarbeiter";
            // 
            // TxtNachname
            // 
            TxtNachname.Location = new Point(131, 347);
            TxtNachname.Name = "TxtNachname";
            TxtNachname.Size = new Size(207, 23);
            TxtNachname.TabIndex = 9;
            // 
            // TxtVorname
            // 
            TxtVorname.Location = new Point(131, 379);
            TxtVorname.Name = "TxtVorname";
            TxtVorname.Size = new Size(207, 23);
            TxtVorname.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 382);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 7;
            label2.Text = "Vorname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 350);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 6;
            label1.Text = "Nachname";
            // 
            // CmdMitarbeiterÜbernehmen
            // 
            CmdMitarbeiterÜbernehmen.Location = new Point(683, 379);
            CmdMitarbeiterÜbernehmen.Name = "CmdMitarbeiterÜbernehmen";
            CmdMitarbeiterÜbernehmen.Size = new Size(174, 52);
            CmdMitarbeiterÜbernehmen.TabIndex = 5;
            CmdMitarbeiterÜbernehmen.Text = "Mitarbeiter in ausgewählte Abteilung übernehmen";
            CmdMitarbeiterÜbernehmen.UseVisualStyleBackColor = true;
            // 
            // CmdNachnameSortieren
            // 
            CmdNachnameSortieren.Location = new Point(460, 379);
            CmdNachnameSortieren.Name = "CmdNachnameSortieren";
            CmdNachnameSortieren.Size = new Size(164, 23);
            CmdNachnameSortieren.TabIndex = 4;
            CmdNachnameSortieren.Text = "Nach Nachname sortieren";
            CmdNachnameSortieren.UseVisualStyleBackColor = true;
            // 
            // CmdVornameSortieren
            // 
            CmdVornameSortieren.Location = new Point(460, 408);
            CmdVornameSortieren.Name = "CmdVornameSortieren";
            CmdVornameSortieren.Size = new Size(164, 23);
            CmdVornameSortieren.TabIndex = 3;
            CmdVornameSortieren.Text = "Nach Vorname sortieren";
            CmdVornameSortieren.UseVisualStyleBackColor = true;
            // 
            // CmdFilter
            // 
            CmdFilter.Location = new Point(131, 408);
            CmdFilter.Name = "CmdFilter";
            CmdFilter.Size = new Size(94, 23);
            CmdFilter.TabIndex = 2;
            CmdFilter.Text = "Filtern";
            CmdFilter.UseVisualStyleBackColor = true;
            CmdFilter.Click += CmdFilter_Click;
            // 
            // CmdAlleAnzeigen
            // 
            CmdAlleAnzeigen.Location = new Point(247, 408);
            CmdAlleAnzeigen.Name = "CmdAlleAnzeigen";
            CmdAlleAnzeigen.Size = new Size(91, 23);
            CmdAlleAnzeigen.TabIndex = 1;
            CmdAlleAnzeigen.Text = "Alle Anzeigen";
            CmdAlleAnzeigen.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { personalNrDataGridViewTextBoxColumn, abteilungsNrDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, vornameDataGridViewTextBoxColumn, stellenbezeichnungDataGridViewTextBoxColumn, adresseDataGridViewTextBoxColumn, plzDataGridViewTextBoxColumn, ortDataGridViewTextBoxColumn, telefonDataGridViewTextBoxColumn });
            dataGridView1.DataSource = mitarbeiterBindingSource;
            dataGridView1.Location = new Point(3, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1043, 322);
            dataGridView1.TabIndex = 0;
            // 
            // personalNrDataGridViewTextBoxColumn
            // 
            personalNrDataGridViewTextBoxColumn.DataPropertyName = "PersonalNr";
            personalNrDataGridViewTextBoxColumn.HeaderText = "PersonalNr";
            personalNrDataGridViewTextBoxColumn.Name = "personalNrDataGridViewTextBoxColumn";
            personalNrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // abteilungsNrDataGridViewTextBoxColumn
            // 
            abteilungsNrDataGridViewTextBoxColumn.DataPropertyName = "AbteilungsNr";
            abteilungsNrDataGridViewTextBoxColumn.HeaderText = "AbteilungsNr";
            abteilungsNrDataGridViewTextBoxColumn.Name = "abteilungsNrDataGridViewTextBoxColumn";
            abteilungsNrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vornameDataGridViewTextBoxColumn
            // 
            vornameDataGridViewTextBoxColumn.DataPropertyName = "Vorname";
            vornameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            vornameDataGridViewTextBoxColumn.Name = "vornameDataGridViewTextBoxColumn";
            vornameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stellenbezeichnungDataGridViewTextBoxColumn
            // 
            stellenbezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Stellenbezeichnung";
            stellenbezeichnungDataGridViewTextBoxColumn.HeaderText = "Stellenbezeichnung";
            stellenbezeichnungDataGridViewTextBoxColumn.Name = "stellenbezeichnungDataGridViewTextBoxColumn";
            stellenbezeichnungDataGridViewTextBoxColumn.ReadOnly = true;
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
            // mitarbeiterBindingSource
            // 
            mitarbeiterBindingSource.DataSource = typeof(Models.Mitarbeiter);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(CmdHinzufügen);
            groupBox2.Controls.Add(CmdLöschen);
            groupBox2.Controls.Add(TxtAbteilungsNr);
            groupBox2.Controls.Add(TxtBezeichnung);
            groupBox2.Controls.Add(CmdAbteilungLöschen);
            groupBox2.Controls.Add(CmdAbteilungBearbeiten);
            groupBox2.Controls.Add(CmdAbteilungHinzufügen);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Location = new Point(3, 443);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1043, 352);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Abteilungen";
            // 
            // CmdHinzufügen
            // 
            CmdHinzufügen.Location = new Point(512, 323);
            CmdHinzufügen.Name = "CmdHinzufügen";
            CmdHinzufügen.Size = new Size(95, 23);
            CmdHinzufügen.TabIndex = 9;
            CmdHinzufügen.Text = "Hinzufügen";
            CmdHinzufügen.UseVisualStyleBackColor = true;
            CmdHinzufügen.Click += CmdHinzufügen_Click;
            // 
            // CmdLöschen
            // 
            CmdLöschen.Location = new Point(623, 323);
            CmdLöschen.Name = "CmdLöschen";
            CmdLöschen.Size = new Size(95, 23);
            CmdLöschen.TabIndex = 8;
            CmdLöschen.Text = "Löschen";
            CmdLöschen.UseVisualStyleBackColor = true;
            // 
            // TxtAbteilungsNr
            // 
            TxtAbteilungsNr.Location = new Point(148, 233);
            TxtAbteilungsNr.Name = "TxtAbteilungsNr";
            TxtAbteilungsNr.Size = new Size(57, 23);
            TxtAbteilungsNr.TabIndex = 7;
            // 
            // TxtBezeichnung
            // 
            TxtBezeichnung.Location = new Point(225, 233);
            TxtBezeichnung.Name = "TxtBezeichnung";
            TxtBezeichnung.Size = new Size(132, 23);
            TxtBezeichnung.TabIndex = 6;
            // 
            // CmdAbteilungLöschen
            // 
            CmdAbteilungLöschen.Location = new Point(9, 323);
            CmdAbteilungLöschen.Name = "CmdAbteilungLöschen";
            CmdAbteilungLöschen.Size = new Size(133, 23);
            CmdAbteilungLöschen.TabIndex = 5;
            CmdAbteilungLöschen.Text = "Abteilung löschen";
            CmdAbteilungLöschen.UseVisualStyleBackColor = true;
            // 
            // CmdAbteilungBearbeiten
            // 
            CmdAbteilungBearbeiten.Location = new Point(9, 294);
            CmdAbteilungBearbeiten.Name = "CmdAbteilungBearbeiten";
            CmdAbteilungBearbeiten.Size = new Size(133, 23);
            CmdAbteilungBearbeiten.TabIndex = 4;
            CmdAbteilungBearbeiten.Text = "Abteilung bearbeiten";
            CmdAbteilungBearbeiten.UseVisualStyleBackColor = true;
            // 
            // CmdAbteilungHinzufügen
            // 
            CmdAbteilungHinzufügen.Location = new Point(9, 265);
            CmdAbteilungHinzufügen.Name = "CmdAbteilungHinzufügen";
            CmdAbteilungHinzufügen.Size = new Size(133, 23);
            CmdAbteilungHinzufügen.TabIndex = 3;
            CmdAbteilungHinzufügen.Text = "Abteilung hinzufügen";
            CmdAbteilungHinzufügen.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 236);
            label3.Name = "label3";
            label3.Size = new Size(133, 15);
            label3.TabIndex = 2;
            label3.Text = "Ausgewählte Abteilung:";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { abteilungsNrDataGridViewTextBoxColumn1, bezeichnungDataGridViewTextBoxColumn });
            dataGridView2.DataSource = abteilungBindingSource;
            dataGridView2.Location = new Point(3, 19);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(1034, 203);
            dataGridView2.TabIndex = 0;
            // 
            // abteilungsNrDataGridViewTextBoxColumn1
            // 
            abteilungsNrDataGridViewTextBoxColumn1.DataPropertyName = "AbteilungsNr";
            abteilungsNrDataGridViewTextBoxColumn1.HeaderText = "AbteilungsNr";
            abteilungsNrDataGridViewTextBoxColumn1.Name = "abteilungsNrDataGridViewTextBoxColumn1";
            abteilungsNrDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bezeichnungDataGridViewTextBoxColumn
            // 
            bezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Bezeichnung";
            bezeichnungDataGridViewTextBoxColumn.HeaderText = "Bezeichnung";
            bezeichnungDataGridViewTextBoxColumn.Name = "bezeichnungDataGridViewTextBoxColumn";
            bezeichnungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // abteilungBindingSource
            // 
            abteilungBindingSource.DataSource = typeof(Models.Abteilung);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 848);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mitarbeiterBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)abteilungBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TxtNachname;
        private TextBox TxtVorname;
        private Label label2;
        private Label label1;
        private Button CmdMitarbeiterÜbernehmen;
        private Button CmdNachnameSortieren;
        private Button CmdVornameSortieren;
        private Button CmdFilter;
        private Button CmdAlleAnzeigen;
        private DataGridView dataGridView1;
        private BindingSource mitarbeiterBindingSource;
        private GroupBox groupBox2;
        private DataGridView dataGridView2;
        private BindingSource abteilungBindingSource;
        private TextBox TxtAbteilungsNr;
        private TextBox TxtBezeichnung;
        private Button CmdAbteilungLöschen;
        private Button CmdAbteilungBearbeiten;
        private Button CmdAbteilungHinzufügen;
        private Label label3;
        private Button CmdHinzufügen;
        private Button CmdLöschen;
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
    }
}
