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

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            // Variable deklarieren
            int x = 42;

            // Das Funktioniert nicht:
            // LblAnzeige.Text = x;


            // Variable in string umwandeln und der Text_Eigenschaft zuweisen
            LblAnzeige.Text = x.ToString();
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int x = 42;

            // Ausgabe mit String-Interpolation
            // Wert: 42

            // Wert: 42 wird angezeigt
            // Wert in geschweiften Klammern wird in string umgewandelt
            LblAnzeige.Text = $"Wert: {x}";
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            int a = 25;
            int b = 17;
            int c = a + b;

            LblAnzeige.Text = $"Ergebnis der Berechnung: \n{a} + {b} = {c}";




        }

        private void CmdAnzeigen4_Click(object sender, EventArgs e)
        {
            int a = 25;
            int b = 17;
            int c = a + b;

            //Ausgabe der Berechnung in einer MEssagebox
            MessageBox.Show($"Ergebnis der Berechnung: \n{a} + {b} = {c}");
            LblAnzeige.Text = "";

        }
    }
}

