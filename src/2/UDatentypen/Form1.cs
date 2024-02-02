// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UDatentypen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            // Variablen anlegen

            // M�glichkeit 1: var (Datentyp wird automatisch erkannt durch das, was auf der rechten Seite des = steht)
            var name = "Mein Name";
            // M�glichkeit 2: string (explizite Angabe des Datentyps)
            string meinName = "Claus Clever";
            // Zeichenketten (Text) immer in Anf�hrungszeichen!
            // Zeichenketten sind Datentyp string

            string strasse = "Meine Stra�e 1";
            string ort = "12345 Mein Ort";

            int alter = 32;
            decimal gehalt = 2852.55M; // F�r decimal M anh�ngen, sonst Fehlermeldung

            // String-Interpolation
            // $"... {Variable}"
            // ^     ^        ^
            // |     Geschweifte Klammern + Variable werden durch den INHALT der Variable ersetzt
            // |
            // $ am Anfang bedeutet, dass innerhalb der geschweiften Klammern Variablen sind,
            //   deren Inhalt als String interpretiert und an der entsprechenden Stelle eingef�gt werden soll.
            LblAnzeige.Text = $"Adresse:\n{name}\n{strasse}\n\nAlter: {alter}\nGehalt: {gehalt} �";
        }
    }
}
