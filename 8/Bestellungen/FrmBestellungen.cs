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

        // Kontext-Objekt anlegen, um  mit der Datenbank zu interagieren
        private BestellungDbContext _ctx = new();

        private void FrmBestellungen_Load(object sender, EventArgs e)
        {
            // Datenbindung zwischen Kontext und DataSource einrichten
            bestellungBindingSource.DataSource = _ctx.Bestellungs.ToList();
            kundeBindingSource1.DataSource = _ctx.Kundes.ToList();


        }

        private void CmdFiltern_Click(object sender, EventArgs e)
        {
            // Kundennummer dews ausgew�hlten Kunden
            int Kundennumer = Convert.ToInt32(TxtKundenNr.Text);

            // DataSource aktualisieren
            bestellungBindingSource.DataSource = _ctx.Bestellungs
                .Where(b => b.KundenNr == Kundennumer)
                .ToList();

        }

        private void CmdBestellungen_Click(object sender, EventArgs e)
        {
            bestellungBindingSource.DataSource = _ctx.Bestellungs
                .ToList();


        }

        private void CmdSpeichern_Click(object sender, EventArgs e)
        {
            try
            {
                // Object vom Datentyp Bestellung anlegen; aktuelle Bestellung auslesen und konvertieren
                Bestellung bestellung = (Bestellung)bestellungBindingSource.Current;

                // Fehlerhafte Benutzereingabe abfangen
                if (!int.TryParse(TxtAusgew�hlterKunde.Text, out int kundennummer))
                    throw new ArgumentException("Kundennummer ist ung�ltig");
                if (TxtBestelltext.Text == "")
                    throw new ArgumentException("Bitte Bestelltext angeben");
                if (!decimal.TryParse(TxtPreis.Text, out decimal preis))
                    throw new ArgumentException("Bitte g�ltigen Preis eingeben");
                if (preis <= 0) throw new ArgumentException("Preis muss gr��er als 0 sein");

                // Eigenschaften zuweisen
                bestellung.KundenNr = kundennummer;
                bestellung.Text = TxtBestelltext.Text;
                bestellung.Datum = DatDatum.Value;
                bestellung.Preis = preis;

                // Neue Bestellung anlegen?
                if (bestellung.BestellNr == 0) _ctx.Bestellungs.Add(bestellung);

                // Speichern
                _ctx.SaveChanges();

                // DataSource 
                bestellungBindingSource.DataSource = _ctx.Bestellungs.ToList();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Cmd�bernehmen_Click(object sender, EventArgs e)
        {
            // Aktuell ausgew�hlte Bestellung in Variable speichern
            Bestellung bestellung = (Bestellung)bestellungBindingSource.Current;
            // Aktuell ausgew�hlte Kunden in Variable speichern
            Kunde kunde = (Kunde)bestellungBindingSource.Current;

            // Der aktuellen Bestellung die aktuelle ausgew�hlte Kundennummer zuweisen
            bestellung.KundenNr = kunde.KundenNr;

            // Anzeige akutaliesiern
            TxtKundenNr.Text = bestellung.KundenNr.ToString();
            dataGridView1.Focus();


        }

        private void CmdL�schen_Click(object sender, EventArgs e)
        {
            // Ausgew�hlte Bestellung in Variable speichern und konvertieren
            Bestellung bestellung = (Bestellung)bestellungBindingSource.Current;

            // Pr�fen, ob �berhaupt eine Bestellung ausgew�hlt ist
            // falls nicht: Abbruch
            if (bestellung == null) return;

            // Datensatz aus der Datenbank entfernen
            _ctx.Bestellungs.Remove(bestellung);

            // Speichern
            _ctx.SaveChanges();

            // Anzeige aktualisieren
            bestellungBindingSource.DataSource = _ctx.Bestellungs.ToList();


        }

        private void CmdPreisSortieren_Click(object sender, EventArgs e)
        {
            bestellungBindingSource.DataSource = _ctx.Bestellungs
                .OrderBy(b => b.Preis)
                .ToList();


        }

        private void CmdHinzuf�gen_Click(object sender, EventArgs e)
        {
            // Neuen Eintrag anlegen
            bestellungBindingSource.AddNew();


        }
    }
}
