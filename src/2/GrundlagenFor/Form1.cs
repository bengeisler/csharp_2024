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

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            int i;

            LblAnzeigen.Text = "";

            for (i = 0; i < 10; i++)
            {
                LblAnzeigen.Text += $"{i}\n";
            }
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int i;

            LblAnzeigen2.Text = "";

            for (i = 0; i < 10; i += 2)
            {
                LblAnzeigen2.Text += $"{i}\n";
            }
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            int i;

            LblAnzeigen3.Text = "";

            for (i = 10; i >= 3; i--)
            {
                LblAnzeigen3.Text += $"{i}\n";
            }
        }

        private void CmdAnzeigen4_Click(object sender, EventArgs e)
        {
            

            LblAnzeige4.Text = "";

            for (double i = 0; i < 5; i += 0.5) 
            {
                LblAnzeige4.Text += $"{i}\n";
            }
        }
    }
}
