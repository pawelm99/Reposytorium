#pragma once
#include <iostream>

using namespace std;

namespace Point2DClass
{
	class Point2D
	{
		int x, y;
		friend ostream& operator<<(ostream& wyjscie, Point2D& rhs);
	public:
		Point2D(int x=0, int y=0);
		~Point2D();
		int get_x();
		int get_y();
		void edit_x(int x);
		void edit_y(int y);
	private:
	};
}