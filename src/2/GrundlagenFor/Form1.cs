// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < 10; i++)

                LblAnzeigen1.Text += $"{i}\n";

        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < 10; i += 2)

                LblAnzeige2.Text += $"{i}\n";
        }

        private void CmdAnzeige3_Click(object sender, EventArgs e)
        {

            for (int = 10; i =< 3; i--)

                LblAnzeige3.Text += $"{i}\n";
        }

        private void CmdAnzeige4_Click(object sender, EventArgs e)
        {
            for (double i = 0; i < 5; i+=0.5)

                LblAnzeige4.Text += $"{i}\n";
        }
    }
}
