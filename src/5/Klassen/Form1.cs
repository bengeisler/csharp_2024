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

        private void CmdButton1_Click(object sender, EventArgs e)
        {
            // Neues Fahrzeug erzeugen: Instanz der anlegen
            //1 Möglichkeit
            Fahrzeug Vespa = new Fahrzeug();
            //2 Möglichkeit
            //Fahrzeug Vespa2=new();
            
            LblAnzegie1.Text = "Vespa\n" + Vespa.Ausgabe() + "\n";
            Vespa.Beschleinigen(10);
            LblAnzegie1.Text += Vespa.Ausgabe() + "\n";

            LblAnzegie1.Text += "\n\n";

            //Weiteres Objekt erzeugen
            // 2 Möglichkeit
            Fahrzeug Schwalbe = new();
            
            LblAnzegie1.Text += "Schwalbe\n" + Schwalbe.Ausgabe() + "\n";
            Schwalbe.Beschleinigen(50);
            LblAnzegie1.Text += Schwalbe.Ausgabe() + "\n";
        }
    }
}
