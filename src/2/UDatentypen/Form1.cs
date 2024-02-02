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
            var name = "Benedikt Geisler";
            var adresse = $"{name}\nMeine Straﬂe 1\n12345 Regensburg";
            var alter = 33;
            var gehalt = 12345.5M;

            LblAnzeige.Text = $"Adresse:\n{adresse}\n\nAlter: {alter}\nGehalt: {gehalt}Ä";
        }
    }
}
