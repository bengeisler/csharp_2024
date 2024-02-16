// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace KlassenEigenschaftsMethoden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            var vespa = new Fahrzeug();

            LblAnzeige.Text = vespa.Ausgabe() + "\n";

            vespa.Beschleunigen(10);
            // vespa.Geschwindigkeit = 20; geht nicht mehr wegen "private set"

            LblAnzeige.Text += vespa.Ausgabe() + "\n";
            LblAnzeige.Text = "\n\n";
        }
    }
}
