// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassenprüfung
{
    class Fahrzeug
    {
        private int _geschwindigkeit;
        private readonly string _bezeichnung;

        public Fahrzeug(int geschwindigkeit, string bezeichnung)
        {
            _geschwindigkeit = geschwindigkeit;
            _bezeichnung = bezeichnung;
        }
        public override string ToString() => $"{_geschwindigkeit}, {_bezeichnung}";

        public void Beschleunigung(int geschwindigkeit) => _geschwindigkeit += geschwindigkeit;

        public bool Equals(Fahrzeug other)
        {
            return _bezeichnung == other._bezeichnung && _geschwindigkeit == other._geschwindigkeit;

        }
        // == Operator überladen
        public static bool operator ==(Fahrzeug f1, Fahrzeug f2) => f1.Equals(f2);
        public static bool operator !=(Fahrzeug f1, Fahrzeug f2) => !f1.Equals(f2);

        

        }
  }
  

