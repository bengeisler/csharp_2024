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
    public partial class FrmFahrzeuge : Form
    {
        public FrmFahrzeuge()
        {
            InitializeComponent();
        }

        // Eigenschaft zum Datenautausch
        public Fahrzeug FahrzeugInBearbeitung = new();


        private void CmdAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdSpeichern3_Click(object sender, EventArgs e)
        {

        }

        private void FrmFahrzeuge_Load(object sender, EventArgs e)
        {
            LblNummer.Text = FahrzeugInBearbeitung.Nr.ToString();
            TxtHalterFr2.Text = FahrzeugInBearbeitung.Halter;
            TxtKennzeichenFr2.Text = FahrzeugInBearbeitung.Kennzeichen;
            TxtMarkeFr2.Text = FahrzeugInBearbeitung.Marke;
            TxtModellFr2.Text = FahrzeugInBearbeitung.Modell;
            TxtOrtFr2.Text = FahrzeugInBearbeitung.Ort;
            
        }
    }
}
