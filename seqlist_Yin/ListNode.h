#ifndef LISTNODE_H
#define LISTNODE_H

template< typename NODETYPE >
class ListNode
{
	friend class List< NODETYPE >
public:
	ListNode( const NODETYPE & );
	NODETYPE getdata() const;
private:
	NODETYPE data;
	ListNode< NODETYPE > *nextPtr; //next node in list
	ListNode< NODETYPE > *prevPtr; //previous node in list

	//~ListNode();
}; //end class ListNode

template< typename NODETYPE >
ListNode< NODETYPE >::ListNode( const NODETYPE &info )
	:data( info ),nextPtr( 0 )
	{}//end ListNode construtor

template< typename NODETYPE >
NODETYPE ListNode< NODETYPE >::getdata() const
{
	return data;
}//end function get data

#end if