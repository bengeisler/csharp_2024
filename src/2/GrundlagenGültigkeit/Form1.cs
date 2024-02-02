// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace GrundlagenGültigkeit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Mx = 0;

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            int x = 0;
            x++;
            Mx++;
            LblAnzeige.Text = x.ToString();
            LblAnzeige.Text = $"x:{x}, Mx:{Mx}";
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int x = 0;
            LblAnzeige.Text = x.ToString();
            Mx++;
            LblAnzeige.Text = $"x:{x}, Mx{Mx}";
        }
    }
    //Lokale Variable
    //- nur gültig innerhalb dieser Funtkion
    //-der gleiche Name kann nicht mehrfach deklariert werden
    
    //Deklarieren: eine Variable erstellen:
    //Datentyp x;
    //   ^     ^
    //   |  Namen der Variable
    //Datentyp der Variable

    //Initialisieren: der Variablen erstmals einen Wert zuweisen
    //x= 0:
    //^  ^
    //|  Wert der zugewiesen wird
    //Variable

    //Das kann auch in einemschnitt erfolgen:
    //int x = 0;

    //Erhöhe x um 1 Gleicbedeutend mit x=x+1;

    //wert im lable anzeigen
    //LblAnzeige.Text = xToString();

    //Alternativ
    //LblAnzeige.Text = $"x: {x}, Mx {Mx}";
}
