// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace WhileÜbung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdButton1_Click(object sender, EventArgs e)
        {
            double zahl = Convert.ToDouble(Num.Text);
            LblAnzeige1.Text = "";

            while (zahl >= 0.01)
            {
                zahl /= 2;
                LblAnzeige1.Text += $"{zahl}\n";
            }
        }
    }
}
