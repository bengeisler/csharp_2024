// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Schnittstelle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnzeigen1_Click(object sender, EventArgs e)
        {
            //Zwei Objekte vom Typ Fahrzeug erzeugen
            var vespa = new Fahrzeug(45, "vespa");
            var schwalbe = new Fahrzeug(50, "Schwalbe");


            //Diese Fahrzeuge in einem Datenfeld speichern
            int[] werte = [1, 2, 3];
            Fahrzeug[] fahrzeug = [schwalbe, vespa];

            //Datenfelder sortieren
            Array.Sort(werte);
            Array.Sort(fahrzeug);

        }
    }
}
