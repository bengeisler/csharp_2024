// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace UDatentypen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAnzeigen_Click(object sender, EventArgs e)
        {

            var Name = "Inan Muhammet";
            var Adresse = "Boessnerstr.1 \n 93049 Regensburg";
            var Alter = "44";
            var Gehalt = "4444";

            LblName.Text = $"Adresse: \n {Name} \n {Adresse} \n \n Alter: {Alter} \n Gehalt: {Gehalt} €";









               
        }
    }
}
