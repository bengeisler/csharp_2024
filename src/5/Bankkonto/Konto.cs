// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accessibility;
using Microsoft.VisualBasic;

namespace Bankkonto
{
     class Konto 
        
    {
        
        private decimal _kontostand;
        public decimal Kontostand
        {
            get => _kontostand;
        private set
            {
                if (value < 0)
                {
                    MessageBox.Show("Kontostand darf nicht negativ werden!");
                }

                else
                {
                    _kontostand = value;
                }
            }


        }
        public void Einzahlen(decimal betrag)

        {
            _kontostand += betrag;
            

        }
        public string KontostandAnzeigen()
        {
            return $"{_kontostand}€";


        }

        public decimal Auszahlen(decimal betrag)
        {

            
            {
                _kontostand -= betrag;
                return _kontostand;
            }
            

            
                
            
                
            
        }


    }


}
