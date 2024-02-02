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

        private decimal x = 0M;
        
       

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {

            double y = 0.0;
            
            

            x = x + 0.1M;
            y = y + 0.1M;

            LblAnzeige.Text = $"x: {x} \ny: {y}";



        }

        private void Btn_Click(object sender, EventArgs e)
        {

            double z = 0.0;


            x = x +0.1M;
            z = z +0.1M;

            LblAnzeige.Text = $"x: {x} \nz: {z}";

        }
    }
}
