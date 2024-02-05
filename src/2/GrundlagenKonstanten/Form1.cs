// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenKonstanten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private enum Wochentag : int
        {
            Montag = 1,
            Dienstag = 2,
            Mittwoch = 3,
            Donnerstarg = 4,
            Freitag = 5,
            Samstag = 6,
            Sonntag = 7,
        }

        private void BtnAnzeige1_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = $"Montag: {Wochentag.Montag} {(int)Wochentag.Montag}";
        }
    }
}
