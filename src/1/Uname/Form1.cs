// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.CodeDom;

namespace Uname
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonEnde_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnName_Click(object sender, EventArgs e)
        {
            LblName.Text = "Claus Clever";
        }
    }
}
