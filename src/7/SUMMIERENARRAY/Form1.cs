// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SUMMIERENARRAY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdErgebnis_Click(object sender, EventArgs e)
        {
            int[] liste = { 7, 13, 25, 16, 8, 2 };

            string strings = string.Join("+", liste);
            int ergebnis = liste.Sum();
            MessageBox.Show($"{strings}={ergebnis}");
        }
    }
}
