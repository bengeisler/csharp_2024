// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenPruefung
{
    class Fahrzeug
    {
        private int _geschwindigkeit;
        // readonly: Kann nur im Konstruktor geschrieben werden
        private readonly string _bezeichnung;

        public Fahrzeug(int geschwindigkeit, string bezeichnung)
        {
            _geschwindigkeit = geschwindigkeit;
            _bezeichnung = bezeichnung;
        }

        public override string? ToString() => $"{_geschwindigkeit}, {_bezeichnung}";

        public void Beschleunigen(int geschwindigkeit) => _geschwindigkeit += geschwindigkeit;

        // Durch Überladung der Equals-Methode kann festgelegt werden, wie Gleichheit
        // von Objekten festgestellt werden kann.
        public bool Equals(Fahrzeug other) {
            return _bezeichnung == other._bezeichnung && _geschwindigkeit == other._geschwindigkeit;
        }

        // == Operator überladen
        public static bool operator ==(Fahrzeug f1, Fahrzeug f2) => f1.Equals(f2);
        // != Operator überladen
        public static bool operator !=(Fahrzeug f1, Fahrzeug f2) => !f1.Equals(f2);

    }
}
