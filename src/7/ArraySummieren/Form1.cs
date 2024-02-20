// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;

namespace ArraySummieren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] ints = [7,13,25,16,8,2];
            string Plus = string.Join("+", ints);
            int summe = ints.Sum();
            MessageBox.Show($"{Plus}={summe}");




            



        }

    }
}
