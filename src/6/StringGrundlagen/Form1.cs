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
            string ausgabe = "Hallo Welt";

            //Länge des String
            Debug.WriteLine(ausgabe.Length); // Zugriff über Index

            // Trim: Leerzeichen am Anfang & Eende entfernen
            ausgabe = "               Hallo Wellt                 ";
            Debug.WriteLine(ausgabe.Trim());

            // Splitt: Zeichenkette anhand Trennzeichen teilen
            ausgabe = "Hallo Welt";
            string[] teile = ausgabe.Split(',');
            foreach(string s in teile)
            {
                Debug.WriteLine(s);
            }

            // Replace : Teil des Strings ersetzen
            // 1. Argument: Altes Zeichen, das ersetzt werden soll
            // 2. Argument: Neues Zeichen das anstelle des alten stehen soll
            Debug.WriteLine(ausgabe.Replace(',', ' '));

            // Remove: Zeichen löschen
            Debug.WriteLine(ausgabe.Remove(5));

            // Formattierung
            decimal zahl = 10.5M;

            Debug.WriteLine($"{zahl}");

            Debug.WriteLine($"{zahl:0.00}");
            Debug.WriteLine($"{zahl:000.00}");

            //Linksbündig
            Debug.WriteLine($"{zahl,-10:0.00}");
            //Rechtsbündig
            Debug.WriteLine($"{zahl,10:0.00}");

            // Tausender-Trennzeichen
            zahl = 1234.56M;
            Debug.WriteLine($"{zahl:0.00}");
            // Tausender-Trennzeichen: ,
            //Nachkommastelle: .
            Debug.WriteLine($"{zahl:#,##0.00}");



        }
    }
}
