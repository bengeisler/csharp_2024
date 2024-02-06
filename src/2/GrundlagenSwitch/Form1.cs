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
        private object x;

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {

            string stadt = TxtStadt.Text;
            string land;
            int flaeche;

            switch (stadt)
            {
                case "Paris":
                    land = "Frankreich";
                    flaeche = 632_734;
                    break;

                // Wenn zum Beispiel mehrere Bedingungen unter einer bestimmten Voraussetzung gelegt sind, alle St�dte in einem Land
                case "Namur":
                case "Antwerpen":
                case "L�ttich":
                    land = "Belgien";
                    flaeche = 30_688;
                    break;

                case "Barcelona":
                    land = "Spanien";
                    flaeche = 505_970;
                    break;

                default:
                    land = "unbekannt";
                    flaeche = 0;
                    break;
            }

            LblAusgabe.Text = $"Stadt: {stadt}, Land: {land}," +
                $" Fl�che: {flaeche}";


        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            double x = r.NextDouble();              //x ist Zufallszahl zwischen 0.0 und 1.0
            LblAusgabe.Text = $"Wert: {x}\n";

            switch (x)
            {
                case < 0.1:
                    LblAusgabe.Text += "Gr��er oder gleich 0.0\n";
                    LblAusgabe.Text += "Kleiner als 0.2";
                    break;

                case < 0.5:
                    LblAusgabe.Text += "Gr��er oder gleich 0.2\n";
                    LblAusgabe.Text += "Kleiner als 0.5";
                    break;

                case < 0.8:
                    LblAusgabe.Text += "Gr��er oder gleich 0.5\n";
                    LblAusgabe.Text += "Kleiner als 0.8";
                    break;

                default:
                    LblAusgabe.Text += "Gr��er oder gleich 0.8\n";
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
                "Belgien" => "Br�ssel",
                "Spanien" => "Madrid",
                _ => "unbekannt"
            };
            LblAusgabe.Text = $"Land: {land}, Hauptstadt: {hauptstadt}";
        }

        private void CmdAnzeigen4_Click(object sender, EventArgs e)
        {
            int x = r.Next(1, 7);

            string bewertung = x switch
            {
                1 or 3 or 5 => "ungerade",
                2 or 4 or 6 => "gerade",
                _ => "kein W�rfelwert"
            };

            LblAusgabe.Text = $"Wert: {x}, {bewertung}";



        }

        private void CmdAnzeigen5_Click(object sender, EventArgs e)
        {
            // Switch mit Vergleichsoperatoren

            // Zufallszahl zwischen -5 und 15 erstellen
            int x = r.Next(-5, 16);

            string bewertung = x switch
            {
                < 0 => "negativ",
                0 => "Null",
                > 9 => "Positiv, zweistellig",
                _ => "Positiv, einstellig"           
            };
            LblAusgabe.Text = $"Wert: {x}, {bewertung}";
        }
    }
}
