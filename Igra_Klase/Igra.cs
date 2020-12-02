using System;
using System.Collections.Generic;
using System.Text;

namespace Igra_Klase
{
	public class Igra
	{
		private string naziv, opis, izdavac, vrsta;
		private decimal cijena;
		private DateTime datumIzdavanja;

		public string Naziv
		{
			get => naziv;
			set 
			{ 
				if(string.IsNullOrEmpty(value))
				{
					throw new ArgumentException("Naziv ne smije biti prazan");
				}
				naziv = value; 
			}
		}
		public string Opis { get => opis; set => opis = value; }
		public string Izdavac { get => izdavac; set => izdavac = value; }
		public string Vrsta { get => vrsta; set => vrsta = value; }
		public decimal Cijena
		{
			get => cijena;
			set
			{
				if(value < 0)
				{
					throw new ArgumentException("Cijena ne smije biti negativna");
				}
				cijena = value;
			}
		}
		public DateTime DatumIzdavanja
		{
			get => datumIzdavanja;
			set
			{
				if(value > DateTime.Now)
				{
					throw new ArgumentException("Datum ne smije biti u budućnosti");
				}
				datumIzdavanja = value;
			}
		}
	}
}
