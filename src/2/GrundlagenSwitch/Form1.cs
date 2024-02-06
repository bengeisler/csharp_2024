// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Security.Permissions;

namespace GrundlagenSwitch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Zufallszahlengenerator
        private readonly Random r = new Random();

        private void BtnAnzeigen1_Click(object sender, EventArgs e)
        {
            string stadt = TxtEingabe.Text;
            string land;
            int flaeche;

            switch (stadt)
            {
                case "Paris":
                    land = "Frankreich";
                    flaeche = 45646;
                    break;
                case "Namur":
                case "Antwerpen":
                case "Lüttlich":
                    land = "Belgien";
                    flaeche = 4234;
                    break;
                case "Barcelona":
                    land = "Spanien";
                    flaeche = 432423;
                    break;
                default:
                    land = "unbekannt";
                    flaeche = 0;
                    break;
            }
            LblAnzeige.Text = $"Stadt: {stadt}\nLand: {land}\nFläche: {flaeche}";


        }

        private void BtnAnzeigen2_Click(object sender, EventArgs e)
        {

            //Zufallszahl erzeugen & anzeigen
            double x = r.NextDouble(); // x ist Zufallszahl zwischen 0.0 und 1.0

            LblAnzeige.Text = $"Wert: {x}";

            switch (x)
            {
                case < 0.1:
                    LblAnzeige.Text += "Größer oder gleich 0.0\n";
                    LblAnzeige.Text += "Kleiner als 0.2";
                    break;
                case < 0.5:
                    LblAnzeige.Text += "Größer oder gleich 0.2\n";
                    LblAnzeige.Text += "Kleiner als 0.5";
                    break;
                case < 0.8:
                    LblAnzeige.Text += "Größer oder gleich 0.5\n";
                    LblAnzeige.Text += "Kleiner als 0.8";
                    break;
                default:
                    LblAnzeige.Text += "Größer oder gleich 0.8\n";
                    LblAnzeige.Text += "Kleiner als 1.0";
                    break;
            }
        }

        private void BtnAnzeigen3_Click(object sender, EventArgs e)
        {
            string land = TxtEingabe.Text;
            string hauptstadt = land switch
            {
                "Frankreich" => "Paris",
                "Beglien" => "Brüssel",
                "Spanien" => "Madrid",
                _ => "unbekannt"
            };
            LblAnzeige.Text = $"Land: {land}, Hauptstadt: {hauptstadt}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int d = Convert.ToInt16(TxtEingabe.Text);
            int x = r.Next(1, d);

            string bewertung = (x % 2 == 0) ? "gerade" : "ungerade";


            //            string bewertung = x switch
            //            {
            //                1 or 3 or 5 => "ungerade",
            //                2 or 4 or 6 => "gerade",
            //                _ => "kein Würfelwert"
            //            };

            LblAnzeige.Text = $"Wert: {x}, {bewertung}";
        }

        private void BtnAnzeigen5_Click(object sender, EventArgs e)
        {
            //Switch mit Vergleichsoperatoren

            //Zufallszahl zwischen -5 und 15 erstellen
            int x = r.Next(-5, 16);

            string bewertung = x switch
            {
                < 0 => "negativ",
                0 => "Null",
                > 9 => "positiv, zweistellig",
                _ => "positiv, einstellig"
            };
            LblAnzeige.Text = $"Wert: {x}, {bewertung}";
        }
    }
}
