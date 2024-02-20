// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Klassenschnittstellen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeige_Click(object sender, EventArgs e)
        {
            var vespa = new Fahrzeug(45, "vespa");
            var schwalbe = new Fahrzeug(50, "schwalbe");


            int[] werte = [1, 2, 3];
            Fahrzeug[] fahrzeuge = [vespa, schwalbe];

            // dAtenfelder sortieren
            Array.Sort(werte);
            Array.Sort(fahrzeuge);
        }
    }
}
