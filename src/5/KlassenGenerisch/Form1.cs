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

        private void CmdListString_Click(object sender, EventArgs e)
        {
            // Lokale Variable, in der strings gespeichert werden k�nnen:
            // List<string>
            List<string> listeMitStrings = new();

            // Wie viele Elemente hat meine Liste?
            // => Eigenschaft "Count"
            LblAnzeige.Text = $"Liste hat {listeMitStrings.Count} Elemente\n";

            // Elemente zur Liste hinzuf�gen
            // => Methode "Add"
            listeMitStrings.Add("Hallo");
            listeMitStrings.Add("Welt");

            // An welchem Index steht der Eintrag "Hallo"?
            var index = listeMitStrings.IndexOf("Hallo");
            LblAnzeige.Text += $"Der Eintrag Hallo steht an der Stelle {index}\n";

            // Eintrag an der Stelle 0 anzeigen
            LblAnzeige.Text += $"Eintrag an Stelle 0: {listeMitStrings[0]}";

            // Elemente aus der Liste entfernen
            listeMitStrings.Remove("Hallo");

            // Element am Anfang der Liste einf�gen
            listeMitStrings.Insert(0, "Mittagessen");

            // Pr�fen, ob ein Element in der Liste enthalten ist
            bool enth�ltMond = listeMitStrings.Contains("Mond");


        }

        private void cmdListland_Click(object sender, EventArgs e)
        {
            // Liste anlegen, in dem L�nder gespeichert werden k�nnen

            List<Land> listeMitL�ndern = new();

            // Land hinzuf�gen
            listeMitL�ndern.Add(new Land("Frankreich", "paris"));
            listeMitL�ndern.Add(new Land("Deutscheland", "Berlin"));

            //Wie viele L�nder enth�lt die Liste?
            LblAnzeige.Text = $"Die Liste enth�lt {listeMitL�ndern.Count} L�nder\n";

            //Enth�lt die Liste das Land Frankreich?
            bool enth�ltFrankreich = listeMitL�ndern.Contains(new Land("Frankreich", "paris"));
            LblAnzeige.Text += $"Land Frankreich ist in Liste enthalten: {enth�ltFrankreich}\n";

            // Land l�schen (�ber Index)
            //listeMitL�ndern.RemoveAt(1);

            // Land l�schen (�ber Objekt)
            listeMitL�ndern.Remove(new Land("Deutschland", "Berlin"));



            // Alle L�nder der Liste anzeigen
            listeMitL�ndern.Add(new Land("Belgien", "Br�ssel"));

            foreach (var land in listeMitL�ndern)
            {
                LblAnzeige.Text += land.ToString() + "\n";


            }

        }
    }
}
