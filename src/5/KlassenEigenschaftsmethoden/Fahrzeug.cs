// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenEigenschaftsmethoden
{
    class Fahrzeug
    {

        private int _geschwndigkeit = 0;

        // Eigenschaftsmethode
        public int Geschwindigkeit
        {
            get
            {
              // getter
              return _geschwndigkeit;
            }

            // setter : Setzt den aktuellen Wert der Eigenschaft
            // private: Der setter kann nr innerhalb dieser Klasse ver
            private set
            {
                // value: Der Wert, der der Eigenschaft zugewiesen wird
                if (value < 0) _geschwndigkeit = 0;
                else if (value > 100) _geschwndigkeit = 100;
                else _geschwndigkeit = value;
                
            }
        }
        public void Beschleunigen(int geschwindigkeit) => Geschwindigkeit += geschwindigkeit;

        public string Ausgabe() => $"Geschwindigkeit: {_geschwndigkeit}";

    }
}
