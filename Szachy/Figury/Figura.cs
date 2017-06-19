using System;

namespace Szachy.Figury
{
	public class Figura: Szachy.Kolor
	{
		
		public const char symbol_PustePole = ' ';
		public const string symbol_PustePoleS = "nic tu nie ma";
		public static char[,] ustawieniePoczatkowe;
		public static string[,] ustawieniekolorFigur;


		public Figura ()
		{
			ustawieniePoczatkowe = new char[Szachownica.wymiar, Szachownica.wymiar];
			ustawieniekolorFigur = new string[Szachownica.wymiar, Szachownica.wymiar];
			intUstawieniePoczatkowe();
			
		}
		private void intUstawieniePoczatkowe()
		{
			for(int rzad =0; rzad <Szachownica.wymiar; rzad++)
			{
				for (int kolumna = 0; kolumna < Szachownica.wymiar; kolumna++) 
				{
					if (rzad == 1)
					{
						ustawieniePoczatkowe[rzad, kolumna] = Pionek.symbol_pionka;
						ustawieniekolorFigur[rzad, kolumna] = Pionek.KOLOR_BIALY;
					} else if (rzad == Szachownica.wymiar - 2) {
						ustawieniePoczatkowe [rzad, kolumna] = Pionek.symbol_pionka;
						ustawieniekolorFigur[rzad, kolumna] = Pionek.KOLOR_CZARNY;
					} else if (rzad == 0 && kolumna == 0 || rzad == 0 && kolumna == Szachownica.wymiar - 1) {
						ustawieniePoczatkowe [rzad, kolumna] = Wieza.symbol_wieza;
						ustawieniekolorFigur[rzad, kolumna] = Wieza.KOLOR_BIALY;
					} else if (rzad == Szachownica.wymiar-1 && kolumna == 0 || rzad == Szachownica.wymiar-1 && kolumna == Szachownica.wymiar - 1) {
						ustawieniePoczatkowe [rzad, kolumna] = Wieza.symbol_wieza;
						ustawieniekolorFigur[rzad, kolumna] = Wieza.KOLOR_CZARNY;
					}else if (rzad == 0 && kolumna == 1 || rzad == 0 && kolumna == Szachownica.wymiar - 2) {
						ustawieniePoczatkowe [rzad, kolumna] = Skoczek.symbol_skoczek;
						ustawieniekolorFigur[rzad, kolumna] = Skoczek.KOLOR_BIALY;
					}else if (rzad == Szachownica.wymiar-1 && kolumna == 1 || rzad == Szachownica.wymiar-1 && kolumna == Szachownica.wymiar - 2) {
						ustawieniePoczatkowe [rzad, kolumna] = Skoczek.symbol_skoczek;
						ustawieniekolorFigur[rzad, kolumna] = Skoczek.KOLOR_CZARNY;
					}else if (rzad == 0 && kolumna == 2 || rzad == 0 && kolumna == Szachownica.wymiar - 3) {
						ustawieniePoczatkowe [rzad, kolumna] = Goniec.symbol_goniec;
						ustawieniekolorFigur[rzad, kolumna] = Goniec.KOLOR_BIALY;
					}else if (rzad == Szachownica.wymiar-1 && kolumna == 2 || rzad == Szachownica.wymiar-1 && kolumna == Szachownica.wymiar -3) {
						ustawieniePoczatkowe [rzad, kolumna] = Goniec.symbol_goniec;
						ustawieniekolorFigur[rzad, kolumna] = Goniec.KOLOR_CZARNY;
					}else if (rzad == 0 && kolumna == 3 ) {
						ustawieniePoczatkowe [rzad, kolumna] = Hetman.symbol_hetman;
						ustawieniekolorFigur[rzad, kolumna] = Hetman.KOLOR_BIALY;
					}else if (rzad == Szachownica.wymiar-1 && kolumna == 3 ) {
						ustawieniePoczatkowe [rzad, kolumna] = Hetman.symbol_hetman;
						ustawieniekolorFigur[rzad, kolumna] = Hetman.KOLOR_CZARNY;
					}else if (rzad == 0 && kolumna == 4 ) {
						ustawieniePoczatkowe [rzad, kolumna] = Krol.symbol_krol;
						ustawieniekolorFigur[rzad, kolumna] = Krol.KOLOR_BIALY;
					}
					else if (rzad == Szachownica.wymiar - 1 && kolumna == 4 ) {
						ustawieniePoczatkowe [rzad, kolumna] = Krol.symbol_krol;
						ustawieniekolorFigur[rzad, kolumna] = Krol.KOLOR_CZARNY;
					}


					else 
					{
						ustawieniePoczatkowe[rzad, kolumna] = symbol_PustePole;
						ustawieniekolorFigur[rzad, kolumna] = symbol_PustePoleS;
					}
				}
			}

		}

		
	}
}

