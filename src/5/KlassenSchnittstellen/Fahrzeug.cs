// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenSchnittstellen
{
   
    class Fahrzeug : IComparable<Fahrzeug>
    {
        private readonly int _geschwindigkeit;
        private readonly string _bezeichnung;

        public Fahrzeug(int geschwindigkeit, string bezeichnung)
        {
            _geschwindigkeit = geschwindigkeit;
            _bezeichnung = bezeichnung;
        }

        public int CompareTo(Fahrzeug? other)
        {
            if (_geschwindigkeit < other._geschwindigkeit) return -1;
            else if (_geschwindigkeit > other._geschwindigkeit) return 1;
            else return 0;
        }
        public override string? ToString() => $"{_geschwindigkeit}, {_bezeichnung}";
    }
}
