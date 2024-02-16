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

        private void CmdAnzeige_Click(object sender, EventArgs e)
        {
            var traktor = new Fahrzeug("Traktor");
            var gokart = new Fahrzeug(10);

            var schwalbe = new Fahrzeug(10, "Schwalbe");

            LblAnzeige.Text = traktor.ToString() + "\n";
            LblAnzeige.Text += gokart.ToString() + "\n";
            LblAnzeige.Text += schwalbe.ToString() + "\n";
        }
    }
}
