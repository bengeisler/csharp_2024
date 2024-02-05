// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementNummericUpAndDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NumZahl_ValueChanged(object sender, EventArgs e)
        {
            LblAnzeige.Text = NumZahl.Value.ToString();
        }
    }
}
