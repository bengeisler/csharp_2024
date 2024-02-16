// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    class Fahrzeug
    {
        //Eigenschaft
        private int _geschwindigkeit = 0;

        // Methode
        public void Beschleunigen(int geschwindigkeit) => _geschwindigkeit += geschwindigkeit;

        //Ausgabe Methode
        public string Ausgabe() => $"Geschwindigkeit: {_geschwindigkeit}";


    }
}
