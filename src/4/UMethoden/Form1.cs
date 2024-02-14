// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UMethoden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            double[] werte = [1, 2, 3, 20, 50];
            double[] werte2 = [1, 2, 3, 4, 5, 6, 100, 200];
            LblAnzeige1.Text = werte.Average().ToString();
            LblAnzeige2.Text = werte2.Average().ToString();








        }
    }
}
