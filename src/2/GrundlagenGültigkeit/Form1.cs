// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

namespace GrundlagenGültigkeit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Mx = 0;

        private void BtnAnzeigen1_Click(object sender, EventArgs e)
        {
            int x = 0;

            x++;
            Mx++;

            //LblAnzeigen.Text = x.ToString();

            //Alternative:
            LblAnzeigen.Text = $"x:{x}, Mx:{Mx}";
        }

        private void BtnAnzeigen2_Click(object sender, EventArgs e)
        {
            int x = 0;

            x++;
            Mx++;

            LblAnzeigen.Text = $"x:{x}, Mx:{Mx}";


        }
    }
}
