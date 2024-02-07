// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace USchleifeWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            // Eingabe auslesen und in double umwandeln
            double zahl = Convert.ToDouble(TxtEingabe.Text);

            LblAnzeige.Text = "";

            while (zahl >= 0.01)
            {
                // Zahl halbieren
                zahl /= 2;
                LblAnzeige.Text += $"{zahl}\n";
            }
        }
    }
}
