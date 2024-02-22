// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Autowerkstatt.Models;
using Microsoft.EntityFrameworkCore;

namespace Autowerkstatt
{
    public partial class FrmWerkstatt : Form
    {
        public FrmWerkstatt()
        {

            InitializeComponent();
        }
        private AutowerkstattDbContext _ctx = new();


        private void FrmWerkstatt_Load(object sender, EventArgs e)
        {
            fahrzeugBindingSource.DataSource = _ctx.Fahrzeugs.ToList();
            reparaturBindingSource.DataSource = _ctx.Reparaturs.ToList();
        }

        private void CmdSpeichern2_Click(object sender, EventArgs e)
        {

        }

        private void CmdFahrzeugÜbernehmen_Click(object sender, EventArgs e)
        {
            Fahrzeug fahrzeug = (Fahrzeug)fahrzeugBindingSource.Current;
            Reparatur reparatur = (Reparatur)reparaturBindingSource.Current;

            LblFahrzeug.Text = fahrzeug.Nr.ToString();
            LblKennzeichen.Text = fahrzeug.Kennzeichen.ToString();
            LblMarke.Text = fahrzeug.Marke.ToString();
            LblModell.Text = fahrzeug.Modell.ToString();
            LblHalter.Text = fahrzeug.Halter.ToString();
            LblOrt.Text = fahrzeug.Ort.ToString();

        }

        private void CmdHinzufügen_Click(object sender, EventArgs e)
        {
            // Objekt für das Formular "Fahrzeug"  
            FrmFahrzeuge frmFahrzeuge = new();

            //Daten übergeben: aktuell in Tabelle ausgewähltes Fahrzeug
            frmFahrzeuge.FahrzeugInBearbeitung = (Fahrzeug)fahrzeugBindingSource.Current;

            // Formular aufrufen
            frmFahrzeuge.Show();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFahrzeuge frmFahrzeuge = new();
            frmFahrzeuge.FahrzeugInBearbeitung = (Fahrzeug)fahrzeugBindingSource.Current;
            frmFahrzeuge.Show();
        }

        private void CmdSpeichern_Click(object sender, EventArgs e)
        {
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

                dotnet ef dbcontext scaffold "Server=(localdb)\mssqllocaldb; Database=BestellungDb; Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer - o Models

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void CmdReparaturenAnzeigen_Click(object sender, EventArgs e)
        {
            FrmReparaturen frmReparaturen = new();
            frmReparaturen.FahrzeugInReparatur = (Fahrzeug)fahrzeugBindingSource.Current;
            frmReparaturen.Show();
        }
    }
}
