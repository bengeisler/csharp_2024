namespace HalloWelt;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void BtnHalloWelt_Click(object sender, EventArgs e)
    {
        LblAnzeige.Text = "Hallo Welt!";
    }

    private void LblAnzeige_Click(object sender, EventArgs e)
    {

    }
}
