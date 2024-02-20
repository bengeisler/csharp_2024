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
        private decimal _kontostand;

        public void Einzahlen(decimal betrag)
        {
            _kontostand += betrag;

        }
        public string KontostandAnzeigen()
        {
            return $"{_kontostand}€";

        }
        public decimal AusZahlen(decimal betrag)
        {
            _kontostand -= betrag;

        }
       
    }
}
