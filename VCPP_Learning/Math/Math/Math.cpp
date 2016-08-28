#include <iostream>
#include <conio.h>
#include <cmath>
using namespace std;
double Add(double a , double b); 
double Subtract(double a , double b); 
double Multiply(double a , double b); 
double Divide(double a , double b); 
double Modulus(double a , double b); 
double Power(double a , double b); 
void main()
{
	double num1 = 0;
	double num2 = 0;
	double ans = 0;
	char ret = 0;
	while (ret!= 113)
	{
		char Operator = '!';
		cout << "Operation:" << endl; 
		cout << Operator << endl; 
		cout << "First Number:"; 
		cin >> num1;
		cout << "Second Number:";
		cin >> num2;
		cout << "Operation:";
		cin >> Operator;
		double(*Calc)(double,double);
		switch(Operator)
		{
			case '+':
				Calc=Add;
				break;
			case '-':
				Calc=Subtract;
				break;
			case '/':
				Calc=Divide;
				break;
			case '*':
				Calc=Multiply;
				break;
			case '%':
				Calc=Modulus;
				break;
			case '^':
				Calc=Power;
				break;

		}
	
		ans = Calc(num1,num2);

		cout << "Answer:" << ans <<endl;
		cout << "Podoubleer Address:" << *Calc <<endl;
		cout << "Podoubleer Address:" << Calc <<endl;
		ret = getch();
	}
	
}
double Add(double a, double b)
{
	return(a+b);
}
double Subtract(double a, double b)
{
	return(a-b);
}
double Multiply(double a, double b)
{
	return(a+b);
}
double Divide(double a, double b)
{
	return(a-b);
}
double Power(double a, double b)
{
	return(pow(a,b));
}
double Modulus(double a, double b)
{
	return(fmod(a,b));
}



