#ifndef STACK_H
#define STACK_H

#include "List.h" // List class definition

template< typename STACKTYPE >
class Stack : private List< STACKTYPE > 
{
public:
   // push calls the List function insertAtFront
   void push( const STACKTYPE &data ) 
   { 
      insertAtFront( data ); 
   } // end function push

   // pop calls the List function removeFromFront
   bool pop( STACKTYPE &data ) 
   { 
      return removeFromFront( data ); 
   } // end function pop

   // isStackEmpty calls the List function isEmpty
   bool isStackEmpty() const 
   { 
      return this->isEmpty();
   } // end function isStackEmpty
 
   // printStack calls the List function print
   void printStack() const 
   { 
      this->print();
   } // end function print 
}; // end class Stack

#endif
