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
            List<string> ListeMitStrings = new();
            lblAnzeige.Text = $"Liste hat {ListeMitStrings.Count} Elemente";
            ListeMitStrings.Add("Hallo");
            ListeMitStrings.Add("Welt");
            var index = ListeMitStrings.IndexOf("hallo");
            lblAnzeige.Text += $"Der Eintrag Hallo steht an der Stelle : {index}\n";
            lblAnzeige.Text += $"Eintrag an Stelle 0: {ListeMitStrings[0]}";

            ListeMitStrings.Remove("Hallo");

            ListeMitStrings.Insert(0, "Mittagessen");

            bool enth�ltMond = ListeMitStrings.Contains("Mond");






        }

        private void CmdListLand_Click(object sender, EventArgs e)
        {
            List<Land> listeMitL�ndern = new();
            listeMitL�ndern.Add(new Land("Frankreich","Paris"));
            listeMitL�ndern.Add(new Land("Deutschland", "Berlin"));
            listeMitL�ndern.Add(new Land("Brasilien", "Brasilia"));

            lblAnzeige.Text = $"Die Liste enth�lt {listeMitL�ndern.Count} L�nder\n";

            bool enth�ltFrankreich = listeMitL�ndern.Contains(new Land("Frankreich", "Paris"));
            lblAnzeige.Text += $"Land Frankreich ist in der Liste enthalten:{enth�ltFrankreich}";
            listeMitL�ndern.RemoveAt(1);
            // listeMitL�ndern.Remove(new Land("Deutschland", "Berlin"));

            foreach (var land in listeMitL�ndern)
            {
                lblAnzeige.Text += land.ToString() + "\n";


            }
        }

    }
}
