// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenKonstruktoren
{
    class Fahrzeug
    {
        private int _geschwindigkeit;
        private string _bezeichnung;

        // Konstruktoren
        public Fahrzeug()
        {
        }

        public Fahrzeug(string bezeichnung) => _bezeichnung = bezeichnung;
        public Fahrzeug(int geschwindigkeit) => _geschwindigkeit = geschwindigkeit;
        public Fahrzeug(int geschwindigkeit, string bezeichnung)
        {
            _geschwindigkeit = geschwindigkeit;
            _bezeichnung = bezeichnung;
        }

        public override string ToString() => $"Geschwindigkeit: {_geschwindigkeit}, Bezeichnung: {_bezeichnung}";

    }


}
