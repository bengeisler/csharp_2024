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

        private void cmdAnzeigen1_Click(object sender, EventArgs e)
        {
            // Variable deklarieren
            int x = 42;

            // Das funktioniert nicht:
            // LblAnzeige.Text = x;

            // Variable in string umwandeln und der Text-Eigenschaft zuweisen
            LblAnzeige.Text = x.ToString();
        }

        private void cmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int x = 42;

            // Ausgabe mit String-Interpolation
            // Wert: 42

            // Ausgabe {x} wird angezeigt
            LblAnzeige.Text = $"Wert: {x}";

            // Wert: 42     wird angezeigt
            // Wert in geschweifte Klammern wird in String umgewandelt
            LblAnzeige.Text = $"Wert: {x}";
        }

        private void cmdAnzeigen3_Click(object sender, EventArgs e)
        {
            int a = 25;
            int b = 17;
            int c = a + b;

            // \n = Zeilenumbruch
            LblAnzeige.Text = $"Ergebnis der Berechnung: \n{a} + {b} = {c}";
        }

        private void cmdAnzeigen4_Click(object sender, EventArgs e)
        {
            int a = 25;
            int b = 17;
            int c = a + b;

            // Ausgabe der Berechnung in einer MessageBox
            MessageBox.Show($"Ergebnis der Berechnuung: \n{a} + {b} = {c}");

            LblAnzeige.Text = "Ende";
        }
    }
}
