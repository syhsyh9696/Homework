#include "iostream"
#include "Time.h"
#include "Time.cpp"

using namespace std;
int main(int argc, char const *argv[])
{
	Time t;

	cout << "The initial universal time is ";
	t.printUniversal();

	cout << "\nThe initial standard time is "
	t.printStandard();

	t.setTime( 13, 13, 1 )
	cout << "\n\nUniversal time after setTime is ";
	t.printUniversal();

	cout << "\n Standard time after setTime is ";
	t.printStandard();

	t.setTime( 99, 99, 99 ); //attempt invalid values
	cout << "\n\nAfter attempting invalid settings: "
		 << "\nUniversal time: ";
	t.printUniversal();

	cout << "\nStandard time: ";
	t.printStandard();
	cout << endl;
	
	return 0;
}