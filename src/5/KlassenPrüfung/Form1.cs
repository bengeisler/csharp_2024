// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace KlassenPrüfung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnzeigen1_Click(object sender, EventArgs e)
        {
            var f1 = new Fahrzeug(0, "f");
            var f2 = new Fahrzeug(0, "f");

            bool sindGleich = f1 == f2;
            LblAnzeigen.Text = sindGleich.ToString();
        }
    }
}
