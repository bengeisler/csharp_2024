﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AUfgabe_Autowerkstatt.Models;

namespace AUfgabe_Autowerkstatt
{
    public partial class FrmFahzeuge : Form
    {
        public FrmFahzeuge()
        {
            InitializeComponent();
        }
        // Datennübergeben


        // Eigenschaft zun Datenaustausch
        public Fahrzeug FahrzeugInBearbeitung = new();

        private void FrmFahzeuge_Load(object sender, EventArgs e)
        {
            LblNummer.Text = FahrzeugInBearbeitung.Nr.ToString();
            TxtKennzeichen.Text = FahrzeugInBearbeitung.Kennzeichen.ToString();
            TxtMarke.Text = FahrzeugInBearbeitung.Marke.ToString();
            TxtModell.Text = FahrzeugInBearbeitung.Modell.ToString();
            TxtHalter.Text = FahrzeugInBearbeitung.Halter;

            TxtOrt.Text = FahrzeugInBearbeitung.Ort.ToString();
        }

        private void CmdAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
