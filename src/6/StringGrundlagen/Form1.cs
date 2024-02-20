// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;

namespace StringGrundlagen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ausgabe in der Debug-Konsole
            Debug.WriteLine("Test");

            // Srings verhalten sich wie Datenfelder

            string ausgabe = "Hallo Welt";
            Debug.WriteLine(ausgabe[0]); // Zugriff über Index

            // Länge
            Debug.WriteLine($"{ausgabe.Length}");

            // Trim: Leerzeichen am Anfang & Ende entfernen

            ausgabe = "     Hallo Welt  ";
            Debug.WriteLine(ausgabe.Trim());

            // Split:
            ausgabe = "Hall,Welt";
            string[] teile = ausgabe.Split(',');
            foreach(string s in teile)
            {
                Debug.WriteLine(s);

            }

            // Replace: Teil des Strings ersetzen

            Debug.WriteLine(ausgabe.Replace());

            // Remove : Zeichen löschen
            // Argument : Index, ab dem gelöscht werden soll
            Debug.WriteLine(ausgabe.Remove(5));

            // Formatierung
            decimal zahl = 10.5M;

            // Ausgabestellen der Zahl formatieren
            Debug.WriteLine($"{zahl}");
            Debug.WriteLine($"{zahl:0.0}");

            //Linksbündig

            Debug.WriteLine($"{zahl,-10:0.00}");
            Debug.WriteLine($"{zahl,10:0.00}");

            // Tausender-Trennzeichen
            zahl = 1234.56M;
            Debug.WriteLine($"{zahl:0.00}");

            // Nachkommastelle:
            Debug.WriteLine($"{zahl:#,##0.00}");

        }
    }
}
