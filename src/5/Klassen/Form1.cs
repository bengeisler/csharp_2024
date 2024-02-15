// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Klassen
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
            // 1. Möglichkeit: mit var
            var vespa = new Fahrzeug();
            // 2. Möglichkeit:
            // Fahrzeug vespa2 = new();

            LblAnzeige.Text = vespa.Ausgabe() + "\n";

            vespa.Beschleunigen(10);

            LblAnzeige.Text += vespa.Ausgabe() + "\n";

            LblAnzeige.Text += "\n\n";

            // Weiteres Objekt erzeugen
            Fahrzeug schwalbe = new();

            LblAnzeige.Text += schwalbe.Ausgabe() + "\n";

            schwalbe.Beschleunigen(50);

            LblAnzeige.Text += schwalbe.Ausgabe() + "\n";
        }
    }
}
