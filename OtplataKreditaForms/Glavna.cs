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

		}


		private void Form1_Load(object sender, EventArgs e)
		{

		}

		

	}
}
