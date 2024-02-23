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
            Fahrzeug fahrzeug = new Fahrzeug();
            fahrzeug.Kennzeichen = LblKennzeichen.Text;
            fahrzeug.Halter = LblHalter.Text;
            fahrzeug.Ort = LblOrt.Text;
            fahrzeug.Modell = LblModell.Text;
            fahrzeug.Marke = LblMarke.Text;



            _ctx.Fahrzeugs.Add(fahrzeug);
            _ctx.SaveChanges();




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
                // Validierung der Eingabe
                if (TxtBeschreibung.Text == "")
                    throw new ArgumentException("Bitte Beschreibung eingeben!");
                if (DatDatum.Value > DateTime.Now)
                    throw new ArgumentException("Gültiges Datum auswählen!");
                if (!decimal.TryParse(TxtKosten.Text, out decimal kosten))
                    throw new ArgumentException("Bitte gültige Kosten eingeben!");
                if (kosten <= 0)
                    throw new ArgumentException("Reparaturen müssen etwas kosten!");
                if (!int.TryParse(LblFahrzeug.Text, out int fahrzeugnummer))
                    throw new ArgumentException("Bitte Fahrzeug auswählen!");

                // Reparatur anlegen & Eigenschaften zuweisen
                Reparatur reparatur = new()
                {
                    FahrzeugNr = fahrzeugnummer,
                    Beschreibung = TxtBeschreibung.Text,
                    Kosten = kosten,
                    Datum = DatDatum.Value
                };

                // Reparatur zur DB hinzufügen
                _ctx.Reparaturs.Add(reparatur);

                // Speichern
                _ctx.SaveChanges();

                // Meldung anzeigen
                MessageBox.Show($"Ein neuer Reparaturdatensatz {reparatur.Nr} wurde für Fahrzeug {LblKennzeichen.Text} angelegt");

                // Felder leeren
                TxtBeschreibung.Text = "";
                TxtKosten.Text = "";
                DatDatum.Value = DateTime.Now;

                LblHalter.Text = "";
                LblKennzeichen.Text = "";
                LblMarke.Text = "";
                LblModell.Text = "";
                LblFahrzeug.Text = "";
                LblOrt.Text = "";



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

        private void CmdLöschen_Click(object sender, EventArgs e)
        {
            try
            {
                // Aktuell ausgewähltes Fahrzeuge auslesen
                Fahrzeug fahrzeug = (Fahrzeug)fahrzeugBindingSource.Current;

                // Abbruch, falls nichts ausgewählt ist
                if (fahrzeug == null) return;

                // Alle Reparaturen dieses Fahrzeugs löschen
                foreach (var reparatur in fahrzeug.Reparaturs)
                    _ctx.Reparaturs.Remove(reparatur);

                // Fahrzeug löschen


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
