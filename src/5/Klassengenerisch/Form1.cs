// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Klassengenerisch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnListString_Click(object sender, EventArgs e)
        {
            //Lokale Variable, in der strings gespeichert werden können:
            //List<string>
            List<string> listeMitStrings = new();

            //Wie viele Elemente hat meine Liste?
            lblAnzeigen1.Text = $"Liste hat {listeMitStrings.Count} Elemente";

            //Elemente zur Liste hinzufügen
            // => Methode
            listeMitStrings.Add("Hallo");
            listeMitStrings.Add("Welt");


            //An welchem Index steht der Eintrag "Hallo"?
            var index = listeMitStrings.IndexOf("Hallo");
            lblAnzeigen1.Text += $"Der Eintrag Hallo steht an der Stelle {index}\n";

            //Eintrag an Stelle 0 anzeigen
            lblAnzeigen1.Text += $"Eintrag an Stelle 0 : {listeMitStrings[0]}";

            //Elemente aus der Liste entfernen
            listeMitStrings.Remove("Hallo");

            //Element am Anfang der Liste einfügen
            listeMitStrings.Insert(0, "Mittagessen");

            //Prüfen, ob ein Element in der Liste enthalten ist
            bool entähltMond = listeMitStrings.Contains("Mond");
        }

        private void btnListLand_Click(object sender, EventArgs e)
        {
            //Liste anlegen, in dem Länder gespeichert werden können
            List<Land> listeMitLänder = new();

            //Land hinzufügen
            listeMitLänder.Add(new Land("Frankreich", "Paris"));
            listeMitLänder.Add(new Land("Deutschland", "Berlin"));

            //Wie viele Länder enthält die Liste=
            lblAnzeigen2.Text = $"Die Liste enthält {listeMitLänder.Count} Länder";

            bool enthältFrankreich = listeMitLänder.Contains(new Land("Frankreich", "Paris"));
            lblAnzeigen2.Text += $"Land Frankreich ist in Liste enthalten: {enthältFrankreich}\n";

            //Land löschen
            listeMitLänder.RemoveAt(1);

            listeMitLänder.Remove(new Land("Deutschlan", "Berlin"));

            listeMitLänder.Add(new Land("Belgien", "Brüssel"));

            foreach (var land in listeMitLänder)
            {
                lblAnzeigen2.Text += land.ToString() + "\n";
            }
        }
    }
}
