using System;
using System.Collections.Generic;

namespace Mitarbeiter.Models;

public partial class Mitarbeiter
{
    public int PersonalNr { get; set; }

    public int AbteilungsNr { get; set; }

    public string Name { get; set; } = null!;

    public string Vorname { get; set; } = null!;

    public string Stellenbezeichnung { get; set; } = null!;

    public string Adresse { get; set; } = null!;

    public string Plz { get; set; } = null!;

    public string Ort { get; set; } = null!;

    public string Telefon { get; set; } = null!;

    public virtual Abteilung AbteilungsNrNavigation { get; set; } = null!;
}
