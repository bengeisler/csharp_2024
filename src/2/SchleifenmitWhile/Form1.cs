// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SchleifenmitWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeige_Click(object sender, EventArgs e)
        {
            double zahl = Convert.ToDouble(TxtEingabe.Text);
            LblAusgabe.Text = "";
            while (zahl >= 0.01)
            {
                zahl /= 2;
                LblAusgabe.Text += $"{zahl}\n";



            }
        }
    }
}
