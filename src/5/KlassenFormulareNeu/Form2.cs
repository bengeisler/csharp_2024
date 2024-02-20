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

namespace KlassenFormulareNeu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Eigenschaft
        public string AnzeigeText;

        // Hauptformular
        public Form1 Hauptformular;
        private void Form2_Load(object sender, EventArgs e)
        {
            LblAnzeige.Text = AnzeigeText;

        }

        private void CmdSchließen_Click(object sender, EventArgs e)
        {
            // Rückgabe an Form1 hier einfügen
            Hauptformular.istOK = chku.Checked;
            // DialogResult OK
            DialogResult = DialogResult.OK;


            // Schließen
            Close();

        }

        private void CmdAbrechen_Click(object sender, EventArgs e)
        {
            // DialogResult setzten
            DialogResult = DialogResult.Cancel;

            Close();

        }
    }
}
