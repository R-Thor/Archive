#include <iostream>
//#include "Volume.h"
#include "Ball.h"
void main()
{
	//std::cout.precision(10);
	//double depth, width, length;
	//std::cout << "Volume Calculator" << std::endl;
	//std::cout << "Width: ";
	//std::cin>>width;
	//std::cout << "Length: ";
	//std::cin>>length;
	//std::cout << "Depth: ";
	//std::cin>>depth;
	//std::cout << CalculateVolume(depth, width, length) << std::endl;
	//system("pause");
	Ball ball,ball2,ball3(25);
	//std::cout << "Radius: " << ball.getRadius() << std::endl;
	//std::cout << "Radius: " << ball3.getRadius() << std::endl;
	//ball.setRadius(5);
	//std::cout << "Radius: " << ball.getRadius()<< std::endl;
	std::cout << ball.getCircumfrence();
	//std::cout << ball.radius = 6;
	system("pause");
}