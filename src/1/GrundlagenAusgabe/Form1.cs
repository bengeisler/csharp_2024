// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenAusgabe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAnzeigen1_Click(object sender, EventArgs e)
        {
            // Variable deklarieren
            int x = 42;

            // Das funktioniert nicht:
            // LblAnzeige.Text = x;

            // Variable in string umwandeln und der Text-Eigenschaft zuweisen
            LblAnzeige.Text = x.ToString();
        }

        private void BtnAnzeigen2_Click(object sender, EventArgs e)
        {
            int x = 42;

            // Ausgabe mit String-Interpolation
            // Wert: 42

            // Ausgabe {x}  wird angezeigt
            LblAnzeige.Text = "Ausgabe {x}";

            // Wert: 42    wird angezeigt
            // Wert in geschweiften Klammern wird in string umgewandelt
            LblAnzeige.Text = $"{x}";


            // Weiteres Beispiel:

            // int alter = 33;
            // string name = "Benedikt";

            // LblAnzeige.Text = $"Hallo, mein Name ist {name} und ich bin {alter} Jahre alt";
            // LblAnzeige.Text = "Hallo, mein Name ist " + name + " und ich bin " + alter.ToString() + " Jahre alt.";
        }
    }
}
