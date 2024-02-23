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
        // Kontext Obejkt
        private BestellungDbContext _ctx = new();

        private void FrmBestellungen_Load(object sender, EventArgs e)
        {
            // Datenbindung zwischen Kontext und Datsource
            bestellungBindingSource.DataSource = _ctx.Bestellungs.ToList();
            kundeBindingSource.DataSource = _ctx.Kundes.ToList();
        }

        private void cmdNachKundefiltern_Click(object sender, EventArgs e)
        {
            int kundennummer = Convert.ToInt32(TxtKundenNr.Text);


            bestellungBindingSource.DataSource = _ctx.Bestellungs
                .Where(x => x.KundenNr == kundennummer)
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
                // Objekt vom Datentyp Bestellung
                Bestellung bestellung = (Bestellung)bestellungBindingSource.Current;


                if (!int.TryParse(TxtKundennummer.Text, out int kundennummer))
                    throw new ArgumentException("Kundennummer ist ungültig");
                if (TxtBestelltext.Text == "")
                    throw new ArgumentException("Bitte Bestelltext angeben!");
                if (!decimal.TryParse(TxtPReis.Text, out decimal preis))
                    throw new ArgumentException("Bitte gültigen Preis eingeben"!);
                if (preis <= 0) throw new ArgumentException("PReis muss größer 0 sein!");




                bestellung.KundenNr = kundennummer;
                bestellung.Text = TxtBestellNr.Text;
                bestellung.Text = TxtBestelltext.Text;
                bestellung.Preis = preis;

                if (bestellung.BestellNr == 0) _ctx.Bestellungs.Add(bestellung);


                //Speichern
                _ctx.SaveChanges();

                // DataSource aktualisieren
                bestellungBindingSource.DataSource = _ctx.Bestellungs.ToList();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void CmdÜbernehmen_Click(object sender, EventArgs e)
        {
            Bestellung bestellung = (Bestellung)bestellungBindingSource.Current;

            Kunde kunde = (Kunde)kundeBindingSource.Current;

            // Der aktuellen Bestellung die aktuell aisgewählte Kundenummer zuweisen
            bestellung.KundenNr = kunde.KundenNr;

            TxtKundenNr.Text = bestellung.KundenNr.ToString();
            dataGridView1.Focus();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ausgewählte Bestellung in Variable speichern und konvertiere
            Bestellung bestellung = (Bestellung)bestellungBindingSource.Current;

            // Prüfen ob überhaupt eine BEstellung ausgewählt ist
            // falls nicht : Abbruch
            if (bestellung == null) return;

            _ctx.Bestellungs.Remove(bestellung);

            //Speichern
            _ctx.SaveChanges();


            // Anzeige aktualisieren
            bestellungBindingSource.DataSource = _ctx.Bestellungs.ToList();

        }

        private void CmdPreisSortieren_Click(object sender, EventArgs e)
        {
            bestellungBindingSource.DataSource = _ctx.Bestellungs


                .OrderByDescending(a => a.Datum)
                .ToList();



        }

        private void CMdHinzufügen_Click(object sender, EventArgs e)
        {
            // Neuen Eintrag anlegen
            bestellungBindingSource.AddNew();

        }
    }
}
