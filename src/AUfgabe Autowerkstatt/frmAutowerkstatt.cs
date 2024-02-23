// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Data;
using System.Text;
using AUfgabe_Autowerkstatt.Models;
using Microsoft.EntityFrameworkCore;

namespace AUfgabe_Autowerkstatt
{
    public partial class FrmAutowerkstattHelfer : Form
    {
        public FrmAutowerkstattHelfer()
        {
            InitializeComponent();
        }

        private AutowerkstattDbContext _ctx = new();




        private void Form1_Load(object sender, EventArgs e)
        {

            // Datenbindung zwischen Kontext und Datsource
            fahrzeugBindingSource.DataSource = _ctx.Fahrzeugs.ToList();
            reparaturBindingSource.DataSource = _ctx.Reparaturs.ToList();

        }

        private void CmdFahrzeuguebernehmen_Click(object sender, EventArgs e)
        {
            Fahrzeug fahrzeug = (Fahrzeug)fahrzeugBindingSource.Current;



            LblFahrzeug.Text = fahrzeug.Nr.ToString();
            LblKennzeichen.Text = fahrzeug.Kennzeichen.ToString();
            LblMarke.Text = fahrzeug.Marke.ToString();
            LblModell.Text = fahrzeug.Modell.ToString();
            LblHalter.Text = fahrzeug.Halter.ToString();
            LblOrt.Text = fahrzeug.Ort.ToString();












        }

        private void CmdHinzuf�gen_Click(object sender, EventArgs e)
        {
            FrmFahzeuge frmFahzeuge = new();

            frmFahzeuge.FahrzeugInBearbeitung = (Fahrzeug)fahrzeugBindingSource.Current;

            frmFahzeuge.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmFahzeuge frmFahzeuge = new();

            frmFahzeuge.FahrzeugInBearbeitung = (Fahrzeug)fahrzeugBindingSource.Current;

            frmFahzeuge.Show();
        }

        private void CmdSpeichern_Click(object sender, EventArgs e)
        {

        }

        private void CmdL�schen_Click(object sender, EventArgs e)
        {
            // �berpr�fen, ob eine Zeile ausgew�hlt ist
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Index der ausgew�hlten Zeile
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                // DataRowView der ausgew�hlten Zeile
                DataRowView rowView = dataGridView1.Rows[selectedIndex].DataBoundItem as DataRowView;

                // DataRow der ausgew�hlten Zeile
                DataRow row = rowView.Row;

                // Den Datensatz l�schen
                row.Delete();

               

                
            }
            else
            {
                MessageBox.Show("Bitte w�hle eine Zeile zum L�schen aus.");
            }













        }
        
    }
}
