using System;
using System.Collections.Generic;

namespace AUfgabe_Autowerkstatt.Models;

public partial class Reparatur
{
    public int Nr { get; set; }

    public DateTime Datum { get; set; }

    public string Beschreibung { get; set; } = null!;

    public decimal Kosten { get; set; }

    public int FahrzeugNr { get; set; }

    public virtual Fahrzeug FahrzeugNrNavigation { get; set; } = null!;
}
