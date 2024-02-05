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

        //Enumeration deklarieren
        private enum Wochentag : int
        {
            Montag = 1, Dienstag = 2, Mittwoch = 3, Donnerstag = 4, Freitag = 5, Samstag = 6, Sonntag = 7
        }


        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            LblAnzeigen.Text =
                $"Sonntag: {Wochentag.Sonntag} {(int)Wochentag.Sonntag}";
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {

        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {

        }
    }
}
