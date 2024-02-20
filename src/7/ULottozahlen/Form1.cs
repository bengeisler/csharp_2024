// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Accessibility;

namespace ULottozahlen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdZiehung_Click(object sender, EventArgs e)
        {
            // Zufallszahlengenerator
            Random random = new();

            // Liste leeren
            LstLottozahlen.Items.Clear();

            // 6 Zufallszahlen (ohne Doppelte) generieren
            List<int> zufallszahlen = [];
            do
            {
                // Neue Zufallszahl generieren
                int zufallszahl = random.Next(1, 50);

                // Der Liste hinzufügen, falls diese Zahl noch nicht in der Liste existiert
                if (!zufallszahlen.Contains(zufallszahl))
                    zufallszahlen.Add(zufallszahl);

            } while (zufallszahlen.Count < 6);

            // Liste sortieren
            zufallszahlen.Sort();

            // Zahlen der ListBox hinzufügen
            foreach (var zahl in zufallszahlen)
                LstLottozahlen.Items.Add(zahl);

            // Zusatzzahl ausgeben
            TxtZusatzzahl.Text = random.Next(1, 50).ToString();
            // Alternativ: String-Interpolation
            // TxtZusatzzahl.Text = $"{random.Next(1, 50)}";



            // Alternativer, deklarativer Ansatz:
            // Zufallszahlengenerator
            //Random random = new();

            //// Erzeuge ein Array mit den Zahlen 1 - 49
            //var alleZahlen = Enumerable.Range(1, 49).ToArray();
            //random.Shuffle(alleZahlen);
            //var lottozahlen = alleZahlen.Take(6).ToList();
            //lottozahlen.Sort();
            //LstLottozahlen.Items.AddRange(lottozahlen.Select(x => x.ToString()).ToArray());

            //TxtZusatzzahl.Text = random.Next(1, 50).ToString();
        }
    }
}
