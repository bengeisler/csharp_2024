// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace USchleifWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            double zahl = Convert.ToDouble(ChkEingabe.Text);

            LblAnzeige.Text = "";


            while (zahl >= 0.01)
            {
                zahl /= 2;

                LblAnzeige.Text += $"{zahl}\n";

            }
    }
}
