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

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            double mittelwert1(double[] werte) => werte.Sum() / werte.Length;
            LblAnzeige.Text = $"Mittelwert 1: {mittelwert1([1, 2, 3])}\n";
            LblAnzeige.Text += $"Mittelwert 2: {mittelwert1([1, 2, 3, 4, 5])}\n";
        }

        private double Mittelwert2(double[] werte) => werte.Average();
    }
}
