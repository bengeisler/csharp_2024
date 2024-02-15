// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UBankkonto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Objekt von der Klasse Konto erzeugen und in "globaler Variable" speichern
        private Konto _konto = new();

        private void CmdEinzahlen_Click(object sender, EventArgs e)
        {
            _konto.Einzahlen(10);
        }
    }
}
