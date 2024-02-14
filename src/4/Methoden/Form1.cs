// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using System.Security.Cryptography;

namespace Methoden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)

        {


        }
        private void Hallo()
        {
            LblAusgabe.Text = "Hallo Welt";

        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {

        }
        private void ZeigeMaximum(int x, int y)
        {


            if (x > y)
            {

                LblAusgabe.Text = $"Maximum: {x}";

            }
            else
            {
                LblAusgabe.Text = $"Maximum:{y}";
            }



        }

        private void CmdAnzeige3_Click(object sender, EventArgs e)
        {
            int ergebnis = Addiere(1, 2);

            LblAusgabe.Text = $"Ergebnis:{ergebnis}";

        }

        private int Addiere(int x, int y)
        {

            return x + y;

        }
        private void CmdAnzeige3_Click(object sender, EventArgs e)
        {

        }
        private int Addiere2(int x, int y) => x + y;

        private void CmdAnzeigen4_Click(object sender, EventArgs e)
        {
            int Addiere3(int x, int y) => x + y;
            LblAusgabe.Text = $"Ergebnis1:{Addiere3(1, 2)}\n";
            LblAusgabe.Text = $"Ergebnis1:{Addiere3(3, 4)}\n";
        }

        private void CmdAnzeige6_Click(object sender, EventArgs e)
        {
            var addiere4 = (int x, int y) => x + y;

            LblAusgabe.Text = $"Ergebnis1:{addiere4(1, 2)}\n";
            LblAusgabe.Text = $"Ergebnis1:{addiere4(3, 4)}\n";
        }

        private void CmdAnzeigen7_Click(object sender, EventArgs e)
        {
            int[] werte = [0, 2, 3, 40, 50];
            bool istPositiv(int x) => x > 0;
            bool ergebnis1 = Array.TrueForAll(werte, istPositiv);
            bool ergebnis2 = Array.TrueForAll(werte, x => x > 0);
            int wert = Array.Find(werte, x => x >= 4);

        }

        private void CmdAnzeige8_Click(object sender, EventArgs e)
        {
            bool stringInInt(string s,out int ergebnis)
            {
                int ergebnis = 0;
                try
                {
                    ergebnis = Convert.ToInt32(s);
                    return true;
                }
                catch
                {
                    ergebnis = 0;
                    return false;
                        
                }
                

            }
        bool erfolgreich = stringIntInt("asdf",out int ergebnis);
            if (erfolgreich) LblAusgabe.Text = $"{ergebnis}";
            else LblAusgabe.Text = "Fehler!";


        }

    }
}





