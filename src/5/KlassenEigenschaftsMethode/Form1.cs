// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace KlassenEigenschaftsMethode
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
            var x = vespa.Geschwindigkeit;
            vespa.Geschwindigkeit = 10;

            LblAnzeigen.Text += vespa.Ausgabe() + "\n";
            LblAnzeigen.Text += "\n\n";


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
