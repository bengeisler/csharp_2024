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

        private void CmdFahrzeug�bernehmen_Click(object sender, EventArgs e)
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

        private void CmdHinzuf�gen_Click(object sender, EventArgs e)
        {
            // Objekt f�r das Formular "Fahrzeug"  
            FrmFahrzeuge frmFahrzeuge = new();

            //Daten �bergeben: aktuell in Tabelle ausgew�hltes Fahrzeug
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
                    throw new ArgumentException("G�ltiges Datum ausw�hlen!");
                if (!decimal.TryParse(TxtKosten.Text, out decimal kosten))
                    throw new ArgumentException("Bitte g�ltige Kosten eingeben!");
                if (kosten <= 0)
                    throw new ArgumentException("Reparaturen m�ssen etwas kosten!");
                if (!int.TryParse(LblFahrzeug.Text, out int fahrzeugnummer))
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

        private void CmdL�schen_Click(object sender, EventArgs e)
        {
            try
            {
                // Aktuell ausgew�hltes Fahrzeuge auslesen
                Fahrzeug fahrzeug = (Fahrzeug)fahrzeugBindingSource.Current;

                // Abbruch, falls nichts ausgew�hlt ist
                if (fahrzeug == null) return;

                // Alle Reparaturen dieses Fahrzeugs l�schen
                foreach (var reparatur in fahrzeug.Reparaturs)
                    _ctx.Reparaturs.Remove(reparatur);

                // Fahrzeug l�schen


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
