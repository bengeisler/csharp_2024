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

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            var traktor = new Fahrzeug("traktor");
            var vespa = new Fahrzeug();
            var schwalbe = new Fahrzeug(10);
            var gokart = new Fahrzeug(10, "gokart");

            LblAnzeige.Text = traktor.ToString() + "\n"; 
            LblAnzeige.Text += vespa.ToString() + "\n"; 
            LblAnzeige.Text += schwalbe.ToString() + "\n"; 
            LblAnzeige.Text += gokart.ToString() + "\n";
        }
    }
}
