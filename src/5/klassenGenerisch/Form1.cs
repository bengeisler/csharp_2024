// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace klassenGenerisch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdListsring_Click(object sender, EventArgs e)
        {
            // Lokale Variable, in der strings gespeichert werden können:
            // List

            List<string> listeMitStrings = new();

            // Wie viele Elemente hat meine Liste?
            LblAnzeige.Text = $"Liste hat {listeMitStrings.Count} Elemente\n";

            //Elemente zur Liste hinzufügen
            // Methode

            listeMitStrings.Add("Hallo");
            listeMitStrings.Add("Welt");

            // An welchen Index steht der Eintrag "Hallo"
            var index = listeMitStrings.IndexOf("Hall");
            LblAnzeige.Text += $"Der Eintrag Hallo steht an der Stelle {index}\n";


            // Eintrag an der Stelle 0 anzeigen

            LblAnzeige.Text += $"Eintrag an Stelle 0: {listeMitStrings[0]}";

            // Elemente aus der Liste Entfernen

            listeMitStrings.Remove("Hallo");

            // Elemente am Anfang der Liste einfügen

            listeMitStrings.Insert(0, "Mittagessen");

            // Prüfen, ob ein Element in der Liste enthalten ist

            bool einthältMond = listeMitStrings.Contains("Mond");


        }

        private void CmdListLand_Click(object sender, EventArgs e)
        {
            // Liste anlegen, in dem Länder gespeichert werden können
            List<Land> listeMitLändern = new();


            // Land hinzufügen
            listeMitLändern.Add(new Land("Frankreich", "Paris"));
            listeMitLändern.Add(new Land("Deutschland", "Berlin"));

            // Wie viele Länder enthält die Liste?
            LblAnzeige.Text = $"Die Liste enthält {listeMitLändern.Count} Länder\n";

            // Enthält die Liste das Land Frankreich?
            bool enthältFrankreich = listeMitLändern.Contains(new Land("Frankreich", "Paris"));
            LblAnzeige.Text += $"Land Frankreich ist in Liste enthalten: {enthältFrankreich}\n";

            // Land löschen
            listeMitLändern.RemoveAt(1);

            // Land löschen (über Objekt)
            listeMitLändern.Remove(new Land("Deutschland", "Berlin"));

            // Länder anzeigen
            listeMitLändern.Add(new Land("Belgien", "Brüssel"));

            foreach (var land in listeMitLändern)
            {
                LblAnzeige.Text += land.ToString() + "\n";

            }




        }
    }
}
