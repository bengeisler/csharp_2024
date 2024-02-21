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
            GrbBestellung = new GroupBox();
            dataGridView1 = new DataGridView();
            bestellNrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kundenNrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            textDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            preisDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            datumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bestellungBindingSource = new BindingSource(components);
            BtnÜbernehmen = new Button();
            BtnAlleBestellungen = new Button();
            BtnKundenÖffnen = new Button();
            label1 = new Label();
            GrbBestellung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bestellungBindingSource).BeginInit();
            SuspendLayout();
            // 
            // GrbBestellung
            // 
            GrbBestellung.Controls.Add(label1);
            GrbBestellung.Controls.Add(BtnKundenÖffnen);
            GrbBestellung.Controls.Add(dataGridView1);
            GrbBestellung.Controls.Add(BtnAlleBestellungen);
            GrbBestellung.Controls.Add(BtnÜbernehmen);
            GrbBestellung.Location = new Point(27, 32);
            GrbBestellung.Name = "GrbBestellung";
            GrbBestellung.Size = new Size(703, 380);
            GrbBestellung.TabIndex = 0;
            GrbBestellung.TabStop = false;
            GrbBestellung.Text = "Bestellungen:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { bestellNrDataGridViewTextBoxColumn, kundenNrDataGridViewTextBoxColumn, textDataGridViewTextBoxColumn, preisDataGridViewTextBoxColumn, datumDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bestellungBindingSource;
            dataGridView1.Location = new Point(6, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(691, 261);
            dataGridView1.TabIndex = 0;
            // 
            // bestellNrDataGridViewTextBoxColumn
            // 
            bestellNrDataGridViewTextBoxColumn.DataPropertyName = "BestellNr";
            bestellNrDataGridViewTextBoxColumn.HeaderText = "BestellNr";
            bestellNrDataGridViewTextBoxColumn.Name = "bestellNrDataGridViewTextBoxColumn";
            // 
            // kundenNrDataGridViewTextBoxColumn
            // 
            kundenNrDataGridViewTextBoxColumn.DataPropertyName = "KundenNr";
            kundenNrDataGridViewTextBoxColumn.HeaderText = "KundenNr";
            kundenNrDataGridViewTextBoxColumn.Name = "kundenNrDataGridViewTextBoxColumn";
            // 
            // textDataGridViewTextBoxColumn
            // 
            textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            textDataGridViewTextBoxColumn.HeaderText = "Text";
            textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            // 
            // preisDataGridViewTextBoxColumn
            // 
            preisDataGridViewTextBoxColumn.DataPropertyName = "Preis";
            preisDataGridViewTextBoxColumn.HeaderText = "Preis";
            preisDataGridViewTextBoxColumn.Name = "preisDataGridViewTextBoxColumn";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // bestellungBindingSource
            // 
            bestellungBindingSource.DataSource = typeof(Models.Bestellung);
            // 
            // BtnÜbernehmen
            // 
            BtnÜbernehmen.Location = new Point(6, 20);
            BtnÜbernehmen.Name = "BtnÜbernehmen";
            BtnÜbernehmen.Size = new Size(138, 23);
            BtnÜbernehmen.TabIndex = 1;
            BtnÜbernehmen.Text = "Kunden übernehmen";
            BtnÜbernehmen.UseVisualStyleBackColor = true;
            // 
            // BtnAlleBestellungen
            // 
            BtnAlleBestellungen.Location = new Point(469, 20);
            BtnAlleBestellungen.Name = "BtnAlleBestellungen";
            BtnAlleBestellungen.Size = new Size(119, 23);
            BtnAlleBestellungen.TabIndex = 2;
            BtnAlleBestellungen.Text = "Alle Bestellungen";
            BtnAlleBestellungen.UseVisualStyleBackColor = true;
            BtnAlleBestellungen.Click += button2_Click;
            // 
            // BtnKundenÖffnen
            // 
            BtnKundenÖffnen.Location = new Point(594, 20);
            BtnKundenÖffnen.Name = "BtnKundenÖffnen";
            BtnKundenÖffnen.Size = new Size(103, 23);
            BtnKundenÖffnen.TabIndex = 3;
            BtnKundenÖffnen.Text = "Nach Kunden öffnen";
            BtnKundenÖffnen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 323);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 4;
            label1.Text = "Bestell Nr:";
            // 
            // FrmBestellungen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GrbBestellung);
            Name = "FrmBestellungen";
            Text = "Form1";
            Load += FrmBestellungen_Load;
            GrbBestellung.ResumeLayout(false);
            GrbBestellung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bestellungBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GrbBestellung;
        private DataGridView dataGridView1;
        private BindingSource bestellungBindingSource;
        private DataGridViewTextBoxColumn bestellNrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kundenNrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn preisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private Button BtnÜbernehmen;
        private Button BtnAlleBestellungen;
        private Button BtnKundenÖffnen;
        private Label label1;
    }
}
