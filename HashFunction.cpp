#include "iostream"
#include "string"
using namespce std;

int hash( const string &key, int tableSize ) {
	int hashVal = 0;

	for ( int i = 0; i < key.lenth( ) ; ++i ) 
		hashVal += key[ i ]; //Using ASCII add to hashVal

	return (hashVal % tableSize)
}

int main(int argc, char const *argv[])
{
	string Temp[ 5 ] = { a, b, c, d, e };
	int returnKey;
	int tableSize;

	tableSize = Temp.lenth( ) + 1;

	returnKey = hash( Temp, tableSize );

	cout << "The answer is: " << returnKey;

	return 0;
}