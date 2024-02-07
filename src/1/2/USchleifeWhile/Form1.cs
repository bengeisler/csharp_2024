// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace USchleifeWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {
            decimal Zahl = Convert.ToDecimal(txtZahl.Text);

            LblAnzeigen1.Text = "";

            while (Zahl > 0.01M)
            {

                Zahl /= 2;
                LblAnzeigen1.Text += $"{Zahl}\n";
            }
        }
    }
}
