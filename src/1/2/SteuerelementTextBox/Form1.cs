// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            LblAnzeigen.Text = TxtEingabe.Text;
        }

        private void cmdRechnen_Click(object sender, EventArgs e)
        {
            double Wert;
            Wert = Convert.ToDouble(TxtEingabe.Text);
            Wert *= 2;

            LblAnzeigen.Text = $"Ergebnis: {Wert}";
            
        }
    }
}
