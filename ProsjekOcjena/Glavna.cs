using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProsjekOcjena
{
	public partial class Glavna : Form
	{
		public Glavna()
		{
			InitializeComponent();
		}

		private void btnIzracunaj_Click(object sender, EventArgs e)
		{
			var unos = txtOcjenaC.Text;
			var ok = int.TryParse(unos, out int ocjenaC);
			if(!ok)
			{
				MessageBox.Show("Pogrešan format broja");
				return;
			}

			unos = txtOcjenaCPlus.Text;
			ok = int.TryParse(unos, out int ocjenaCPlus);
			if (!ok)
			{
				MessageBox.Show("Pogrešan format broja");
				return;
			}

			unos = txtOcjenaCSharp.Text;
			ok = int.TryParse(unos, out int ocjenaCSharp);
			if (!ok)
			{
				MessageBox.Show("Pogrešan format broja");
				return;
			}

			var prosjek = (ocjenaC + ocjenaCPlus + ocjenaCSharp) / 3.0;
			lblProsjek.Text = prosjek.ToString("N2");

		}

		
	}
}
