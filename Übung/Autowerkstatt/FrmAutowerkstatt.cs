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

        private void CmdHinzuf�gen_Click(object sender, EventArgs e)
        {
            // Objekt f�r Formular Fahrzeug erstellen
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

        private void CmdFahrzeug�bernehmen_Click(object sender, EventArgs e)
        {
            // Aktuell ausgew�hltes Fahrzeug auslesen
            Fahrzeug ausgew�hltesFahrzeug = (Fahrzeug)fahrzeugBindingSource.Current;

            // Falls kein Fahrzeug ausgew�hlt ist => Abbruch (Methode hier verlassen)
            if (ausgew�hltesFahrzeug == null) return;

            // Fahrzeugeigenschaften in Reparaturanzeige �bernehmen
            LblHalter.Text = ausgew�hltesFahrzeug.Halter;
            LblKennzeichen.Text = ausgew�hltesFahrzeug.Kennzeichen;
            LblMarke.Text = ausgew�hltesFahrzeug.Marke;
            LblModell.Text = ausgew�hltesFahrzeug.Modell;
            LblNummer.Text = ausgew�hltesFahrzeug.Nr.ToString();
            LblOrt.Text = ausgew�hltesFahrzeug.Ort;
        }

        private void FrmAutowerkstatt_Load(object sender, EventArgs e)
        {
            // Datenquelle des DataGridView bef�llen
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
                    throw new ArgumentException("G�ltiges Datum ausw�hlen!");
                if (!decimal.TryParse(TxtKosten.Text, out decimal kosten))
                    throw new ArgumentException("Bitte g�ltige Kosten eingeben!");
                if (kosten <= 0)
                    throw new ArgumentException("Reparaturen m�ssen etwas kosten!");
                if (!int.TryParse(LblNummer.Text, out int fahrzeugnummer))
                    throw new ArgumentException("Bitte Fahrzeug ausw�hlen!");

                // Reparatur anlegen & Eigenschaften zuweisen
                Reparatur reparatur = new()
                {
                    FahrzeugNr = fahrzeugnummer,
                    Beschreibung = TxtBeschreibung.Text,
                    Kosten = kosten,
                    Datum = DatDatum.Value
                };

                // Reparatur zur DB hinzuf�gen
                _ctx.Reparaturs.Add(reparatur);

                // Speichern
                _ctx.SaveChanges();

                // Meldung anzeigen
                MessageBox.Show($"Ein neuer Reparaturdatensatz {reparatur.Nr} wurde f�r Fahrzeug {LblKennzeichen.Text} angelegt");

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
            // Objekt f�r Formular Reparaturen erzeugen
            FrmReparaturen frmReparaturen = new();

            // Anzeigen
            frmReparaturen.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Aktuell ausgew�hltes Fahrzeug auslesen und in Variable speichern
            var fahrzeugInBearbeitung = (Fahrzeug)fahrzeugBindingSource.Current;

            // Objekt f�r Formular Fahrzeug erstellen
            FrmFahrzeuge frmFahrzeuge = new()
            {
                FahrzeugInBearbeitung = fahrzeugInBearbeitung
            };

            // Formular anzeigen
            frmFahrzeuge.ShowDialog();

            if (frmFahrzeuge.DialogResult == DialogResult.OK)
            {
                // Pr�fen ob hinzuf�gen oder �ndern
                if (fahrzeugInBearbeitung.Nr == 0)
                    _ctx.Fahrzeugs.Add(fahrzeugInBearbeitung);

                // Speichern
                _ctx.SaveChanges();

                // Update der Anzeige
                fahrzeugBindingSource.DataSource = _ctx.Fahrzeugs.ToList();
                fahrzeugBindingSource.ResetBindings(false);
            }

        }

        private void CmdL�schen_Click(object sender, EventArgs e)
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
