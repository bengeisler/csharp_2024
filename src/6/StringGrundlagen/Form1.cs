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
            Debug.WriteLine("Test");

            //Strings verhalten sich wie Datenfelder
            String ausgabe = "Hallo Welt";
            Debug.WriteLine(ausgabe[0]);//Zugriff über Index ---> Ausgabe: H


            //Länge des Strings
            Debug.WriteLine($"{ausgabe.Length}");// ----> 10

            //Trim: Leerzeichen am Anfang & Ende entfernen
            ausgabe = "     Hallo Welt  ";
            Debug.WriteLine(ausgabe.Trim());

            //Split: Zeichenkette anhand Trennzeichen teilen
            ausgabe = "Hallo,Welt";
            string[] teile = ausgabe.Split(',');
            foreach (string s in teile) { Debug.WriteLine(s); }
            //  ^
            //Hallo
            //Welt

            //Replace: Teile des Strings ersetzen
            Debug.WriteLine(ausgabe.Replace(',', '&')); //von Hallo,Welt ----> Hallo&Welt

            //Remove: Zeichen löschen
            //Arugment: Index, ab dem gelöscht werden soll
            Debug.WriteLine(ausgabe.Remove(5));

            //Formatierung der Zahl
            decimal zahl = 10.5000001M;

            Debug.WriteLine($"{zahl}");//---------> 10.5000001

            Debug.WriteLine($"{zahl:0.00}"); //---> 10.5

            Debug.WriteLine($"{zahl:0000.00}"); //---> 0010.5

            //Liksbündig
            Debug.WriteLine($"|{zahl,-10:0.00}|");//-----> |10.50          |
            Debug.WriteLine($"|{zahl,+10:0.00}|");//-----> |          10.50|

            //Tausender-Trennzeichen: ,
            //Nachkommastelle: .
            zahl = 1234.56M;
            Debug.WriteLine($"{zahl:0.00}"); //-----> 1234,56
            Debug.WriteLine($"{zahl:#,##0.00}");//-> 1.234,56
        }
    }
}
