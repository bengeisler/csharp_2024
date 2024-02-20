// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace KlassenEigeschaftsmethoden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            // Neues Fahrzeug erzeugen: Instanz der Klasse anlegen
            var vespa = new Fahrzeug();
            //Fahrzeug vespa2 = new();
            LblAnzeigen.Text = vespa.Ausgabe() + "\n";
            vespa.Beschleunigen(10);
            var x = vespa.Geschwindigkeit;
            LblAnzeigen.Text += vespa.Ausgabe() + "\n";
            LblAnzeigen.Text += "\n\n";
        }
    }
}
