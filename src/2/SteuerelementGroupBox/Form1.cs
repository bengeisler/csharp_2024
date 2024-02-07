// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace SteuerelementGroupBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            OptBerlin.Checked = true;
            OptBreakfast.Checked = true;
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

        private void OptBreakfast_CheckedChanged(object sender, EventArgs e)
        {
            _unterkunft = "Bed and Breakfast";
            Anzeigen();
        }

        private void OptFerienwohnung_CheckedChanged(object sender, EventArgs e)
        {
            _unterkunft = "Ferienwohnung";
            Anzeigen();
        }

        private void OptHotel_CheckedChanged(object sender, EventArgs e)
        {
            _unterkunft = "Hotel";
            Anzeigen();
        }
        private void Anzeigen()
        {
            label1.Text = $"{_urlaubsort}, {_unterkunft}";
        }


    }
}
