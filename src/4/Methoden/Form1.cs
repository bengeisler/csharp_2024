// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.ComponentModel;
using System.Drawing.Text;

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
        // void: Rückgabetyp der Methode (void = keine Rückgabe)
        // Hallo: Name der Methode
        // () Methode nat kkeine Parameter
        // {} Methodenkörper: Hier stehen die Anweisungen, die in dieser
        // 
        private void Hallo()
        {
            LblAusgabe.Text = "Hallo Welt";

        }

        private void BtmAnzeigen2_Click(object sender, EventArgs e)
        {
            ZeigeMaximum(10, 20);
        }
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

        private void CmdAnklicken3_Click(object sender, EventArgs e)
        {
            int ergebnis = Addiere(1, 2);
            LblAusgabe.Text = $"Ergebnis: {ergebnis}";

        }
        private int Addiere(int x, int y)
        {
            // return: Wert zurückgeben
            return x + y;


        }

        private void CmdAnklicken4_Click(object sender, EventArgs e)
        {
            LblAusgabe.Text = $"Ergebnis: {Addiere(1, 2)}";
        }
        //Ausdruckskörper-Syntax ("expression bodied member")
        //Funktion exakt gleich mit "Addiere"
        private int Addiere2(int x, int y) => x + y;

        private void CmdAnklicken5_Click(object sender, EventArgs e)
        {
            //Lokale Funktion innerhalb einer Methode
            //"private" braucht man hier nicht, da die Funktion In einer Methode
            //und nicht in einer Klasse deklariert wird

            int Addiere3(int x, int y) => x + y;

            LblAusgabe.Text = $"Ergebnis 1: {Addiere3(1, 2)}\n";
            LblAusgabe.Text += $"Ergebnis 2: {Addiere3(3, 4)}";

        }

        private void CmdAnklicken6_Click(object sender, EventArgs e)
        {
            //Funktionen in einer Variablen speichern
            var addiere4 = (int x, int y) => x + y;

            LblAusgabe.Text = $"Ergebnis 1: {addiere4(1, 2)}\n";
            LblAusgabe.Text += $"Ergebnis 2: {addiere4(3, 4)}";
        }

        private void CmdAnklicken7_Click(object sender, EventArgs e)
        {
            int[] werte = [0, 2, 3, 40, 50];
            // bool allePositiv = true
            // forech (int x in werte) {
            // if (x < 0) allePositiv = false;
            //}

            // Prüfen, ob alle Elemente eine Bedingung erfüllen
            // 1. mit lokaler Funktion
            bool istPositiv(int x) => x > 0;
            bool ergebnis1 = Array.TrueForAll(werte, istPositiv);

            bool ergebnis = Array.TrueForAll(werte, x => x == 0);
            int wert = Array.Find(werte, x => x == 4);

            var quadrate = werte.Select(x => x * x).ToArray();

        }

        private void CmdAnklicken8_Click(object sender, EventArgs e)
        {
            // Lokale Funktion,die versucht string in int zu wandeln
            bool stringInInt(string s, out int ergebnis)
            {
            try
            {
                    // string in int wandeln
                ergebnis = Convert.ToInt32(s);
                    return true;
            }
            catch
            {
                    ergebnis = 0;
                    return false;
               
            }
            
            }

            bool erfolgreich = stringInInt("asdf", out int ergebnis);
            // Alternativ: Funktion von C# verwenden:
            // erfolgreich = int.TryParse("asdf", out int ergebnis)
            if (erfolgreich) LblAusgabe.Text = $"{ergebnis}";
            else LblAusgabe.Text = "Fehler";

        }
    }
}
