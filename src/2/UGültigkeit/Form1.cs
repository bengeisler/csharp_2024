// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UGültigkeit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double x = 0;
        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {

            

            double y = 0.0;

            x = x + 0.1;
            y = y + 0.1;

            LblAnzeigen.Text = $"x: {x}\ny: {y}";



        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            double z = 0.0;

            x = x + 0.1;

            LblAnzeigen.Text = $"x: {x}\nz: {z}";
        }
    }
}
