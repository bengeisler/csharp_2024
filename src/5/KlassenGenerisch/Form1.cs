// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace KlassenGenerisch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnListString_Click(object sender, EventArgs e)
        {
            //Lokale Variable, in der strings gespeichert werden können:
            //List<string>
            List<string> listMitStrings = new();

            //wie viele Elemente  hat meine liste


            //Elemente zur Liste hinzufügen
            // => Methode
            listMitStrings.Add("Hallo");  //<--- Element 1
            listMitStrings.Add("Welt");   //<--- Element 2
            LblAnzeige1.Text = $"Liste hat {listMitStrings.Count} Elemente\n";
            LblAnzeige1.Text += $"Eintrag Stelle 0  {listMitStrings[0]}";
        }

        private void CmdListDone_Click(object sender, EventArgs e)
        {
            // Liste anlegen, in dem Länder gespeichert werden können
            List<Land> listemitLändern = new();

            //Land hinzufügen
            listemitLändern.Add(new Land("Frankreich", "Paris"));
            listemitLändern.Add(new Land("Deutschland", "Berlin"));

            //Wie viele Länder enthält die Liste?
            LblAnzeige1.Text = $"Die Liste enthält {listemitLändern.Count} Länder\n";

            //Enthält die Liste das Land Frankreich?
            bool enthältFrankreich = listemitLändern.Contains(new Land("Frankreich", "Paris"));
            LblAnzeige1.Text = $"Land Frankreich ist in der Liste enthalten: {enthältFrankreich} \n";

            //Land Löschen
            //listemitLändern.RemoveAt(1);

            //Land löschen
            listemitLändern.Remove(new Land("Deutschland", "Berlin"));

            //Alle Länder anzeigen
            listemitLändern.Add(new Land("Belgien", "Brüssel"));

            foreach (var land in listemitLändern) 
            {
                LblAnzeige1.Text += $"{land}\n";
            }
        }
    }
}
