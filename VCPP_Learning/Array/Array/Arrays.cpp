#include <iostream>
#include <conio.h>//getch()
//#include <cstring>
#include <string>


void m_HandleMenuSelection();
void m_PrintMenu();
void m_GetNumber();

void main()
{
	for(;;)
	{
		m_PrintMenu();
	}
	//while ( true )
	//{
	//	switch (GetMenu())
	//	{
	//		case '1':
	//			break;
	//		default:
	//			GetMenu()
	//	}
	//}
	//std::string x[5]; 
	//x[0] = "ABCD";
	//x[1] = "EFGH";
	//char myArray[25] = "abcdefg";// = new int[0];
	//std::cout << x[0] << std::endl;
	//char myStrings[5][25];
	//myStrings[0] = "ABCDEFG";
	//cout << sizeof(myArray) << endl;
	//myStrings[][0] = "asdsds";
	//myArray[0] = 4;
	//cout << myArray[0];
	//int y[8][8];

	//getch();
}
void m_PrintMenu()
{
	std::cout << "Menu" << std::endl;
	std::cout << "1 - Enter Number" << std::endl;
	std::cout << "Q - Quit" << std::endl;
	m_HandleMenuSelection();
}
void m_HandleMenuSelection()
{
	switch(getch())
	{
		case 'Q':
			break;
		case '1':
			m_GetNumber();
			break;
		default:
			break;
	}

}
void m_GetNumber()
{
	double Entry = 0;
	std::cout<<"Enter number:";
	std::cin>>Entry;
	//std::cout << *Entry;
}