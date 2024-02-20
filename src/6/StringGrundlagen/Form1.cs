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
            //Aktuelles Datum und Uhrzeit
            Debug.WriteLine(DateTime.Now.ToString());

            //Aktuelles Datum
            Debug.WriteLine(DateTime.Now.Date);

            //Aktuelle Uhrzeit
            Debug.WriteLine(DateTime.Now.TimeOfDay);
            Debug.WriteLine(DateTime.Now.ToShortTimeString());

            //Rechnen mit Datum und Uhrzeit

            Debug.WriteLine(DateTime.Now.AddMinutes(95).ToShortTimeString());
            Debug.WriteLine(DateTime.Now.AddMonths(1).ToShortTimeString());

            // Datum erzeugen
            DateTime d1 = new(2024, 02, 19);
            Debug.WriteLine(d1);
            DateTime d2 = new(2024, 02, 19, 08, 45, 00);
            Debug.WriteLine(d2);

            Debug.WriteLine(DateTime.Now - d2);





            Debug.WriteLine("Test");

            string ausgabe = "Hallo Welt";
            Debug.WriteLine(ausgabe[0]);
            // Länge des Strings
            Debug.WriteLine($"{ausgabe.Length}");

            // Trim: Leerzeichen am Anfang und Ende entfernen
            ausgabe = "      Hallo Welt       ";
            Debug.WriteLine(ausgabe.Trim());

            // Split: Zeichenkette anhand Trennzeichen teilen
            ausgabe = "Hallo,Welt";
            string[] teile = ausgabe.Split(',');
            foreach (string s in teile)
            {
                Debug.WriteLine(s);
            }

            //Replace: Teil des Strings ersetzen
            Debug.WriteLine(ausgabe.Replace(',', ' '));

            // Remove: Zeichen löschen
            Debug.WriteLine(ausgabe.Remove(5));

            //Formatierung
            decimal zahl = 10.50001M;
            Debug.WriteLine($"{zahl}");
            Debug.WriteLine($"{zahl:0.00}");

            //Linksbündig
            Debug.WriteLine($"|{zahl,-10:0.00}|");



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LblAusgabe.Text = dateTimePicker1.Value.ToShortDateString();

        }
    }
}
