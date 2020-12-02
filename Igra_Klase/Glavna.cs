using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Igra_Klase
{
	public partial class Glavna : Form
	{
		public Glavna()
		{
			InitializeComponent();
		}

		private void btnUnesi_Click(object sender, EventArgs e)
		{
			try
			{
				var naziv = txtNaziv.Text;
				var opis = txtOpis.Text;
				var vrsta = txtVrsta.Text;
				var izdavac = txtIzdavac.Text;
				var ok = decimal.TryParse(txtCijena.Text, out decimal cijena);
				if (!ok)
				{
					MessageBox.Show("Pogrešan format");
					return;
				}
				ok = DateTime.TryParse(txtDatumIzdavanja.Text, out DateTime datumIzdavanja);
				if (!ok)
				{
					MessageBox.Show("Pogrešan format");
					return;
				}
				var igra = new Igra();
				igra.Naziv = naziv;
				igra.Opis = opis;
				igra.Izdavac = izdavac;
				igra.Vrsta = vrsta;
				igra.Cijena = cijena;
				igra.DatumIzdavanja = datumIzdavanja;
				MessageBox.Show("Podaci su uspješno uneseni");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Dogodila se pogreška. Tekst: {ex.Message}");
			}
		}
	}
}
