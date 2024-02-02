// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenDatentypen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            
            string Vorname = "Claus";
            string Nachname = "Clever";
            string Strasse = "Bergstraﬂe 34";
            string Ort = "09445 Brunnstadt";

            int Alter = 32;
            decimal Geld = 2852.55M;

            LblAnzeigen.Text = $"Adresse: \n{Vorname} {Nachname} \n{Strasse} \n{Ort} \n \nAlter: {Alter}\nGehalt: {Geld}";

        }
    }
}
