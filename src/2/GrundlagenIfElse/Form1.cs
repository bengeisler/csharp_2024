// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenIfElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            if (txtAusgabe.Value >= 0)
            {
                LblAnzeige.Text = "positiv";
            }
            else
            {
                LblAnzeige.Text = "negativ";
            }
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            //LblAnzeige.ForeColor = Color.Red;

            if (txtAusgabe.Value < 0)
            {
                
                LblAnzeige.ForeColor = Color.Red;
            }
            else
            {
               
                LblAnzeige.ForeColor = Color.Black;

                //Ternärer Operator
                LblAnzeige.ForeColor = txtAusgabe.Value < 0 ? Color.Red : Color.Black;


            }
        }
    }
}
