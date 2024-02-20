// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlassenFormulareNEU
{
    public partial class Form2 : Form
    {
        public Form2(Form1 hauptformular)
        {
            InitializeComponent();
        }

        public string AnzeigeText;

        public Form1 Hauptformular;


        private void CmdSchließen_Click(object sender, EventArgs e)
        {

            Hauptformular.istOk = CheckOk.Checked;
            DialogResult = DialogResult.OK;

            Close();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LblAnzeige.Text = AnzeigeText;

        }

        private void CmdAbbrechen_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();

        }
    }
}
