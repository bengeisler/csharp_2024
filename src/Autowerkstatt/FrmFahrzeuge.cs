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

        // Eigenschaft zum Datenaustausch
        public Fahrzeug FahrzeugInBearbeitung;

        private void FrmFahrzeuge_Load(object sender, EventArgs e)
        {
            // Falls ein neues Fahrzeug übergeben wurde, Felder nicht befüllen
            // => Methode hier verlassen
            if (FahrzeugInBearbeitung.Nr == 0) return;

            // Felder mit den Daten aus dem übergebenen Fahrzeug befüllen
            LblNummer.Text = FahrzeugInBearbeitung.Nr.ToString();
            TxtHalter.Text = FahrzeugInBearbeitung.Halter;
            TxtKennzeichen.Text = FahrzeugInBearbeitung.Kennzeichen;
            TxtMarke.Text = FahrzeugInBearbeitung.Marke;
            TxtModell.Text = FahrzeugInBearbeitung.Modell;
            TxtOrt.Text = FahrzeugInBearbeitung.Ort;
        }

        private void CmdSpeichern_Click(object sender, EventArgs e)
        {
            try
            {
                // Validierung der Eingabe
                if (TxtHalter.Text == "")
                    throw new ArgumentException("Bitte Halter eingeben!");
                if (TxtMarke.Text == "")
                    throw new ArgumentException("Bitte Marke eingeben!");
                if (TxtOrt.Text == "")
                    throw new ArgumentException("Bitte Ort eingeben!");
                if (TxtModell.Text == "")
                    throw new ArgumentException("Bitte Modell eingeben!");
                if (TxtKennzeichen.Text == "")
                    throw new ArgumentException("Bitte Kennzeichen eingeben!");

                // Eigenschaften dem Fahrzeug zuweisen
                FahrzeugInBearbeitung.Halter = TxtHalter.Text;
                FahrzeugInBearbeitung.Marke = TxtMarke.Text;
                FahrzeugInBearbeitung.Ort = TxtOrt.Text;
                FahrzeugInBearbeitung.Modell = TxtModell.Text;
                FahrzeugInBearbeitung.Kennzeichen = TxtKennzeichen.Text;

                // DialogResult setzen & Formular schließen
                DialogResult = DialogResult.OK;
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
    }
}
