// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.Eventing.Reader;

namespace USteuerbetrag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdBerechnen_Click(object sender, EventArgs e)
        {
            double eingabe = Convert.ToDouble(txtGehalt.Text);
            double ausgabe;

            if (eingabe > 30000)
            {
                ausgabe = eingabe * 0.25;
            }
            else if (eingabe > 20000)
            {
                ausgabe = eingabe * 0.20;
            }
            else if (eingabe > 12000)
            {
                ausgabe = eingabe * 0.15;
            }
            else
            {
                ausgabe = eingabe * 0.12;
            }

            LblAnzeigen.Text = ausgabe.ToString();
            ausgabe = Convert.ToDouble(txtGehalt.Text);
        }

        private void cmdSwitch_Click(object sender, EventArgs e)
        {
            double eingabe = Convert.ToDouble(txtGehalt.Text);
            double ausgabe;

            switch (eingabe)
            {
                case > 30000:
                    ausgabe = eingabe * 0.25;
                    break;
                case > 20000:
                    ausgabe = eingabe * 0.20;
                    break;
                case > 12000:
                    ausgabe = eingabe * 0.15;
                    break;
                default:
                    ausgabe = eingabe * 0.12;
                    break;

            }
            LblAnzeigen.Text = ausgabe.ToString();
            ausgabe = Convert.ToDouble(txtGehalt.Text);
        }
    }
}
