using System;
using System.Collections.Generic;

namespace Mitarbeiterverwaltung4.Models;

public partial class Abteilung
{
    public int AbteilungsNr { get; set; }

    public string Bezeichnung { get; set; } = null!;

    public virtual ICollection<Mitarbeiter> Mitarbeiters { get; set; } = new List<Mitarbeiter>();
}
