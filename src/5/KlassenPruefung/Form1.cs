// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace KlassenPruefung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeige_Click(object sender, EventArgs e)
        {
            var f1 = new Fahrzeug(0, "f");

            var f2 = new Fahrzeug(0, "f");

            bool sindGleich = f1 == f2;

            var f3 = f1;
            var f4 = f1;

            bool sindGleich3 = f1.Equals(f2);
        }
    }
}
