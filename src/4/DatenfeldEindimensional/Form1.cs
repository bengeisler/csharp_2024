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

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            //Datenfeld deklarieren & initialisieren
            int[] werte = [1, 2, 3, 4, 5, 6, 7];

            // Werte in ListBox übernehmen
            foreach (int i in werte)
            {
                LstFeld.Items.Add(werte);

                //Zugriff auf Elemente außerhalb des Bereichs wirft eine Außnahme!
                //LstWerte.Item.Add(werte[20]);

            }

        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int[] werte = [1, 2, 3, 4, 5, 6, 7];

            // Auf Bereiche zugreifen
            // Sieh Buch seite 156
            int[] bereich = werte[^3..^1];
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            // ListBox leeren
            LstFeld.Items.Clear();

            // Datenfelddeklarieren und initialisieren
            int[] werte = [878, -1, 34, 999, 1, 0, 7];


            //Datenfeld sortieren
            Array.Sort(werte);


            // Werte in ListBox übernehmen
            foreach (int i in werte)
            {
                LstFeld.Items.Add(werte);
            }
    }
}
