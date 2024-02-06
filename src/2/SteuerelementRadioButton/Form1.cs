// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementRadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdButton1_Click(object sender, EventArgs e)
        {
            if (OptRot1.Checked) LblAnzeige1.Text = "Rot";
            else if (OptRot2.Checked) LblAnzeige1.Text = "Grün";
            else if (OptRot3.Checked) LblAnzeige1.Text = "Blau";
            else LblAnzeige1.Text = "Nichts ausgewählt";
        }
        private void CmdButton2_Click (object sender, EventArgs e)
        {
            OptRot1.Checked = true;
        }
        private void OptRot2_CheckedChanged (object sender, EventArgs e)
        {
            LblAnzeige2.Text = "Grün";
        }
        private void OptRot3_CheckedChanged (object sender, EventArgs e)
        {
            LblAnzeige2.Text = "bLUE";
        }
    }
}
