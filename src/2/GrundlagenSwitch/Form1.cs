// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenSwitch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Zufallszahlengenerator
        private readonly Random r = new();

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            string stadt = TxtStadt.Text;
            string land;
            int flaeche;

            // Abhängig von dem Namen der Stadt das Land anzeigen, in dem die Stadt
            // liegt und die Fläche des Landes
            switch (stadt)
            {
                case "Paris":
                    land = "Frankreich";
                    flaeche = 632734;
                    break;
                case "Namur":
                case "Antwerpen":
                case "Lüttich":
                    land = "Belgien";
                    flaeche = 30688;
                    break;
                case "Barcelona":
                    land = "Spanien";
                    flaeche = 505970;
                    break;
                default:
                    land = "unbekannt";
                    flaeche = 0;
                    break;
            }

            LblAusgabe.Text = $"Stadt: {stadt}, Land: {land}, Fläche: {flaeche}";

        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            // Zufallszahl erzeugen & anzeigen
            double x = r.NextDouble(); // x ist Zufallszahl zwischen 0.0 und 1.0
            LblAusgabe.Text = $"Wert: {x}\n";

            switch (x)
            {
                case < 0.1:
                    LblAusgabe.Text += "Größer oder gleich 0.0\n";
                    LblAusgabe.Text += "Kleiner als 0.2";
                    break;
                case < 0.5:
                    LblAusgabe.Text += "Größer oder gleich 0.2\n";
                    LblAusgabe.Text += "Kleiner als 0.5";
                    break;
                case < 0.8:
                    LblAusgabe.Text += "Größer oder gleich 0.5\n";
                    LblAusgabe.Text += "Kleiner als 0.8";
                    break;
                default:
                    LblAusgabe.Text += "Größer oder gleich 0.8\n";
                    LblAusgabe.Text += "Kleiner als 1.0";
                    break;
            }


        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            string land = TxtStadt.Text;
            string hauptstadt = land switch
            {
                "Frankreich" => "Paris",
                "Belgien" => "Brüssel",
                "Spanien" => "Madrid",
                _ => "unbekannt"
            };
            LblAusgabe.Text = $"Land: {land}, Hauptstadt: {hauptstadt}";
        }

        private void CmdAnzeigen4_Click(object sender, EventArgs e)
        {
            // Ganzzahlige Zufallszahl zwischen 1 und 6 erstellen
            int x = r.Next(1, 7);

            string bewertung = x switch
            {
                1 or 3 or 5 => "ungerade",
                2 or 4 or 6 => "gerade",
                _ => "kein Würfelwert"
            } ;

            LblAusgabe.Text = $"Wert: {x}, {bewertung}";
        }
    }
}
