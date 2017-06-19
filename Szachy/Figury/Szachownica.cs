using System;

namespace Szachy.Figury
{
	public class Szachownica
	{
		private string[,] _szachownica;
		public const int wymiar = 8;

		private Figura figura;
		private Ruch ruch;
		
		public Szachownica ()
		{
			
			ruch = new Ruch();
			_szachownica = new string[wymiar, wymiar];
			SzachownicaPoziomo = "*----";
			SzachownicaPionowo = "|  ";
		}
		public string SzachownicaPoziomo { get; set;}
		public string SzachownicaPionowo { get; set;}

		public void  narysujSzachownice()
		{
			while (!ruch.wyjscie) 
			{
				Console.Clear ();
				Console.WriteLine ("     0    1    2    3    4    5    6    7");

				for (int i = 0; i < wymiar; i++) 
				{
					Console.Write ("  ");
					for (int j = 0; j < wymiar; j++) 
					{
						Console.Write (SzachownicaPoziomo);
					}
					Console.Write ("*\n");

					for (int j = 0; j < wymiar; j++) 
					{
						if (j == 0)
						Console.Write (i + " ");
						Console.Write (SzachownicaPionowo + Figura.ustawieniePoczatkowe[i,j] + " ");

					}
					Console.Write ("|\n");
				
				}
				Console.Write ("  ");
				for (int i = 0; i < wymiar; i++) 
				{
					Console.Write (SzachownicaPoziomo);
				
				}
				Console.Write ("*\n\n");
				ruch.WykonajRuch ();
			}
		}
	}
}

