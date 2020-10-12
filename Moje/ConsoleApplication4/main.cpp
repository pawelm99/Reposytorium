#include <iostream>
#include "Point.h"

using namespace std;
using Point::Point2D;

class Human :public Point2D
{
	
public:
	Human();
	~Human();

	
private:

};

//Konstruktory,Destruktory
Human::Human()
{
}
Human::~Human()
{
}

class Zombi :public Point2D
{
public:
	Zombi();
	~Zombi();

private:

};

//Konstruktory,Destruktory
Zombi::Zombi()
{
}
Zombi::~Zombi()
{
}



int main()
{
	Human H;
	Zombi Z;
	
	H.edit_x(3);
	H.edit_y(3);
	
	cout << H;
	cout << Z;
}

