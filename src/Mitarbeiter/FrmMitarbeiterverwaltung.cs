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

        private void CmdMitarbeiterHinzufügen_Click(object sender, EventArgs e)
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
                    // Datensatz der Tabelle hinzufügen
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
            // DataGridViews befüllen
            mitarbeiterBindingSource.DataSource = _ctx.Mitarbeiters.ToList();
            abteilungBindingSource.DataSource = _ctx.Abteilungs.ToList();
        }

        private void CmdMitarbeiterLöschen_Click(object sender, EventArgs e)
        {
            try
            {
                // Aktuell ausgewählten Mitarbeiter in Variable speichern
                var ausgewählterMitarbeiter = (Mitarbeiter)mitarbeiterBindingSource.Current;

                // Abbrechen, wenn nichts ausgewählt ist
                if (ausgewählterMitarbeiter == null) return;

                // Mitarbeiter löschen
                _ctx.Mitarbeiters.Remove(ausgewählterMitarbeiter);

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
                // Ausgewählten Mitarbeiter übergeben
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

        private void CmdMitarbeiterInAbteilungÜbernehmen_Click(object sender, EventArgs e)
        {
            try
            {
                var mitarbeiter = (Mitarbeiter)mitarbeiterBindingSource.Current;
                var abteilung = (Abteilung)abteilungBindingSource.Current;

                // Abbrechen, falls kein Mitarbeiter oder keine Abteilung ausgewählt wurde
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

        private void CmdAbteilungHinzufügen_Click(object sender, EventArgs e)
        {
            try
            {
                // Objekt für neues Formular erstellen
                var frmAbteilungBearbeiten = new FrmAbteilungBearbeiten()
                {
                    // Neues leeres Abteilungs-Objekt wird übergeben
                    AbteilungInBearbeitung = new()
                };

                frmAbteilungBearbeiten.ShowDialog();

                if (frmAbteilungBearbeiten.DialogResult == DialogResult.OK)
                {
                    // Abteilung hinzufügen
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
                // Objekt für neues Formular erstellen
                var frmAbteilungBearbeiten = new FrmAbteilungBearbeiten()
                {
                    // Aktuell ausgewählte Abteilung wird übergeben
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

        private void CmdAbteilungLöschen_Click(object sender, EventArgs e)
        {
            try
            {
                // Aktuell ausgewählte Abteilung in Variable speichern
                var abteilung = (Abteilung)abteilungBindingSource.Current;

                // Abbruch, falls keine Abteilung ausgewählt ist
                if (abteilung == null) return;

                // Prüfen, ob kein Mitarbeiter mehr in der Abteilung ist
                if (abteilung.Mitarbeiters.Count > 0)
                    throw new ArgumentException("Abteilung kann nur gelöscht werden wenn sie keine Mitarbeiter mehr besitzt.");

                // Abteilung löschen
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
