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
            // Lokale Variable, in der strings gespeichert werden können:
            // List<string>
            List<string> listeMitStrings = new();

            // Wie viele Elemente hat meine Liste?
            // => Eigenschaft "Count"
            LblAnzeige.Text = $"Liste hat {listeMitStrings.Count} Elemente\n";

            // Elemente zur Liste hinzufügen
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

            // Element am Anfang der Liste einfügen
            listeMitStrings.Insert(0, "Mittagessen");

            // Prüfen, ob ein Element in der Liste enthalten ist
            bool enthältMond = listeMitStrings.Contains("Mond");
        }
    }
}
