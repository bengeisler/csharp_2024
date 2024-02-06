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

        private void BtnAnzeigen_Click(object sender, EventArgs e)
        {
            decimal eingabe = Convert.ToDecimal(txtBox.Text);

            LblAnzeigen.Text = "";

            while (eingabe > 0.01M)
            {

                eingabe /= 2;
                LblAnzeigen.Text += $"{eingabe.ToString()}\n";
            }
        }
    }
}
