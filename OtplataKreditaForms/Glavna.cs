using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtplataKreditaForms
{
	public partial class Glavna : Form
	{
		public Glavna()
		{
			InitializeComponent();
		}

		public void IzracunParametara(double iznos, double stopa, int brojGodina, out double anuitet, out double iznosKamata)
		{
			if(iznos < 0)
			{
				throw new ArgumentException("Iznos mora biti >= 0");
			}
			if(stopa < 2 || stopa > 15)
			{
				throw new ArgumentOutOfRangeException("Stopa mora biti u rasponu 2-15%");
			}
			if(brojGodina < 3 || brojGodina > 30)
			{
				throw new ArgumentOutOfRangeException("Godina mora biti u rasponu 3-30");
			}
			var r = Kamatnjak(stopa);
			var n = brojGodina * 12;

			anuitet = iznos * Math.Pow(r, n) * (r - 1) / (Math.Pow(r, n) - 1);
			iznosKamata = anuitet * n - iznos;
		}

		public double Kamatnjak(double stopa)
		{
			return 1 + stopa / 12 / 100;
		}


		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnIzracunaj_Click(object sender, EventArgs e)
		{
			try
			{
				var ok = double.TryParse(txtGlavnica.Text, out double glavnica);
				if(!ok)
				{
					MessageBox.Show("Pogrešan format glavnice");
					return;
				}
				ok = double.TryParse(txtStopa.Text, out double stopa);
				if (!ok)
				{
					MessageBox.Show("Pogrešan format stope");
					return;
				}
				ok = int.TryParse(txtGodina.Text, out int godina);
				if (!ok)
				{
					MessageBox.Show("Pogrešan format broja godina");
					return;
				}
				IzracunParametara(glavnica, stopa, godina, out double anuitet, out double iznosKamata);
				lblAnuitet.Text = anuitet.ToString("N2");
				lblUkupnoKamate.Text = iznosKamata.ToString("N2");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Dogodila se pogreška. Tekst: {ex.Message}");
			}
		}
	}
}
