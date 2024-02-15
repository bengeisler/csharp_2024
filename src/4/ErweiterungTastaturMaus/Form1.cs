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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtEingabe_KeyDown(object sender, KeyEventArgs e)
        {
            LblEingabe.Text = $"Code:{e.KeyCode} Value:{e.KeyValue} Alt:{e.Alt} Strg:{e.Control} Shift:{e.Shift}";

            if (e.KeyCode == Keys.Enter)
                LblEingabe.Text += "\nEnter wurde gedrückt!";

        }

        private void PanMaus_MouseDown(object sender, MouseEventArgs e)
        {
            LblMaus.Text = $"X:{e.X} Y:{e.Y} Button:{e.Button} Clicks:{e.Clicks}";

        }
    }
}
