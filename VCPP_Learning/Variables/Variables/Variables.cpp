#include <iostream>
#include <conio.h>
//#include <ctype.h>
using namespace std;
void main()
{
	int num1;
	num1 = 0;
	
	while(num1!=5)
	{
		cout << "Fave Num = ";
		cin  >> num1;
		cout << "num1="<< num1 <<endl;
		_getch();
	}
	cout << "Code Accepted"<< num1 <<endl;
}