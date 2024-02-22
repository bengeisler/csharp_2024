// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Autowerkstatt
{
    partial class FrmReparaturen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            CmdAlleAnzeigen = new Button();
            label1 = new Label();
            LblFilter = new Label();
            dataGridView1 = new DataGridView();
            CboxFilter = new ComboBox();
            reparaturBindingSource = new BindingSource(components);
            nrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            datumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            beschreibungDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kostenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fahrzeugNrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reparaturBindingSource).BeginInit();
            SuspendLayout();
            // 
            // CmdAlleAnzeigen
            // 
            CmdAlleAnzeigen.Location = new Point(12, 12);
            CmdAlleAnzeigen.Name = "CmdAlleAnzeigen";
            CmdAlleAnzeigen.Size = new Size(178, 34);
            CmdAlleAnzeigen.TabIndex = 0;
            CmdAlleAnzeigen.Text = "Alle anzeigen";
            CmdAlleAnzeigen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 17);
            label1.Name = "label1";
            label1.Size = new Size(172, 25);
            label1.TabIndex = 1;
            label1.Text = "Filter nach Fahrzeug:";
            // 
            // LblFilter
            // 
            LblFilter.AutoSize = true;
            LblFilter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblFilter.Location = new Point(12, 80);
            LblFilter.Name = "LblFilter";
            LblFilter.Size = new Size(206, 32);
            LblFilter.TabIndex = 2;
            LblFilter.Text = "Alle Reparaturen";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nrDataGridViewTextBoxColumn, datumDataGridViewTextBoxColumn, beschreibungDataGridViewTextBoxColumn, kostenDataGridViewTextBoxColumn, fahrzeugNrDataGridViewTextBoxColumn });
            dataGridView1.DataSource = reparaturBindingSource;
            dataGridView1.Location = new Point(12, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(883, 319);
            dataGridView1.TabIndex = 3;
            // 
            // CboxFilter
            // 
            CboxFilter.FormattingEnabled = true;
            CboxFilter.Location = new Point(392, 14);
            CboxFilter.Name = "CboxFilter";
            CboxFilter.Size = new Size(252, 33);
            CboxFilter.TabIndex = 4;
            // 
            // reparaturBindingSource
            // 
            reparaturBindingSource.DataSource = typeof(Models.Reparatur);
            // 
            // nrDataGridViewTextBoxColumn
            // 
            nrDataGridViewTextBoxColumn.DataPropertyName = "Nr";
            nrDataGridViewTextBoxColumn.HeaderText = "Nr";
            nrDataGridViewTextBoxColumn.MinimumWidth = 8;
            nrDataGridViewTextBoxColumn.Name = "nrDataGridViewTextBoxColumn";
            nrDataGridViewTextBoxColumn.ReadOnly = true;
            nrDataGridViewTextBoxColumn.Width = 150;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            datumDataGridViewTextBoxColumn.MinimumWidth = 8;
            datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            datumDataGridViewTextBoxColumn.ReadOnly = true;
            datumDataGridViewTextBoxColumn.Width = 150;
            // 
            // beschreibungDataGridViewTextBoxColumn
            // 
            beschreibungDataGridViewTextBoxColumn.DataPropertyName = "Beschreibung";
            beschreibungDataGridViewTextBoxColumn.HeaderText = "Beschreibung";
            beschreibungDataGridViewTextBoxColumn.MinimumWidth = 8;
            beschreibungDataGridViewTextBoxColumn.Name = "beschreibungDataGridViewTextBoxColumn";
            beschreibungDataGridViewTextBoxColumn.ReadOnly = true;
            beschreibungDataGridViewTextBoxColumn.Width = 150;
            // 
            // kostenDataGridViewTextBoxColumn
            // 
            kostenDataGridViewTextBoxColumn.DataPropertyName = "Kosten";
            kostenDataGridViewTextBoxColumn.HeaderText = "Kosten";
            kostenDataGridViewTextBoxColumn.MinimumWidth = 8;
            kostenDataGridViewTextBoxColumn.Name = "kostenDataGridViewTextBoxColumn";
            kostenDataGridViewTextBoxColumn.ReadOnly = true;
            kostenDataGridViewTextBoxColumn.Width = 150;
            // 
            // fahrzeugNrDataGridViewTextBoxColumn
            // 
            fahrzeugNrDataGridViewTextBoxColumn.DataPropertyName = "FahrzeugNr";
            fahrzeugNrDataGridViewTextBoxColumn.HeaderText = "FahrzeugNr";
            fahrzeugNrDataGridViewTextBoxColumn.MinimumWidth = 8;
            fahrzeugNrDataGridViewTextBoxColumn.Name = "fahrzeugNrDataGridViewTextBoxColumn";
            fahrzeugNrDataGridViewTextBoxColumn.ReadOnly = true;
            fahrzeugNrDataGridViewTextBoxColumn.Width = 150;
            // 
            // FrmReparaturen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 450);
            Controls.Add(CboxFilter);
            Controls.Add(dataGridView1);
            Controls.Add(LblFilter);
            Controls.Add(label1);
            Controls.Add(CmdAlleAnzeigen);
            Name = "FrmReparaturen";
            Text = "Reparaturen";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)reparaturBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAlleAnzeigen;
        private Label label1;
        private Label LblFilter;
        private DataGridView dataGridView1;
        private ComboBox CboxFilter;
        private DataGridViewTextBoxColumn nrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn beschreibungDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kostenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fahrzeugNrDataGridViewTextBoxColumn;
        private BindingSource reparaturBindingSource;
    }
}