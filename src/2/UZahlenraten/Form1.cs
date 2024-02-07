// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UZahlenraten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly Random r = new Random();
        private int x;
        private int versuch;

        private void BtnZahlerzeugen_Click(object sender, EventArgs e)
        {
            x = (int)r.Next(1, 100);
            versuch = 3;
            LblAusgabe.Text = $"Versuche: {versuch}, {x.ToString()}";

        }

        private void BtnEingabepr¸fen_Click(object sender, EventArgs e)
        {
            int eingabe = Convert.ToInt16(TxtEingabe.Text);
            string nahe = "platzhalter";

            if (versuch > 0)
            {
                if (eingabe < x)
                {
                    nahe = "zu klein";
                    versuch--;
                }
                else if (eingabe > x)
                {
                    nahe = "zu groﬂ";
                    versuch--;
                }
                if (eingabe == x)
                {
                    LblAusgabe.Text = $"Richtig, die Zahl lautet {x}";
                }
                else
                {
                    LblAusgabe.Text = $"Versuche: {versuch} Eingabe: {eingabe}, {nahe}";
                }
            }
            else
            {
                LblAusgabe.Text = "Keine Versuche mehr";
            }
        }
    }
}

