// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassengenerisch
{
    internal class Land : IEquatable<Land>
    {
        private readonly string _name;
        private readonly string _hautpstadt;

        //Konstruktor
        public Land(string name, string hautpstadt)
        {
            _name = name;
            _hautpstadt = hautpstadt;
        }

        public bool Equals(Land? other) => _name == other._name && _hautpstadt == other._hautpstadt;

        //ToString()-Methode überschreiben
        public override string ToString() => $"{_name}/{_hautpstadt}";
    }
}
