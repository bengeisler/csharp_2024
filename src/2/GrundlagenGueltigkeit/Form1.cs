// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenGueltigkeit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // "Globale" Variable
        private int Mx = 0;
        // private: Sichtbarkeit der Variable (nur innerhalb der Klasse)
        // int: Datentyp
        // Mx: Name der Variable
        // = 0: Initialisierung mit dem Wert 0

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            // Lokale Variable
            // - nur gültig innerhalb dieser Funktion
            // - der gleiche Name kann nicht mehrfach deklariert werden
            int x = 0;

            // Deklarieren: eine Variable erstellen:
            // int x;
            //  ^  ^
            //  |  Name der Variable
            // Datentyp der Variable
            //
            // Eine Variable muss immer deklariert werden!

            // Initialisieren: der Variablen erstmals einen Wert zuweisen
            // x = 0:
            // ^   ^
            // |   Wert, der zugewiesen wird
            // Variable

            // Das kann auch in einem Schritt erfolgen:
            // int x = 0;

            // Erhöhe x um 1. Gleichbedeutend mit : x = x + 1; 
            x++;

            Mx++;

            // Wert im Label anzeigen
            // LblAnzeige.Text = x.ToString();

            // Alternativ:
            LblAnzeige.Text = $"x: {x}, Mx: {Mx}";

        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int x = 0;


            //Hallo Andre

            Mx++;

            // Wert im Label anzeigen
            LblAnzeige.Text = x.ToString();
        }
    }
}
