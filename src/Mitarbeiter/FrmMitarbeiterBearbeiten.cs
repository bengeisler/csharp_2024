// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Mitarbeiterverwaltung.Models;

namespace Mitarbeiterverwaltung
{
    public partial class FrmMitarbeiterBearbeiten : Form
    {
        public FrmMitarbeiterBearbeiten()
        {
            InitializeComponent();
        }

        FirmaDbContext _ctx = new();
        BindingSource _bs = new();
        public Mitarbeiter MitarbeiterInBearbeitung;

        private void FrmMitarbeiterBearbeiten_Load(object sender, EventArgs e)
        {
            _bs.DataSource = _ctx.Abteilungs.ToList();
            CboxAbteilung.DataSource = _bs.DataSource;
            CboxAbteilung.DisplayMember = "Bezeichnung";
            CboxAbteilung.ValueMember = "AbteilungsNr";

            // Falls ein neuer Mitarbeiter angelegt wird, können die Eingabefelder
            // leer bleiben. Ein neuer Mitarbeiter hat die Personalnummer 0, da er noch
            // nicht in der Datenbank angelegt wurde
            if (MitarbeiterInBearbeitung.PersonalNr == 0) return;

            TxtAdresse.Text = MitarbeiterInBearbeitung.Adresse;
            TxtName.Text = MitarbeiterInBearbeitung.Name;
            TxtOrt.Text = MitarbeiterInBearbeitung.Ort;
            TxtPersonalnummer.Text = MitarbeiterInBearbeitung.PersonalNr.ToString();
            TxtPlz.Text = MitarbeiterInBearbeitung.Plz;
            TxtStellenbezeichnung.Text = MitarbeiterInBearbeitung.Stellenbezeichnung;
            TxtTelefonnummer.Text = MitarbeiterInBearbeitung.Telefon;
            TxtVorname.Text = MitarbeiterInBearbeitung.Vorname;
            CboxAbteilung.SelectedValue = MitarbeiterInBearbeitung.AbteilungsNr;
        }

        private void CmdSpeichern_Click(object sender, EventArgs e)
        {
            try
            {
                // Validierung der Benutzereingabe
                if (TxtName.Text == "")
                    throw new ArgumentException("Bitte Name eingeben");
                if (TxtVorname.Text == "")
                    throw new ArgumentException("Bitte Vorname eingeben");
                if (TxtStellenbezeichnung.Text == "")
                    throw new ArgumentException("Bitte Stellenbezeichnung eingeben");
                if (TxtAdresse.Text == "")
                    throw new ArgumentException("Bitte Adresse eingeben");
                if (TxtPlz.Text == "" || TxtPlz.Text.Length != 5)
                    throw new ArgumentException("Bitte gültige PLZ eingeben");
                if (TxtOrt.Text == "")
                    throw new ArgumentException("Bitte Ort eingeben");
                if (TxtTelefonnummer.Text == "")
                    throw new ArgumentException("Bitte Telefonnummer eingeben");
                if (CboxAbteilung.SelectedValue == null)
                    throw new ArgumentException("Bitte Abteilung auswählen!");

                // Eigenschaften des Objekts zuweisen
                MitarbeiterInBearbeitung.Name = TxtName.Text;
                MitarbeiterInBearbeitung.Vorname = TxtVorname.Text;
                MitarbeiterInBearbeitung.Adresse = TxtAdresse.Text;
                MitarbeiterInBearbeitung.Ort = TxtOrt.Text;
                MitarbeiterInBearbeitung.Plz = TxtPlz.Text;
                MitarbeiterInBearbeitung.Telefon = TxtTelefonnummer.Text;
                MitarbeiterInBearbeitung.Stellenbezeichnung = TxtStellenbezeichnung.Text;
                // Abteilungsnummer: Verknüpfung zwischen den Tabellen
                // Da für die ComboBox der ValueMember auf die Eigenschaft AbteilungsNr des
                // Objekts Abteilung gesetzt wurde, kann über SelectedValue die ausgewählte
                // Abteilungsnummer ausgelesen werden
                MitarbeiterInBearbeitung.AbteilungsNr = (int)CboxAbteilung.SelectedValue;

                // DialogResult setzten
                DialogResult = DialogResult.OK;

                // Schließen
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmdAbbrechen_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FrmMitarbeiterBearbeiten_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Sicherheitsabfrage anzeigen
            var ergebnis = MessageBox.Show(
                "Wollen Sie wirklich abbrechen?",
                "Abbrechen",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Ergebnis auswerten
            if (ergebnis != DialogResult.Yes)
                // Schließen abbrechen, falls nicht mit "Ja" bestätigt wurde
                e.Cancel = true;
        }
    }
}
