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

        private void BtnAnzeigen_Click(object sender, EventArgs e)
        {
            string Adresse = "Adresse";
            string Name = "Claus Clever";
            string PLZ = "09445 Brunnenstadt";
            string Straﬂe = "Bergstraﬂe34";
            string alter = "Alter:32";
            string gehalt = "Gehalt;";
            decimal euro = 2852.55M;


            LblAnzeige.Text = $"RODINA: \n {Name} \n {Straﬂe} \n {PLZ} \n \n {alter} \n {gehalt} {euro} Ä";
        }
    }
}
