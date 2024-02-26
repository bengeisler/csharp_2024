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
    public partial class FrmAbteilungBearbeiten : Form
    {
        public FrmAbteilungBearbeiten()
        {
            InitializeComponent();
        }

        // Eigenschaft zum Datenaustausch zwischen den Formularen
        public Abteilung AbteilungInBearbeitung;

        private void FrmAbteilungBearbeiten_Load(object sender, EventArgs e)
        {
            // Falls ein neuer Datensatz angelegt wird, hier Methode verlassen
            if (AbteilungInBearbeitung.AbteilungsNr == 0) return;

            TxtAbteilungsbezeichnung.Text = AbteilungInBearbeitung.Bezeichnung;
            TxtAbteilungsnummer.Text = AbteilungInBearbeitung.AbteilungsNr.ToString();
        }

        private void CmdSpeichern_Click(object sender, EventArgs e)
        {
            try
            {
                // Validierung der Eingabe
                if (TxtAbteilungsbezeichnung.Text == "")
                    throw new ArgumentException("Bitte Abteilungsbezeichnung vergeben");

                // Eigenschaften zuweisen
                AbteilungInBearbeitung.Bezeichnung = TxtAbteilungsbezeichnung.Text;

                // DialogResult setzen
                DialogResult = DialogResult.OK;

                // Schließen
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }
    }
}
