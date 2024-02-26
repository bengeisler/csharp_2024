// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using Mitarbeiterverwaltung.Models;

namespace Mitarbeiterverwaltung
{
    public partial class FrmMitarbeiterverwaltung : Form
    {
        public FrmMitarbeiterverwaltung()
        {
            InitializeComponent();
        }

        // Datenbank-Kontext-Objekt erstellen
        private FirmaDbContext _ctx = new();

        private void CmdMitarbeiterHinzuf�gen_Click(object sender, EventArgs e)
        {
            // Objekt vom Typ MitarbeiterBearbeiten erstellen (Formular)
            FrmMitarbeiterBearbeiten frmMitarbeiterBearbeiten = new()
            {
                // 
                MitarbeiterInBearbeitung = new()
            };

            // Formular anzeigen
            frmMitarbeiterBearbeiten.ShowDialog();

            // Speichern, falls Benutzer auf Speichern geklickt hat
            if (frmMitarbeiterBearbeiten.DialogResult == DialogResult.OK)
            {
                // Datenbankzugriff immer in try-catch!
                try
                {
                    // Datensatz der Tabelle hinzuf�gen
                    _ctx.Mitarbeiters.Add(frmMitarbeiterBearbeiten.MitarbeiterInBearbeitung);

                    // Speichern
                    _ctx.SaveChanges();

                    // Anzeige updaten
                    mitarbeiterBindingSource.DataSource = _ctx.Mitarbeiters.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FrmMitarbeiterverwaltung_Load(object sender, EventArgs e)
        {
            // DataGridViews bef�llen
            mitarbeiterBindingSource.DataSource = _ctx.Mitarbeiters.ToList();
            abteilungBindingSource.DataSource = _ctx.Abteilungs.ToList();
        }

        private void CmdMitarbeiterL�schen_Click(object sender, EventArgs e)
        {
            try
            {
                // Aktuell ausgew�hlten Mitarbeiter in Variable speichern
                var ausgew�hlterMitarbeiter = (Mitarbeiter)mitarbeiterBindingSource.Current;

                // Abbrechen, wenn nichts ausgew�hlt ist
                if (ausgew�hlterMitarbeiter == null) return;

                // Mitarbeiter l�schen
                _ctx.Mitarbeiters.Remove(ausgew�hlterMitarbeiter);

                // Speichern
                _ctx.SaveChanges();

                // Anzeige aktualisieren
                mitarbeiterBindingSource.DataSource = _ctx.Mitarbeiters.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var mitarbeiterBearbeiten = (Mitarbeiter)mitarbeiterBindingSource.Current;
            // Objekt vom Typ MitarbeiterBearbeiten erstellen (Formular)
            FrmMitarbeiterBearbeiten frmMitarbeiterBearbeiten = new()
            {
                // Ausgew�hlten Mitarbeiter �bergeben
                MitarbeiterInBearbeitung = mitarbeiterBearbeiten
            };

            // Formular anzeigen
            frmMitarbeiterBearbeiten.ShowDialog();

            // Speichern, falls Benutzer auf Speichern geklickt hat
            if (frmMitarbeiterBearbeiten.DialogResult == DialogResult.OK)
            {
                // Datenbankzugriff immer in try-catch!
                try
                {
                    // Speichern
                    _ctx.SaveChanges();

                    // Anzeige updaten
                    mitarbeiterBindingSource.DataSource = _ctx.Mitarbeiters.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CmdAlleAnzeigen_Click(object sender, EventArgs e)
        {
            mitarbeiterBindingSource.DataSource = _ctx.Mitarbeiters.ToList();
        }

        private void CmdFiltern_Click(object sender, EventArgs e)
        {
            mitarbeiterBindingSource.DataSource = _ctx.Mitarbeiters
                .Where(m => m.Name.Contains(TxtNachname.Text))
                .Where(m => m.Vorname.Contains(TxtVorname.Text))
                .ToList();
        }

        private void CmdNachNachnameSortieren_Click(object sender, EventArgs e)
        {
            mitarbeiterBindingSource.DataSource = _ctx.Mitarbeiters
                .OrderBy(m => m.Name)
                .ToList();
        }

        private void CmdNachVornameSortieren_Click(object sender, EventArgs e)
        {
            mitarbeiterBindingSource.DataSource = _ctx.Mitarbeiters
                .OrderBy(m => m.Vorname)
                .ToList();
        }

        private void CmdMitarbeiterInAbteilung�bernehmen_Click(object sender, EventArgs e)
        {
            try
            {
                var mitarbeiter = (Mitarbeiter)mitarbeiterBindingSource.Current;
                var abteilung = (Abteilung)abteilungBindingSource.Current;

                // Abbrechen, falls kein Mitarbeiter oder keine Abteilung ausgew�hlt wurde
                if (mitarbeiter == null || abteilung == null) return;

                // Abteilungsnummer des Mitarbeiters aktualisieren
                mitarbeiter.AbteilungsNr = abteilung.AbteilungsNr;

                // Speichern
                _ctx.SaveChanges();

                // Anzeige aktualisieren
                mitarbeiterBindingSource.DataSource = _ctx.Mitarbeiters.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmdAbteilungHinzuf�gen_Click(object sender, EventArgs e)
        {
            try
            {
                // Objekt f�r neues Formular erstellen
                var frmAbteilungBearbeiten = new FrmAbteilungBearbeiten()
                {
                    // Neues leeres Abteilungs-Objekt wird �bergeben
                    AbteilungInBearbeitung = new()
                };

                frmAbteilungBearbeiten.ShowDialog();

                if (frmAbteilungBearbeiten.DialogResult == DialogResult.OK)
                {
                    // Abteilung hinzuf�gen
                    _ctx.Abteilungs.Add(frmAbteilungBearbeiten.AbteilungInBearbeitung);

                    // Speichern
                    _ctx.SaveChanges();

                    // Anzeige aktualisieren
                    abteilungBindingSource.DataSource = _ctx.Abteilungs.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmdAbteilungBearbeiten_Click(object sender, EventArgs e)
        {
            try
            {
                // Objekt f�r neues Formular erstellen
                var frmAbteilungBearbeiten = new FrmAbteilungBearbeiten()
                {
                    // Aktuell ausgew�hlte Abteilung wird �bergeben
                    AbteilungInBearbeitung = (Abteilung)abteilungBindingSource.Current
                };

                frmAbteilungBearbeiten.ShowDialog();

                if (frmAbteilungBearbeiten.DialogResult == DialogResult.OK)
                {
                    // Speichern
                    _ctx.SaveChanges();

                    // Anzeige aktualisieren
                    abteilungBindingSource.DataSource = _ctx.Abteilungs.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmdAbteilungL�schen_Click(object sender, EventArgs e)
        {
            try
            {
                // Aktuell ausgew�hlte Abteilung in Variable speichern
                var abteilung = (Abteilung)abteilungBindingSource.Current;

                // Abbruch, falls keine Abteilung ausgew�hlt ist
                if (abteilung == null) return;

                // Pr�fen, ob kein Mitarbeiter mehr in der Abteilung ist
                if (abteilung.Mitarbeiters.Count > 0)
                    throw new ArgumentException("Abteilung kann nur gel�scht werden wenn sie keine Mitarbeiter mehr besitzt.");

                // Abteilung l�schen
                _ctx.Abteilungs.Remove(abteilung);

                // Speichern
                _ctx.SaveChanges();

                // Anzeige aktualisieren
                abteilungBindingSource.DataSource = _ctx.Abteilungs.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
