// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Autowerkstatt
{
    partial class FrmWerkstatt
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
            GrpErfassung = new GroupBox();
            label5 = new Label();
            CmdSpeichern = new Button();
            TxtBeschreibung = new TextBox();
            label16 = new Label();
            LblModell = new Label();
            label14 = new Label();
            LblOrt = new Label();
            label12 = new Label();
            LblHalter = new Label();
            label10 = new Label();
            LblMarke = new Label();
            label8 = new Label();
            LblKennzeichen = new Label();
            label6 = new Label();
            LblFahrzeug = new Label();
            label4 = new Label();
            TxtKosten = new TextBox();
            label3 = new Label();
            DatDatum = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            fahrzeugBindingSource = new BindingSource(components);
            reparaturBindingSource = new BindingSource(components);
            GrpFahrzeuge = new GroupBox();
            CmdLöschen = new Button();
            CmdSpeichern2 = new Button();
            CmdHinzufügen = new Button();
            dataGridView1 = new DataGridView();
            nrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kennzeichenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            markeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modellDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            halterDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ortDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CmdFahrzeugÜbernehmen = new Button();
            CmdReparaturenAnzeigen = new Button();
            GrpErfassung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fahrzeugBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reparaturBindingSource).BeginInit();
            GrpFahrzeuge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // GrpErfassung
            // 
            GrpErfassung.Controls.Add(CmdReparaturenAnzeigen);
            GrpErfassung.Controls.Add(label5);
            GrpErfassung.Controls.Add(CmdSpeichern);
            GrpErfassung.Controls.Add(TxtBeschreibung);
            GrpErfassung.Controls.Add(label16);
            GrpErfassung.Controls.Add(LblModell);
            GrpErfassung.Controls.Add(label14);
            GrpErfassung.Controls.Add(LblOrt);
            GrpErfassung.Controls.Add(label12);
            GrpErfassung.Controls.Add(LblHalter);
            GrpErfassung.Controls.Add(label10);
            GrpErfassung.Controls.Add(LblMarke);
            GrpErfassung.Controls.Add(label8);
            GrpErfassung.Controls.Add(LblKennzeichen);
            GrpErfassung.Controls.Add(label6);
            GrpErfassung.Controls.Add(LblFahrzeug);
            GrpErfassung.Controls.Add(label4);
            GrpErfassung.Controls.Add(TxtKosten);
            GrpErfassung.Controls.Add(label3);
            GrpErfassung.Controls.Add(DatDatum);
            GrpErfassung.Controls.Add(label2);
            GrpErfassung.Controls.Add(label1);
            GrpErfassung.Location = new Point(12, 12);
            GrpErfassung.Name = "GrpErfassung";
            GrpErfassung.Size = new Size(527, 686);
            GrpErfassung.TabIndex = 0;
            GrpErfassung.TabStop = false;
            GrpErfassung.Text = "Erfassung Reparatur:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(115, 247);
            label5.Name = "label5";
            label5.Size = new Size(23, 15);
            label5.TabIndex = 21;
            label5.Text = "Nr:";
            // 
            // CmdSpeichern
            // 
            CmdSpeichern.Location = new Point(114, 520);
            CmdSpeichern.Name = "CmdSpeichern";
            CmdSpeichern.Size = new Size(141, 23);
            CmdSpeichern.TabIndex = 20;
            CmdSpeichern.Text = "Speichern";
            CmdSpeichern.UseVisualStyleBackColor = true;
            CmdSpeichern.Click += CmdSpeichern_Click;
            // 
            // TxtBeschreibung
            // 
            TxtBeschreibung.Location = new Point(115, 73);
            TxtBeschreibung.Multiline = true;
            TxtBeschreibung.Name = "TxtBeschreibung";
            TxtBeschreibung.Size = new Size(200, 95);
            TxtBeschreibung.TabIndex = 19;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(321, 192);
            label16.Name = "label16";
            label16.Size = new Size(31, 15);
            label16.TabIndex = 18;
            label16.Text = "Euro";
            // 
            // LblModell
            // 
            LblModell.AutoSize = true;
            LblModell.Location = new Point(115, 354);
            LblModell.Name = "LblModell";
            LblModell.Size = new Size(44, 15);
            LblModell.TabIndex = 17;
            LblModell.Text = "label15";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(5, 354);
            label14.Name = "label14";
            label14.Size = new Size(47, 15);
            label14.TabIndex = 16;
            label14.Text = "Modell:";
            // 
            // LblOrt
            // 
            LblOrt.AutoSize = true;
            LblOrt.Location = new Point(114, 450);
            LblOrt.Name = "LblOrt";
            LblOrt.Size = new Size(44, 15);
            LblOrt.TabIndex = 15;
            LblOrt.Text = "label13";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(5, 450);
            label12.Name = "label12";
            label12.Size = new Size(27, 15);
            label12.TabIndex = 14;
            label12.Text = "Ort:";
            // 
            // LblHalter
            // 
            LblHalter.AutoSize = true;
            LblHalter.Location = new Point(114, 409);
            LblHalter.Name = "LblHalter";
            LblHalter.Size = new Size(44, 15);
            LblHalter.TabIndex = 13;
            LblHalter.Text = "label11";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(5, 409);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 12;
            label10.Text = "Halter:";
            // 
            // LblMarke
            // 
            LblMarke.AutoSize = true;
            LblMarke.Location = new Point(115, 323);
            LblMarke.Name = "LblMarke";
            LblMarke.Size = new Size(38, 15);
            LblMarke.TabIndex = 11;
            LblMarke.Text = "label9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 323);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 10;
            label8.Text = "Marke:";
            // 
            // LblKennzeichen
            // 
            LblKennzeichen.AutoSize = true;
            LblKennzeichen.Location = new Point(115, 286);
            LblKennzeichen.Name = "LblKennzeichen";
            LblKennzeichen.Size = new Size(38, 15);
            LblKennzeichen.TabIndex = 9;
            LblKennzeichen.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 286);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 8;
            label6.Text = "Kennzeichen:";
            // 
            // LblFahrzeug
            // 
            LblFahrzeug.AutoSize = true;
            LblFahrzeug.Location = new Point(144, 247);
            LblFahrzeug.Name = "LblFahrzeug";
            LblFahrzeug.Size = new Size(38, 15);
            LblFahrzeug.TabIndex = 7;
            LblFahrzeug.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 241);
            label4.Name = "label4";
            label4.Size = new Size(84, 21);
            label4.TabIndex = 6;
            label4.Text = "Fahrzeug:";
            // 
            // TxtKosten
            // 
            TxtKosten.Location = new Point(115, 184);
            TxtKosten.Name = "TxtKosten";
            TxtKosten.Size = new Size(200, 23);
            TxtKosten.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 192);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 4;
            label3.Text = "Kosten:";
            // 
            // DatDatum
            // 
            DatDatum.Location = new Point(115, 36);
            DatDatum.Name = "DatDatum";
            DatDatum.Size = new Size(200, 23);
            DatDatum.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 76);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Beschreibung:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 42);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Datum:";
            // 
            // fahrzeugBindingSource
            // 
            fahrzeugBindingSource.DataSource = typeof(Models.Fahrzeug);
            // 
            // reparaturBindingSource
            // 
            reparaturBindingSource.DataSource = typeof(Models.Reparatur);
            // 
            // GrpFahrzeuge
            // 
            GrpFahrzeuge.Controls.Add(CmdLöschen);
            GrpFahrzeuge.Controls.Add(CmdSpeichern2);
            GrpFahrzeuge.Controls.Add(CmdHinzufügen);
            GrpFahrzeuge.Controls.Add(dataGridView1);
            GrpFahrzeuge.Controls.Add(CmdFahrzeugÜbernehmen);
            GrpFahrzeuge.Location = new Point(564, 12);
            GrpFahrzeuge.Name = "GrpFahrzeuge";
            GrpFahrzeuge.Size = new Size(748, 686);
            GrpFahrzeuge.TabIndex = 0;
            GrpFahrzeuge.TabStop = false;
            GrpFahrzeuge.Text = "Fahrzeuge";
            // 
            // CmdLöschen
            // 
            CmdLöschen.Location = new Point(436, 22);
            CmdLöschen.Name = "CmdLöschen";
            CmdLöschen.Size = new Size(89, 23);
            CmdLöschen.TabIndex = 4;
            CmdLöschen.Text = "Löschen";
            CmdLöschen.UseVisualStyleBackColor = true;
            // 
            // CmdSpeichern2
            // 
            CmdSpeichern2.Location = new Point(327, 22);
            CmdSpeichern2.Name = "CmdSpeichern2";
            CmdSpeichern2.Size = new Size(89, 23);
            CmdSpeichern2.TabIndex = 3;
            CmdSpeichern2.Text = "Speichern";
            CmdSpeichern2.UseVisualStyleBackColor = true;
            CmdSpeichern2.Click += CmdSpeichern2_Click;
            // 
            // CmdHinzufügen
            // 
            CmdHinzufügen.Location = new Point(218, 22);
            CmdHinzufügen.Name = "CmdHinzufügen";
            CmdHinzufügen.Size = new Size(89, 23);
            CmdHinzufügen.TabIndex = 2;
            CmdHinzufügen.Text = "Hinzufügen";
            CmdHinzufügen.UseVisualStyleBackColor = true;
            CmdHinzufügen.Click += CmdHinzufügen_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nrDataGridViewTextBoxColumn, kennzeichenDataGridViewTextBoxColumn, markeDataGridViewTextBoxColumn, modellDataGridViewTextBoxColumn, halterDataGridViewTextBoxColumn, ortDataGridViewTextBoxColumn });
            dataGridView1.DataSource = fahrzeugBindingSource;
            dataGridView1.Location = new Point(6, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(755, 492);
            dataGridView1.TabIndex = 1;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // nrDataGridViewTextBoxColumn
            // 
            nrDataGridViewTextBoxColumn.DataPropertyName = "Nr";
            nrDataGridViewTextBoxColumn.HeaderText = "Nr";
            nrDataGridViewTextBoxColumn.Name = "nrDataGridViewTextBoxColumn";
            nrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kennzeichenDataGridViewTextBoxColumn
            // 
            kennzeichenDataGridViewTextBoxColumn.DataPropertyName = "Kennzeichen";
            kennzeichenDataGridViewTextBoxColumn.HeaderText = "Kennzeichen";
            kennzeichenDataGridViewTextBoxColumn.Name = "kennzeichenDataGridViewTextBoxColumn";
            kennzeichenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // markeDataGridViewTextBoxColumn
            // 
            markeDataGridViewTextBoxColumn.DataPropertyName = "Marke";
            markeDataGridViewTextBoxColumn.HeaderText = "Marke";
            markeDataGridViewTextBoxColumn.Name = "markeDataGridViewTextBoxColumn";
            markeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modellDataGridViewTextBoxColumn
            // 
            modellDataGridViewTextBoxColumn.DataPropertyName = "Modell";
            modellDataGridViewTextBoxColumn.HeaderText = "Modell";
            modellDataGridViewTextBoxColumn.Name = "modellDataGridViewTextBoxColumn";
            modellDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // halterDataGridViewTextBoxColumn
            // 
            halterDataGridViewTextBoxColumn.DataPropertyName = "Halter";
            halterDataGridViewTextBoxColumn.HeaderText = "Halter";
            halterDataGridViewTextBoxColumn.Name = "halterDataGridViewTextBoxColumn";
            halterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ortDataGridViewTextBoxColumn
            // 
            ortDataGridViewTextBoxColumn.DataPropertyName = "Ort";
            ortDataGridViewTextBoxColumn.HeaderText = "Ort";
            ortDataGridViewTextBoxColumn.Name = "ortDataGridViewTextBoxColumn";
            ortDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CmdFahrzeugÜbernehmen
            // 
            CmdFahrzeugÜbernehmen.Location = new Point(24, 549);
            CmdFahrzeugÜbernehmen.Name = "CmdFahrzeugÜbernehmen";
            CmdFahrzeugÜbernehmen.Size = new Size(200, 23);
            CmdFahrzeugÜbernehmen.TabIndex = 0;
            CmdFahrzeugÜbernehmen.Text = "<<< Fahrzeug übernehmen";
            CmdFahrzeugÜbernehmen.UseVisualStyleBackColor = true;
            CmdFahrzeugÜbernehmen.Click += CmdFahrzeugÜbernehmen_Click;
            // 
            // CmdReparaturenAnzeigen
            // 
            CmdReparaturenAnzeigen.Location = new Point(363, 22);
            CmdReparaturenAnzeigen.Name = "CmdReparaturenAnzeigen";
            CmdReparaturenAnzeigen.Size = new Size(141, 23);
            CmdReparaturenAnzeigen.TabIndex = 22;
            CmdReparaturenAnzeigen.Text = "Reparaturen Anzeigen";
            CmdReparaturenAnzeigen.UseVisualStyleBackColor = true;
            CmdReparaturenAnzeigen.Click += CmdReparaturenAnzeigen_Click;
            // 
            // FrmWerkstatt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 754);
            Controls.Add(GrpFahrzeuge);
            Controls.Add(GrpErfassung);
            Name = "FrmWerkstatt";
            Text = "Autowerkstatt Helfer";
            Load += FrmWerkstatt_Load;
            GrpErfassung.ResumeLayout(false);
            GrpErfassung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fahrzeugBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)reparaturBindingSource).EndInit();
            GrpFahrzeuge.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GrpErfassung;
        private GroupBox GrpFahrzeuge;
        private Label label16;
        private Label LblModell;
        private Label label14;
        private Label LblOrt;
        private Label label12;
        private Label LblHalter;
        private Label label10;
        private Label LblMarke;
        private Label label8;
        private Label LblKennzeichen;
        private Label label6;
        private Label LblFahrzeug;
        private Label label4;
        private TextBox TxtKosten;
        private Label label3;
        private DateTimePicker DatDatum;
        private Label label2;
        private Label label1;
        private Button CmdSpeichern;
        private TextBox TxtBeschreibung;
        private Button CmdFahrzeugÜbernehmen;
        private DataGridView dataGridView1;
        private BindingSource fahrzeugBindingSource;
        private Button CmdLöschen;
        private Button CmdSpeichern2;
        private Button CmdHinzufügen;
        private BindingSource reparaturBindingSource;
        private Label label5;
        private DataGridViewTextBoxColumn nrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kennzeichenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn markeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modellDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn halterDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ortDataGridViewTextBoxColumn;
        private Button CmdReparaturenAnzeigen;
    }
}
