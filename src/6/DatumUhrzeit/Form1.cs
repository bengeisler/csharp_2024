// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;

namespace DatumUhrzeit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Aktuelle Zeit
            Debug.WriteLine(DateTime.Now.ToString());

            //Aktuelles Datum
            Debug.WriteLine(DateTime.Now.Date);

            //Aktuelle Uhrzeit
            Debug.WriteLine(DateTime.Now.TimeOfDay);
            Debug.WriteLine(DateTime.Now.ToShortTimeString());

            //Rechnen mit Datum und Uhrzeit
            Debug.WriteLine(DateTime.Now.AddMinutes(95).ToShortTimeString());

            //Datum erzeugen
            DateTime d1 = new(2024, 02, 19);
            Debug.WriteLine(d1);
            DateTime d2 = new(2024, 02, 19, 08, 45, 00);
            Debug.WriteLine(d2);

            Debug.WriteLine(DateTime.Now - d2);

        }

        private void DatPicker_ValueChanged(object sender, EventArgs e)
        {
            LblAusgabe.Text = DatPicker.Value.ToShortDateString();

        }
    }
}
