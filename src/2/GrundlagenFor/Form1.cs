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

            LblAnzeigen1.Text = "";

            for (i = 0; i < 10; i++)
            {

                LblAnzeigen1.Text += $"{i}\n";
            }
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int i;

            LblAnzeigen2.Text = "";

            for (i = 0; i < 10; i+=2)
            {

                LblAnzeigen2.Text += $"{i}\n";
            }
        }
    }
}
