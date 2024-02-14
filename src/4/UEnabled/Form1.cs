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
        private void LstStaaten_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Zuweisung über Ternären Operator
            CmdLöschen.Enabled = LstStaaten.SelectedItem is null ? false : true;
        }

        private void CmdLöschen_Click(object sender, EventArgs e)
        {
            LstStaaten.Items.Remove(LstStaaten.SelectedItem);
        }
    }
}
