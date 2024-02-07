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
        private readonly Random r = new();

        private void CmdAnzeige1_Click(object sender, EventArgs e)
        {
            string stadt = txtStadt.Text;
            string land;
            int flaeche;

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
            double x = r.NextDouble();

            LblAusgabe.Text = $"Wert: {x} \n";

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
            string land = txtStadt.Text;
            string hauptstad = land switch
            {
                "Frankriech" => "Paris",
                "Belgien" => "Brüssel",
                "Spanien" => "Madrid",
                _ => "unbebaknnt"

            };
            LblAusgabe.Text = $"Land: {land}, Hauptstadt: {hauptstad}";

        }

        private void CmdAnzeigen4_Click(object sender, EventArgs e)
        {
            int x = r.Next(1, 7);

            string bewertung = x switch
            {
                1 or 3 or 5 => "ungerade",
                2 or 4 or 6 => "gerade",
                _ => "klein Würfelwert"
            };

            LblAusgabe.Text = $"Wert: {x}, {bewertung}";


        }

        private void CmdAnzeigen5_Click(object sender, EventArgs e)
        {
            // Swich mit Vergleichsoperaoren
            // Zufallszahl zwischen -5 und 15 erstellen
            int x = r.Next(-5, 16);

            string bewertung = x switch
            {
                < 0 => "negativ",
                0 => "null",
                > 9 => "positiv, zweitstellig",
                _ => "positiv, einstellig"

            };

            LblAusgabe.Text = $"Wert: {x}, {bewertung}";


        }
    }
}

