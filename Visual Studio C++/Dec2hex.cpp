#include <iostream>
#include <iomanip>

using namespace std;

void BIN(int liczba);
void HEX(int liczba);
void OCT(int liczba);

int main()
{
	cout<<"Enter number \n";
	int liczba;
	cin>>liczba;
	cout<<"\nBIN\n";
	BIN(liczba);
	cout<<"\nHEX\n";
	HEX(liczba);
	cout<<"\nOCT\n";
	OCT(liczba);
	cout<<"\n";
	system("PAUSE");
	return(0);


}

void BIN(int liczba)
{
	int dec,i=0,bin[100];
	dec=liczba;
	while(dec>0)
	{
		bin[i]=dec%2;
		i++;
		dec=dec/2;
	}
	for(int j=i-1;j>=0;j--)
	{
		cout<<bin[j];
		cout<<endl;
	}
}

void HEX(int liczba)
{
	int dec,i=0,hex[100];
	char hexchar[16]={'0','1','2','3','4','5','6','7','8','9','A','B','C','D','E','F'};
	dec=liczba;
	while(dec>0)
	{
		hex[i]=dec%16;
		i++;
		dec=dec/16;
	}
	for(int j=i-1;j>=0;j--)
	{
		cout<<hexchar[hex[j]];
		cout<<endl;
	}
}

void OCT(int liczba)
{
	int dec,i=0,oct[100];
	dec=liczba;
	while(dec>0)
	{
		oct[i]=dec%8;
		i++;
		dec=dec/8;
	}
	for(int j=i-1;j>=0;j--)
	{
		cout<<oct[j];
		cout<<endl;
	}
}
