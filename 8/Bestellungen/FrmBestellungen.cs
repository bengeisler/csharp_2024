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
        //Kontext-Objekt anlegen, um mit der Datenbank zu interagieren

        private BestellungDbContext _ctx = new();

        private void FrmBestellungen_Load(object sender, EventArgs e)
        {
            //Daenbindung zwischen Kontext und DataSource einrichten
            bestellungBindingSource.DataSource = _ctx.Bestellungs.ToList();
            kundeBindingSource.DataSource = _ctx.Kundes.ToList();
        }



        private void CmdButtonKundeÜbern_Click(object sender, EventArgs e)
        {
            int Kundennummer = Convert.ToInt32(textBoxKunde.Text);

            //DataSource aktualisieren
            bestellungBindingSource.DataSource = _ctx.Bestellungs
            .Where(b => b.KundenNr == Kundennummer)
            .ToList();
        }

        private void CmdButtonFilter_Click(object sender, EventArgs e)
        {
            bestellungBindingSource.DataSource = _ctx.Bestellungs
                .ToList();
        }

        private void CmdButtonHinzufügen_Click(object sender, EventArgs e)
        {
            try
            {
                //Objekt vom Datentyp Bestellung anlegen
                Bestellung bestellung = (Bestellung)bestellungBindingSource.Current;
                if (!int.TryParse(textBoxKunde.Text, out int kundennummer))
                    throw new ArgumentException("Kundennummer ist ungültig!");
                if (textBoxBestell.Text == "")
                    throw new ArgumentException("Kundennummer ist ungültig");
                if (!decimal.TryParse(textBoxPreis.Text, out decimal preis))
                    throw new ArgumentException("Bitte gültigen Preis eingeben!");
                if (preis <= 0) throw new ArgumentException("Preis  muss größer 0 sein!");

                //Eigenschaften zuweisen
                bestellung.KundenNr = kundennummer;
                bestellung.Text = textBoxBestell.Text;
                bestellung.Datum = dateTimePicker1.Value;
                bestellung.Preis = preis;

                //Neue Bestellung anlegen?
                if (bestellung.BestellNr == 0) _ctx.Bestellungs.Add(bestellung);


                // speichern
                _ctx.SaveChanges();
                //DataSource aktuallisieren
                bestellungBindingSource.DataSource = _ctx.Bestellungs.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmdButtonbestellung_Click(object sender, EventArgs e)
        {
            //Aktuell ausgewählte Bestellung in Variable speichern
            Bestellung bestellung = (Bestellung)bestellungBindingSource.Current;
            //Aktuell ausgewählten Kunden in Variable speichern
            Kunde kunde = (Kunde)kundeBindingSource.Current;

            //Der aktuellen Bestellung die aktuelle ausgewählte Kundennummer zuweisen
            bestellung.KundenNr = kunde.KundenNr;

            //Anzeige aktualisieren
            textBoxKunde.Text = bestellung.KundenNr.ToString();


        }

        private void CmdButtonClear_Click(object sender, EventArgs e)
        {
            //Ausgewählte Bestellung in Variable speichern und konvertieren;
            Bestellung bestellung = (Bestellung)bestellungBindingSource.Current;

            //Prüfen, ob überhaupt eine Bestellung ausgewählt ist
            //falls nicht: Abbruch
            if (bestellung == null) return;

            //Datensatz aus der Datenbank entfernen
            _ctx.Bestellungs.Remove(bestellung);

            //Speichern
            _ctx.SaveChanges();

            //Anzeige aktualisieren
            // bestellungBindingSource.DataSource = _ctx
        }

        private void CmdButtonSort_Click(object sender, EventArgs e)
        {
            bestellungBindingSource.DataSource = _ctx.Bestellungs
                .OrderBy(a => a.Preis)
                .ThenBy(a => a.Text)
                .ToList();

        }

        private void CmdButtonHinzufügen2_Click(object sender, EventArgs e)
        {
           // bestellungBindingSource.Addnew();
        }
    }
}
