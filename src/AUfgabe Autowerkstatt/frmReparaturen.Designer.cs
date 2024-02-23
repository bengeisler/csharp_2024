// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace AUfgabe_Autowerkstatt
{
    partial class frmReparaturen
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
            cmdAlleanzeigen = new Button();
            LblFilternachFahrzeug = new Label();
            CombFilterFahzeug = new ComboBox();
            dataGridView1 = new DataGridView();
            nrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            datumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            beschreibungDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kostenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fahrzeugNrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fahrzeugNrNavigationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reparaturBindingSource1 = new BindingSource(components);
            GrpReparaturen = new GroupBox();
            reparaturBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reparaturBindingSource1).BeginInit();
            GrpReparaturen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reparaturBindingSource).BeginInit();
            SuspendLayout();
            // 
            // cmdAlleanzeigen
            // 
            cmdAlleanzeigen.Location = new Point(35, 26);
            cmdAlleanzeigen.Name = "cmdAlleanzeigen";
            cmdAlleanzeigen.Size = new Size(126, 23);
            cmdAlleanzeigen.TabIndex = 0;
            cmdAlleanzeigen.Text = "Alle anzeigen";
            cmdAlleanzeigen.UseVisualStyleBackColor = true;
            cmdAlleanzeigen.Click += cmdAlleanzeigen_Click;
            // 
            // LblFilternachFahrzeug
            // 
            LblFilternachFahrzeug.AutoSize = true;
            LblFilternachFahrzeug.Location = new Point(254, 30);
            LblFilternachFahrzeug.Name = "LblFilternachFahrzeug";
            LblFilternachFahrzeug.Size = new Size(113, 15);
            LblFilternachFahrzeug.TabIndex = 1;
            LblFilternachFahrzeug.Text = "Filter nach Fahrzeug";
            // 
            // CombFilterFahzeug
            // 
            CombFilterFahzeug.FormattingEnabled = true;
            CombFilterFahzeug.Location = new Point(411, 26);
            CombFilterFahzeug.Name = "CombFilterFahzeug";
            CombFilterFahzeug.Size = new Size(121, 23);
            CombFilterFahzeug.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nrDataGridViewTextBoxColumn, datumDataGridViewTextBoxColumn, beschreibungDataGridViewTextBoxColumn, kostenDataGridViewTextBoxColumn, fahrzeugNrDataGridViewTextBoxColumn, fahrzeugNrNavigationDataGridViewTextBoxColumn });
            dataGridView1.DataSource = reparaturBindingSource1;
            dataGridView1.Location = new Point(32, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(594, 250);
            dataGridView1.TabIndex = 3;
            // 
            // nrDataGridViewTextBoxColumn
            // 
            nrDataGridViewTextBoxColumn.DataPropertyName = "Nr";
            nrDataGridViewTextBoxColumn.HeaderText = "Nr";
            nrDataGridViewTextBoxColumn.Name = "nrDataGridViewTextBoxColumn";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // beschreibungDataGridViewTextBoxColumn
            // 
            beschreibungDataGridViewTextBoxColumn.DataPropertyName = "Beschreibung";
            beschreibungDataGridViewTextBoxColumn.HeaderText = "Beschreibung";
            beschreibungDataGridViewTextBoxColumn.Name = "beschreibungDataGridViewTextBoxColumn";
            // 
            // kostenDataGridViewTextBoxColumn
            // 
            kostenDataGridViewTextBoxColumn.DataPropertyName = "Kosten";
            kostenDataGridViewTextBoxColumn.HeaderText = "Kosten";
            kostenDataGridViewTextBoxColumn.Name = "kostenDataGridViewTextBoxColumn";
            // 
            // fahrzeugNrDataGridViewTextBoxColumn
            // 
            fahrzeugNrDataGridViewTextBoxColumn.DataPropertyName = "FahrzeugNr";
            fahrzeugNrDataGridViewTextBoxColumn.HeaderText = "FahrzeugNr";
            fahrzeugNrDataGridViewTextBoxColumn.Name = "fahrzeugNrDataGridViewTextBoxColumn";
            // 
            // fahrzeugNrNavigationDataGridViewTextBoxColumn
            // 
            fahrzeugNrNavigationDataGridViewTextBoxColumn.DataPropertyName = "FahrzeugNrNavigation";
            fahrzeugNrNavigationDataGridViewTextBoxColumn.HeaderText = "FahrzeugNrNavigation";
            fahrzeugNrNavigationDataGridViewTextBoxColumn.Name = "fahrzeugNrNavigationDataGridViewTextBoxColumn";
            // 
            // reparaturBindingSource1
            // 
            reparaturBindingSource1.DataSource = typeof(Models.Reparatur);
            // 
            // GrpReparaturen
            // 
            GrpReparaturen.Controls.Add(dataGridView1);
            GrpReparaturen.Location = new Point(59, 84);
            GrpReparaturen.Name = "GrpReparaturen";
            GrpReparaturen.Size = new Size(729, 354);
            GrpReparaturen.TabIndex = 4;
            GrpReparaturen.TabStop = false;
            GrpReparaturen.Text = "Alle Reparaturen";
            GrpReparaturen.Enter += GrpReparaturen_Enter;
            // 
            // reparaturBindingSource
            // 
            reparaturBindingSource.DataSource = typeof(Models.Reparatur);
            // 
            // frmReparaturen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GrpReparaturen);
            Controls.Add(CombFilterFahzeug);
            Controls.Add(LblFilternachFahrzeug);
            Controls.Add(cmdAlleanzeigen);
            Name = "frmReparaturen";
            Text = "frmReparaturen";
            Load += frmReparaturen_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)reparaturBindingSource1).EndInit();
            GrpReparaturen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)reparaturBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdAlleanzeigen;
        private Label LblFilternachFahrzeug;
        private ComboBox CombFilterFahzeug;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn beschreibungDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kostenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fahrzeugNrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fahrzeugNrNavigationDataGridViewTextBoxColumn;
        private BindingSource reparaturBindingSource1;
        private GroupBox GrpReparaturen;
        private BindingSource reparaturBindingSource;
    }
}