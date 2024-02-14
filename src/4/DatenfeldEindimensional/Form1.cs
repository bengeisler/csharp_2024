// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace DatenfeldEindimensional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            LstWerte.Items.Clear();

            // Datenfeld deklarieren & initialisieren
            int[] werte = [1, 2, 3, 4, 5, 6, 7];

            // Werte in ListBox übernehmen
            foreach (int wert in werte)
            {
                LstWerte.Items.Add(wert);
            }

            // Zugriff auf Elemente außerhalb des Bereichs wirft eine Außnahme!
            // LstWerte.Items.Add(werte[20]);
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int[] werte = [1, 2, 3, 4, 5, 6, 7];

            // Auf Bereiche zugreifen
            // Siehe Buch Seite 156
            int[] bereich = werte[^3..^1];
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            // ListBox leeren
            LstWerte.Items.Clear();

            // Datenfeld deklarieren und initialisieren
            int[] werte = [878, -1, 34, 999, 1, 0, 7];

            // Datenfeld (aufsteigend) sortieren
            Array.Sort(werte);

            LblAusgabe.Text = $"{Array.IndexOf(werte, -500)}";

            // Werte in ListBox übernehmen
            foreach (int wert in werte)
            {
                LstWerte.Items.Add(wert);
            }
        }
    }
}
