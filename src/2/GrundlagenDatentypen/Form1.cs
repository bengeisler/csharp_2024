// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenDatentypen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            // Byte: 0-255

            // Speicher
            // 8 Bit: ____ _100
            //        1111 1111 255
            // 2^0 = 1
            // 2^1 = 2
            // 2^2 = 4
            // ...
            // 2^7 = 128


            // bool
            bool a = true;
            bool b = false;

            // Zahlen
            // - Ganze Zahlen
            byte c = 255; // 0 - 255
            int d = 1000; // -2.147.483.648 - 2.147.483.647
            int k = 1_000_000_000;
            int l = 1000000000;

            // - Kommazahlen
            double f = 3.5;
            float g = 1.0f;

            // Für Geld:
            decimal h = 3.5M;

            // Zeichenketten
            string i = "Hallo";
            char j = 'A';

            // Automatische Typ-Erkennung
            var m = "Hallo";
            var n = 5;
            var o = 10.0;


            // Bool
            var x = (2 == 3);
            var y = (2 < 3);


        }
    }
}
