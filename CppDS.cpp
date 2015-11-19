#include "iostream"
#include "vector"
#include "list"
#include "string"
#include "iomanip"

using namespace std;

template < typename T >
void outputList ( int a, list< T > &listObject ) 
{
	list< T > *tempPtr = &listObject; //remember to add a function!
	for (int i = 0; i < a; ++i)
		tempPtr = tempPtr->nextPtr;

	cout << tempPtr->data << ' ';
	tempPtr = NULL;
	delete tempPtr;
}

using namespace std;
int main( ) {
	vector< int > integer1( 5 );

	cout << "Please enter the number of which node you want to display on screen"
		 << endl
		 << "Warning:5 is the most"
		 << "Enter 5 integers:" << endl;
	inputVector( integer1 );

	cout << "after intput,the vector contain:" << endl
	 	 << "integer: " << endl;
	outputVector( integer1 );

	list<string> testList;
	testList.push_front("I");
	testList.push_front("am");
	testList.push_front("an");
	testList.push_back("awesome");
	testList.push_back("boy");

	cout << "There is " << testList.size() 
		 << "element in testList" << endl;

	for (int i = 0; i < 5; ++i)
		outputList( integer1[i], testList );


	system("pause");
	return 0;
}
