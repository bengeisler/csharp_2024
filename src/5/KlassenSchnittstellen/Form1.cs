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

        private void CmdAnzeige_Click(object sender, EventArgs e)
        {
            var vespa = new Fahrzeug(45, "Vespa)");
            var schwalbe = new Fahrzeug(50, "Schwalbe");
            int[] werte = [1, 2, 3, 4];
            Fahrzeug[] fahrzeuge = [vespa, schwalbe];
            Array.Sort(werte);
            Array.Sort(fahrzeuge);
                
        }
    }
}
