// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace KlassenEigenschaftsmethoden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            var vespa = new Fahrzeug();
            LblAnzeige.Text = vespa.Ausgabe() + "\n";

            vespa.Beschleunigen(10);
            // Geschwindkiet kann aus der Eigenschaftsmethode ausgelsen werden
            var x = vespa.Geschwindigkeit;

            LblAnzeige.Text += vespa.Ausgabe() + "\n";
            LblAnzeige.Text += "\n\n";

        }
    }
}
