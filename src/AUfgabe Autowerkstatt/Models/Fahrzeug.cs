using System;
using System.Collections.Generic;

namespace AUfgabe_Autowerkstatt.Models;

public partial class Fahrzeug
{
    public int Nr { get; set; }

    public string Kennzeichen { get; set; } = null!;

    public string Marke { get; set; } = null!;

    public string Modell { get; set; } = null!;

    public string Halter { get; set; } = null!;

    public string Ort { get; set; } = null!;

    public virtual ICollection<Reparatur> Reparaturs { get; set; } = new List<Reparatur>();
}
