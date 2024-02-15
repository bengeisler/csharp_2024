// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace KlassenPruefung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            // Objekte sind Referenztypen
            var f1 = new Fahrzeug(0, "f");
            var f2 = new Fahrzeug(0, "f");

            // sindGleich = false!
            // f1 und f2 zeigen auf zwei unterschiedliche Objekte
            // in f1 und f2 sind nur die ADRESSEN der Objekte im Speicher hinterlegt
            // 2 Objekte => 2 Adressen! Diese Adressen sind natürlich nicht gleich
            bool sindGleich = f1 == f2;

            var f3 = f1;
            var f4 = f1;

            // f3 und f4 zeigen beide auf f1, und damit auf das gleiche Objekt
            // deswegen ist sindGleich2 true!
            bool sindGleich2 = f3 == f4;

            // erhöht die Geschwindigkeit von f1 um 10
            // f3 und f4 zeigen auf das gleiche Objekt, deswegen ist hier die
            // Geschwindigkeit natürlich auch 10
            f1.Beschleunigen(10);

            // f3 zeigt auf f1, deswegen wird hierdurch natürlich f1 beschleunigt
            f3.Beschleunigen(10);


            // -------------------------------
            // Primitive Datentypen sind Werttypen!
            int x1 = 10;
            int x2 = 20;

            // KOPIE des Wertes von x1 (10) wird in x3 gespeichert
            int x3 = x1;

            // Das verändert nur x3, x1 bleibt unverändert!
            // Das ist ein wichtiger Unterschied zu Referenztypen!
            x3 += 100;

            // -------------------------------
            // Objekte Vergleichen
            f2.Beschleunigen(20);

            // f1: _geschwindigkeit = 20, _bezeichnung = f
            // f2: _geschwindigkeit = 20, _bezeichnung = f
            // => Beide Objekte haben die gleichen Werte für ihre Eigenschaften!
            // Dadurch dass in der Klasse Fahrzeug die Equals-Methode überladen wurde,
            // ist sindGleich3 hier true!
            bool sindGleich3 = f1.Equals(f2);
        }
    }
}
