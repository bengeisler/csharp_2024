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

        private void CmdButton1_Click(object sender, EventArgs e)
        {
            var traktor = new Fahrzeug("traktor");
            var Vespa = new Fahrzeug();
            var Schwalbe = new Fahrzeug(10);
           var gokart = new Fahrzeug(10,"gokart");

            LblAnzeige1.Text = traktor.ToString()+"\n";
            LblAnzeige1.Text += Vespa.ToString() + "\n";
            LblAnzeige1.Text += Schwalbe.ToString() + "\n";
            LblAnzeige1.Text += gokart.ToString() + "\n";

        }
    }
}
