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

            bool enthältMond = ListeMitStrings.Contains("Mond");






        }

        private void CmdListLand_Click(object sender, EventArgs e)
        {
            List<Land> listeMitLändern = new();
            listeMitLändern.Add(new Land("Frankreich","Paris"));
            listeMitLändern.Add(new Land("Deutschland", "Berlin"));
            listeMitLändern.Add(new Land("Brasilien", "Brasilia"));

            lblAnzeige.Text = $"Die Liste enthält {listeMitLändern.Count} Länder\n";

            bool enthältFrankreich = listeMitLändern.Contains(new Land("Frankreich", "Paris"));
            lblAnzeige.Text += $"Land Frankreich ist in der Liste enthalten:{enthältFrankreich}";
            listeMitLändern.RemoveAt(1);
            // listeMitLändern.Remove(new Land("Deutschland", "Berlin"));

            foreach (var land in listeMitLändern)
            {
                lblAnzeige.Text += land.ToString() + "\n";


            }
        }

    }
}
