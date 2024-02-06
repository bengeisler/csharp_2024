// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMeinName_Click(object sender, EventArgs e)
        {
            LblMeinName.Text = "Benedikt Geisler";
        }

        private void BtnEnde_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
