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
            //Lokale Variable, in der strings gespeichert werden k�nnen:
            //List<string>
            List<string> listeMitStrings = new();

            //Wie viele Elemente hat meine Liste?
            lblAnzeigen1.Text = $"Liste hat {listeMitStrings.Count} Elemente";

            //Elemente zur Liste hinzuf�gen
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

            //Element am Anfang der Liste einf�gen
            listeMitStrings.Insert(0, "Mittagessen");

            //Pr�fen, ob ein Element in der Liste enthalten ist
            bool ent�hltMond = listeMitStrings.Contains("Mond");
        }

        private void btnListLand_Click(object sender, EventArgs e)
        {
            //Liste anlegen, in dem L�nder gespeichert werden k�nnen
            List<Land> listeMitL�nder = new();

            //Land hinzuf�gen
            listeMitL�nder.Add(new Land("Frankreich", "Paris"));
            listeMitL�nder.Add(new Land("Deutschland", "Berlin"));

            //Wie viele L�nder enth�lt die Liste=
            lblAnzeigen2.Text = $"Die Liste enth�lt {listeMitL�nder.Count} L�nder";

            bool enth�ltFrankreich = listeMitL�nder.Contains(new Land("Frankreich", "Paris"));
            lblAnzeigen2.Text += $"Land Frankreich ist in Liste enthalten: {enth�ltFrankreich}\n";

            //Land l�schen
            listeMitL�nder.RemoveAt(1);

            listeMitL�nder.Remove(new Land("Deutschlan", "Berlin"));

            listeMitL�nder.Add(new Land("Belgien", "Br�ssel"));

            foreach (var land in listeMitL�nder)
            {
                lblAnzeigen2.Text += land.ToString() + "\n";
            }
        }
    }
}
