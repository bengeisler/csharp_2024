// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Drawing.Text;

namespace SteuerelemntGroupBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            OptBerlin.Checked = true;
            OptBedandBreakfast.Checked = true;

        }
        private string _urlaubsort = "Paris";
        private string _unterkunft = "Hotel";
        private void OptBerlin_CheckedChanged(object sender, EventArgs e)
        {
            _urlaubsort = "Berlin";
            Anzeigen();
        }

        private void OptParis_CheckedChanged(object sender, EventArgs e)
        {
            _urlaubsort = "Paris";
            Anzeigen();
        }

        private void OptRom_CheckedChanged(object sender, EventArgs e)
        {
            _urlaubsort = "Rom";
            Anzeigen();
        }

        private void OptBedandBreakfast_CheckedChanged(object sender, EventArgs e)
        {
            _unterkunft = "Bead and Breakfast";
            Anzeigen();
        }

        private void OptFerienwohung_CheckedChanged(object sender, EventArgs e)
        {
            _unterkunft = "Ferienwohung";
            Anzeigen();
        }

        private void OptHotel_CheckedChanged(object sender, EventArgs e)
        {
            _unterkunft = "Hotel";
            Anzeigen();
        }

        private void Anzeigen()
        {
            LblAnzeige.Text = $"{_urlaubsort}, {_unterkunft}";
        }

    }
}
