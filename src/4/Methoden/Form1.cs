// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Methoden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            Hallo();
        }

        // Methode anlegen
        // private: Sichtbarkeit (nur innerhalb dieser Klasse)
        // void:    Rückgabetyp der Methode (void = keine Rückgabe)
        // Hallo:   Name der Methode
        // ()       Methode hat keine Parameter
        // {}       Methodenkörper: Hier stehen die Anweisungen, die in dieser
        //            Methode ausgeführt werden 
        private void Hallo()
        {
            LblAusgabe.Text = "Hallo Welt";
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            // Aufruf der Methode mit den Argumenten 10 und 20 (für x und y)
            ZeigeMaximum(10, 20);
        }

        // Methode mit Parametern
        // In Klammern stehen die Parameter der Methode
        private void ZeigeMaximum(int x, int y)
        {
            if (x > y)
            {
                LblAusgabe.Text = $"Maximum: {x}";
            }
            else
            {
                LblAusgabe.Text = $"Maximum: {y}";
            }
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            // Rückgabe der Funktion in einer Variablen speichern
            int ergebnis = Addiere(1, 2);

            LblAusgabe.Text = $"Ergebnis: {ergebnis}";
        }

        // Methode mit Parametern und Rückgabewert
        // int: Methode liefert einen Wert vom Datentyp int zurück
        private int Addiere(int x, int y)
        {
            // return: Wert zurückgeben & Methode wird verlassen
            return x + y;
        }

        private void CmdAnzeigen4_Click(object sender, EventArgs e)
        {
            LblAusgabe.Text = $"Ergebnis: {Addiere2(1, 2)}";
        }

        // Ausdruckskörper-Syntax ("expression bodied member")
        // Funktion exakt gleich mit "Addiere"
        private int Addiere2(int x, int y) => x + y;

        private void CmdAnzeigen5_Click(object sender, EventArgs e)
        {
            // Lokale Funktion innerhalb einer Methode
            // "private" braucht man hier nicht, da die Funktion IN einer Methode 
            // und nicht in einer Klasse deklariert wird
            int Addiere3(int x, int y) => x + y;

            LblAusgabe.Text = $"Ergebnis 1: {Addiere3(1, 2)}\n";
            LblAusgabe.Text += $"Ergebnis 2: {Addiere3(3, 4)}";
        }

        private void CmdAnzeigen6_Click(object sender, EventArgs e)
        {
            // Funktion (Lambda-Ausdruck) in einer Variablen speichern
            //  Variable        Lambda-Ausdruck
            //  |<---->|   |<-------------------->|
            var addiere4 = (int x, int y) => x + y;

            LblAusgabe.Text = $"Ergebnis 1: {addiere4(1, 2)}\n";
            LblAusgabe.Text += $"Ergebnis 2: {addiere4(3, 4)}";
        }

        private void CmdAnzeigen7_Click(object sender, EventArgs e)
        {
            int[] werte = [0, 2, 3, 40, 50];


            //bool allePositiv = true;
            //foreach (int x in werte) {
            //  if (x < 0) allePositiv = false;
            //}

            // Prüfen, ob alle Elemente eine Bedingung erfüllen
            // 1. mit lokaler Funktion
            bool istPositiv(int x) => x > 0;
            bool ergebnis1 = Array.TrueForAll(werte, istPositiv);
            // 2. Kürer, mit Lambda-Ausdruck
            bool ergebnis2 = Array.TrueForAll(werte, x => x > 0); // Ist true, falls alle Elemente Bedingung erfüllen

            // Ersten Wert im Datenfeld finden, der die Bedingung erfüllt
            int wert = Array.Find(werte, x => x >= 4);

            // Die Anwendungsgebiete für Lambda-Ausdrücke sind vielfältig; dementsprechend oft und
            // gerne werden sie eingesetzt!
        }
    }
}
