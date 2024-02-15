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

        private void btnAnzeigen1_Click(object sender, EventArgs e)
        {
            //Neues Fahrzeug erzeugen: Instanz der Klasse anlegen
            // 1. Möglichkeit: mit var
            var vespa = new Fahrzeug();
            // 2. Möglichkeit:
            // Fahrzeug vespa2 = new();

            LblAnzeigen.Text = vespa.Ausgabe() + "\n";

            vespa.Beschleunigen(10);

            LblAnzeigen.Text += vespa.Ausgabe() + "\n";

            LblAnzeigen.Text += "\n\n";

            Fahrzeug schwalbe = new();
            LblAnzeigen.Text += schwalbe.Ausgabe() + "\n";

            schwalbe.Beschleunigen(50);

            LblAnzeigen.Text += schwalbe.Ausgabe() + "\n";
        }
    }
}
