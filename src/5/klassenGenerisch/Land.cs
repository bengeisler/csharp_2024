// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klassenGenerisch
{
    class Land : IEquatable<Land>
    {
        // Eigenschaften

        private readonly string _name;
        private readonly string _hauptstadt;

        // Konstruktor
        public Land(string name, string hauptstadt)
        {
            _name = name;
            _hauptstadt = hauptstadt;
        }
        // Equals
        public bool Equals(Land? other) => _name == other._name && _hauptstadt == other._hauptstadt;

        // ToString()-Methode

        public override string ToString() => $"{_name}/{_hauptstadt}";




    }
}
