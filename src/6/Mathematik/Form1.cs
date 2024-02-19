using System.Diagnostics;

namespace Mathematik;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        // Mathematische Konstanten
        Debug.WriteLine($"Pi: {Math.PI}");

        // Zahlen runden
        double x = 1.234;
        // - Mathematisch runden
        Debug.WriteLine($"{x} mathematisch gerundet: {Math.Round(x)}");
        // Aufrunden
        Debug.WriteLine($"{x} gerundet: {Math.Ceiling(x)}");
        // Abrunden
        Debug.WriteLine($"{x} gerundet: {Math.Floor(x)}");

        // Quaddrieren
        x = 15;
        Debug.WriteLine($"{x} quadriert: {Math.Pow(x, 2)}");
        // Wurzel ziehen
        x = 25;
        Debug.WriteLine($"Wurzel von {x}: {Math.Sqrt(x)}");


    }
}
