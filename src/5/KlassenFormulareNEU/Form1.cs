// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace KlassenFormulareNEU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool istOk;

        private void CmdAufrufen_Click(object sender, EventArgs e)
        {
            Form2 unterformular = new Form2();
            unterformular.AnzeigeText = TxtEingabe.Text;
            unterformular.Hauptformular = this;
            unterformular.ShowDialog();

            var ergebnis = unterformular.ShowDialog();
            if (ergebnis == DialogResult.OK)
            {
                checkok.checked = istOk;

            }
        }
    }
}
