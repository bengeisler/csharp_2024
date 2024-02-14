// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Tastatur_und_Maus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            Lbl1.Text = $"Code:{e.KeyCode} \nValue: {e.KeyValue} \nAlt:{e.Alt} \nStrg:{e.Control} \nShift:{e.Shift}";

            if (e.KeyCode == Keys.Enter)
            {
                Lbl1.Text += "\nEnter wurde gedrückt!";
            }
        }

        private void Pan_MouseDown(object sender, MouseEventArgs e)
        {
            Lbl2.Text = $"X:{e.X} \nY:{e.Y} \nButton:{e.Button} \nClicks:{e.Clicks}";
        }
    }
}
