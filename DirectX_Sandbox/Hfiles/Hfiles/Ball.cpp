#include "Ball.h"


Ball::Ball()
{
	radius=1.0;
}
Ball::Ball(double radius)
{
	Ball::radius=radius;
}
Ball::~Ball()
{
}

void Ball::setRadius(double radius)
{
	Ball::radius=radius;
}

double Ball::getRadius()
{
	return(radius);
}

double Ball::getCircumfrence()
{
	return((22.0/7.0)*2.0*radius);
}
