#ifndef BALL_H_

#define BALL_H_

class Ball
{
public:
	Ball();
	Ball(double);
	~Ball();
	void setRadius(double);
	double getRadius();
	double getCircumfrence();
private:
	double radius;
	double diameter;
	double circumfrence;
	double volume;
};

#endif

