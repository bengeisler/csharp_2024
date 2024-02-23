using System;
using System.Collections.Generic;

namespace Bestellungen.Models;

public partial class Bestellung
{
    public int BestellNr { get; set; }

    public int KundenNr { get; set; }

    public string Text { get; set; } = null!;

    public decimal Preis { get; set; }

    public DateTime Datum { get; set; }

    public virtual Kunde KundenNrNavigation { get; set; } = null!;
}
