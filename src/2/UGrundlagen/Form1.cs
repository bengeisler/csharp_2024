// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UGrundlagen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double x = 0;

        private void BtnAnzeigen1_Click(object sender, EventArgs e)
        {
            double y = 0;

            x = x + 0.1;
            y = y + 0.1;


            LblAnzeigen1.Text = $"x:{x}";
            LblAnzeigen2.Text = $"y:{y}";


        }

        private void BtnAnzeigen2_Click(object sender, EventArgs e)
        {
            double z = 0;

            x = x + 0.1;
            z = z + 0.1;

            LblAnzeigen1.Text = $"x:{x}";
            LblAnzeigen2.Text = $"z:{z}";


        }
    }
}
