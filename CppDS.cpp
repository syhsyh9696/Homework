#include "iostream"
#include "vector"
#include "List"
#include "string"

using namespace std;

template < typename T >
bool LinearToLinked（ vector< int > &v, List< T > &listObject ）
{
	
}

template < typename T >
void outputList ( int a, List< T > &listObject ) const
{
	List< T > *tempPtr= getFirstPtr(); //remember to add a function!
	for (int i = 0; i < a; ++i)
	{
		tempPtr = tempPtr->nextPtr;
	}

	cout << currentPtr-data << ' ';
	tempPtr = NULL;
	delete tempPtr;
}

int main(int argc, char const *argv[])
	vector< int > integer1( 5 );

	cout << "Please enter the number of which node you want to display on screen"
		 << endl
		 << "Warning:5 is the most"
		 << "Enter 5 integers:" << endl;
	inputVector( integer1 );

	cout << "after intput,the vector contain:" << endl
	 	 << "integer: " << endl;
	outputVector( integer1 );


	return 0;
}
