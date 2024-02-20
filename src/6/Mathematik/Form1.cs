// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;

namespace Mathematik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Mathematische Konstanten
            Debug.WriteLine($"Pi:{Math.PI}");


            //Zahlen runden
            double x = 1.634;
            //- Mathematisch runden
            Debug.WriteLine($"{x} gerundet: {Math.Round(x)}");  // Auf Ganzzahl
            Debug.WriteLine($"{x} gerundet: {Math.Round(x, 2)}"); //Kommastellen
            // Aufrunden
            Debug.WriteLine($"{x} gerundet: {Math.Ceiling(x)}");
            // Abrunden
            Debug.WriteLine($"{x} gerundet: {Math.Floor(x)}");

            // Quadrieren
            x = 15;
            Debug.WriteLine($"{x} quadreirt: {Math.Pow(x, 2)}");
            // Wurzel zeihen
            x = 25;
            Debug.WriteLine($"Wurzel von {x}: {Math.Sqrt(x)}");


        }
    }
}
