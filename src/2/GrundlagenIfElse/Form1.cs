// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenIfElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            //    Bedingung
            if (NumZahl.Value > 0)
            {
                // Alles innerhalb dieser geschweiften Klammern wird ausgeführt,
                // falls die Bedingung WAHR ist
                LblAusgabe.Text = "Positiv";
            }
            else if (NumZahl.Value == 0)
            {
                LblAusgabe.Text = "0";
            }
            // Falls Bedingung nicht wahr ist
            else
            {
                // Alles innerhalb dieser geschweiften Klammern wird ausgeführt,
                // falls die Bedingung NICHT wahr ist
                LblAusgabe.Text = "Negativ";
            }

        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            // Farbe des Labels: rot, falls Zahl negativ ist und ansonsten schwarz
            if (NumZahl.Value < 0)
            {
                LblAusgabe.ForeColor = Color.Red;
            }
            else
            {
                LblAusgabe.ForeColor = Color.Black;
            }

            // if/else hier oben macht genau das gleiche wie:

            // Ternärer Operator
            LblAusgabe.ForeColor = NumZahl.Value < 0 ? Color.Red : Color.Black;
            //                     <-----^--------->   <----^--->  <------^-->
            //                          Bedingung          |              | 
            //                                      Rückgabe, falls wahr  |
            //                                                            |
            //                                               Rückgabe, falls unwahr

        }
    }
}
