// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Configuration;

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
            if (NumZahl.Value > 0)
            {
                LblAusgabe.Text = "Positiv";
            }
            else
            {
                LblAusgabe.Text = "Negativ";

            }
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            //LblAugabe.ForeColor = Color.Rot;

            if (NumZahl.Value < 0)








            {



                LblAusgabe.ForeColor = NumZahl.Value < 0 ? Color.Red : Color.Black;

            }
            
        }   
    }
}
