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

        private readonly Random r = new Random();
        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            string stadt = txtAusgabe.Text;
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
                case "LütticH":
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
            Lblausgabe.Text = $"Stadt: {stadt},Land : {land},Fläche:{flaeche}";

        }

        private void CmdAnzeige2_Click(object sender, EventArgs e)
        {
            double x = r.NextDouble();
            Lblausgabe.Text = $"Wert: {x}\n";
            switch (x)
            {
                case < 0.1:
                    Lblausgabe.Text += "Größer oder gleich 0.0 \n";
                    Lblausgabe.Text += "Kleiner als 0.2;";
                    break;
                case < 0.5:
                    Lblausgabe.Text += "Größer oder gleich 0.2 \n";
                    Lblausgabe.Text += "Kleiner als 0.5;";
                    break;
                case < 0.8:
                    Lblausgabe.Text += "Größer oder gleich 0.5 \n";
                    Lblausgabe.Text += "Kleiner als 0.8;";
                    break;
                default:
                    Lblausgabe.Text += "Größer oder gleich 0.8\n";
                    Lblausgabe.Text += "Kleiner als 1.0";
                    break;


            }
        }

        private void CmdAnzeige3_Click(object sender, EventArgs e)
        {
            string land = txtAusgabe.Text;
            string hauptstadt = land switch
            {
                "Frankreich" => "Paris",
                "Belgien" => "Brüssel",
                "Spanien" => "Madrid",
                _ => "unbekannt"
            };
            Lblausgabe.Text = $"Land:{land}, hauptstadt: {hauptstadt}";

        }

        private void CmdAnzeige4_Click(object sender, EventArgs e)
        {
            int x = r.Next(1, 7);
            string bewertung = x switch
            {
                1 or 3 or 5 => "ungerade",
                2 or 4 or 6 => "gerade",
                _ => "kein Würfelwert"

            }

        }

        private void CmdAnzeige5_Click(object sender, EventArgs e)
        {
            int x = r.Next(-5, 16);
            string bewertung = x switch
            {



                < 0 => "negativ,"
                0 => "Null",
                > 9 => "positiv,zweistellig",
                _ => "positiv,einstellig"

            };
            Lblausgabe.Text = $"Wert: {x},{bewertung}";

        }
    }

}
