// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Security.Cryptography.X509Certificates;

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
            var traktor = new Fahrzeug();
            var vespa = new Fahrzeug();
            var schwalbe = new Fahrzeug(10);
            var gokart = new Fahrzeug(10,"gokart") ;
            LblAnzeigen.Text = traktor.ToString() + "\n";
            LblAnzeigen.Text += vespa.ToString() + "\n";
            LblAnzeigen.Text += schwalbe.ToString() + "\n";
            LblAnzeigen.Text += gokart.ToString() + "\n";
            var f1 = new xy.Fahrzeug();

        }
    }
}
