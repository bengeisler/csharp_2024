// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Klassenprüfung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnklicken_Click(object sender, EventArgs e)
        {
            var f1 = new Fahrzeug(0, "f");
            var f2 = new Fahrzeug(0, "f");

            bool sindHleich = f1 == f2;

            f1.Beschleunigen(10);
            f3.Beschleunigen(10);

        }
    }
}
