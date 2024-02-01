// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Uname
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdMeinName_Click(object sender, EventArgs e)
        {
            LblMeinName.Text = "Andre Herian";

        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();


        }
    }
}
