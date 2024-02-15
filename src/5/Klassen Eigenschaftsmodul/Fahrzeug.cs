// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen_Eigenschaftsmodul
{
    class Fahrzeug
    {
        //Eigenschaft
        private int _geschwindigkeit = 0;

        //Eigenschaftsmethode
        private int Geschwindigkeit 
        {
            //getter : liefert den aktuellen Wert der Eigenschaft zurück
            // option 2 get => return _geschwindigkeit;
            get
            {
                return _geschwindigkeit;
            }

            //setter : setzt dena ktuellen Wert der Eigenschaft
            //private: Der Steller kann nur innerhalb diese rklasse verwendet werden
            set
            {
                //value: Der Wert, der der Eigenschaft zugewiesen wird
                if (value < 0) _geschwindigkeit = 0;
                else if (value < 100) _geschwindigkeit = 100;
                else _geschwindigkeit = value;

            }
        }
        public void Beschleunigen(int geschwindigkeit) => Geschwindigkeit += geschwindigkeit;

        public string Ausgabe() => $"Geschwindigkeit: {_geschwindigkeit}";
    }
}
