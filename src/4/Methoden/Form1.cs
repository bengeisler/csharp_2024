// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Linq.Expressions;

namespace Methoden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen1_Click(object sender, EventArgs e)
        {
            Hallo();
        }
        //Methode anlegen
        //private: Sichtbarkeit nur innerhalbdieser Klasse)
        // void:Rückgabetyp der Methode void = keine Rückgabe
        //Hallo: Name der Methode
        // ()   Methode hat keine parameter
        // Methoden hat keine Parameter
        //{} Methodenkörper: Hier stehen die Anweisungen, die in
        //      Methode ausgeführt werden
        private void Hallo()
        {
            LblAusgabe.Text = "Hallo Welt";


        }

        private void cmdAnzeigen2_Click(object sender, EventArgs e)
        {
            ZeigeMaximum(10, 20);
        }

        //Methoden mit Parameter
        private void ZeigeMaximum(int x, int y)
        {
            if (x > y)

            {

                LblAusgabe.Text = $"maximum: {x}";

            }
            else
            {

                LblAusgabe.Text = $"Maximum: {y}";

            }


        }

        private void cmdAnzeigen3_Click(object sender, EventArgs e)
        {
            int ergebnis = Addiere(3, 63);
            LblAusgabe.Text = $"Ergebnis: {ergebnis}";
        }

        // Methode mit Parametern und Rückgabewert
        // int: Methode liefert einen Wert vom Datentyp int zurück
        private int Addiere(int x, int y)
        {
            // return: wert zurückgaben & Methode wird verlassen
            return x + y;




        }

        private void cmdAnzeigen4_Click(object sender, EventArgs e)
        {

            LblAusgabe.Text = $"Ergbnis: {Addiere2(1, 2)}";


        }


        // Ausdruckskörper-Syntax; ("Expression boodied member")
        private int Addiere2(int x, int y) => x + y;

        private void cmdAnzeigen5_Click(object sender, EventArgs e)
        {
            // Lokale Funktion innerhalb einer Methode
            // "private" braucht man hier icht, da die Funktion IN einer Methode
            // und nict in einer Klasse deklariert wird
            int Addiere3(int x, int y) => x + y;

            LblAusgabe.Text = $"Ergbnis 1:{Addiere3(1, 2)}\n";
            LblAusgabe.Text += $"Ergbnis 2: {Addiere3(3, 4)}";

        }

        private void cmdAnzeigen6_Click(object sender, EventArgs e)
        {
            // Funktion in einer Variablen speichern

            var Addiere4 = (int x, int y) => x + y;

            LblAusgabe.Text = $"Ergbnis 1:{Addiere4(1, 2)}\n";
            LblAusgabe.Text += $"Ergbnis 2: {Addiere4(3, 4)}";

        }

        private void cmdAnzeigen7_Click(object sender, EventArgs e)
        {

            int[] werte = [0, 2, 3, 40, 50];

            bool istPositiv(int x) => x > 0;
            bool ergebnis1 = Array.TrueForAll(werte, istPositiv);
            bool ergebnis2 = Array.TrueForAll(werte, x => x > 0);

            int wert = Array.Find(werte, x => x >= 4);


        }

        private void cmdAnzeigen8_Click(object sender, EventArgs e)
        {

            // Lokale Funktion, die versucht string in int zu wandeln
            bool stringInInt(string s, out int ergebnis)

                try
            {

                // string in int wandeln
                ergebnis = Convert.ToInt32(s)
                Convert.ToInt32(s);

            }
            catch
            {
                return ergebnis;
            }
            

            }

        bool erfoglreich = stringInInt("asdf", out int ergebnis);

        if (erfolgreich) LblAusgabe.Text = $"{ergebnis};
            else lblAusgabe.Text = "Feheler!";


        }

        
    }

}
