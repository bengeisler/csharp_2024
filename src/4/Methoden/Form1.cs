namespace Methoden;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void CmdAnzeigen1_Click(object sender, EventArgs e)
    {
        Hallo();
    }

    //Methode anlegen
    //private:  Sichtbarkeit (nur  innerhalb dieser klasse)
    //void:     Rückgabetyp der Methode (void = keine Rückgabe)
    //Hallo:    Name der Methode
    //()        Methode hat keinen Parameter
    //          Methodenkörper: Hier stehen die Anweisungen, die in dieser
    //          Methode ausgeführt werden

    private void Hallo()
    {
        LblAnzeige1.Text = "Hello World";
    }

    private void CmdButton2_Click(object sender, EventArgs e)
    {
        ZeigeMaximum(10, 20); // <--- Aufruf der Methode mit den Argumenten 10 und 20 (für x und y)
    }
    private void ZeigeMaximum(int x, int y)
    {
        if (x > y)
        {
            LblAnzeige1.Text = $"Maximum:{x}";
        }
        else
        {
            LblAnzeige1.Text = $"Maximum:{y}";
        }
    }

    private void CmdButton3_Click(object sender, EventArgs e)
    {
        int ergebnis = addiere(1, 2);
        LblAnzeige1.Text = $"{ergebnis}";
    }

    //Methode mit Parametern und Rückgabewert
    //int: Methode liefert einen Wert vom Datentyp int zurück
    private int addiere(int x, int y)
    {
        //return: wert zurückgeben
        return x + y;
    }

    private void CmdButton4_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void CmdButton5_Click(object sender, EventArgs e)
    {

    }
    private int Addiere2(int x, int y) => x + y;

    private void CmdButton6_Click(object sender, EventArgs e)

    {
        int Addiere2(int x, int y) => x + y;
        LblAnzeige1.Text = $"Ergebnis1: {addiere(1, 2)}\n";
        LblAnzeige1.Text = $"Ergebnis : {addiere(3, 4)}\n";
    }

    private void CmdButton7_Click(object sender, EventArgs e)
    {
        // var addiere4= (int x, int y) => x + y;
        Func<int, int, int> addiere4 = (int x, int y) => x + y;
        LblAnzeige1.Text = $"Ergebnis1: {addiere(1, 2)}\n";
        LblAnzeige1.Text = $"Ergebnis : {addiere(3, 4)}\n";

    }

    private void CmdButton8_Click(object sender, EventArgs e)
    {
        int[] werte = [0, 2, 3, 40, 50];

        //bool allePositiv = true;
        //foreach (int x in werte){
        // if (x<0) allePositiv = false,
        //}

        //Prüfen, ob alle Elemente eine Bedingung erfüllen
        //1. mit lokaler Funktion
        bool istPositiv(int x) => x < 0;
        bool ergebnis1 = Array.TrueForAll(werte, x => x > 0);
        // ist True, falls alle elemente Bedingung...

        //Erstenn Wert im Datenfeld finden, der die Bedingung erfüllt
        int wert = Array.Find(werte, x => x >= 0);

        //Die Anwendungsgebiete für Lambda-Ausdrücke sind vielfältig; dementsprächend oft und
        //gern werden sie eingesetzt!

    }

    private void CmdButton9_Click(object sender, EventArgs e)
    {
        //Lokale Funktion, die versucht sting in int zu wandeln
        void stringInInt(string s)
         
        {
          bool stringInInt(string s, out int ergebnis)  
            try
            {
                //string in int wandeln
                ergebnis=Convert.ToInt32(s);
            }
            catch
            {
                ergebnis = 0;
                return false;
            }

            bool erfolgreich = stringInInt("asdf", out int ergebnis);
            //Alternativ : Funktion von C# verwenden:
            //Erfolgreich = int.TryParse("asdf";out in ergebnis);
            if (erfolgreich) LblAnzeige1.Text = $"ergebnis}";
            else LblAnzeige1.Text = "Fehler!";
    }
}
