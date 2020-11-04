using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IzracunKamata
{
	public partial class Glavna : Form
	{
		public Glavna()
		{
			InitializeComponent();
		}

		double IzracunKamata(double glavnica, double stopa)
		{
			if(stopa < 0 || stopa > 20)
			{
				throw new ArgumentOutOfRangeException("Stopa je izvan raspona");				
			}
			var rezultat = glavnica * stopa / 100;
			return rezultat;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnIzracunaj_Click(object sender, EventArgs e)
		{
			try
			{
				var ok = double.TryParse(txtGlavnica.Text, out double glavnica);
				if (!ok)
				{
					MessageBox.Show("Pogrešan format");
					return;
				}
				ok = double.TryParse(txtStopa.Text, out double stopa);
				if (!ok)
				{
					MessageBox.Show("Pogrešan format");
					return;
				}
				//Stara verzija prije exceptiona - sad više nije potrebna jer funkcija provjerava stopu
				//if (stopa < 0 || stopa > 20)
				//{
				//	MessageBox.Show("Stopa je izvan raspona");
				//	return;
				//}
				var rezultat = IzracunKamata(glavnica, stopa);
				lblIznos.Text = rezultat.ToString("N2");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Dogodila se pogreška. Tekst: {ex.Message}");				
			}
		}
	}
}
