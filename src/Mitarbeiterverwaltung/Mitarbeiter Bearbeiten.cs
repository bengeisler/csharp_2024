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

namespace Mitarbeiterverwaltung
{
    public partial class Mitarbeiter_Bearbeiten : Form
    {
        public Mitarbeiter_Bearbeiten()
        {
            InitializeComponent();
        }

        private void CmdAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
