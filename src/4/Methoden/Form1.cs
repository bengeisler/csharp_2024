// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.ComponentModel;

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

        private void Hallo()
        {
            LblAnzeigen.Text = "Hallo Welt :)";
        }

        private void cmdAnzeigen2_Click(object sender, EventArgs e)
        {
            //Argumente
            ZeigeMaximum(10, 20);

        }

        private void ZeigeMaximum(int x, int y) //Parameter
        {
            if (x > y)
            {
                LblAnzeigen.Text = $"Maximum: {x}";
            }
            else
            {
                LblAnzeigen.Text = $"Maximum: {y}";
            }
        }

        private void cmdAnzeigen3_Click(object sender, EventArgs e)
        {
            int ergebnis = Addiere(1, 2);
            LblAnzeigen.Text = $"Ergebnis: {ergebnis}";
        }

        private int Addiere(int x, int y)
        {
            return x + y;

        }

        private void cmdAnzeigen4_Click(object sender, EventArgs e)
        {

            LblAnzeigen.Text = $"Ergebnis: {Addiere2(1, 2)}";

        }
        private int Addiere2(int x, int y) => x + y;

        private void cmdAnzeigen5_Click(object sender, EventArgs e)
        {
            int Addiere3(int x, int y) => x + y;

            LblAnzeigen.Text = $"Ergebnis 1: {Addiere3(1, 2)}\n";
            LblAnzeigen.Text = $"Ergebnis 2: {Addiere3(3, 4)}";
        }

        private void CmdAnzeigen6_Click(object sender, EventArgs e)
        {
            var addiere4 = (int x, int y) => x + y;

            LblAnzeigen.Text = $"Ergebnis 1: {Addiere4(1, 2)}\n";
            LblAnzeigen.Text = $"Ergebnis 2: {Addiere4(3, 4)}";

        }

        private void cmdAnzeigen7_Click(object sender, EventArgs e)
        {
            int[] werte = [0, 2, 3, 40, 50];

            bool istpositiv(int x) => x > 0;
            bool ergebnis1 = Array.TrueForAll(werte, istpositiv);

            bool ergebnis2 = Array.TrueForAll(werte, x => x > 0);

            int wert = Array.Find(werte, x => x >= 4);
        }
    }
}
