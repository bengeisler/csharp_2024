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

        private void CndAnzeigen_Click(object sender, EventArgs e)
        {
            var traktor = new Fahrzeug("traktor");
            var vespa = new Fahrzeug();
            var schwalbe = new Fahrzeug(10);
            var gokart = new Fahrzeug("gokart",10);

            LblAusgabe.Text = traktor.ToString() + "\n";
            LblAusgabe.Text += vespa.ToString() + "\n";
            LblAusgabe.Text += schwalbe.ToString() + "\n";
            LblAusgabe.Text += gokart.ToString() + "\n";





        }
    }
}
