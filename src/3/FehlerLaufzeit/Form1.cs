// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace FehlerLaufzeit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdOhneEx_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtBox1.Text);
            int y = Convert.ToInt32(txtBox2.Text);
            int z = x / y;
            LblAnzeigen.Text = $"Ergebnis: {z}";
        }
    }
}
