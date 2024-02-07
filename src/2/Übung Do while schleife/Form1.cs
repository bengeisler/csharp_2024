// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Übung_Do_while_schleife
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            double x;
            double y = 0;
            
            
        
        private void CmdButton1_Click(object sender, EventArgs e)
        {
            y = 0;
            x = 0;
            LblAnzeigen1.Text = "";
            for (x = 35; x > 17.5; x -= 2.5, y++)
            {

                LblAnzeigen1.Text += $"\n{x}";

            }
            
        }

        private void CmdButton2_Click(object sender, EventArgs e)
        {


            y = 0;
            x = 0;
            double gesamt = 0;
            double erg = 0;
            for (x = 35; x >= 20; x -= 2.5, y++)
            {

                gesamt += x;
            }
                erg = gesamt / y;
                    LblAnzeigen3.Text = $"Summe\n{gesamt}";
                    LblAnzeigen4.Text = $"Mittelwert\n{erg}";
                
            

        }
    }
}
