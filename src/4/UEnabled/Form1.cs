// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UEnabled
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Listbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Listbox1.SelectedIndex == -1)
                cmdLoeschen.Enabled = false;
            else
                cmdLoeschen.Enabled = true;

        }

        private void cmdLoeschen_Click(object sender, EventArgs e)
        {
            Listbox1.Items.Remove(Listbox1.SelectedItem);


        }
    }
}
