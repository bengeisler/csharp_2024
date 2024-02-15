namespace KlassenSchnittstellen;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void CmdAnzeige_Click(object sender, EventArgs e)
    {
        // Zwei Objekte vom Typ Fahrzeug erzeugen
        var vespa = new Fahrzeug(45, "vespa");
        var schwalbe = new Fahrzeug(50, "schwalbe");

        // Diese Fahrzeuge in einem Datenfeld speichern
        int[] werte = [3, 2, 1];
        Fahrzeug[] fahrzeuge = [vespa, schwalbe];

        // Datenfelder sortieren
        Array.Sort(werte);
        // Damit das auch für die Klasse Fahrzeug funktioniert, muss diese
        // die Schnittstelle IComparable<Fahrzeug> implementieren!
        Array.Sort(fahrzeuge);
    }
}
