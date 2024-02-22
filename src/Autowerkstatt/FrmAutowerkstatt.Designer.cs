// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Autowerkstatt
{
    partial class FrmAutowerkstatt
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            LblNummer = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            LblKennzeichen = new Label();
            LblMarke = new Label();
            LblModell = new Label();
            LblHalter = new Label();
            LblOrt = new Label();
            label18 = new Label();
            DatDatum = new DateTimePicker();
            TxtBeschreibung = new TextBox();
            TxtKosten = new TextBox();
            label19 = new Label();
            dataGridView1 = new DataGridView();
            nrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kennzeichenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            markeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modellDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            halterDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ortDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fahrzeugBindingSource = new BindingSource(components);
            CmdReparaturSpeichern = new Button();
            CmdFahrzeugÜbernehmen = new Button();
            CmdHinzufügen = new Button();
            CmdSpeichern = new Button();
            CmdLöschen = new Button();
            CmdReparaturenAnzeigen = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fahrzeugBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(255, 32);
            label1.TabIndex = 0;
            label1.Text = "Erfassung Reparatur:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 66);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 1;
            label2.Text = "Datum:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 100);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 2;
            label3.Text = "Beschreibung:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 248);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 3;
            label4.Text = "Kosten:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(285, 317);
            label5.Name = "label5";
            label5.Size = new Size(35, 25);
            label5.TabIndex = 4;
            label5.Text = "Nr:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 311);
            label6.Name = "label6";
            label6.Size = new Size(124, 32);
            label6.TabIndex = 5;
            label6.Text = "Fahrzeug:";
            // 
            // LblNummer
            // 
            LblNummer.AutoSize = true;
            LblNummer.Location = new Point(350, 318);
            LblNummer.Name = "LblNummer";
            LblNummer.Size = new Size(59, 25);
            LblNummer.TabIndex = 6;
            LblNummer.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 362);
            label8.Name = "label8";
            label8.Size = new Size(113, 25);
            label8.TabIndex = 7;
            label8.Text = "Kennzeichen:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(38, 387);
            label9.Name = "label9";
            label9.Size = new Size(65, 25);
            label9.TabIndex = 8;
            label9.Text = "Marke:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(38, 412);
            label10.Name = "label10";
            label10.Size = new Size(71, 25);
            label10.TabIndex = 9;
            label10.Text = "Modell:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(38, 472);
            label11.Name = "label11";
            label11.Size = new Size(63, 25);
            label11.TabIndex = 10;
            label11.Text = "Halter:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(38, 497);
            label12.Name = "label12";
            label12.Size = new Size(42, 25);
            label12.TabIndex = 11;
            label12.Text = "Ort:";
            // 
            // LblKennzeichen
            // 
            LblKennzeichen.AutoSize = true;
            LblKennzeichen.Location = new Point(167, 362);
            LblKennzeichen.Name = "LblKennzeichen";
            LblKennzeichen.Size = new Size(69, 25);
            LblKennzeichen.TabIndex = 12;
            LblKennzeichen.Text = "label13";
            // 
            // LblMarke
            // 
            LblMarke.AutoSize = true;
            LblMarke.Location = new Point(167, 387);
            LblMarke.Name = "LblMarke";
            LblMarke.Size = new Size(69, 25);
            LblMarke.TabIndex = 13;
            LblMarke.Text = "label14";
            // 
            // LblModell
            // 
            LblModell.AutoSize = true;
            LblModell.Location = new Point(167, 412);
            LblModell.Name = "LblModell";
            LblModell.Size = new Size(69, 25);
            LblModell.TabIndex = 14;
            LblModell.Text = "label15";
            // 
            // LblHalter
            // 
            LblHalter.AutoSize = true;
            LblHalter.Location = new Point(167, 472);
            LblHalter.Name = "LblHalter";
            LblHalter.Size = new Size(69, 25);
            LblHalter.TabIndex = 15;
            LblHalter.Text = "label16";
            // 
            // LblOrt
            // 
            LblOrt.AutoSize = true;
            LblOrt.Location = new Point(167, 497);
            LblOrt.Name = "LblOrt";
            LblOrt.Size = new Size(69, 25);
            LblOrt.TabIndex = 16;
            LblOrt.Text = "label17";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(573, 9);
            label18.Name = "label18";
            label18.Size = new Size(130, 32);
            label18.TabIndex = 17;
            label18.Text = "Fahrzeuge";
            // 
            // DatDatum
            // 
            DatDatum.Location = new Point(176, 60);
            DatDatum.Name = "DatDatum";
            DatDatum.Size = new Size(300, 31);
            DatDatum.TabIndex = 18;
            // 
            // TxtBeschreibung
            // 
            TxtBeschreibung.Location = new Point(176, 97);
            TxtBeschreibung.Multiline = true;
            TxtBeschreibung.Name = "TxtBeschreibung";
            TxtBeschreibung.Size = new Size(300, 139);
            TxtBeschreibung.TabIndex = 19;
            // 
            // TxtKosten
            // 
            TxtKosten.Location = new Point(176, 242);
            TxtKosten.Name = "TxtKosten";
            TxtKosten.Size = new Size(233, 31);
            TxtKosten.TabIndex = 20;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(415, 248);
            label19.Name = "label19";
            label19.Size = new Size(48, 25);
            label19.TabIndex = 21;
            label19.Text = "Euro";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nrDataGridViewTextBoxColumn, kennzeichenDataGridViewTextBoxColumn, markeDataGridViewTextBoxColumn, modellDataGridViewTextBoxColumn, halterDataGridViewTextBoxColumn, ortDataGridViewTextBoxColumn });
            dataGridView1.DataSource = fahrzeugBindingSource;
            dataGridView1.Location = new Point(573, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(870, 462);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // nrDataGridViewTextBoxColumn
            // 
            nrDataGridViewTextBoxColumn.DataPropertyName = "Nr";
            nrDataGridViewTextBoxColumn.HeaderText = "Nr";
            nrDataGridViewTextBoxColumn.MinimumWidth = 8;
            nrDataGridViewTextBoxColumn.Name = "nrDataGridViewTextBoxColumn";
            nrDataGridViewTextBoxColumn.ReadOnly = true;
            nrDataGridViewTextBoxColumn.Width = 50;
            // 
            // kennzeichenDataGridViewTextBoxColumn
            // 
            kennzeichenDataGridViewTextBoxColumn.DataPropertyName = "Kennzeichen";
            kennzeichenDataGridViewTextBoxColumn.HeaderText = "Kennzeichen";
            kennzeichenDataGridViewTextBoxColumn.MinimumWidth = 8;
            kennzeichenDataGridViewTextBoxColumn.Name = "kennzeichenDataGridViewTextBoxColumn";
            kennzeichenDataGridViewTextBoxColumn.ReadOnly = true;
            kennzeichenDataGridViewTextBoxColumn.Width = 150;
            // 
            // markeDataGridViewTextBoxColumn
            // 
            markeDataGridViewTextBoxColumn.DataPropertyName = "Marke";
            markeDataGridViewTextBoxColumn.HeaderText = "Marke";
            markeDataGridViewTextBoxColumn.MinimumWidth = 8;
            markeDataGridViewTextBoxColumn.Name = "markeDataGridViewTextBoxColumn";
            markeDataGridViewTextBoxColumn.ReadOnly = true;
            markeDataGridViewTextBoxColumn.Width = 150;
            // 
            // modellDataGridViewTextBoxColumn
            // 
            modellDataGridViewTextBoxColumn.DataPropertyName = "Modell";
            modellDataGridViewTextBoxColumn.HeaderText = "Modell";
            modellDataGridViewTextBoxColumn.MinimumWidth = 8;
            modellDataGridViewTextBoxColumn.Name = "modellDataGridViewTextBoxColumn";
            modellDataGridViewTextBoxColumn.ReadOnly = true;
            modellDataGridViewTextBoxColumn.Width = 150;
            // 
            // halterDataGridViewTextBoxColumn
            // 
            halterDataGridViewTextBoxColumn.DataPropertyName = "Halter";
            halterDataGridViewTextBoxColumn.HeaderText = "Halter";
            halterDataGridViewTextBoxColumn.MinimumWidth = 8;
            halterDataGridViewTextBoxColumn.Name = "halterDataGridViewTextBoxColumn";
            halterDataGridViewTextBoxColumn.ReadOnly = true;
            halterDataGridViewTextBoxColumn.Width = 150;
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
            // fahrzeugBindingSource
            // 
            fahrzeugBindingSource.DataSource = typeof(Models.Fahrzeug);
            // 
            // CmdReparaturSpeichern
            // 
            CmdReparaturSpeichern.Location = new Point(176, 528);
            CmdReparaturSpeichern.Name = "CmdReparaturSpeichern";
            CmdReparaturSpeichern.Size = new Size(112, 34);
            CmdReparaturSpeichern.TabIndex = 23;
            CmdReparaturSpeichern.Text = "Speichern";
            CmdReparaturSpeichern.UseVisualStyleBackColor = true;
            CmdReparaturSpeichern.Click += CmdReparaturSpeichern_Click;
            // 
            // CmdFahrzeugÜbernehmen
            // 
            CmdFahrzeugÜbernehmen.Location = new Point(573, 528);
            CmdFahrzeugÜbernehmen.Name = "CmdFahrzeugÜbernehmen";
            CmdFahrzeugÜbernehmen.Size = new Size(281, 34);
            CmdFahrzeugÜbernehmen.TabIndex = 24;
            CmdFahrzeugÜbernehmen.Text = "<<< Fahrzeug übernehmen";
            CmdFahrzeugÜbernehmen.UseVisualStyleBackColor = true;
            CmdFahrzeugÜbernehmen.Click += CmdFahrzeugÜbernehmen_Click;
            // 
            // CmdHinzufügen
            // 
            CmdHinzufügen.Location = new Point(799, 10);
            CmdHinzufügen.Name = "CmdHinzufügen";
            CmdHinzufügen.Size = new Size(112, 34);
            CmdHinzufügen.TabIndex = 25;
            CmdHinzufügen.Text = "Hinzufügen";
            CmdHinzufügen.UseVisualStyleBackColor = true;
            CmdHinzufügen.Click += CmdHinzufügen_Click;
            // 
            // CmdSpeichern
            // 
            CmdSpeichern.Location = new Point(917, 10);
            CmdSpeichern.Name = "CmdSpeichern";
            CmdSpeichern.Size = new Size(112, 34);
            CmdSpeichern.TabIndex = 26;
            CmdSpeichern.Text = "Speichern";
            CmdSpeichern.UseVisualStyleBackColor = true;
            // 
            // CmdLöschen
            // 
            CmdLöschen.Location = new Point(1035, 10);
            CmdLöschen.Name = "CmdLöschen";
            CmdLöschen.Size = new Size(112, 34);
            CmdLöschen.TabIndex = 27;
            CmdLöschen.Text = "Löschen";
            CmdLöschen.UseVisualStyleBackColor = true;
            // 
            // CmdReparaturenAnzeigen
            // 
            CmdReparaturenAnzeigen.Location = new Point(332, 10);
            CmdReparaturenAnzeigen.Name = "CmdReparaturenAnzeigen";
            CmdReparaturenAnzeigen.Size = new Size(214, 34);
            CmdReparaturenAnzeigen.TabIndex = 28;
            CmdReparaturenAnzeigen.Text = "Reparaturen anzeigen";
            CmdReparaturenAnzeigen.UseVisualStyleBackColor = true;
            CmdReparaturenAnzeigen.Click += CmdReparaturenAnzeigen_Click;
            // 
            // FrmAutowerkstatt
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1448, 578);
            Controls.Add(CmdReparaturenAnzeigen);
            Controls.Add(CmdLöschen);
            Controls.Add(CmdSpeichern);
            Controls.Add(CmdHinzufügen);
            Controls.Add(CmdFahrzeugÜbernehmen);
            Controls.Add(CmdReparaturSpeichern);
            Controls.Add(dataGridView1);
            Controls.Add(label19);
            Controls.Add(TxtKosten);
            Controls.Add(TxtBeschreibung);
            Controls.Add(DatDatum);
            Controls.Add(label18);
            Controls.Add(LblOrt);
            Controls.Add(LblHalter);
            Controls.Add(LblModell);
            Controls.Add(LblMarke);
            Controls.Add(LblKennzeichen);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(LblNummer);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAutowerkstatt";
            Text = "Autowerkstatt Helferlein";
            Load += FrmAutowerkstatt_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fahrzeugBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label LblNummer;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label LblKennzeichen;
        private Label LblMarke;
        private Label LblModell;
        private Label LblHalter;
        private Label LblOrt;
        private Label label18;
        private DateTimePicker DatDatum;
        private TextBox TxtBeschreibung;
        private TextBox TxtKosten;
        private Label label19;
        private DataGridView dataGridView1;
        private Button CmdReparaturSpeichern;
        private Button CmdFahrzeugÜbernehmen;
        private Button CmdHinzufügen;
        private Button CmdSpeichern;
        private Button CmdLöschen;
        private DataGridViewTextBoxColumn nrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kennzeichenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn markeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modellDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn halterDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ortDataGridViewTextBoxColumn;
        private BindingSource fahrzeugBindingSource;
        private Button CmdReparaturenAnzeigen;
    }
}
