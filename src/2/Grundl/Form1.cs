// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.CodeDom;

namespace Grundl_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAnzeige_Click(object sender, EventArgs e)
        {
            // x= Name  y= Straﬂe  z= Stadt  a= Alter  b= Gehalt
            String x = "Claus Clever",y="Bergstraﬂe 32",z= "09445 Brunnstadt";
            int a = 34;
            decimal b = 2852.55M;/*<-- M anh‰gen sonst Fehlermeldung*/
            
            LblAnzeige.Text = $"Adresse:\n{x}\n{y}\n{z}\n\nAlter: {a}\nGehalt:{b}Ä";
        }
    }
}
