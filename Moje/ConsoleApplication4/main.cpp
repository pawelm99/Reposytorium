#include <iostream>
#include "Point2D.h"
#include "Human.h"
#include "Zombie.h"

using namespace std;
using Point2DClass::Point2D;
using HumanClass::Human;
using ZombieClass::Zombie;

int main()
{
	Human H;
	Zombie Z;
	
	H.edit_x(3);
	H.edit_y(3);

	if (H.get_x() == Z.get_y())
	{
		cout << "Dopadl cie \n";
	}
	cout << H;
	cout << Z;


}

