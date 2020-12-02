using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista
{
    public partial class Glavna : Form
    {
        List<string> rijeci = new List<string>();
        
        public Glavna()
        {
            InitializeComponent();
            
        }



		private void btnDodaj_Click(object sender, EventArgs e)
		{
            rijeci.Add(txtJednarijec.Text);
            AzurirajListBox();
		}

        private void AzurirajListBox()
		{
            lstPopis.DataSource = null;
            lstPopis.DataSource = rijeci;
		}

		private void btnDodajNaPos_Click(object sender, EventArgs e)
		{
            var ok = int.TryParse(txtPozicija.Text, out int pozicija);
            if(!ok)
			{
                MessageBox.Show("Pogrešan format za poziciju");
                return;
			}
            if(pozicija <0 || pozicija > rijeci.Count - 1)
			{
                MessageBox.Show("Pozicija je izvan raspona");
                return;
			}
            rijeci.Insert(pozicija, txtJednarijec.Text);
            AzurirajListBox();
		}

		private void btnDodajVise_Click(object sender, EventArgs e)
		{
            var poljeRijeci = txtViseRijeci.Text.Split(' ');
            rijeci.AddRange(poljeRijeci);
            AzurirajListBox();
		}

		private void btnUkloni_Click(object sender, EventArgs e)
		{
            var index = lstPopis.SelectedIndex;
            if(index >= 0)
			{
                rijeci.RemoveAt(index);
                AzurirajListBox();
			}
		}

		private void btnOcisti_Click(object sender, EventArgs e)
		{
            rijeci.Clear();            
            AzurirajListBox();
		}
	}
}
