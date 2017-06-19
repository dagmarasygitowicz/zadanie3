using System;

namespace Szachy.Figury
{
	public class Ruch : Figura
	{
		private int koncowyX;
		private int koncowyY;
		private int miejsceFiguryX;
		private int miejsceFiguryY;

		public Ruch ()
		{
			miejsceFiguryX  = 0;
			miejsceFiguryY = 0;
			koncowyX = 0;
			koncowyY = 0;
			wyjscie = false;
		}
		public bool wyjscie{ get; set; }

		public void WykonajRuch()
		{
			liczbaFigur();
			_ostatniRuch();
			_pobierzDaneDoPrzesuniecia ();
			if (!wyjscie)
			{
				
				_przesunFigure ();
				
				
			}
		}
		private bool _czyPozycjaZnajujeSieNaSzachownicy(bool parsed)
		{
			bool blad = false;
			if (!parsed) {
				blad = true;
			} else if (miejsceFiguryX < 0 || miejsceFiguryY < 0 || koncowyX < 0 || koncowyY < 0) {
				blad = true;
			} else if (miejsceFiguryX > Szachownica.wymiar - 1 || miejsceFiguryY > Szachownica.wymiar - 1 || koncowyX > Szachownica.wymiar - 1 || koncowyY > Szachownica.wymiar - 1) {
				blad = true;
			}
			if (blad) {
				Console.WriteLine ("Bledny typ wprowadzonych danych");
			}
			return blad;
		}
		private void _pobierzDaneDoPrzesuniecia()
		{
			Console.WriteLine ("Podaj w ktorym rzedzie znajduje sie figura");
			wyjscie = _czyPozycjaZnajujeSieNaSzachownicy (int.TryParse (Console.ReadLine (),out miejsceFiguryX));
			if (!wyjscie) 
			{
				Console.WriteLine ("Podaj w ktorej kolumnie znajduje sie figura");
				wyjscie = _czyPozycjaZnajujeSieNaSzachownicy (int.TryParse (Console.ReadLine (),out miejsceFiguryY));
				
			}
			if (!wyjscie) 
			{
				Console.WriteLine ("Podaj w ktorym rzedzie ma znalesc sie figura");
				wyjscie = _czyPozycjaZnajujeSieNaSzachownicy (int.TryParse (Console.ReadLine (),out koncowyX));

			}
			if (!wyjscie) 
			{
				Console.WriteLine ("Podaj w ktorej kolumnie ma znalesc sie figura");
				wyjscie = _czyPozycjaZnajujeSieNaSzachownicy (int.TryParse (Console.ReadLine (),out koncowyY));
			}

		}
		private void _przesunFigure()
		{
			ustawieniePoczatkowe[koncowyX,koncowyY]=ustawieniePoczatkowe[miejsceFiguryX,miejsceFiguryY];
			ustawieniekolorFigur[koncowyX, koncowyY] = ustawieniekolorFigur[miejsceFiguryX, miejsceFiguryY];
			ustawieniePoczatkowe[miejsceFiguryX,miejsceFiguryY] = symbol_PustePole;
			ustawieniekolorFigur[miejsceFiguryX, miejsceFiguryY] = symbol_PustePoleS;
		}

		private void _ostatniRuch()
		{
			char _figura = ustawieniePoczatkowe[koncowyX, koncowyY];
			string _kolorFigura = ustawieniekolorFigur[koncowyX, koncowyY];
			
			Console.WriteLine(_figura+" "+_kolorFigura+":"+miejsceFiguryX +","+ miejsceFiguryY + "--->" + koncowyX +","+ koncowyY);
		}
		private void liczbaFigur()
		{
			int liczba_figur = 0;
			for (int rzad = 0; rzad < Szachownica.wymiar; rzad++)
			{
				for (int kolumna = 0; kolumna < Szachownica.wymiar; kolumna++)
				{
					if (ustawieniePoczatkowe[rzad, kolumna] != symbol_PustePole)
					{
						liczba_figur++;
					}
				}
			}
			Console.WriteLine("Na szachownicy pozostły "+liczba_figur+" figury.");
		}

	}
}

