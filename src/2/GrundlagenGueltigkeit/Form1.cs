// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenGueltigkeit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Mx = 0;


        private void CmdAnzeige1_Click(object sender, EventArgs e)
        {
           
            int x = 0;

            

            x++;

            Mx++;


            LblAnzeige.Text = $"x: [x], Mx: {Mx}";




        }

        private void CmdAnzeige2_Click(object sender, EventArgs e)
        {
            int x = 0;

            Mx++;




            LblAnzeige.Text = $"x: [x], Mx: {Mx}";



        }
    }
}
