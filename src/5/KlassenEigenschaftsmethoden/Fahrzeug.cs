// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenEigenschaftsmethoden
{
    internal class Fahrzeug
    {
        //Eigenschaft
        private int _geschwindigkeit = 0;

        //Eigenschaftsmethode
        public int Geschwindigkeit
        {
            get
            {
                return _geschwindigkeit;
            }
            private set
            {
                if (value < 0) _geschwindigkeit = 0;
                else if (value > 100) _geschwindigkeit = 100;
                else _geschwindigkeit = value;
            }
        }
        public void Beschleunigen(int geschwindigkeit) => Geschwindigkeit += geschwindigkeit;

        public string Ausgabe() => $"Geschwindigkeit: {_geschwindigkeit}";
    }   
}
