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

        private void CmdLoeschen_Click(object sender, EventArgs e)
        {
            LstBox.Items.Remove(LstBox.SelectedItem);
        }

        private void LstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstBox.SelectedIndex == -1)
            {
                CmdLoeschen.Enabled = false;

            }
            else
            {
                CmdLoeschen.Enabled = true;
            }
        }
    }
}
