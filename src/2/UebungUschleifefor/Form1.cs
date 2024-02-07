// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UebungUschleifefor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            double i;
            var summe;

            Lbl1.Text = "";


            for (i = 35; i >= 20; i -= 2.5)
            {
                Lbl1.Text += $"{i}\n";
            }
        }

        private void CmdAnziegen2_Click(object sender, EventArgs e)
        {
            Lbl2.Text = 
        }
    }
}
