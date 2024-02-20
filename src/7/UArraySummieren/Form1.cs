// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UArraySummieren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int[] Zahlenliste = { 7, 13, 25, 16, 8, 2 };


        private void cmdBerechnen_Click(object sender, EventArgs e)
        {
            var elemente = "";

            for (int i = 0; i < Zahlenliste.Length-1; i++)
            elemente += Zahlenliste[i]+"+";

            elemente += Zahlenliste[^1];
            elemente += "";
            elemente += Zahlenliste.Sum();

            MessageBox.Show(elemente);


            
        }
    }
}
