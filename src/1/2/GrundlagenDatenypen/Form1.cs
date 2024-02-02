// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenDatenypen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            string Adresse = "Adresse";
            string Name = "Claus Clever";
            string Strasse = "Bergstraﬂe 34";
            string PLZ = "09445 Brunnstadt";
            string Alter = "Alter: 32";
            string Gehalt = "Gehalt:";
            decimal Euro = 2852.55M;

            LblAnzeigen.Text = $"Adresse: \n {Name} \n {Strasse} \n {PLZ} \n \n {Alter} \n {Gehalt} {Euro}";
        }
    }
}
