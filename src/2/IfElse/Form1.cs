// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace IfElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeige1_Click(object sender, EventArgs e)
        {
            if (Numtext.Value > 0)
            {
                //alles innerhalb dieser geschweiften Klammern wird ausgeführt.
                ////falls die Bedingung WAHR ist
                LblAnzeige.Text = "Positiv";
            }
            else if (Numtext.Value == 0)
            {
                LblAnzeige.Text = "die Zahl ist 0";
            }

            //Falls Bedingung nicht wahr
            else
            {
                //Alles innerhalb der Geschweiften klammer wrd ausgeführt,
                //Falls die Bedingung NICHT wahr ist
                LblAnzeige.Text = "Negativ";
            }
        }

        private void AmdAnzeigen2_Click(object sender, EventArgs e)
        {
            if (Numtext.Value <0)
            {
                LblAnzeige.ForeColor = Color.Red;
            }
            else if (Numtext.Value >0)
            {
                LblAnzeige.ForeColor = Color.Green;
            }
            //Ternärer Operator
            //LblAnzeige.ForeColor = Numtext.Value < 0 ? Color.Red : Color.Black;
            //                      <----------------->  <-------->  <--------->
            //                               |               |           Rückgabe falls unwahr
            //                               |        Rückgabe falls wahr
            //                         Bedingung

            //gleiches wie if ....Red | else....Black

            else
            {
                LblAnzeige.ForeColor = Color.Black;
            }
        }
    }
}
