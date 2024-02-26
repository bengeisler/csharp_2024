using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiederholungDerGrundlagen
{
	// Klasse muss public sein, damit die beiden Formulare
	// Daten austauschen können
	// IEquatable<Möbel> kommt erst in Aufgabe 20 hinzu
	// IComparable<Möbel> kommt erst in Aufgabe 21 hinzu
	public class Möbel : IEquatable<Möbel>, IComparable<Möbel>
	{
		// 2. 
		// Eigenschaft "Bezeichnung"
		// - public:		Sie ist außerhalb dieser Klasse sichtbar
		// - readonly:	wird benötigt, damit diese Eigenschaft nur im Konstruktor geschrieben werden kann
		// - string:		Datentyp der Eigenschaft
		public readonly string Bezeichnung;

		// 3.
		// Eigenschaft "Preis"
		// - public:			Außerhalb der Klasse sichtbar
		// - get:					Lesend kann von außerhalb zugegriffen werden
		// - private set:	Der Schreibzugriff ist nur innerhalb der Klasse erlaubt
		// Der Codeausschnitt, um eine Eigenschaft zu erstellen lautet: "prop"
		public decimal Preis { get; private set; }

        // 4.
        // Konstruktor
        // Codeausschnitt: "ctor"
        public Möbel(string bezeichnung, decimal preis)
		{
			// Eigenschaften zuweisen
			Bezeichnung = bezeichnung;
			Preis = preis;
		}

		// 5. + 10.
		// ToString()-Methode überschreiben
		public override string ToString()
		{
			// ToString() ab Aufgabe 5:
			// return $"{Bezeichnung} - {Preis:C}";

			// ToString() ab Aufgabe 10:
			return $"{Bezeichnung} - {Preis:C} - {Farbe}";
		}

		// 7.
		// void: Methode besitzt keine Rückgabewert
		public void PreisReduzieren(decimal wert)
		{
			// Sicherstellen, dass der Preis nicht negativ wird
			if ((Preis - wert) < 0)
				throw new ArgumentException("Reduzierter Preis kann nicht < 0 sein!");

			Preis -= wert;	// Preis reduzieren
		}

		// 8.
		// Eigenschaft Farbe
		// (eigentlich stehen alle Eigenschaften per Konvention zu Beginn einer
		//  Klasse. Damit der Code in der Reihenfolge der Aufgabenstellung von oben
		//  nach unten lesbar ist, füge ich sie hier ein.)
		public string Farbe;

		// 9. 
		// Konstruktor erweitern (überladen)
		public Möbel(string bezeichnung, decimal preis, string farbe)
		{
			Bezeichnung = bezeichnung;
			Preis = preis;
			Farbe = farbe;
		}

		// 20. => - Klicken Sie in der Klasse "Möbel" mit Rechts auf "class"
		//				- Wählen Sie "Schnellaktionen und Refactorings"
		//				- Wählen Sie "Equals() und GetHashCode() generieren..."
		//				- Wählen Sie alle Eigenschaften aus und setzen Sie den Haken bei IEquatable implementieren
		public override bool Equals(object obj)
		{
			return Equals(obj as Möbel);
		}

		public bool Equals(Möbel other)
		{
			return other != null &&
						 Bezeichnung == other.Bezeichnung &&
						 Preis == other.Preis &&
						 Farbe == other.Farbe;
		}

		public override int GetHashCode()
		{
			int hashCode = 428429282;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Bezeichnung);
			hashCode = hashCode * -1521134295 + Preis.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Farbe);
			return hashCode;
		}

		// 21.
		public int CompareTo(Möbel other)
		{
			return Bezeichnung.CompareTo(other.Bezeichnung);
		}
	}
}
