using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WiederholungDerGrundlagen
{
	public partial class FormMöbelstückHinzufügen : Form
	{
		// 19.
		// Eigenschaft zum Datenaustausch zwischen den Formularen anlegen
		public Möbel NeuesMöbelstück;
		public FormMöbelstückHinzufügen()
		{
			InitializeComponent();
		}

		private void btnSpeichern_Click(object sender, EventArgs e)
		{
			// 19.
			// Die Benutzereingaben zu prüfen war nicht explizit in der Aufgabe gefordert
			// Der Vollständigkeit halber sind sie hier mit aufgenommen.
			try
			{
				if (txtBezeichnung.Text == "")
					throw new ArgumentException("Bitte eine Bezeichnung eingeben.");
				if (txtFarbe.Text == "")
					throw new ArgumentException("Bitte eine Farbe eingeben.");
				if (!decimal.TryParse(txtPreis.Text, out decimal preis))
					throw new ArgumentException("Bitte einen gültigen Preis eingeben.");
				if (preis < 0)
					throw new ArgumentException("Der Preis darf nicht < 0 sein.");

				// Neues Möbelstück erzeugen
				NeuesMöbelstück = new Möbel(txtBezeichnung.Text, preis, txtFarbe.Text);

				DialogResult = DialogResult.OK;

				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnAbbrechen_Click(object sender, EventArgs e)
		{
			// 19.
			Close();
		}

        private void FormMöbelstückHinzufügen_Load(object sender, EventArgs e)
        {

        }
    }
}
