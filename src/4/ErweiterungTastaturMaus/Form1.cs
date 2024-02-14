// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace ErweiterungTastaturMaus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtEingabe_KeyDown(object sender, KeyEventArgs e)
        {
            lblEingabe.Text = $"Code:{e.KeyCode} Value:{e.KeyValue}, Alt:{e.Alt} Strg:{e.Control} Shift:{e.Shift}";

            if (e.KeyCode == Keys.Enter)
            {
                lblEingabe.Text += "\nEnter wurde gedrückt!";
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lbl2.Text = $"X:{e.X} Y:{e.Y} Button:{e.Button} Clicks:{e.Clicks}";
        }
    }
}
