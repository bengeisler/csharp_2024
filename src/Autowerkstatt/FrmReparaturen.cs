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
using Autowerkstatt.Models;

namespace Autowerkstatt
{
    public partial class FrmReparaturen : Form
    {
        public FrmReparaturen()
        {
            InitializeComponent();
        }

        private AutowerkstattDbContext _ctx = new();

        private void CboxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Abbruch, falls nichts ausgewählt ist
            if (CboxFilter.SelectedValue == null) return;

            // Aktuell ausgewählte Fahrzeugnummer aus ComboBox auslesen
            int fahrzeugnummer = (int)CboxFilter.SelectedValue;

            // Aktuell ausgewähltes Kennzeichen aus ComboBox auslesen
            string kennzeichen = CboxFilter.Text;

            // Tabelle filtern
            reparaturBindingSource.DataSource = _ctx.Reparaturs
                .Where(r => r.FahrzeugNr == fahrzeugnummer)
                .ToList();

            // Anzeige aktualisieren
            LblFilter.Text = $"Reparaturen von Fahrzeug - {kennzeichen} -";
        }

        private void FrmReparaturen_Load(object sender, EventArgs e)
        {
            // Datenquellen binden
            reparaturBindingSource.DataSource = _ctx.Reparaturs.ToList();
            fahrzeugBindingSource.DataSource = _ctx.Fahrzeugs.ToList();
        }

        private void CmdAlleAnzeigen_Click(object sender, EventArgs e)
        {
            reparaturBindingSource.DataSource = _ctx.Reparaturs.ToList();
            LblFilter.Text = "Alle Fahrzeuge";
        }
    }
}
