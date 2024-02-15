// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Klassen_Eigenschaftsmodul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdButton1_Click(object sender, EventArgs e)
        {
            Fahrzeug Vespa = new Fahrzeug();

            LblAnzeigen1.Text = "Vespa\n" + Vespa.Ausgabe() + "\n";

            Vespa.Beschleunigen(10);
            //Geschwindigkeit kann aus der Eigenschaftsmethoden ausgelesen werden


            LblAnzeigen1.Text += Vespa.Ausgabe() + "\n";

            LblAnzeigen1.Text += "\n\n";
        }
    }
}