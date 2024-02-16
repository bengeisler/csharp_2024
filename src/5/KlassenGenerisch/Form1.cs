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
            //Lokale Variable, in der strings gespeichert werden k�nnen:
            //List<string>
            List<string> listMitStrings = new();

            //wie viele Elemente  hat meine liste


            //Elemente zur Liste hinzuf�gen
            // => Methode
            listMitStrings.Add("Hallo");  //<--- Element 1
            listMitStrings.Add("Welt");   //<--- Element 2
            LblAnzeige1.Text = $"Liste hat {listMitStrings.Count} Elemente\n";
            LblAnzeige1.Text += $"Eintrag Stelle 0  {listMitStrings[0]}";
        }

        private void CmdListDone_Click(object sender, EventArgs e)
        {
            // Liste anlegen, in dem L�nder gespeichert werden k�nnen
            List<Land> listemitL�ndern = new();

            //Land hinzuf�gen
            listemitL�ndern.Add(new Land("Frankreich", "Paris"));
            listemitL�ndern.Add(new Land("Deutschland", "Berlin"));

            //Wie viele L�nder enth�lt die Liste?
            LblAnzeige1.Text = $"Die Liste enth�lt {listemitL�ndern.Count} L�nder\n";

            //Enth�lt die Liste das Land Frankreich?
            bool enth�ltFrankreich = listemitL�ndern.Contains(new Land("Frankreich", "Paris"));
            LblAnzeige1.Text = $"Land Frankreich ist in der Liste enthalten: {enth�ltFrankreich} \n";

            //Land L�schen
            //listemitL�ndern.RemoveAt(1);

            //Land l�schen
            listemitL�ndern.Remove(new Land("Deutschland", "Berlin"));

            //Alle L�nder anzeigen
            listemitL�ndern.Add(new Land("Belgien", "Br�ssel"));

            foreach (var land in listemitL�ndern) 
            {
                LblAnzeige1.Text += $"{land}\n";
            }
        }
    }
}
