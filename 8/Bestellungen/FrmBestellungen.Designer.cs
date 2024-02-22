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
            dataGridView1 = new DataGridView();
            bestellNrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kundenNrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            textDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            preisDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            datumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bestellungBindingSource = new BindingSource(components);
            CmdLabel1 = new Label();
            CmdLabel2 = new Label();
            CmdLabel3 = new Label();
            CmdLabel4 = new Label();
            CmdLabel5 = new Label();
            CmdLabel6 = new Label();
            CmdLabel7 = new Label();
            CmdButtonKundeÜbern = new Button();
            CmdButtonAlleBestell = new Button();
            CmdButtonFilter = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBoxBestell = new TextBox();
            dataGridView2 = new DataGridView();
            kundenNrDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adresseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            plzDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ortDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kundeBindingSource = new BindingSource(components);
            textBoxPreis = new TextBox();
            textBoxKunde = new TextBox();
            textBoxArtikel = new TextBox();
            CmdButtonbestellung = new Button();
            CmdButtonHinzufügen = new Button();
            CmdButtonClear = new Button();
            CmdButtonSort = new Button();
            CmdButtonHinzufügen2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bestellungBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kundeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { bestellNrDataGridViewTextBoxColumn, kundenNrDataGridViewTextBoxColumn, textDataGridViewTextBoxColumn, preisDataGridViewTextBoxColumn, datumDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bestellungBindingSource;
            dataGridView1.Location = new Point(12, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(543, 150);
            dataGridView1.TabIndex = 0;
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
            // CmdLabel1
            // 
            CmdLabel1.AutoSize = true;
            CmdLabel1.Location = new Point(12, 43);
            CmdLabel1.Name = "CmdLabel1";
            CmdLabel1.Size = new Size(78, 15);
            CmdLabel1.TabIndex = 1;
            CmdLabel1.Text = "Bestellungen:";
            // 
            // CmdLabel2
            // 
            CmdLabel2.AutoSize = true;
            CmdLabel2.Location = new Point(12, 255);
            CmdLabel2.Name = "CmdLabel2";
            CmdLabel2.Size = new Size(60, 15);
            CmdLabel2.TabIndex = 3;
            CmdLabel2.Text = "Bestell Nr.";
            // 
            // CmdLabel3
            // 
            CmdLabel3.AutoSize = true;
            CmdLabel3.Location = new Point(213, 255);
            CmdLabel3.Name = "CmdLabel3";
            CmdLabel3.Size = new Size(67, 15);
            CmdLabel3.TabIndex = 4;
            CmdLabel3.Text = "Kunden Nr.";
            // 
            // CmdLabel4
            // 
            CmdLabel4.AutoSize = true;
            CmdLabel4.Location = new Point(239, 300);
            CmdLabel4.Name = "CmdLabel4";
            CmdLabel4.Size = new Size(44, 15);
            CmdLabel4.TabIndex = 5;
            CmdLabel4.Text = "Artikel ";
            // 
            // CmdLabel5
            // 
            CmdLabel5.AutoSize = true;
            CmdLabel5.Location = new Point(398, 260);
            CmdLabel5.Name = "CmdLabel5";
            CmdLabel5.Size = new Size(46, 15);
            CmdLabel5.TabIndex = 6;
            CmdLabel5.Text = "Datum:";
            // 
            // CmdLabel6
            // 
            CmdLabel6.AutoSize = true;
            CmdLabel6.Location = new Point(412, 300);
            CmdLabel6.Name = "CmdLabel6";
            CmdLabel6.Size = new Size(32, 15);
            CmdLabel6.TabIndex = 7;
            CmdLabel6.Text = "Preis";
            // 
            // CmdLabel7
            // 
            CmdLabel7.AutoSize = true;
            CmdLabel7.Location = new Point(593, 300);
            CmdLabel7.Name = "CmdLabel7";
            CmdLabel7.Size = new Size(31, 15);
            CmdLabel7.TabIndex = 8;
            CmdLabel7.Text = "Euro";
            // 
            // CmdButtonKundeÜbern
            // 
            CmdButtonKundeÜbern.Location = new Point(15, 61);
            CmdButtonKundeÜbern.Name = "CmdButtonKundeÜbern";
            CmdButtonKundeÜbern.Size = new Size(124, 23);
            CmdButtonKundeÜbern.TabIndex = 9;
            CmdButtonKundeÜbern.Text = "Kunde Übernehmen";
            CmdButtonKundeÜbern.UseVisualStyleBackColor = true;
            CmdButtonKundeÜbern.Click += CmdButtonKundeÜbern_Click;
            // 
            // CmdButtonAlleBestell
            // 
            CmdButtonAlleBestell.Location = new Point(304, 59);
            CmdButtonAlleBestell.Name = "CmdButtonAlleBestell";
            CmdButtonAlleBestell.Size = new Size(129, 23);
            CmdButtonAlleBestell.TabIndex = 10;
            CmdButtonAlleBestell.Text = "Alle Bestellungen";
            CmdButtonAlleBestell.UseVisualStyleBackColor = true;
            // 
            // CmdButtonFilter
            // 
            CmdButtonFilter.Location = new Point(428, 59);
            CmdButtonFilter.Name = "CmdButtonFilter";
            CmdButtonFilter.Size = new Size(127, 23);
            CmdButtonFilter.TabIndex = 11;
            CmdButtonFilter.Text = "Nach Kunden Filtern";
            CmdButtonFilter.UseVisualStyleBackColor = true;
            CmdButtonFilter.Click += CmdButtonFilter_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(456, 255);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // textBoxBestell
            // 
            textBoxBestell.DataBindings.Add(new Binding("Text", bestellungBindingSource, "BestellNr", true));
            textBoxBestell.Location = new Point(78, 252);
            textBoxBestell.Name = "textBoxBestell";
            textBoxBestell.Size = new Size(100, 23);
            textBoxBestell.TabIndex = 16;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { kundenNrDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn, adresseDataGridViewTextBoxColumn, plzDataGridViewTextBoxColumn, ortDataGridViewTextBoxColumn, telefonDataGridViewTextBoxColumn });
            dataGridView2.DataBindings.Add(new Binding("DataContext", bestellungBindingSource, "BestellNr", true));
            dataGridView2.DataSource = kundeBindingSource;
            dataGridView2.Location = new Point(12, 352);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(644, 150);
            dataGridView2.TabIndex = 17;
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
            // textBoxPreis
            // 
            textBoxPreis.CausesValidation = false;
            textBoxPreis.DataBindings.Add(new Binding("Text", bestellungBindingSource, "Preis", true));
            textBoxPreis.Location = new Point(450, 292);
            textBoxPreis.Name = "textBoxPreis";
            textBoxPreis.Size = new Size(100, 23);
            textBoxPreis.TabIndex = 20;
            // 
            // textBoxKunde
            // 
            textBoxKunde.DataBindings.Add(new Binding("Text", bestellungBindingSource, "KundenNr", true));
            textBoxKunde.Location = new Point(286, 252);
            textBoxKunde.Name = "textBoxKunde";
            textBoxKunde.Size = new Size(100, 23);
            textBoxKunde.TabIndex = 21;
            // 
            // textBoxArtikel
            // 
            textBoxArtikel.DataBindings.Add(new Binding("Text", bestellungBindingSource, "Text", true));
            textBoxArtikel.Location = new Point(286, 297);
            textBoxArtikel.Name = "textBoxArtikel";
            textBoxArtikel.Size = new Size(100, 23);
            textBoxArtikel.TabIndex = 22;
            // 
            // CmdButtonbestellung
            // 
            CmdButtonbestellung.Location = new Point(177, 59);
            CmdButtonbestellung.Name = "CmdButtonbestellung";
            CmdButtonbestellung.Size = new Size(75, 23);
            CmdButtonbestellung.TabIndex = 23;
            CmdButtonbestellung.Text = "Speichern";
            CmdButtonbestellung.UseVisualStyleBackColor = true;
            CmdButtonbestellung.Click += CmdButtonbestellung_Click;
            // 
            // CmdButtonHinzufügen
            // 
            CmdButtonHinzufügen.Location = new Point(177, 30);
            CmdButtonHinzufügen.Name = "CmdButtonHinzufügen";
            CmdButtonHinzufügen.Size = new Size(75, 23);
            CmdButtonHinzufügen.TabIndex = 24;
            CmdButtonHinzufügen.Text = "Hinzufügen";
            CmdButtonHinzufügen.UseVisualStyleBackColor = true;
            CmdButtonHinzufügen.Click += CmdButtonHinzufügen_Click;
            // 
            // CmdButtonClear
            // 
            CmdButtonClear.Location = new Point(304, 30);
            CmdButtonClear.Name = "CmdButtonClear";
            CmdButtonClear.Size = new Size(75, 23);
            CmdButtonClear.TabIndex = 25;
            CmdButtonClear.Text = "Löschen";
            CmdButtonClear.UseVisualStyleBackColor = true;
            CmdButtonClear.Click += CmdButtonClear_Click;
            // 
            // CmdButtonSort
            // 
            CmdButtonSort.Location = new Point(581, 59);
            CmdButtonSort.Name = "CmdButtonSort";
            CmdButtonSort.Size = new Size(75, 23);
            CmdButtonSort.TabIndex = 26;
            CmdButtonSort.Text = "Sortieren";
            CmdButtonSort.UseVisualStyleBackColor = true;
            CmdButtonSort.Click += CmdButtonSort_Click;
            // 
            // CmdButtonHinzufügen2
            // 
            CmdButtonHinzufügen2.Location = new Point(177, 1);
            CmdButtonHinzufügen2.Name = "CmdButtonHinzufügen2";
            CmdButtonHinzufügen2.Size = new Size(85, 23);
            CmdButtonHinzufügen2.TabIndex = 27;
            CmdButtonHinzufügen2.Text = "Hinzufügen2";
            CmdButtonHinzufügen2.UseVisualStyleBackColor = true;
            CmdButtonHinzufügen2.Click += CmdButtonHinzufügen2_Click;
            // 
            // FrmBestellungen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 596);
            Controls.Add(CmdButtonHinzufügen2);
            Controls.Add(CmdButtonSort);
            Controls.Add(CmdButtonClear);
            Controls.Add(CmdButtonHinzufügen);
            Controls.Add(CmdButtonbestellung);
            Controls.Add(textBoxArtikel);
            Controls.Add(textBoxKunde);
            Controls.Add(textBoxPreis);
            Controls.Add(dataGridView2);
            Controls.Add(textBoxBestell);
            Controls.Add(dateTimePicker1);
            Controls.Add(CmdButtonFilter);
            Controls.Add(CmdButtonAlleBestell);
            Controls.Add(CmdButtonKundeÜbern);
            Controls.Add(CmdLabel7);
            Controls.Add(CmdLabel6);
            Controls.Add(CmdLabel5);
            Controls.Add(CmdLabel4);
            Controls.Add(CmdLabel3);
            Controls.Add(CmdLabel2);
            Controls.Add(CmdLabel1);
            Controls.Add(dataGridView1);
            Name = "FrmBestellungen";
            Text = "Form1";
            Load += FrmBestellungen_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bestellungBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)kundeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label CmdLabel1;
        private BindingSource bestellungBindingSource;
        private DataGridViewTextBoxColumn bestellNrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kundenNrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn preisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private BindingSource bindingSource1;
        private Label CmdLabel2;
        private Label CmdLabel3;
        private Label CmdLabel4;
        private Label CmdLabel5;
        private Label CmdLabel6;
        private Label CmdLabel7;
        private Button CmdButtonKundeÜbern;
        private Button CmdButtonAlleBestell;
        private Button CmdButtonFilter;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBoxPreis;
        private TextBox textBoxBestell;
        private DataGridView dataGridView2;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private DateTimePicker dateTimePicker2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView3;
        private Label label7;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private DateTimePicker dateTimePicker3;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private DataGridView dataGridView5;
        private Label label14;
        private DataGridView dataGridView6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox textBox15;
        private TextBox textBox16;
        private DateTimePicker dateTimePicker4;
        private Button button10;
        private Button button11;
        private Button button12;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private DataGridView dataGridView7;
        private Label label21;
        private DataGridView dataGridView8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private TextBox textBox17;
        private TextBox textBox18;
        private TextBox textBox19;
        private TextBox textBox20;
        private DateTimePicker dateTimePicker5;
        private Button button13;
        private Button button14;
        private Button button15;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private DataGridView dataGridView9;
        private Label label28;
        private DataGridView dataGridView10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private TextBox textBox21;
        private TextBox textBox22;
        private TextBox textBox23;
        private TextBox textBox24;
        private DateTimePicker dateTimePicker6;
        private Button button16;
        private Button button17;
        private Button button18;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private DataGridView dataGridView11;
        private Label label35;
        private DataGridView dataGridView12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private DataGridViewTextBoxColumn kundenNrDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn plzDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ortDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private BindingSource kundeBindingSource;
        private DataGridViewTextBoxColumn bestellNrDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn textDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn preisDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn kundenNrNavigationDataGridViewTextBoxColumn;
        private TextBox textBoxKunde;
        private TextBox textBoxArtikel;
        private Button CmdButtonbestellung;
        private Button CmdButtonHinzufügen;
        private Button CmdButtonClear;
        private Button CmdButtonSort;
        private Button CmdButtonHinzufügen2;
    }
}
