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
            // Lokale Variable, in der strings gespeichert werden k�nnen:
            // List

            List<string> listeMitStrings = new();

            // Wie viele Elemente hat meine Liste?
            LblAnzeige.Text = $"Liste hat {listeMitStrings.Count} Elemente\n";

            //Elemente zur Liste hinzuf�gen
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

            // Elemente am Anfang der Liste einf�gen

            listeMitStrings.Insert(0, "Mittagessen");

            // Pr�fen, ob ein Element in der Liste enthalten ist

            bool einth�ltMond = listeMitStrings.Contains("Mond");


        }

        private void CmdListLand_Click(object sender, EventArgs e)
        {
            // Liste anlegen, in dem L�nder gespeichert werden k�nnen
            List<Land> listeMitL�ndern = new();


            // Land hinzuf�gen
            listeMitL�ndern.Add(new Land("Frankreich", "Paris"));
            listeMitL�ndern.Add(new Land("Deutschland", "Berlin"));

            // Wie viele L�nder enth�lt die Liste?
            LblAnzeige.Text = $"Die Liste enth�lt {listeMitL�ndern.Count} L�nder\n";

            // Enth�lt die Liste das Land Frankreich?
            bool enth�ltFrankreich = listeMitL�ndern.Contains(new Land("Frankreich", "Paris"));
            LblAnzeige.Text += $"Land Frankreich ist in Liste enthalten: {enth�ltFrankreich}\n";

            // Land l�schen
            listeMitL�ndern.RemoveAt(1);

            // Land l�schen (�ber Objekt)
            listeMitL�ndern.Remove(new Land("Deutschland", "Berlin"));

            // L�nder anzeigen
            listeMitL�ndern.Add(new Land("Belgien", "Br�ssel"));

            foreach (var land in listeMitL�ndern)
            {
                LblAnzeige.Text += land.ToString() + "\n";

            }




        }
    }
}
