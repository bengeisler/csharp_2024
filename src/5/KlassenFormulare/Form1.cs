// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace KlassenFormulare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnzeigen_Click(object sender, EventArgs e)
        {
            Form2 unterformular = new();

            unterformular.ShowDialog();

            unterformular.Anzeigentext = txtEingabe.Text;

            //rückgaben aus Formular 2 verarbeiten


        }

        public bool istOk;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
