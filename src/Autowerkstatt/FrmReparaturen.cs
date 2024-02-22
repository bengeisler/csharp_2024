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

        // Kontext-Objekt für den Datenbankzugriff erstellen
        private AutowerkstattDbContext _ctx = new();

        private void CboxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // => Skript S. 32
            // Aktuell in der ComboBox ausgewähltes Fahrzeug auslesen und in Variable speichern
            var fahrzeug = (Fahrzeug)CboxFilter.SelectedItem;


        }

        private void FrmReparaturen_Load(object sender, EventArgs e)
        {
            // Binding Source für die ComboBox befüllen
            fahrzeugBindingSource.DataSource = _ctx.Fahrzeugs.ToList();

            // Binding Source für die Tabelle befüllen
            reparaturBindingSource.DataSource = _ctx.Reparaturs.ToList();
        }
    }
}
