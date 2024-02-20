// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;

namespace UArraysSummieren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdErgebnis_Click(object sender, EventArgs e)
        {
            int[] zahlen = { 7, 13, 25, 16, 8, 2 };

            
            string verknüpft = string.Join ("+", zahlen);
            int erg = zahlen.Sum();
            MessageBox.Show($"{verknüpft}={erg}");
        }
    }
}
