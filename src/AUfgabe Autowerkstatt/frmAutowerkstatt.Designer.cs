// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace AUfgabe_Autowerkstatt
{
    partial class FrmAutowerkstattHelfer
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
            LblErfassungReparatur = new Label();
            LblDatum = new Label();
            LblBeschreibung = new Label();
            LblKosten = new Label();
            dateTimePicker1 = new DateTimePicker();
            TxtBeschreibung = new TextBox();
            reparaturBindingSource = new BindingSource(components);
            TxtKosten = new TextBox();
            LblEuro = new Label();
            LblFahrzeug = new Label();
            fahrzeugBindingSource = new BindingSource(components);
            LblKennzeichen = new Label();
            LblMarke = new Label();
            LblModell = new Label();
            LblHalter = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            CmdSpeichern = new Button();
            label7 = new Label();
            LblOrt = new Label();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            nrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Kennzeichen = new DataGridViewTextBoxColumn();
            Marke = new DataGridViewTextBoxColumn();
            Modell = new DataGridViewTextBoxColumn();
            Halter = new DataGridViewTextBoxColumn();
            Ort = new DataGridViewTextBoxColumn();
            Reparaturs = new DataGridViewTextBoxColumn();
            CmdFahrzeuguebernehmen = new Button();
            CmdLöschen = new Button();
            CmdHinzufügen = new Button();
            CmdSpeichernFahrzeuge = new Button();
            CmdReparaturenanzeigen = new Button();
            ((System.ComponentModel.ISupportInitialize)reparaturBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fahrzeugBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LblErfassungReparatur
            // 
            LblErfassungReparatur.AutoSize = true;
            LblErfassungReparatur.Location = new Point(43, 24);
            LblErfassungReparatur.Name = "LblErfassungReparatur";
            LblErfassungReparatur.Size = new Size(112, 15);
            LblErfassungReparatur.TabIndex = 0;
            LblErfassungReparatur.Text = "Erfassung Reparatur";
            // 
            // LblDatum
            // 
            LblDatum.AutoSize = true;
            LblDatum.Location = new Point(43, 64);
            LblDatum.Name = "LblDatum";
            LblDatum.Size = new Size(43, 15);
            LblDatum.TabIndex = 1;
            LblDatum.Text = "Datum";
            // 
            // LblBeschreibung
            // 
            LblBeschreibung.AutoSize = true;
            LblBeschreibung.Location = new Point(48, 99);
            LblBeschreibung.Name = "LblBeschreibung";
            LblBeschreibung.Size = new Size(79, 15);
            LblBeschreibung.TabIndex = 2;
            LblBeschreibung.Text = "Beschreibung";
            // 
            // LblKosten
            // 
            LblKosten.AutoSize = true;
            LblKosten.Location = new Point(48, 251);
            LblKosten.Name = "LblKosten";
            LblKosten.Size = new Size(43, 15);
            LblKosten.TabIndex = 3;
            LblKosten.Text = "Kosten";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(172, 58);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // TxtBeschreibung
            // 
            TxtBeschreibung.Location = new Point(172, 96);
            TxtBeschreibung.Multiline = true;
            TxtBeschreibung.Name = "TxtBeschreibung";
            TxtBeschreibung.Size = new Size(212, 141);
            TxtBeschreibung.TabIndex = 5;
            // 
            // reparaturBindingSource
            // 
            reparaturBindingSource.DataSource = typeof(Models.Reparatur);
            // 
            // TxtKosten
            // 
            TxtKosten.DataBindings.Add(new Binding("DataContext", reparaturBindingSource, "Kosten", true));
            TxtKosten.DataBindings.Add(new Binding("Text", reparaturBindingSource, "Kosten", true));
            TxtKosten.Location = new Point(207, 243);
            TxtKosten.Name = "TxtKosten";
            TxtKosten.Size = new Size(100, 23);
            TxtKosten.TabIndex = 6;
            // 
            // LblEuro
            // 
            LblEuro.AutoSize = true;
            LblEuro.Location = new Point(346, 251);
            LblEuro.Name = "LblEuro";
            LblEuro.Size = new Size(31, 15);
            LblEuro.TabIndex = 7;
            LblEuro.Text = "Euro";
            // 
            // LblFahrzeug
            // 
            LblFahrzeug.AutoSize = true;
            LblFahrzeug.Location = new Point(162, 299);
            LblFahrzeug.Name = "LblFahrzeug";
            LblFahrzeug.Size = new Size(38, 15);
            LblFahrzeug.TabIndex = 8;
            LblFahrzeug.Text = "label1";
            // 
            // fahrzeugBindingSource
            // 
            fahrzeugBindingSource.DataSource = typeof(Models.Fahrzeug);
            // 
            // LblKennzeichen
            // 
            LblKennzeichen.AutoSize = true;
            LblKennzeichen.Location = new Point(162, 345);
            LblKennzeichen.Name = "LblKennzeichen";
            LblKennzeichen.Size = new Size(38, 15);
            LblKennzeichen.TabIndex = 9;
            LblKennzeichen.Text = "label2";
            // 
            // LblMarke
            // 
            LblMarke.AutoSize = true;
            LblMarke.Location = new Point(162, 386);
            LblMarke.Name = "LblMarke";
            LblMarke.Size = new Size(38, 15);
            LblMarke.TabIndex = 10;
            LblMarke.Text = "label3";
            // 
            // LblModell
            // 
            LblModell.AutoSize = true;
            LblModell.Location = new Point(162, 438);
            LblModell.Name = "LblModell";
            LblModell.Size = new Size(38, 15);
            LblModell.TabIndex = 11;
            LblModell.Text = "label4";
            // 
            // LblHalter
            // 
            LblHalter.AutoSize = true;
            LblHalter.Location = new Point(161, 476);
            LblHalter.Name = "LblHalter";
            LblHalter.Size = new Size(38, 15);
            LblHalter.TabIndex = 12;
            LblHalter.Text = "label5";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 299);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 13;
            label2.Text = "Fahrzeug";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 345);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 14;
            label3.Text = "Kennzeichen";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 386);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 15;
            label4.Text = "marke";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 438);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 16;
            label5.Text = "Modell";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 476);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 17;
            label6.Text = "Halter";
            // 
            // CmdSpeichern
            // 
            CmdSpeichern.Location = new Point(137, 562);
            CmdSpeichern.Name = "CmdSpeichern";
            CmdSpeichern.Size = new Size(75, 23);
            CmdSpeichern.TabIndex = 18;
            CmdSpeichern.Text = "Speichern";
            CmdSpeichern.UseVisualStyleBackColor = true;
            CmdSpeichern.Click += CmdSpeichern_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 520);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 19;
            label7.Text = "Ort";
            // 
            // LblOrt
            // 
            LblOrt.AutoSize = true;
            LblOrt.Location = new Point(162, 520);
            LblOrt.Name = "LblOrt";
            LblOrt.Size = new Size(38, 15);
            LblOrt.TabIndex = 20;
            LblOrt.Text = "label8";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(390, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(669, 489);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fahrzeuge";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nrDataGridViewTextBoxColumn, Kennzeichen, Marke, Modell, Halter, Ort, Reparaturs });
            dataGridView1.DataSource = fahrzeugBindingSource;
            dataGridView1.Location = new Point(25, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(644, 289);
            dataGridView1.TabIndex = 0;
            
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // nrDataGridViewTextBoxColumn
            // 
            nrDataGridViewTextBoxColumn.DataPropertyName = "Nr";
            nrDataGridViewTextBoxColumn.HeaderText = "Nr";
            nrDataGridViewTextBoxColumn.Name = "nrDataGridViewTextBoxColumn";
            // 
            // Kennzeichen
            // 
            Kennzeichen.DataPropertyName = "Kennzeichen";
            Kennzeichen.HeaderText = "Kennzeichen";
            Kennzeichen.Name = "Kennzeichen";
            // 
            // Marke
            // 
            Marke.DataPropertyName = "Marke";
            Marke.HeaderText = "Marke";
            Marke.Name = "Marke";
            // 
            // Modell
            // 
            Modell.DataPropertyName = "Modell";
            Modell.HeaderText = "Modell";
            Modell.Name = "Modell";
            // 
            // Halter
            // 
            Halter.DataPropertyName = "Halter";
            Halter.HeaderText = "Halter";
            Halter.Name = "Halter";
            // 
            // Ort
            // 
            Ort.DataPropertyName = "Ort";
            Ort.HeaderText = "Ort";
            Ort.Name = "Ort";
            // 
            // Reparaturs
            // 
            Reparaturs.DataPropertyName = "Reparaturs";
            Reparaturs.HeaderText = "Reparaturs";
            Reparaturs.Name = "Reparaturs";
            // 
            // CmdFahrzeuguebernehmen
            // 
            CmdFahrzeuguebernehmen.Location = new Point(549, 582);
            CmdFahrzeuguebernehmen.Name = "CmdFahrzeuguebernehmen";
            CmdFahrzeuguebernehmen.Size = new Size(220, 23);
            CmdFahrzeuguebernehmen.TabIndex = 0;
            CmdFahrzeuguebernehmen.Text = "<<<< Fahrzeug übernehmen";
            CmdFahrzeuguebernehmen.UseVisualStyleBackColor = true;
            CmdFahrzeuguebernehmen.Click += CmdFahrzeuguebernehmen_Click;
            // 
            // CmdLöschen
            // 
            CmdLöschen.Location = new Point(549, 46);
            CmdLöschen.Name = "CmdLöschen";
            CmdLöschen.Size = new Size(75, 23);
            CmdLöschen.TabIndex = 1;
            CmdLöschen.Text = "Löschen";
            CmdLöschen.UseVisualStyleBackColor = true;
            CmdLöschen.Click += CmdLöschen_Click;
            // 
            // CmdHinzufügen
            // 
            CmdHinzufügen.Location = new Point(641, 46);
            CmdHinzufügen.Name = "CmdHinzufügen";
            CmdHinzufügen.Size = new Size(75, 23);
            CmdHinzufügen.TabIndex = 22;
            CmdHinzufügen.Text = "Hinufügen";
            CmdHinzufügen.UseVisualStyleBackColor = true;
            CmdHinzufügen.Click += CmdHinzufügen_Click;
            // 
            // CmdSpeichernFahrzeuge
            // 
            CmdSpeichernFahrzeuge.Location = new Point(763, 46);
            CmdSpeichernFahrzeuge.Name = "CmdSpeichernFahrzeuge";
            CmdSpeichernFahrzeuge.Size = new Size(75, 23);
            CmdSpeichernFahrzeuge.TabIndex = 23;
            CmdSpeichernFahrzeuge.Text = "Speichern";
            CmdSpeichernFahrzeuge.UseVisualStyleBackColor = true;
            
            // 
            // CmdReparaturenanzeigen
            // 
            CmdReparaturenanzeigen.Location = new Point(390, 46);
            CmdReparaturenanzeigen.Name = "CmdReparaturenanzeigen";
            CmdReparaturenanzeigen.Size = new Size(153, 23);
            CmdReparaturenanzeigen.TabIndex = 24;
            CmdReparaturenanzeigen.Text = "Reparaturen anzeigen";
            CmdReparaturenanzeigen.UseVisualStyleBackColor = true;
            
            // 
            // FrmAutowerkstattHelfer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 642);
            Controls.Add(CmdReparaturenanzeigen);
            Controls.Add(CmdSpeichernFahrzeuge);
            Controls.Add(CmdHinzufügen);
            Controls.Add(CmdLöschen);
            Controls.Add(CmdFahrzeuguebernehmen);
            Controls.Add(groupBox1);
            Controls.Add(LblOrt);
            Controls.Add(label7);
            Controls.Add(CmdSpeichern);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(LblHalter);
            Controls.Add(LblModell);
            Controls.Add(LblMarke);
            Controls.Add(LblKennzeichen);
            Controls.Add(LblFahrzeug);
            Controls.Add(LblEuro);
            Controls.Add(TxtKosten);
            Controls.Add(TxtBeschreibung);
            Controls.Add(dateTimePicker1);
            Controls.Add(LblKosten);
            Controls.Add(LblBeschreibung);
            Controls.Add(LblDatum);
            Controls.Add(LblErfassungReparatur);
            Name = "FrmAutowerkstattHelfer";
            Text = "autowerkstatt Helfer";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)reparaturBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)fahrzeugBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblErfassungReparatur;
        private Label LblDatum;
        private Label LblBeschreibung;
        private Label LblKosten;
        private DateTimePicker dateTimePicker1;
        private TextBox TxtBeschreibung;
        private TextBox TxtKosten;
        private Label LblEuro;
        private Label LblFahrzeug;
        private Label LblKennzeichen;
        private Label LblMarke;
        private Label LblModell;
        private Label LblHalter;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button CmdSpeichern;
        private Label label7;
        private Label LblOrt;
        private GroupBox groupBox1;
        private Button CmdFahrzeuguebernehmen;
        private DataGridView dataGridView1;
        private Button CmdLöschen;
        private Button CmdHinzufügen;
        private BindingSource reparaturBindingSource;
        private BindingSource fahrzeugBindingSource;
        private DataGridViewTextBoxColumn nrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Kennzeichen;
        private DataGridViewTextBoxColumn Marke;
        private DataGridViewTextBoxColumn Modell;
        private DataGridViewTextBoxColumn Halter;
        private DataGridViewTextBoxColumn Ort;
        private DataGridViewTextBoxColumn Reparaturs;
        private Button CmdSpeichernFahrzeuge;
        private Button CmdReparaturenanzeigen;
    }
}
