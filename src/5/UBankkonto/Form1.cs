// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace UBankkonto
{
    public partial class Form1 : Form
    {
        /* Strategie zur Lösung der Aufgabe
         * ================================
         * 
         * 1. Klasse Konto.cs anlegen
         *      - (private) Eigenschaft _kontostand zum Speichern des Kontostandes
         *      - Methode "Einzahlen" um Geld auf das Konto einzuzahlen
         *          - public oder private?
         *          - Welcher Rückgabetyp?
         *          - Welche Parameter?
         *      - Methode "Auszahlen" um Geld auszuzahlen
         *          - public oder private?
         *          - Welcher Rückgabetyp?
         *          - Welche Parameter?
         *      - Methode "KontostandAnzeigen" um den Kontostand als string formattiert
         *        zurückzugeben. Gleiche Überlegung wie bei den anderen beiden Methoden.
         *   
         * 2. Klasse "Konto" hier in der Form1 verwenden
         *      - Neues Objekt der Klasse "Konto" erzeugen
         *          - Wo/wann wird das Objekt erzeugt?
         *          - Wo wird das Objekt gespeichert?
         *  
         * 3. Arbeiten mit dem Objekt
         *      - Testen von Anzeigen, Einzahlen und Auszahlen: Methoden des Objekts
         *        hier in der Form1 in den Ereignismethoden der Buttons aufrufen
         *      - Für den ersten Test ist es ausreichend, "Dummy-Werte" zu verwenden. Also z.B.
         *        _konto.Einzahlen(10); mit einem festen Wert aufrufen anstelle mit der Eingabe
         *        aus der TextBox
         *      - Das wird auch "laufendes Skelett" genannt - die Anwendung funktioniert schon mal,
         *        ist aber noch nicht komplett fertig. Man kann einzelne Teile aber testen.
         * 
         * 4. Funktionalität
         *      - Eingabe aus der TextBox einlesen und in ein geeignetes Format umwandeln
         *      - Fehlerbehandlung! Was könnte hier schiefgehen?
         *      - Die umgewandelte Eingabe anstelle der festen Zahlen in den Methodenaufrufen 
         *        verwenden
         *        
         * 5. Bonus: Nur Auszahlen, falls Kontostand gedeckt ist
         *      - Eigenschaftsmethode hinzufügen, die die Änderung des Kontostands kontrolliert
         *      - Es soll nur ausgezahlt werden können, wenn der Konto
         */

        public Form1()
        {
            InitializeComponent();
        }

        // Objekt von der Klasse Konto erzeugen und in "globaler Variable" speichern
        private Konto _konto = new();

        private void CmdEinzahlen_Click(object sender, EventArgs e)
        {
            try
            {
                decimal betrag = Convert.ToDecimal(TxtEingabe.Text);
                _konto.Einzahlen(betrag);
                LblKontostand.Text = _konto.KontostandAnzeigen();
            }
            catch
            {
                MessageBox.Show("Bitte gültige Zahl eingeben!");
            }

        }

        private void CmdKontostand_Click(object sender, EventArgs e)
        {
            LblKontostand.Text = _konto.KontostandAnzeigen();
        }

        private void CmdAuszahlen_Click(object sender, EventArgs e)
        {
            try
            {
                decimal betrag = Convert.ToDecimal(TxtEingabe.Text);
                _konto.Auszahlen(betrag);
                LblKontostand.Text = _konto.KontostandAnzeigen();
            }
            catch
            {
                MessageBox.Show("Bitte gültige Zahl eingeben!");
            }
        }
    }
}
