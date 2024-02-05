// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Grundlagenifelse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            if (NumZahl.Value < 0)
            {
                LblAusgabe.Text = "negativ";


            }


            else
            {
                LblAusgabe.Text = "positiv";
                //LblAusgabe

            }

            



        }

        private void CmdAnzeige2_Click(object sender, EventArgs e)
        {
            if (NumZahl.Value <0)
            {
                LblAusgabe.ForeColor = Color.Red;
            }
       
            else
            {

                LblAusgabe.ForeColor = Color.Black;

        
            }
        }
    }
}
