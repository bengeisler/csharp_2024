// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenEnumeration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Emulation deklarieren
        private enum Wochentag : int
        {
            Montag = 1,
            Dienstag = 2,
            Mittwoch = 3,
            Donnerstag = 4,
            Freitag = 5,
            Samstag = 6,
            Sonntag = 7

        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = $"Montag: {Wochentag.Montag} {(int)Wochentag.Montag}";
            // Ausgabe Montag:Montag1^            ^           ^
            //                       |            |        Mit einem (int) gbt er die zahl an
            //                       |        in klammern ohne ein int  gibt nur den namen aus
            //               das "Montag"  steht noch im string
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {

        }
    }
}
