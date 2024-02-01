// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenAusgaben
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAnzeigen1_Click(object sender, EventArgs e)
        {
            // Variable deklarieren
            int x = 42;

            // Das funktioniert nicht:
            // LblAnzeige.Text = x;

            //Variable in String umwandeln und der Text-Eigenschaft zuweisen
            LblAnzeigen.Text = x.ToString();
        }

        private void BtnAnzeigen2_Click(object sender, EventArgs e)
        {
            int x = 42;

            //Ausgabe mit String Interpolation
            //Wert: 42

            LblAnzeigen.Text = $"Wert: {x}";
        }
    }
}
