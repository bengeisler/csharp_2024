// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBankkonto
{
    class Konto
    {
        // Eigenschaft Kontostand
        private decimal _kontostand;

        // Methode Einzahlen
        public void Einzahlen(decimal betrag) => _kontostand += betrag;

        // Methode Kontostand anzeigen
        public string KontostandAnzeigen() => $"{_kontostand}€";
    }
}
