// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Mitarbeiterverwaltung4.Models;

namespace Mitarbeiterverwaltung4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private FirmaDbContext _ctx = new();

        private void Form1_Load(object sender, EventArgs e)
        {
            mitarbeiterBindingSource.DataSource = _ctx.Mitarbeiters.ToList();
            abteilungBindingSource.DataSource = _ctx.Mitarbeiters.ToList();

        }

        private void CmdNachNameSortieren_Click(object sender, EventArgs e)
        {
           
            string nachname = (TxtNachname.Text);

           
            mitarbeiterBindingSource.DataSource = _ctx.Mitarbeiters
                .Where(b => b.Name == nachname)
                .ToList();
        }
    }
}
