// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Autowerkstatt.Models;

namespace Autowerkstatt
{
    public partial class FrmAutowerkstatt : Form
    {
        public FrmAutowerkstatt()
        {
            InitializeComponent();
        }

        private void CmdHinzuf�gen_Click(object sender, EventArgs e)
        {

        }

        private AutowerkstattDbContext _ctx = new();

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ereignismethode CmdHinzuf�gen aufrufen
            CmdHinzuf�gen_Click(null, null);
        }

        private void CmdFahrzeug�bernehmen_Click(object sender, EventArgs e)
        {
            // Aktuell in der Tabelle ausgew�hltes Fahrzeug in Variable speichern
            Fahrzeug ausgew�hltesFahrzeug = (Fahrzeug)fahrzeugBindingSource.Current;


            LblHalter.Text = ausgew�hltesFahrzeug.Halter;
        }

        private void FrmAutowerkstatt_Load(object sender, EventArgs e)
        {
            // Datenquelle bef�llen aus der Tabelle der Datenbank
            fahrzeugBindingSource.DataSource = _ctx.Fahrzeugs.ToList();
        }
    }
}
