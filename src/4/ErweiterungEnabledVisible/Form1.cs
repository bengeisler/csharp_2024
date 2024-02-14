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

        private void cmdLöschen_Click(object sender, EventArgs e)
        {
            LstStädte.Items.Remove(LstStädte.SelectedItem);



        }

        private void LstStädte_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdLöschen.Enabled = LstStädte.SelectedItem is null ? false : true;
        }
    }
}

