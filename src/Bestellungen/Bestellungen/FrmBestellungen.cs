// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Bestellungen.Models;

namespace Bestellungen
{
    public partial class FrmBestellungen : Form
    {
        public FrmBestellungen()
        {
            InitializeComponent();
        }

        // Kontext-Objekt anlegen, um mit der Datenbank zu interagieren
        private BestellungDbContext _ctx = new();

        private void FrmBestellungen_Load(object sender, EventArgs e)
        {
            // Datenbindung zwischen Kontext und DataSource einrichten
            bestellungBindingSource.DataSource = _ctx.Bestellungs.ToList();
            kundeBindingSource.DataSource = _ctx.Kundes.ToList();
        }

        private void CmdNachKundeFiltern_Click(object sender, EventArgs e)
        {
            // Kundennummer des ausgewählten Kunden aus TextBox auslesen
            int kundennummer = Convert.ToInt32(TxtAusgewählterKunde.Text);

            // DataSource aktualisieren: Bestellungen nach Kundennummer filtern
            bestellungBindingSource.DataSource = _ctx.Bestellungs
                .Where(b => b.KundenNr == kundennummer)
                .ToList();
        }

        private void CmdAlleBestellungen_Click(object sender, EventArgs e)
        {
            bestellungBindingSource.DataSource = _ctx.Bestellungs.ToList();
        }

        private void CmdSpeichern_Click(object sender, EventArgs e)
        {
            try
            {
                // Objekt vom Datentyp Bestellung anlegen; aktuelle Bestellung auslesen und konvertieren
                Bestellung bestellung = (Bestellung)bestellungBindingSource.Current;

                // Fehlerhafte Benutzereingaben abfangen
                if (!int.TryParse(TxtAusgewählterKunde.Text, out int kundennummer))
                    throw new ArgumentException("Kundennummer ist ungültig!");
                if (TxtBestelltext.Text == "")
                    throw new ArgumentException("Bitte Bestelltext angeben!");
                if (!decimal.TryParse(TxtPreis.Text, out decimal preis))
                    throw new ArgumentException("Bitte gültigen Preis eingeben!");
                if (preis <= 0) throw new ArgumentException("Preis muss größer 0 sein!");

                // Eigenschaften zuweisen
                bestellung.KundenNr = kundennummer;
                bestellung.Text = TxtBestelltext.Text;
                bestellung.Datum = DatDatum.Value;
                bestellung.Preis = preis;

                // Neue Bestellung anlegen?
                if (bestellung.BestellNr == 0) _ctx.Bestellungs.Add(bestellung);

                // Speichern
                _ctx.SaveChanges();

                // DataSource aktualisieren
                bestellungBindingSource.DataSource = _ctx.Bestellungs.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmdHinzufügen_Click(object sender, EventArgs e)
        {
            // Neuen Eintrag anlegen
            bestellungBindingSource.AddNew();
        }

        private void CmdKundeÜbernehmen_Click(object sender, EventArgs e)
        {
            // Aktuell ausgewählte Bestellung in Variable speichern
            Bestellung bestellung = (Bestellung)bestellungBindingSource.Current;
            // Aktuell ausgewählten Kunden in Variable speichern
            Kunde kunde = (Kunde)kundeBindingSource.Current;

            // Der aktuellen Bestellung die aktuell ausgewählte Kundennummer zuweisen
            bestellung.KundenNr = kunde.KundenNr;

            // Anzeige aktualisieren
            TxtKundenNr.Text = bestellung.KundenNr.ToString();
            dataGridView1.Focus();
        }

        private void CmdLöschen_Click(object sender, EventArgs e)
        {
            // Ausgewählte Bestellung in Variable speichern und konvertieren
            Bestellung bestellung = (Bestellung)bestellungBindingSource.Current;

            // Prüfen, ob überhaupt eine Bestellung ausgewählt ist
            // falls nicht: Abbruch
            if (bestellung == null) return;

            // Datensatz aus der Datenbank entfernen
            _ctx.Bestellungs.Remove(bestellung);

            // Speichern
            _ctx.SaveChanges();

            // Anzeige aktualisieren
            bestellungBindingSource.DataSource = _ctx.Bestellungs.ToList();
        }

        private void CmdSortieren_Click(object sender, EventArgs e)
        {
            bestellungBindingSource.DataSource = _ctx.Bestellungs
                .OrderBy(b => b.Preis)
                .ToList();
        }
    }
}
