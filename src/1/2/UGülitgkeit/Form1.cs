// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UGülitgkeit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double x = 0;
        private double y = 0;
        private double z = 0;

        private void cmdAnzeigen1_Click(object sender, EventArgs e)
        {
            

            x = x + 0.1;
            y = y + 0.1;

            LblAnzeigen.Text = $"x:{x} \ny:{y}";

        }

        private void cmdAnzeigen2_Click(object sender, EventArgs e)
        {
            z = z + 0.1;
            x = x + 0.1;

            LblAnzeigen.Text = $"x:{x} \nz:{z}";  


        }
    }
}
