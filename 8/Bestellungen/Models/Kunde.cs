using System;
using System.Collections.Generic;

namespace Bestellungen.Models;

public partial class Kunde
{
    public int KundenNr { get; set; }

    public string Name { get; set; } = null!;

    public string Adresse { get; set; } = null!;

    public string Plz { get; set; } = null!;

    public string Ort { get; set; } = null!;

    public string Telefon { get; set; } = null!;

    public virtual ICollection<Bestellung> Bestellungs { get; set; } = new List<Bestellung>();
}
