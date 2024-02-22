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

        private void CmdHinzufügen_Click(object sender, EventArgs e)
        {

        }

        private AutowerkstattDbContext _ctx = new();

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ereignismethode CmdHinzufügen aufrufen
            CmdHinzufügen_Click(null, null);
        }

        private void CmdFahrzeugÜbernehmen_Click(object sender, EventArgs e)
        {
            // Aktuell in der Tabelle ausgewähltes Fahrzeug in Variable speichern
            Fahrzeug ausgewähltesFahrzeug = (Fahrzeug)fahrzeugBindingSource.Current;


            LblHalter.Text = ausgewähltesFahrzeug.Halter;
        }

        private void FrmAutowerkstatt_Load(object sender, EventArgs e)
        {
            // Datenquelle befüllen aus der Tabelle der Datenbank
            fahrzeugBindingSource.DataSource = _ctx.Fahrzeugs.ToList();
        }
    }
}
