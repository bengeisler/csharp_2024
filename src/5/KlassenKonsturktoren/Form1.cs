// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace KlassenKonsturktoren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            var traktor = new Fahrzeug("traktor");
            var vespa = new Fahrzeug();
            var schwalbe = new Fahrzeug(10);
            var gokart = new Fahrzeug(10,"gokart");

            lblAnzeigen.Text = traktor.ToString() + "\n";
            lblAnzeigen.Text += vespa.ToString() + "\n";
            lblAnzeigen.Text += schwalbe.ToString() + "\n";
            lblAnzeigen.Text += gokart.ToString() + "\n";
        }
    }
}
