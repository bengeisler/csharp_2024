// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenEnumerationen
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
            Donnerstag = 4,
            Freitag = 5,
            Samstag = 6,
            Sonntag = 7,
        }
          

        private void CmdAnzeige1_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = $"Montag: {Wochentag.Montag} {(int)Wochentag.Montag}";

        }

        private void CmdAnzeige2_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Wollen Sie schlieﬂen?", "Schlieﬂen", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                Close ();
            LblAnzeige.ForeColor = Color.Green
        }
    }
}
