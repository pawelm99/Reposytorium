#include <iostream>
#include "Point2D.h"

using namespace std;

namespace Point2DClass
{

//Konstruktory,Destruktory
Point2D::Point2D(int x, int y) :x(x), y(y)
{
}
Point2D::~Point2D()
{
}

//Metody 
int Point2D::get_x() { return this->x; };
int Point2D::get_y() { return this->y; };
void Point2D::edit_x(int x) { this->x = x; };
void Point2D::edit_y(int y) { this->y = y; };
//----------------------------------------------

//Wyswietlanie pozycji dla wszystkich
ostream& operator<<(ostream& wyjscie, Point2D& rhs)
{
	wyjscie << "(" << rhs.get_x() << "," << rhs.get_y() << ")";
	return wyjscie;
}
}