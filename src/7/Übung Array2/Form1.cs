// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Security.Cryptography;

namespace Übung_Array2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdButton1_Click(object sender, EventArgs e)
        {
            

            int[] array = new int[6];
            for (int i = 0; i < 6; i++)
            {
                array[i] = r.Next(1, 50);
            }
            Array.Sort(array);
            foreach ()
            {

            }
            
        }
    }
}
