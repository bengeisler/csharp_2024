// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UGueltigkeit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Decimal x = 0.0m;
        
       


        private void CmdAnzeige1_Click(object sender, EventArgs e)
        {
            Decimal y = 0.0m;
            x = x + 0.1m;
            y = y + 0.1m;

            LblAsugabe.Text = $"x: {x} \ny: {y}";


        }

        private void CmdAnzeige2_Click(object sender, EventArgs e)
        {
            Decimal z = 0.0m;
            x = x + 0.1m;
            z = z + 0.1m;

            LblAsugabe.Text = $"x: {x} \nz: {z}";



        }
    }
}
