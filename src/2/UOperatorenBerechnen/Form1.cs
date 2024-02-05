// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UOperatorenBerechnen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAusdruck1_Click(object sender, EventArgs e)
        {
            int a = 3;
            int b = 4;
            int c = 2;
            double d = -2.5;

            double x = a * d + b * c;

            LblAnzeigen.Text = x.ToString();


        }

        private void CmdAusdruck2_Click(object sender, EventArgs e)
        {
            int a = 3;
            int b = 4;
            int c = 2;
            double d = -2.5;

            double x = a * (d + b) * c;

            LblAnzeigen.Text = x.ToString();
        }

        private void CmdAusdruck3_Click(object sender, EventArgs e)
        {

            int Minuten = 325;
            int Std = 60;
            int Stundenberechnung = Minuten / Std;
            int Modulo = Minuten % 60;


            string Anfang = "Minuten sind";
            string Mitte = "Stunden und";
            String letzte = "Minuten.";

            LblAnzeigen.Text = $"{Minuten} {Anfang} {Stundenberechnung} {Mitte} {Modulo} {letzte}";

        }

        private void CmdAusdruck4_Click(object sender, EventArgs e)
        {
            int Minuten = 3661;
            int Std = 60;
            int Stundenberechnung = 3661 / 60 /60;
            int Mins = 3661 / 60 - 60;
            int seks = 3661 % 60; //3723 --> 1 std 2 minuten 3 sekunden

            string Anfang = "Sekunden sind";
            string Mitte = "Stunden,";
            String letzte = "Minuten und";
            string le = "Sekunden.";

            LblAnzeigen.Text = $"{Minuten} {Anfang} {Stundenberechnung} {Mitte} {Mins} {letzte} {seks} {le}";
        }
    }
}
