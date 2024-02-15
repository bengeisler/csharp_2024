// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace KlassenKonstruktoren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnzeigen1_Click(object sender, EventArgs e)
        {
            var traktor = new Fahrzeug("traktor");
            var schwalbe = new Fahrzeug(10);
            var gokart = new Fahrzeug(10, "GoKart");

            LblAnzeigen.Text = traktor.ToString() + "\n";
            LblAnzeigen.Text += schwalbe.ToString() + "\n";
            LblAnzeigen.Text += gokart.ToString() + "\n";

            //Fahrzeug test = new("Test");
        }
    }
}
