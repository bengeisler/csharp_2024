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
            textBox5 = new TextBox();
            TxtBestellNr = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
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
            bestellungBindingSource = new BindingSource(components);
            bindingSource1 = new BindingSource(components);
            GrpBestellungen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bestellungBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // GrpBestellungen
            // 
            GrpBestellungen.Controls.Add(textBox5);
            GrpBestellungen.Controls.Add(TxtBestellNr);
            GrpBestellungen.Controls.Add(textBox3);
            GrpBestellungen.Controls.Add(textBox2);
            GrpBestellungen.Controls.Add(textBox1);
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
            GrpBestellungen.Size = new Size(776, 416);
            GrpBestellungen.TabIndex = 0;
            GrpBestellungen.TabStop = false;
            GrpBestellungen.Text = "Bestellungen";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(451, 355);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 14;
            // 
            // TxtBestellNr
            // 
            TxtBestellNr.Location = new Point(72, 308);
            TxtBestellNr.Name = "TxtBestellNr";
            TxtBestellNr.Size = new Size(100, 23);
            TxtBestellNr.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(272, 308);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(272, 355);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(451, 308);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(407, 311);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 9;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(407, 358);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 8;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(228, 358);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 311);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 311);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 5;
            label1.Text = "Bestell Nr.";
            // 
            // CmdFiltern
            // 
            CmdFiltern.Location = new Point(407, 39);
            CmdFiltern.Name = "CmdFiltern";
            CmdFiltern.Size = new Size(135, 23);
            CmdFiltern.TabIndex = 4;
            CmdFiltern.Text = "Nach Kunde filtern";
            CmdFiltern.UseVisualStyleBackColor = true;
            // 
            // CmdBestellungen
            // 
            CmdBestellungen.Location = new Point(263, 39);
            CmdBestellungen.Name = "CmdBestellungen";
            CmdBestellungen.Size = new Size(135, 23);
            CmdBestellungen.TabIndex = 3;
            CmdBestellungen.Text = "Alle Bestellungen";
            CmdBestellungen.UseVisualStyleBackColor = true;
            // 
            // CmdÜbernehmen
            // 
            CmdÜbernehmen.Location = new Point(20, 39);
            CmdÜbernehmen.Name = "CmdÜbernehmen";
            CmdÜbernehmen.Size = new Size(135, 23);
            CmdÜbernehmen.TabIndex = 2;
            CmdÜbernehmen.Text = "Kunde übernehmen";
            CmdÜbernehmen.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { bestellNrDataGridViewTextBoxColumn, kundenNrDataGridViewTextBoxColumn, textDataGridViewTextBoxColumn, preisDataGridViewTextBoxColumn, datumDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bestellungBindingSource;
            dataGridView1.Location = new Point(0, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(542, 176);
            dataGridView1.TabIndex = 1;
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
            // FrmBestellungen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GrpBestellungen);
            Name = "FrmBestellungen";
            Text = "Form1";
            Load += FrmBestellungen_Load;
            GrpBestellungen.ResumeLayout(false);
            GrpBestellungen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bestellungBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
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
        private TextBox textBox5;
        private TextBox TxtBestellNr;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
