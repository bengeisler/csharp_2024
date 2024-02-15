// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UMethode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnzeigen1_Click(object sender, EventArgs e)
        {
            double[] wert = [0, 20, 40, 100];
            double[] wert2 = [10, 30, 10, 40];

            LblAusgabe1.Text = wert.Average().ToString();
            LblAusgabe2.Text = wert2.Average().ToString();
                       

        }

        //private double Addieren(int x, int y) => 
    }
}
