namespace LottozahlenÜBUNG;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void cmdZiehung_Click(object sender, EventArgs e)
    {
        Random random = new Random();

        List<int> list = new List<int>();

        int zufallszahl = random.Next(1, 50);
        list.Add(zufallszahl);
        
        int counter = 0;

        list.Sort();




        while (list.Count < 7)
        {
            zufallszahl = random.Next(1, 50);
            list.Add((int)zufallszahl);
            LstBox.Items.Add(zufallszahl);

        }
        






    }
}
