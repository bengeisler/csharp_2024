// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeBankkonto
{
    class Konto 

    {
        private decimal _kontostand;

        public decimal Kontostand
        {
            get { return _kontostand; }

            set
            {
                if (value < 0)
                    MessageBox.Show("Fehler: Kontostand darf nicht negativ sein.");

                else
                {
                    _kontostand = value;
                    MessageBox.Show($"Neuer Kontostand; {_kontostand}€");

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
           return _kontostand -= betrag;
        }


    }
}
