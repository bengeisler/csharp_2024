// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Autowerkstatt.Models;

/* Probleme:
 * - Anzeige in der Tabelle
 * - Überflüssige BindingSources werden angelegt
 * - Datenaustausch zwischen den Formularen +2
 * - Speichern: Umsetzung allgemein
 * - Speichern: Übernehmen in die Datenbank
 * - 
*/
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
            // Objekt für das Formular "Fahrzeug" instanziieren
            FrmFahrzeuge frmFahrzeuge = new();

            // Daten übergeben: aktuell in Tabelle ausgewähltes Fahrzeug 
            frmFahrzeuge.FahrzeugInBearbeitung = (Fahrzeug)fahrzeugBindingSource.Current;

            // Formular aufrufen
            frmFahrzeuge.Show();
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

            // Felder auf der linken Seite befüllen
            LblHalter.Text = ausgewähltesFahrzeug.Halter;
            LblKennzeichen.Text = ausgewähltesFahrzeug.Kennzeichen;
            // ...


        }

        private void FrmAutowerkstatt_Load(object sender, EventArgs e)
        {
            // Datenquelle befüllen aus der Tabelle der Datenbank
            fahrzeugBindingSource.DataSource = _ctx.Fahrzeugs.ToList();
        }

        private void CmdReparaturSpeichern_Click(object sender, EventArgs e)
        {
            // Datenbankzugriff mit try/catch
            try
            {
                // Benutzereingaben validieren
                // if (...) throw ...
                // - Kennzeichen nicht leer
                // - Beschreibung nicht leer
                // - Kosten >= 0
                // ...

                // Neue Reparatur anlegen
                Reparatur neueReparatur = new();

                // Eigenschaften befüllen
                // neueReparatur.FahrzeugNr = LblNummer.Text; // hier fehlt noch string -> int Umwandlung
                neueReparatur.Beschreibung = TxtBeschreibung.Text;
                // ...

                // Reparatur zur Datenbank hinzufügen
                _ctx.Reparaturs.Add(neueReparatur);

                // Speichern
                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
