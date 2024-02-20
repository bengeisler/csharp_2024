// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;

namespace UArraySummieren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdErgebnis_Click(object sender, EventArgs e)
        {
            // Array anlegen und befüllen
            int[] zahlenliste = [7, 13, 25, 16, 8, 2];

            // Rechenweg
            string rechenweg = string.Join("+", zahlenliste);

            // Ergebnis
            int ergebnis = zahlenliste.Sum();

            // Ausgabe
            string ausgabe = $"{rechenweg}={ergebnis}";
            // Alternative:
            // string ausgabe = rechenweg + "=" + ergebnis;

            // MessageBox anzeigen
            MessageBox.Show(ausgabe);
        }
    }
}
