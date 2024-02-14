// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace ErweiterungEnabledVisible
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdL�schen_Click(object sender, EventArgs e)
        {
            LstSt�dte.Items.Remove(LstSt�dte.SelectedItem);



        }

        private void LstSt�dte_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdL�schen.Enabled = LstSt�dte.SelectedItem is null ? false : true;
        }
    }
}

