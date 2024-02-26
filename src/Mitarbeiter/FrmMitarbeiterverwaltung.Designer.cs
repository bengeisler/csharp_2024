// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Mitarbeiterverwaltung
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
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            mitarbeiterBindingSource = new BindingSource(components);
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
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            abteilungBindingSource = new BindingSource(components);
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
            CmdMitarbeiterHinzufügen.Click += CmdMitarbeiterHinzufügen_Click;
            // 
            // CmdMitarbeiterLöschen
            // 
            CmdMitarbeiterLöschen.Location = new Point(516, 351);
            CmdMitarbeiterLöschen.Name = "CmdMitarbeiterLöschen";
            CmdMitarbeiterLöschen.Size = new Size(236, 34);
            CmdMitarbeiterLöschen.TabIndex = 1;
            CmdMitarbeiterLöschen.Text = "Mitarbeiter löschen";
            CmdMitarbeiterLöschen.UseVisualStyleBackColor = true;
            CmdMitarbeiterLöschen.Click += CmdMitarbeiterLöschen_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9 });
            dataGridView1.DataSource = mitarbeiterBindingSource;
            dataGridView1.Location = new Point(12, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1422, 225);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "PersonalNr";
            dataGridViewTextBoxColumn1.HeaderText = "PersonalNr";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "AbteilungsNr";
            dataGridViewTextBoxColumn2.HeaderText = "AbteilungsNr";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Name";
            dataGridViewTextBoxColumn3.HeaderText = "Name";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Vorname";
            dataGridViewTextBoxColumn4.HeaderText = "Vorname";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Stellenbezeichnung";
            dataGridViewTextBoxColumn5.HeaderText = "Stellenbezeichnung";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Adresse";
            dataGridViewTextBoxColumn6.HeaderText = "Adresse";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "Plz";
            dataGridViewTextBoxColumn7.HeaderText = "Plz";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "Ort";
            dataGridViewTextBoxColumn8.HeaderText = "Ort";
            dataGridViewTextBoxColumn8.MinimumWidth = 8;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "Telefon";
            dataGridViewTextBoxColumn9.HeaderText = "Telefon";
            dataGridViewTextBoxColumn9.MinimumWidth = 8;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Width = 150;
            // 
            // mitarbeiterBindingSource
            // 
            mitarbeiterBindingSource.DataSource = typeof(Models.Mitarbeiter);
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
            CmdFiltern.Click += CmdFiltern_Click;
            // 
            // CmdAlleAnzeigen
            // 
            CmdAlleAnzeigen.Location = new Point(298, 390);
            CmdAlleAnzeigen.Name = "CmdAlleAnzeigen";
            CmdAlleAnzeigen.Size = new Size(161, 34);
            CmdAlleAnzeigen.TabIndex = 9;
            CmdAlleAnzeigen.Text = "Alle anzeigen";
            CmdAlleAnzeigen.UseVisualStyleBackColor = true;
            CmdAlleAnzeigen.Click += CmdAlleAnzeigen_Click;
            // 
            // CmdNachNachnameSortieren
            // 
            CmdNachNachnameSortieren.Location = new Point(819, 314);
            CmdNachNachnameSortieren.Name = "CmdNachNachnameSortieren";
            CmdNachNachnameSortieren.Size = new Size(259, 34);
            CmdNachNachnameSortieren.TabIndex = 10;
            CmdNachNachnameSortieren.Text = "Nach Nachname sortieren";
            CmdNachNachnameSortieren.UseVisualStyleBackColor = true;
            CmdNachNachnameSortieren.Click += CmdNachNachnameSortieren_Click;
            // 
            // CmdNachVornameSortieren
            // 
            CmdNachVornameSortieren.Location = new Point(819, 351);
            CmdNachVornameSortieren.Name = "CmdNachVornameSortieren";
            CmdNachVornameSortieren.Size = new Size(259, 34);
            CmdNachVornameSortieren.TabIndex = 11;
            CmdNachVornameSortieren.Text = "Nach Vorname sortieren";
            CmdNachVornameSortieren.UseVisualStyleBackColor = true;
            CmdNachVornameSortieren.Click += CmdNachVornameSortieren_Click;
            // 
            // CmdMitarbeiterInAbteilungÜbernehmen
            // 
            CmdMitarbeiterInAbteilungÜbernehmen.Location = new Point(1146, 313);
            CmdMitarbeiterInAbteilungÜbernehmen.Name = "CmdMitarbeiterInAbteilungÜbernehmen";
            CmdMitarbeiterInAbteilungÜbernehmen.Size = new Size(288, 66);
            CmdMitarbeiterInAbteilungÜbernehmen.TabIndex = 12;
            CmdMitarbeiterInAbteilungÜbernehmen.Text = "Mitarbeiter in ausgewählte Abteilung übernehmen";
            CmdMitarbeiterInAbteilungÜbernehmen.UseVisualStyleBackColor = true;
            CmdMitarbeiterInAbteilungÜbernehmen.Click += CmdMitarbeiterInAbteilungÜbernehmen_Click;
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
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11 });
            dataGridView2.DataSource = abteilungBindingSource;
            dataGridView2.Location = new Point(12, 484);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(1422, 225);
            dataGridView2.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "AbteilungsNr";
            dataGridViewTextBoxColumn10.HeaderText = "AbteilungsNr";
            dataGridViewTextBoxColumn10.MinimumWidth = 8;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "Bezeichnung";
            dataGridViewTextBoxColumn11.HeaderText = "Bezeichnung";
            dataGridViewTextBoxColumn11.MinimumWidth = 8;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            dataGridViewTextBoxColumn11.Width = 150;
            // 
            // abteilungBindingSource
            // 
            abteilungBindingSource.DataSource = typeof(Models.Abteilung);
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
            TxtAbteilungsnummer.DataBindings.Add(new Binding("Text", abteilungBindingSource, "AbteilungsNr", true));
            TxtAbteilungsnummer.Location = new Point(221, 722);
            TxtAbteilungsnummer.Name = "TxtAbteilungsnummer";
            TxtAbteilungsnummer.ReadOnly = true;
            TxtAbteilungsnummer.Size = new Size(41, 31);
            TxtAbteilungsnummer.TabIndex = 16;
            // 
            // TxtAbteilungsbezeichnung
            // 
            TxtAbteilungsbezeichnung.DataBindings.Add(new Binding("Text", abteilungBindingSource, "Bezeichnung", true));
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
            CmdAbteilungHinzufügen.Click += CmdAbteilungHinzufügen_Click;
            // 
            // CmdAbteilungBearbeiten
            // 
            CmdAbteilungBearbeiten.Location = new Point(956, 720);
            CmdAbteilungBearbeiten.Name = "CmdAbteilungBearbeiten";
            CmdAbteilungBearbeiten.Size = new Size(236, 34);
            CmdAbteilungBearbeiten.TabIndex = 19;
            CmdAbteilungBearbeiten.Text = "Abteilung bearbeiten";
            CmdAbteilungBearbeiten.UseVisualStyleBackColor = true;
            CmdAbteilungBearbeiten.Click += CmdAbteilungBearbeiten_Click;
            // 
            // CmdAbteilungLöschen
            // 
            CmdAbteilungLöschen.Location = new Point(1198, 720);
            CmdAbteilungLöschen.Name = "CmdAbteilungLöschen";
            CmdAbteilungLöschen.Size = new Size(236, 34);
            CmdAbteilungLöschen.TabIndex = 20;
            CmdAbteilungLöschen.Text = "Abteilung löschen";
            CmdAbteilungLöschen.UseVisualStyleBackColor = true;
            CmdAbteilungLöschen.Click += CmdAbteilungLöschen_Click;
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
            Load += FrmMitarbeiterverwaltung_Load;
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
        private Label label5;
        private TextBox TxtAbteilungsnummer;
        private TextBox TxtAbteilungsbezeichnung;
        private Button CmdAbteilungHinzufügen;
        private Button CmdAbteilungBearbeiten;
        private Button CmdAbteilungLöschen;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private BindingSource mitarbeiterBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private BindingSource abteilungBindingSource;
    }
}
