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
        private readonly int _geschwindigkeit;
        private readonly string _bezeichnung;

        //konstruktoren
        public Fahrzeug()
        {
        }
        public Fahrzeug(int geschwindigkeit) => _geschwindigkeit = geschwindigkeit;
        public Fahrzeug(string bezeichnung) => _bezeichnung = bezeichnung;
        public Fahrzeug(int geschwindigkeit, string bezeichnung) : this(geschwindigkeit) => _bezeichnung = bezeichnung;


        public override string? ToString() => base.ToString();
        // Mit Rechtsklick auf class generiert

        // Selber geschrieben :)
        //public override string ToString() => $"Geschwindigkeit: {_geschwindigkeit}, Bezeichnung: {_bezeichnung}";
    }
}

        
