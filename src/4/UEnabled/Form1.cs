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

        private void btnloeschen_Click(object sender, EventArgs e)
        {
            lstbox.Items.Remove(lstbox.SelectedItem);
            btnloeschen.Enabled = false;
        }

        private void lstbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int auswahl;
            auswahl = lstbox.SelectedIndex;

            if (auswahl != -1)
            {
                btnloeschen.Enabled = true;
            }
        }
    }
}
