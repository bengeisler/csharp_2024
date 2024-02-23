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
            reparaturBindingSource2 = new BindingSource(components);
            TxtBeschreibung = new TextBox();
            reparaturBindingSource = new BindingSource(components);
            TxtKosten = new TextBox();
            reparaturBindingSource1 = new BindingSource(components);
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
            ((System.ComponentModel.ISupportInitialize)reparaturBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reparaturBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reparaturBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fahrzeugBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(168, 21);
            label1.TabIndex = 0;
            label1.Text = "Erfassung Reparatur:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 40);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Datum:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 60);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 2;
            label3.Text = "Beschreibung:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 149);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 3;
            label4.Text = "Kosten:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(200, 190);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(23, 15);
            label5.TabIndex = 4;
            label5.Text = "Nr:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(8, 187);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(84, 21);
            label6.TabIndex = 5;
            label6.Text = "Fahrzeug:";
            // 
            // LblNummer
            // 
            LblNummer.AutoSize = true;
            LblNummer.Location = new Point(245, 191);
            LblNummer.Margin = new Padding(2, 0, 2, 0);
            LblNummer.Name = "LblNummer";
            LblNummer.Size = new Size(38, 15);
            LblNummer.TabIndex = 6;
            LblNummer.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 217);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(77, 15);
            label8.TabIndex = 7;
            label8.Text = "Kennzeichen:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(27, 232);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 8;
            label9.Text = "Marke:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(27, 247);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(47, 15);
            label10.TabIndex = 9;
            label10.Text = "Modell:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(27, 283);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(42, 15);
            label11.TabIndex = 10;
            label11.Text = "Halter:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(27, 298);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(27, 15);
            label12.TabIndex = 11;
            label12.Text = "Ort:";
            // 
            // LblKennzeichen
            // 
            LblKennzeichen.AutoSize = true;
            LblKennzeichen.Location = new Point(117, 217);
            LblKennzeichen.Margin = new Padding(2, 0, 2, 0);
            LblKennzeichen.Name = "LblKennzeichen";
            LblKennzeichen.Size = new Size(44, 15);
            LblKennzeichen.TabIndex = 12;
            LblKennzeichen.Text = "label13";
            // 
            // LblMarke
            // 
            LblMarke.AutoSize = true;
            LblMarke.Location = new Point(117, 232);
            LblMarke.Margin = new Padding(2, 0, 2, 0);
            LblMarke.Name = "LblMarke";
            LblMarke.Size = new Size(44, 15);
            LblMarke.TabIndex = 13;
            LblMarke.Text = "label14";
            // 
            // LblModell
            // 
            LblModell.AutoSize = true;
            LblModell.Location = new Point(117, 247);
            LblModell.Margin = new Padding(2, 0, 2, 0);
            LblModell.Name = "LblModell";
            LblModell.Size = new Size(44, 15);
            LblModell.TabIndex = 14;
            LblModell.Text = "label15";
            // 
            // LblHalter
            // 
            LblHalter.AutoSize = true;
            LblHalter.Location = new Point(117, 283);
            LblHalter.Margin = new Padding(2, 0, 2, 0);
            LblHalter.Name = "LblHalter";
            LblHalter.Size = new Size(44, 15);
            LblHalter.TabIndex = 15;
            LblHalter.Text = "label16";
            // 
            // LblOrt
            // 
            LblOrt.AutoSize = true;
            LblOrt.Location = new Point(117, 298);
            LblOrt.Margin = new Padding(2, 0, 2, 0);
            LblOrt.Name = "LblOrt";
            LblOrt.Size = new Size(44, 15);
            LblOrt.TabIndex = 16;
            LblOrt.Text = "label17";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(401, 5);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(89, 21);
            label18.TabIndex = 17;
            label18.Text = "Fahrzeuge";
            // 
            // DatDatum
            // 
            DatDatum.DataBindings.Add(new Binding("Value", reparaturBindingSource2, "Datum", true));
            DatDatum.Location = new Point(123, 36);
            DatDatum.Margin = new Padding(2);
            DatDatum.Name = "DatDatum";
            DatDatum.Size = new Size(211, 23);
            DatDatum.TabIndex = 18;
            // 
            // reparaturBindingSource2
            // 
            reparaturBindingSource2.DataSource = typeof(Models.Reparatur);
            // 
            // TxtBeschreibung
            // 
            TxtBeschreibung.DataBindings.Add(new Binding("Text", reparaturBindingSource, "Beschreibung", true));
            TxtBeschreibung.Location = new Point(123, 58);
            TxtBeschreibung.Margin = new Padding(2);
            TxtBeschreibung.Multiline = true;
            TxtBeschreibung.Name = "TxtBeschreibung";
            TxtBeschreibung.Size = new Size(211, 85);
            TxtBeschreibung.TabIndex = 19;
            // 
            // reparaturBindingSource
            // 
            reparaturBindingSource.DataSource = typeof(Models.Reparatur);
            // 
            // TxtKosten
            // 
            TxtKosten.DataBindings.Add(new Binding("Text", reparaturBindingSource1, "Kosten", true));
            TxtKosten.Location = new Point(123, 145);
            TxtKosten.Margin = new Padding(2);
            TxtKosten.Name = "TxtKosten";
            TxtKosten.Size = new Size(164, 23);
            TxtKosten.TabIndex = 20;
            // 
            // reparaturBindingSource1
            // 
            reparaturBindingSource1.DataSource = typeof(Models.Reparatur);
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(290, 149);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(31, 15);
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
            dataGridView1.Location = new Point(401, 36);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(609, 277);
            dataGridView1.TabIndex = 22;
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
            CmdReparaturSpeichern.Location = new Point(123, 317);
            CmdReparaturSpeichern.Margin = new Padding(2);
            CmdReparaturSpeichern.Name = "CmdReparaturSpeichern";
            CmdReparaturSpeichern.Size = new Size(78, 20);
            CmdReparaturSpeichern.TabIndex = 23;
            CmdReparaturSpeichern.Text = "Speichern";
            CmdReparaturSpeichern.UseVisualStyleBackColor = true;
            CmdReparaturSpeichern.Click += CmdReparaturSpeichern_Click;
            // 
            // CmdFahrzeugÜbernehmen
            // 
            CmdFahrzeugÜbernehmen.Location = new Point(401, 317);
            CmdFahrzeugÜbernehmen.Margin = new Padding(2);
            CmdFahrzeugÜbernehmen.Name = "CmdFahrzeugÜbernehmen";
            CmdFahrzeugÜbernehmen.Size = new Size(197, 20);
            CmdFahrzeugÜbernehmen.TabIndex = 24;
            CmdFahrzeugÜbernehmen.Text = "<<< Fahrzeug übernehmen";
            CmdFahrzeugÜbernehmen.UseVisualStyleBackColor = true;
            CmdFahrzeugÜbernehmen.Click += CmdFahrzeugÜbernehmen_Click;
            // 
            // CmdHinzufügen
            // 
            CmdHinzufügen.Location = new Point(559, 6);
            CmdHinzufügen.Margin = new Padding(2);
            CmdHinzufügen.Name = "CmdHinzufügen";
            CmdHinzufügen.Size = new Size(78, 20);
            CmdHinzufügen.TabIndex = 25;
            CmdHinzufügen.Text = "Hinzufügen";
            CmdHinzufügen.UseVisualStyleBackColor = true;
            CmdHinzufügen.Click += CmdHinzufügen_Click;
            // 
            // CmdSpeichern
            // 
            CmdSpeichern.Location = new Point(642, 6);
            CmdSpeichern.Margin = new Padding(2);
            CmdSpeichern.Name = "CmdSpeichern";
            CmdSpeichern.Size = new Size(78, 20);
            CmdSpeichern.TabIndex = 26;
            CmdSpeichern.Text = "Speichern";
            CmdSpeichern.UseVisualStyleBackColor = true;
            // 
            // CmdLöschen
            // 
            CmdLöschen.Location = new Point(724, 6);
            CmdLöschen.Margin = new Padding(2);
            CmdLöschen.Name = "CmdLöschen";
            CmdLöschen.Size = new Size(78, 20);
            CmdLöschen.TabIndex = 27;
            CmdLöschen.Text = "Löschen";
            CmdLöschen.UseVisualStyleBackColor = true;
            CmdLöschen.Click += CmdLöschen_Click;
            // 
            // FrmAutowerkstatt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 347);
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
            Margin = new Padding(2);
            Name = "FrmAutowerkstatt";
            Text = "Autowerkstatt Helferlein";
            Load += FrmAutowerkstatt_Load;
            ((System.ComponentModel.ISupportInitialize)reparaturBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)reparaturBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)reparaturBindingSource1).EndInit();
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
        private BindingSource reparaturBindingSource;
        private BindingSource reparaturBindingSource1;
        private BindingSource reparaturBindingSource2;
    }
}
