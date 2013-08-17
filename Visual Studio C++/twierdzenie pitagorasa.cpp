// Funkcje i struktury-------
#include <iostream>
#include <cmath> //nowa biblioteka
//definicja struktur ---------
struct BokiTrojkata
{
    double bokA;
    double bokB;
    double bokC;
    bool czy_prawda;
};
struct WynikiTrojkata
{
    double Wynik1;
    double Wynik2;
    double Wynik3;
    bool czy_prawda;
};
//definicje funkcji-----------
WynikiTrojkata TwierdzeniePitagorasa( BokiTrojkata pobiezboki );
void WyswietlWyniki( const WynikiTrojkata wynik );
//funkcja g��wna -------------
int main()
{
    using std::cout;
    using std::cin;
    //tworzenie obiekt�w struktur
    BokiTrojkata wprowadzDane;
    WynikiTrojkata wyswietl;
    
    cout << "Wprowadz dana bokow a, b i c: ";
    //sprytny spos�b wprowadzania danych
    while( cin >> wprowadzDane.bokA >> wprowadzDane.bokB >> wprowadzDane.bokC )
    {
        wyswietl = TwierdzeniePitagorasa( wprowadzDane );
        WyswietlWyniki( wyswietl );
        cout << "\nPodaj ponownie boki lub 'k' by wyjsc.\n";
    }
	system("PAUSE");
    return 0;
}
//funkcja obliczaj�ca kwadrat poszczeg�lnych bok�w A, B, C
WynikiTrojkata TwierdzeniePitagorasa( BokiTrojkata pobierzboki )
{
    // pow s�u�y do pot�gowania liczb
    using std::pow;
    //tworzy struktur� by m�c j� zwr�ci� przez return
    WynikiTrojkata odpowiedz;
    
    if(( pow( pobierzboki.bokA, 2 ) + pow( pobierzboki.bokB, 2 ) ) == pow( pobierzboki.bokC, 2 ) )
    {
        odpowiedz.Wynik1 =( pow( pobierzboki.bokA, 2 ) );
        odpowiedz.Wynik2 =( pow( pobierzboki.bokB, 2 ) );
        odpowiedz.Wynik3 =( pow( pobierzboki.bokC, 2 ) );
        odpowiedz.czy_prawda = true;
    } else {
        odpowiedz.czy_prawda = false;
        /*   odpowiedz.Wynik1 = (pow(pobierzboki.bokA, 2));
                 odpowiedz.Wynik2 = (pow(pobierzboki.bokB, 2));
                 odpowiedz.Wynik3 = (pow(pobierzboki.bokC, 2));*/
    }
    return odpowiedz; //zwraca struktur�
}
void WyswietlWyniki( const WynikiTrojkata wynik )
{
    using std::cout;
    
    if( wynik.czy_prawda )
    {
        cout << "\nTo sa boki trojkata, a dodatkowo trojkata prostokatnego!\n"
        << "Udalo sie to ustalic dzieki twierdzeniu pitagorasa.\n"
        << "Bok a * a = " << wynik.Wynik1
        << "\tBok b * b = " << wynik.Wynik2
        << "\tBok c * c = " << wynik.Wynik3
        << "\nTwierdzenie pitagorasa to: (a*a) + (b*b) = (c*c)\n"
        << "\n";
    } else
         cout << "\nPodane boki nie tworza trojkata prostokatnego(lub zadnego innego)\n\n";
    
}