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

        private void button1_Click(object sender, EventArgs e)
        {
            double d = Convert.ToDouble(TxtZahl.Text);

            LblAnzeige.Text = "";
            while (d >= 0.01)
            {
                d /= 2;
                LblAnzeige.Text += $"{d}\n";
            }
        }
    }
}
