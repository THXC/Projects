#include <iostream>

using namespace std;

void bin(int liczba);
void oct(int liczba);
void hex(int liczba);

int main()
{
	cout<<"Enter a number ";
	int liczba;
	cin>>liczba;
	cout<<"\nBIN = ";
	bin(liczba);
	cout<<"\nOCT = ";
	oct(liczba);
	cout<<"\nHEX = ";
	hex(liczba);
	cout<<"\n";
	system("PAUSE");
}

void bin(int liczba)
{
	int rest = liczba % 2;
	if(liczba>1)
	{
		bin(liczba / 2);
	}
	cout<<rest;
	return;
}

void oct(int liczba)
{
	int rest = liczba % 8;
	if(liczba>1)
	{
		oct(liczba / 8);
	}
	cout<<rest;
	return;
}

void hex(int liczba)
{
	int rest = liczba % 16;
	if(liczba>1)
	{
		hex(liczba / 16);
	}
	cout<<rest;
	return;
}