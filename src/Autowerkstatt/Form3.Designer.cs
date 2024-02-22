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
            ComFilter = new ComboBox();
            fahrzeugBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            nrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            datumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            beschreibungDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kostenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fahrzeugNrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reparaturBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)fahrzeugBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reparaturBindingSource).BeginInit();
            SuspendLayout();
            // 
            // CmdAlleAnzeigen
            // 
            CmdAlleAnzeigen.Location = new Point(29, 11);
            CmdAlleAnzeigen.Name = "CmdAlleAnzeigen";
            CmdAlleAnzeigen.Size = new Size(95, 23);
            CmdAlleAnzeigen.TabIndex = 0;
            CmdAlleAnzeigen.Text = "Alle anzeigen";
            CmdAlleAnzeigen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 15);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 1;
            label1.Text = "Filter nach Fahrzeug";
            // 
            // ComFilter
            // 
            ComFilter.DataBindings.Add(new Binding("DataContext", fahrzeugBindingSource, "Kennzeichen", true));
            ComFilter.DataBindings.Add(new Binding("Text", fahrzeugBindingSource, "Kennzeichen", true));
            ComFilter.DataSource = fahrzeugBindingSource;
            ComFilter.DisplayMember = "Kennzeichen";
            ComFilter.FormattingEnabled = true;
            ComFilter.Location = new Point(346, 11);
            ComFilter.Name = "ComFilter";
            ComFilter.Size = new Size(121, 23);
            ComFilter.TabIndex = 2;
            ComFilter.ValueMember = "Nr";
            ComFilter.SelectedIndexChanged += ComFilter_SelectedIndexChanged;
            // 
            // fahrzeugBindingSource
            // 
            fahrzeugBindingSource.DataSource = typeof(Models.Fahrzeug);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(29, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(559, 330);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alle Reparaturen";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nrDataGridViewTextBoxColumn, datumDataGridViewTextBoxColumn, beschreibungDataGridViewTextBoxColumn, kostenDataGridViewTextBoxColumn, fahrzeugNrDataGridViewTextBoxColumn });
            dataGridView1.DataSource = reparaturBindingSource;
            dataGridView1.Location = new Point(0, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(547, 304);
            dataGridView1.TabIndex = 4;
            // 
            // nrDataGridViewTextBoxColumn
            // 
            nrDataGridViewTextBoxColumn.DataPropertyName = "Nr";
            nrDataGridViewTextBoxColumn.HeaderText = "Nr";
            nrDataGridViewTextBoxColumn.Name = "nrDataGridViewTextBoxColumn";
            nrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // beschreibungDataGridViewTextBoxColumn
            // 
            beschreibungDataGridViewTextBoxColumn.DataPropertyName = "Beschreibung";
            beschreibungDataGridViewTextBoxColumn.HeaderText = "Beschreibung";
            beschreibungDataGridViewTextBoxColumn.Name = "beschreibungDataGridViewTextBoxColumn";
            beschreibungDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kostenDataGridViewTextBoxColumn
            // 
            kostenDataGridViewTextBoxColumn.DataPropertyName = "Kosten";
            kostenDataGridViewTextBoxColumn.HeaderText = "Kosten";
            kostenDataGridViewTextBoxColumn.Name = "kostenDataGridViewTextBoxColumn";
            kostenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fahrzeugNrDataGridViewTextBoxColumn
            // 
            fahrzeugNrDataGridViewTextBoxColumn.DataPropertyName = "FahrzeugNr";
            fahrzeugNrDataGridViewTextBoxColumn.HeaderText = "FahrzeugNr";
            fahrzeugNrDataGridViewTextBoxColumn.Name = "fahrzeugNrDataGridViewTextBoxColumn";
            fahrzeugNrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reparaturBindingSource
            // 
            reparaturBindingSource.DataSource = typeof(Models.Reparatur);
            // 
            // FrmReparaturen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 590);
            Controls.Add(groupBox1);
            Controls.Add(ComFilter);
            Controls.Add(label1);
            Controls.Add(CmdAlleAnzeigen);
            Name = "FrmReparaturen";
            Text = "Reparaturen";
            Load += FrmReparaturen_Load;
            ((System.ComponentModel.ISupportInitialize)fahrzeugBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)reparaturBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAlleAnzeigen;
        private Label label1;
        private ComboBox ComFilter;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn beschreibungDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kostenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fahrzeugNrDataGridViewTextBoxColumn;
        private BindingSource reparaturBindingSource;
        private BindingSource fahrzeugBindingSource;
    }
}