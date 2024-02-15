// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.Eventing.Reader;

namespace UEnabled
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Lichtenstein");
            listBox1.Items.Add("Malta");
            listBox1.Items.Add("Andorra");
            listBox1.Items.Add("San Marino");
            listBox1.Items.Add("Monaco");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.Items.Count - 1);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            cmdLoeschen.Enabled = true;

            else
            cmdLoeschen.Enabled = false;




        }
    }
}
