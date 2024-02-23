// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Autowerkstatt.Models;

namespace Autowerkstatt
{
    public partial class FrmAutowerkstatt : Form
    {
        // DB-Kontext-Objekt erstellen
        private AutowerkstattDbContext _ctx = new();

        public FrmAutowerkstatt()
        {
            InitializeComponent();
        }

        private void CmdHinzufügen_Click(object sender, EventArgs e)
        {
            // Objekt für Formular Fahrzeug erstellen
            FrmFahrzeuge frmFahrzeuge = new()
            {
                FahrzeugInBearbeitung = new Fahrzeug()
            };

            // Formular anzeigen
            frmFahrzeuge.ShowDialog();

            // Nach Speichern Tabelle aktualisieren
            if (frmFahrzeuge.DialogResult == DialogResult.OK)
            {
                _ctx.SaveChanges();
                fahrzeugBindingSource.DataSource = _ctx.Fahrzeugs.ToList();
                fahrzeugBindingSource.ResetBindings(false);
            }



        }

        private void CmdFahrzeugÜbernehmen_Click(object sender, EventArgs e)
        {
            // Aktuell ausgewähltes Fahrzeug auslesen
            Fahrzeug ausgewähltesFahrzeug = (Fahrzeug)fahrzeugBindingSource.Current;

            // Falls kein Fahrzeug ausgewählt ist => Abbruch (Methode hier verlassen)
            if (ausgewähltesFahrzeug == null) return;

            // Fahrzeugeigenschaften in Reparaturanzeige übernehmen
            LblHalter.Text = ausgewähltesFahrzeug.Halter;
            LblKennzeichen.Text = ausgewähltesFahrzeug.Kennzeichen;
            LblMarke.Text = ausgewähltesFahrzeug.Marke;
            LblModell.Text = ausgewähltesFahrzeug.Modell;
            LblNummer.Text = ausgewähltesFahrzeug.Nr.ToString();
            LblOrt.Text = ausgewähltesFahrzeug.Ort;
        }

        private void FrmAutowerkstatt_Load(object sender, EventArgs e)
        {
            // Datenquelle des DataGridView befüllen
            fahrzeugBindingSource.DataSource = _ctx.Fahrzeugs.ToList();
        }

        private void CmdReparaturSpeichern_Click(object sender, EventArgs e)
        {
            // Datenbankzugriff mit try/catch absichern
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
                if (!int.TryParse(LblNummer.Text, out int fahrzeugnummer))
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
                LblNummer.Text = "";
                LblOrt.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmdReparaturenAnzeigen_Click(object sender, EventArgs e)
        {
            // Objekt für Formular Reparaturen erzeugen
            FrmReparaturen frmReparaturen = new();

            // Anzeigen
            frmReparaturen.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Aktuell ausgewähltes Fahrzeug auslesen und in Variable speichern
            var fahrzeugInBearbeitung = (Fahrzeug)fahrzeugBindingSource.Current;

            // Objekt für Formular Fahrzeug erstellen
            FrmFahrzeuge frmFahrzeuge = new()
            {
                FahrzeugInBearbeitung = fahrzeugInBearbeitung
            };

            // Formular anzeigen
            frmFahrzeuge.ShowDialog();

            if (frmFahrzeuge.DialogResult == DialogResult.OK)
            {
                // Prüfen ob hinzufügen oder ändern
                if (fahrzeugInBearbeitung.Nr == 0)
                    _ctx.Fahrzeugs.Add(fahrzeugInBearbeitung);

                // Speichern
                _ctx.SaveChanges();

                // Update der Anzeige
                fahrzeugBindingSource.DataSource = _ctx.Fahrzeugs.ToList();
                fahrzeugBindingSource.ResetBindings(false);
            }

        }

        private void CmdLöschen_Click(object sender, EventArgs e)
        {
            try
            {
            Fahrzeug fahrzeug = (Fahrzeug)fahrzeugBindingSource.Current;

            if (fahrzeug == null) return;


            }
            catch (Exception)
            {

                throw;
            }
            

        }
    }
}
