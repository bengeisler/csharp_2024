// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenEigenschaftsMethode
{
     class Fahrzeug
    {
        // Eigenschaft

        private int _geschwindigkeit = 0;

        // Eigenschaftsmethode

        public int Geschwindigkeit
        {
            // getter : Liefert den aktuellen Wert der Eigenschaft zurück
            get
            {
                return _geschwindigkeit;
            }

            // setter: Setzt den aktuellen Wert der Eigenschaft
            // private : Der setter kann nur innerhalb dieser Klasse ver
            private set
            {
                // value: Der Wert, der der Eigenschaft zugewiesen wird
                if (value < 0) _geschwindigkeit = 0;
                else if (value > 100) _geschwindigkeit = 100;
                else _geschwindigkeit = value;

            }
        }
        public void Beschleunigen(int geschwindigkeit) => Geschwindigkeit += geschwindigkeit;

        public string Ausgabe() => $"Geschwindigkeit: {_geschwindigkeit}";


    }

}
