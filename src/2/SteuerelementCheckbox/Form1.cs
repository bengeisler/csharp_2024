// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Security.Cryptography.X509Certificates;

namespace SteuerelementCheckbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdButton2_Click(object sender, EventArgs e)
        {
            //Tenäroperator
            //LblAnzeige1.Text = ChkSchalter.Checked ? "Ein" : "Aus";

            // Aternative mit IF else
                 if (ChkSchalter.Checked )
             {
                 LblAnzeige1.Text = "Ein";
             }
                else
             {
                 LblAnzeige1.Text = "Aus";
             }


        }

        private void ChkSchalter_CheckedChanged(object sender, EventArgs e)
        {
            LblAnzeige1.Text = ChkSchalter.Checked ? "Ein" : "Aus";
        }

        private void CmdButton1_Click(object sender, EventArgs e)
        {
            ChkSchalter.Checked = !ChkSchalter.Checked;
        }
    }
}
