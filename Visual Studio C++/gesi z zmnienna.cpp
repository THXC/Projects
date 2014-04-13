#include <iostream>
#include <cmath>

using namespace std;

struct Dane
{
	unsigned short int dana_1;
	bool prawda;
};
struct Wynik
{
	unsigned short int Wynik_1;
	bool prawda;
};

Wynik Gesi( Dane pobierz );
void WyswietlWynik( const Wynik wynik);

int main()
{
	Dane wprowadzDane;
	Wynik wyswietl;

	cout << "\n Rolnik na podworzu, Leca gesi,\n -Witajcie \"100\" gesi"
		 << "\n ... Gdyby nas bylo \n Jeszcze raz tyle \n i pol tyle"
		 << "\n i cwierc tyle \n i ty razem z nami, \n Dopero by nas bylo \"100\""
		 << "\n \n Ile gesi Lecialo?\n  ";

	while( cin >> wprowadzDane.dana_1)
	{
		wyswietl = Gesi( wprowadzDane );
		WyswietlWynik( wyswietl );
		cout << "\n Podaj Ponownie lub 'k' by wyjsc. \n";
	}
	system("PAUSE");
	return(0);	
}

Wynik Gesi( Dane pobierz )
{
	Wynik odp;
	if(((pobierz.dana_1 *11) / 4 ) == 99 )
	{
		odp.Wynik_1 =((( pobierz.dana_1 * 11) / 4) +1);
		odp.prawda = true;
	}
	else
	{
		odp.prawda = false;
		odp.Wynik_1 = (( pobierz.dana_1 * 11) / 4) +1; 
	}
	return odp;
}

void WyswietlWynik( const Wynik wynik )
{
	if( wynik.prawda )
	{
		cout << "\n Udalo ci sie odgadnac liczbe gesi! "
			 /*<< "\n Ustaliles wynik dzieki mojemu wzorowi? "*/
			 << "\n (( x + x ) + ( x / 2 ) + ( x / 4 ) + 1) "
			 << "\n ((36 + 36) + ( 36 / 2) + ( 36 / 4) + 1) = "
			 << wynik.Wynik_1
			 << "\n";
	}
	else
		cout << "\n Podana ilosc gesi sie niezgadza! "
			 << wynik.Wynik_1;
}