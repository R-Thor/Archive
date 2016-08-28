#include <iostream>
#include <cmath>


void main()
{
	using namespace std;
	int x = 5;
	
	cout << x << endl;
	cout << &x << endl;
	int *pointer_To_x;
	pointer_To_x =  &x;
	cout << pointer_To_x << endl;
	cout << *pointer_To_x << endl;
	system("Pause");
}