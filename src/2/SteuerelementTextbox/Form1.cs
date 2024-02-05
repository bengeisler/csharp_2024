// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementTextbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            LblAnzeigen.Text = CmdAnzeigen1.Text;
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            double wert;
            wert = Convert.ToDouble(TxtBox.Text);
            wert *= 2;
            LblAnzeigen.Text = $"Ergebnis: {wert}";
        }
    }
}
