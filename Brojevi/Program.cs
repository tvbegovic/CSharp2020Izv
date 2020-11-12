using System;

namespace Brojevi
{
	class Program
	{
		static void Main(string[] args)
		{
			var nastavi = true;
			do
			{
				Console.Write("Unesite broj elemenata niza (1-1000): ");
				var unos = Console.ReadLine();
				if(string.IsNullOrEmpty(unos))
				{
					nastavi = false;
				}
				else
				{
					//Provjeri format broja i da li je u rasponu
					var ok = int.TryParse(unos, out int brojElemenata);
					if(!ok)
					{
						Console.WriteLine("Pogrešan format broja");
						continue;
					}
					if(brojElemenata < 1 || brojElemenata > 1000)
					{
						Console.WriteLine("Broj nije u rasponu");
						continue;
					}

					//Deklariraj polje
					int[] brojevi = new int[brojElemenata];

					//Unesi elemente
					var i = 0;
					while(i < brojElemenata)
					{
						Console.Write("Unesi element {0}: ", i + 1);
						unos = Console.ReadLine();
						ok = int.TryParse(unos, out brojevi[i]);
						if(!ok)
						{
							Console.WriteLine("Pogrešan format");
							continue;
						}
						i++;
					}

					//Ispiši polje
					Console.Write("Unijeli ste polje: ");
					foreach (var broj in brojevi)
					{
						Console.Write("{0} ", broj);
					}
					Console.WriteLine();

					//Izračunaj sumu, min, max i prosjek
					var suma = 0;
					var min = brojevi[0];
					var max = brojevi[0];

					foreach (var broj in brojevi)
					{
						suma += broj;
						if(broj < min)
						{
							min = broj;  
						}
						if(broj > max)
						{
							max = broj;
						}
					}
					var prosjek = suma * 1.0 / brojElemenata;

					//Ispiši rezultate
					Console.WriteLine("Suma elemenata polja je {0}", suma);
					Console.WriteLine("Prosjek elemenata je {0:N2}", prosjek);
					Console.WriteLine("Najmanji element je {0}", min);
					Console.WriteLine("Najveći element je {0}", max);

				}

			} while (nastavi);
		}
	}
}
