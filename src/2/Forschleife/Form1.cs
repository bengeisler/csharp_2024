// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Forschleife
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdButton1_Click(object sender, EventArgs e)
        {
            int i;
            LblAnzeige1.Text = "";
            for (i = 0; i < 10; i++)
            {
                LblAnzeige1.Text += $"\n{i}";
            }
        }

        private void CmdButton2_Click(object sender, EventArgs e)
        {
            int i;
            LblAnzeige2.Text = "";
            for (i = 0; i < 10; i+=2)
            {
                LblAnzeige2.Text += $"\n{i}";
            }
        }
    }
}
