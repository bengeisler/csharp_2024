// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace KlassenSchnittstellen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdButton1_Click(object sender, EventArgs e)
        {
            var vespa = new Fahrzeug(45, "Vespa");
            var Schwalbe = new Fahrzeug(50, "Schwalbe");

            //Diese Fahrzeuge in einem Datenfeld speicher
            int [] werte = [1, 9, 5];
            Fahrzeug[] fahrzeuge = [vespa, Schwalbe];
            Array.Sort(werte);
            Array.Sort(fahrzeuge);
        }
    }
}
