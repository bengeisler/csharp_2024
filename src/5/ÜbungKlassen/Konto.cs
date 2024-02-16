// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜbungKlassen
{
    class Konto
    {
       public decimal _kontostand;
        public decimal kontostand
        {
            get => _kontostand;
            private set
            {
                if (value < -100)
                {
                    MessageBox.Show("Übersteigt den Limit");
                }
                else
                {
                    _kontostand = value;
                }
            }
        }
        public void Einzahlen(decimal betrag)
        {
            
            kontostand += betrag;

        }

        

        public void Auszahlen(decimal betrag)
        {
            kontostand -= betrag;

        }
        public string KontostandAnzeigen() => $"{kontostand}$";
        
            
        

    }
}
