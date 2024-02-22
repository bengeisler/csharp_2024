// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Autowerkstatt.Models;

/* Probleme:
 * - Anzeige in der Tabelle
 * - �berfl�ssige BindingSources werden angelegt
 * - Datenaustausch zwischen den Formularen +2
 * - Speichern: Umsetzung allgemein
 * - Speichern: �bernehmen in die Datenbank
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

        private void CmdHinzuf�gen_Click(object sender, EventArgs e)
        {
            // Objekt f�r das Formular "Fahrzeug" instanziieren
            FrmFahrzeuge frmFahrzeuge = new();

            // Daten �bergeben: aktuell in Tabelle ausgew�hltes Fahrzeug 
            frmFahrzeuge.FahrzeugInBearbeitung = (Fahrzeug)fahrzeugBindingSource.Current;

            // Formular aufrufen
            frmFahrzeuge.Show();
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

            // Felder auf der linken Seite bef�llen
            LblHalter.Text = ausgew�hltesFahrzeug.Halter;
            LblKennzeichen.Text = ausgew�hltesFahrzeug.Kennzeichen;
            // ...


        }

        private void FrmAutowerkstatt_Load(object sender, EventArgs e)
        {
            // Datenquelle bef�llen aus der Tabelle der Datenbank
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

                // Eigenschaften bef�llen
                // neueReparatur.FahrzeugNr = LblNummer.Text; // hier fehlt noch string -> int Umwandlung
                neueReparatur.Beschreibung = TxtBeschreibung.Text;
                // ...

                // Reparatur zur Datenbank hinzuf�gen
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
