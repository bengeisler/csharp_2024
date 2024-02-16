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
        // Eigenschaftsmethode:
        // Kontrolliert den Zugriff auf eine Eigenschaft
        public decimal Kontostand
        {
            get => _kontostand;
            private set
            {
                // Falls neuer Kontostand < 0 ist:
                if (value < 0)
                {
                    // Fehler ausgeben
                    MessageBox.Show("Kontostand darf nicht negativ werden!");
                }
                // Andernfalls:
                else
                {
                    _kontostand = value;
                }
            }
        }

        // Methode Einzahlen
        public void Einzahlen(decimal betrag) => Kontostand += betrag;

        // Methode Auszahlen
        public decimal Auszahlen(decimal betrag)
        {
            Kontostand -= betrag;
            return Kontostand;
        }


        // Methode Kontostand anzeigen
        public string KontostandAnzeigen() => $"{Kontostand}€";
    }
}
