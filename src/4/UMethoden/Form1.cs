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
            double[] a = { 1.5, 2, 3, 4, };
            double[] b = { 5, 6, 7.5, 8, };
            LblAusgabe.Text = $"Ergebnisse:\n" +
               $"{Mittelwert(a)}\n{Mittelwert(b)}";

        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
         
        }
    }
}
