using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WiederholungDerGrundlagen
{
	public partial class Form1 : Form
	{
		// Dateizugriff, Aufgabe 4: Globale Variable, 
		// um die Anzahl der Speichervorgänge zu speichern
		int ZählerDateiSpeichern;

		// Objektorientierung, Aufgabe 13: Globale Variable
		// um Möbel in einer Liste zu speichern
		List<Möbel> Möbelliste = new List<Möbel>();
		public Form1()
		{
			InitializeComponent();
		}

		/* ---------------------------------------------------------------
		 * 
		 *							O P E R A T O R E N
		 *
		 * ---------------------------------------------------------------
		 */
		private void btnOperatoren_Click(object sender, EventArgs e)
		{
			// 1.
			int i = 0;				// Lokale Variable vom Datentyp "int" erstellen
			i++;					// ++ Operator: Variable um 1 erhöhen. 
			Debug.WriteLine(i);		// Variable in der Konsole ausgeben. Kürzel für Code-Snippet: cw

			// 2.
			i += 3;					// Variable um 3 erhöhen. Alternativschreibweise: i = i + 3;
			Debug.WriteLine(i);

			// 3.
			i *= 3;					// Variable mit 3 multiplizieren. Alternativschreibweise: i = i * 3;
			Debug.WriteLine(i);

			// 4.
			double erhöhungInProzent = i * 0.2;		// Erhöhung um 20% berechnen (Datentyp double)
			i += (int)erhöhungInProzent;			// Diese Erhöhung zu i hinzuzählen, dabei double in int wandeln
			// Alternative: i *= 1.2;
			Debug.WriteLine(i);						

			// 5.
			int ergebnis = i / 4;		// Ergebnis der Division berechnen
			int rest = i % 4;			// Mit dem Modulo-Operator den Rest der Division berechnen
			Debug.WriteLine($"Ergebnis: {ergebnis}, Rest: {rest}");

			// Alternative Schreibweisen der Ausgabeformatierung:
			Debug.WriteLine("Ergebnis: {0}, Rest: {1}", ergebnis, rest);
			Debug.WriteLine("Ergebis: " + ergebnis + ", Rest: " + rest);

			// 6.
			Debug.WriteLine("Der aktuelle Wert der Zahl beträgt: " + ergebnis);

			// 7.
			string k = "Mein Text";
			Debug.WriteLine(k);

			// 8.
			k += " ist kurz.";    // Text anhängen
			Debug.WriteLine(k);
		}

		/* ---------------------------------------------------------------
		 * 
		 *							S C H L E I F E N
		 *
		 * ---------------------------------------------------------------
		 */
		private void btnSchleifen_Click(object sender, EventArgs e)
		{
			// 1.a
			Debug.WriteLine("1a");
			// Start bei 1, damit die Nummer des Durchlaufs auch korrekt bei 1 beginnt
			for (int i = 1; i < 6; i++)		// Code-Snippen für for-Schleife: for
			{
				Debug.WriteLine("Durchlauf: " + i);
			}

			// 1.b
			Debug.WriteLine("1b");
			for (int i = 5; i < 10; i++)
			{
				Debug.WriteLine("Durchlauf: " + i);
			}

			// 1.c
			Debug.WriteLine("1c");
			// Diese Schleife wird 6 mal ausgeführt, da der Schleifenzähler bei 0
			// startet und bis einschließlich 5 läuft
			int durchlaufZähler = 0;
			for (int i = 0; i <= 5; i++)
			{
				durchlaufZähler++;
			}
			Debug.WriteLine($"Diese Schleife wurde {durchlaufZähler} mal durchlaufen");
		}

		/* ---------------------------------------------------------------
		 * 
		 *							D A T E I Z U G R I F F
		 *
		 * ---------------------------------------------------------------
		 */
		// Beim Dateizugriff nicht vergessen: using System.IO; 
		// Generell sollten Dateizugriffe immer innerhalb eines try-catch-Blocks erfolgen.
		// Das wird der Einfachheit halber hier allerdings weggelassen.
		private void btnDateiEinlesen_Click(object sender, EventArgs e)
		{
			// 1. 
			var ofd = new OpenFileDialog()
			{
				InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
				Filter = "Textdateien (*.txt)|*.txt",
				Title = "Datei öffnen"
			};

			// OpenFileDialog anzeigen
			// Ergebnis auswerten: Falls nicht auf "Öffnen" geklickt wurde, wird 
			// diese Funktion hier mittels "return" verlassen
			if (ofd.ShowDialog() != DialogResult.OK) return;

			// 2.
			// Hier gibt es verschiedene Möglichkeiten

			// Möglichkeit 1
			Debug.WriteLine("Aufgabe 2, Möglichkeit 1:");
			string[] zeilenInDatei = File.ReadAllLines(ofd.FileName);		  // Alle Zeilen der Datei in ein String-Array einlesen
			Debug.WriteLine($"Die Datei hat {zeilenInDatei.Length} Zeilen");  // Größe des Arrays ausgeben => Entspricht Anzahl der Zeilen

			// Möglichkeit 2
			Debug.WriteLine("Aufgabe 2, Möglichkeit 2:");
			var sr = new StreamReader(ofd.FileName);		// Objekt der Klasse StreamReader erstellen, um Datei einzulesen
			int zeilenanzahl = 0;							// Variable zum Zählen der Zeilen
			while (!sr.EndOfStream)							// Alle Zeilen einlesen. Alternative: sr.Peek() != -1
			{
				sr.ReadLine();			// Zeile einlesen
				zeilenanzahl++;			// Zeilenzähler erhöhen
			}
			Debug.WriteLine($"Die Datei hat {zeilenanzahl} Zeilen");

			// 3.
			// Auch hier gibt es wieder verschiedene Möglichkeiten

			// Möglichkeit 1:
			lstListe.Items.Clear();																			// ListBox leeren
			string[] zeilenDerDatei = File.ReadAllLines(ofd.FileName);	// Alle Zeilen der Datei in ein String-Array einlesen
			foreach (var zeile in zeilenDerDatei)												// Alle Einträge dieses Arrays der Listbox hinzufügen
				lstListe.Items.Add(zeile);

			MessageBox.Show("Das war Aufgabe 3, Möglichkeit 1");

			// Möglichkeit 2:
			lstListe.Items.Clear();                             // ListBox leeren
			var sr2 = new StreamReader(ofd.FileName);			// Objekt der Klasse StreamReader erstellen, um Datei einzulesen
			while (!sr2.EndOfStream)							// Alle Zeilen einlesen. Alternative: sr.Peek() != -1
				lstListe.Items.Add(sr2.ReadLine());             // Zeile einlesen und der ListBox hinzufügen

			MessageBox.Show("Das war Aufgabe 3, Möglichkeit 2");

			// Möglichkeit 3:
			lstListe.Items.Clear();                                     // ListBox leeren
			lstListe.Items.AddRange(File.ReadAllLines(ofd.FileName));   // Alle Zeilen der Datei einlesen und als Range der Listbox hinzufügen

			MessageBox.Show("Das war Aufgabe 3, Möglichkeit 3");
		}

		private void btnDateiSpeichern_Click(object sender, EventArgs e)
		{
			// 4.
			// => Ganz oben globale Variable anlegen
			var sfd = new SaveFileDialog()
			{
				InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
				Filter = "Textdateien (*.txt)|*.txt",
				Title = "Datei speichern",
				FileName = "MeineListe_" + ZählerDateiSpeichern + ".txt"
			};

			// SaveFileDialog anzeigen
			// Abbruch, falls nicht "Speichern" ausgewählt wurde
			if (sfd.ShowDialog() != DialogResult.OK) return;

            // 5.
            // Hier gibt es mehrere Möglichkeiten 
            // => Bitte Möglichkeiten selbst einkommentieren und testen

            // 1. Möglichkeit

            //foreach (var item in lstListe.Items)              // Jeder Eintrag der ListBox wird an die Datei angehängt
            //    File.AppendAllText(sfd.FileName, item + "\n");  // Das bedeutet aber auch: Falls diese Datei schon existiert, bleibt
            //                                                    // der bestehende Inhalt erhalten

            // 2. Möglichkeit

            //var sw = new StreamWriter(sfd.FileName, false);   // Pfad aus SaveFileDialog übernehmen
            //                                                  // false: Datei überschreiben / true: neuen Inhalt anhängen
            //foreach (var item in lstListe.Items)			  // Alle Einträge der ListBox in die Datei schreiben
            //{
            //    sw.WriteLine(item);
            //}
            //sw.Close();																				// Am Ende den StreamWriter wieder schließen


            // 3. Möglichkeit

            File.WriteAllLines(sfd.FileName, lstListe.Items.OfType<string>().ToArray());



			// Für jeden Speichervorgang den Zähler um 1 erhöhen
			ZählerDateiSpeichern++;
		}

		// Dateizugriff, Aufgabe 6
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			// MessageBox anzeigen
			var dr = MessageBox.Show(
				"Wollen Sie noch speichern?",
				"Speichern?",
				MessageBoxButtons.YesNoCancel,
				MessageBoxIcon.Question);

			if (dr == DialogResult.Yes)
				btnDateiSpeichern_Click(sender, e);

			if (dr == DialogResult.Cancel)
				e.Cancel = true;
		}


		/* ---------------------------------------------------------------
		 * 
		 *								D A T U M   &   U H R Z E I T
		 *
		 * ---------------------------------------------------------------
		 */
		private void btnDatumUndUhrzeit_Click(object sender, EventArgs e)
		{
			// 1. 
			Debug.WriteLine(DateTime.Now);

			// 2.
			Debug.WriteLine(DateTime.Now.ToShortDateString());

			// 3.
			Debug.WriteLine(DateTime.Now.ToShortTimeString());
		}

		/* ---------------------------------------------------------------
		 * 
		 *				S T R I N G - F O R M A T T I E R U N G
		 *
		 * ---------------------------------------------------------------
		 */
		private void btnStringFormattierung_Click(object sender, EventArgs e)
		{
			// 1.
			double zahl = 12345.6789;

			// 2.
			Debug.WriteLine($"Ausgabe ohne Nachkommastelle: {zahl:#}");

			// 3.
			Debug.WriteLine($"Ausgabe mit zwei Nachkommastellen: {zahl:#.00}");

			// 4. 
			Debug.WriteLine($"Ausgabe mit Tausender-Trennzeichen: {zahl:#,#} (ohne Nachkommastellen)");				 // ohne Nachkommastellen
			Debug.WriteLine($"Ausgabe mit Tausender-Trennzeichen: {zahl:#,#.####} (mit Nachkommastellen)");    // mit Nachkommastellen

			// 5. 
			Debug.WriteLine($"Ausgabe als Währung: {zahl:C}");

			// 6.
			Debug.WriteLine($"Ausgabe linksbündig mit Breite von 20 : ->{zahl,-20}<-");

			// 7.
			Debug.WriteLine($"Ausgabe rechtsbündig mit Breite von 20: ->{zahl,20}<-");
		}

		/* ---------------------------------------------------------------
		 * 
		 *							F E H L E R B E H A N D L U N G
		 *
		 * ---------------------------------------------------------------
		 */
		// 1. => Siehe Form
		private void txtFehlerbehandung_KeyDown(object sender, KeyEventArgs e)
		{
			// 2.
			if (e.KeyCode == Keys.Enter)		// Abfragen, ob Enter-Taste gedrückt wurde
			{
				try
				{
					// a.
					if (txtFehlerbehandung.Text == "") 
						throw new ArgumentException("Die Eingabe darf nicht leer sein!");

					// b.
					if (txtFehlerbehandung.Text.Length < 3) 
						throw new ArgumentException("Es müssen mindestens drei Zeichen eingegeben werden!");

					// c.
					if (!int.TryParse(txtFehlerbehandung.Text, out int eingabe)) 
						throw new ArgumentException("Bitte eine Ganzzahl eingeben!");

					// d.
					if (eingabe < 0)
						throw new ArgumentException("Die Eingabe muss > 0 sein!");

					// e. (Erfolgsfall)
					Debug.WriteLine("Folgendes wurde in die Textbox eingegben: " + txtFehlerbehandung.Text);
				}
				catch (Exception ex)
				{
					// e. (Fehlerfall)
					MessageBox.Show(ex.Message);
				}
			}
		}

		/* ---------------------------------------------------------------
		 * 
		 *										M E T H O D E N
		 *
		 * ---------------------------------------------------------------
		 */

		// 1.

		// Methoden Addition & Subtraktion
		// - private:					Sichtbarkeit 
		// - int:							Rückgabetyp
		// - Addition:				Name der Methode
		// - (int a, int b):	Parameter der Methode
		private int Addition(int a, int b)
		{
			return a + b;
		}
		private int Subtraktion(int a, int b)
		{
			return a - b;
		}

		private string TageInWochenUndTage(int tage)
        {
			var wochen = tage / 7;
			var resttage = tage % 7;
			return $"{tage} Tage sind {wochen} Wochen und {resttage} Tage";
        }

		// 2.
		private void btnMethoden_Click(object sender, EventArgs e)
		{
			// Addition
			int ergebnis = Addition(2, 3);
			Debug.WriteLine("Ergebnis der Addition: 2 + 3 = " + ergebnis);

			// Subtraktion
			ergebnis = Subtraktion(2, 3);
			Debug.WriteLine("Ergebnis der Subtraktion: 2 - 3 = " + ergebnis);

			// Wochen und Tage
			Debug.WriteLine("Tage in Wochen/Tage: " + TageInWochenUndTage(27));
		}

		/* ---------------------------------------------------------------
		 * 
		 *							O B J E K T O R I E N T I E R U N G
		 *
		 * ---------------------------------------------------------------
		 */
		//  1. => Siehe neue Klasse im Projektmappen-Explorer
		//  2. => Siehe Klasse "Möbel"
		//  3. => Siehe Klasse "Möbel"
		//  4. => Siehe Klasse "Möbel"
		//  5. => Siehe Klasse "Möbel"
		//  8. => Siehe Klasse "Möbel"
		//  9. => Siehe Klasse "Möbel"
		// 10. => Siehe Klasse "Möbel"
		// 18. => Siehe neues Formular im Projektmappen-Explorer
		// 20. => Siehe Klasse "Möbel"
		private void btnObjektorientierung_Click(object sender, EventArgs e)
		{
			// 6. 
			// Zwei Objekte der Klasse "Möbel" erstellen und ausgeben
			var erstesMöbelstück = new Möbel("Stuhl", 50);
			var zweitesMöbelstück = new Möbel("Tisch", 150);

			Debug.WriteLine(erstesMöbelstück);
			Debug.WriteLine(zweitesMöbelstück);

			// 7.
			// Teil 1 siehe Klasse "Möbel"

			// Test Fehlerfall
			try
			{
				erstesMöbelstück.PreisReduzieren(60);		
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			Debug.WriteLine(erstesMöbelstück);

			// Test Erfolgsfall
			try
			{
				zweitesMöbelstück.PreisReduzieren(60);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			Debug.WriteLine(zweitesMöbelstück);

			// 11.
			erstesMöbelstück.Farbe = "Gelb";
			zweitesMöbelstück.Farbe = "Braun";

			Debug.WriteLine(erstesMöbelstück);
			Debug.WriteLine(zweitesMöbelstück);

			// 12. 
			var drittesMöbelstück = new Möbel("Schrank", 400, "Schwarz");
			var vierteMöbelstück = new Möbel("Regal", 200, "Weiß");
			var fünftesMöbelstück = new Möbel("Bank", 220, "Rot");

			// 13.
			// Die Liste wird als globale Variable erstellt, damit
			// sie auch in der Ereignismethode "Möbelstück hinzufügen" 
			// verwendet werden kann.

			Möbelliste.Add(erstesMöbelstück);
			Möbelliste.Add(zweitesMöbelstück);
			Möbelliste.Add(drittesMöbelstück);
			Möbelliste.Add(vierteMöbelstück);
			Möbelliste.Add(fünftesMöbelstück);

			// 14.
			Debug.WriteLine("(14) Alle Möbel in der Liste:");
			foreach (var möbel in Möbelliste)
				Debug.WriteLine(möbel);

			// 15.
			erstesMöbelstück.Farbe = "Gelb";
			zweitesMöbelstück.Farbe = "Gelb";

			// 16.
			var listeMitGelbenMöbeln = Möbelliste
				.Where(m => m.Farbe == "Gelb")
				.ToList();

			// 17.
			Debug.WriteLine("(17) Alle Möbel mit der Farbe gelb:");
			foreach (var möbel in listeMitGelbenMöbeln)
				Debug.WriteLine(möbel);

			// 22. 
			// Möglichkeit 1: Dazu muss IComparable<Möbel> in der Klasse "Möbel" imlementiert sein
			Möbelliste.Sort();

			Debug.WriteLine("(22) Sortierte Möbelliste (Möglichkeit 1):");
			foreach (var möbel in Möbelliste)
				Debug.WriteLine(möbel);

			// Möglichkeit 2: Sortierung über LINQ
			// Hierfür muss IComparable<Möbel> nicht in der Klasse implementiert sein
			var sortierteMöbelliste = Möbelliste
				.OrderBy(m => m.Bezeichnung)
				.ToList();

			Debug.WriteLine("(22) Sortierte Möbelliste (Möglichkeit 2):");
			foreach (var möbel in sortierteMöbelliste)
				Debug.WriteLine(möbel);
		}

		private void btnNeuesMöbelstück_Click(object sender, EventArgs e)
		{
			// 19.
			// Ein neues Objekt der Klasse "FormMöbelstückHinzufügen" erstellen
			var formNeuesMöbelstück = new FormMöbelstückHinzufügen();

			// Formular anzeigen
			formNeuesMöbelstück.ShowDialog();

			// Rückgabe auswerten & verarbeiten
			if (formNeuesMöbelstück.DialogResult == DialogResult.OK)
			{
				// Neues Möbelstück der Liste hinzufügen
				Möbelliste.Add(formNeuesMöbelstück.NeuesMöbelstück);

				// a.
				Debug.WriteLine("(19.a) Es wurde ein Objekt hinzugefügt: " +
					formNeuesMöbelstück.NeuesMöbelstück);

				// b.
				Debug.WriteLine("(19.b) Objekte in der Liste:");
				foreach (var möbel in Möbelliste)
					Debug.WriteLine(möbel);
			}
		}


    }
}
