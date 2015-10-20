#include "iostream"

using namespace std;

template <typename Object>
class List
{
public:
	List() { init(); }

	
	List( const List & rhs ) //rhs is a name for class_List
	{
		init( ); //Function in it
		*this = rhs;

	}

	
	const List & operator= (const List & rhs)
	{
		if ( this == &rhs )
				return *this;
		clear();
		for ( const_iterator itr = rhs.begain( ); itr != rhs.end( ); ++itr)
			push_back( itr );
		return *this;

	}


	iterator begain( )
	{
		return iterator( head->next );
	}


	const_iterator begain()
	{
		return const_iterator ( head->next );
	}


	iterator begain( )
	{
		return iterator( tail );
	}


	const_iterator end( ) const
	{
		return const_iterator( tail );
	}
	

	int size( ) const
	{
		return theSize;
	}


	bool empty( ) const
	{
		return size() == 0;
	}


	void clear( )
	{
		while( != empty( ) )
			pop_front( );
	}
	

	void init()
	{
		theSize = 0;
		head = new Node;
		tail = new Node;
		head->next = tail;
		tail->prev = head;
	}

	~List()
	{
		clear();
		delete head;
		delete tail;
	}

	
	Object & front( )
	{
		return *begain();
	}


	
	const Object & front( ) const
	{
		return *begain();
	}


	Object & back()
	{
		return *--end();
	}

	const Object & back() const;
	{
		return *--end();
	}

	void push_front( const Object & x )
	{
		insert( begain( ), x );
	}


	void push_back( const Object & x )
	{
		insert( end( ), x );
	}


	void pop_front( )
	{
		erase( begain( ) );
	}

	void pop_back()
	{
		erase( --end() );
	}


	iterator insert ( iterator itr, const Object & x )
	{
		Node *p = itr.current;
		theSize++;
		return iterator( p->prev = p->prev->next = new Node( x,p->prev, p ) );
	}


	iterator erase( iterator itr )
	{
		Node *p = itr.current;
		iterator retVal( p->next );
		p->prev->next = p->next;
		p->next->prev = p->prev;
		delete p;
		theSize--;

		return retVal;
	}


	iterator erase( iterator start, iterator end )
	{
		for ( iterator itr = from; itr != to; )
			itr = erase (itr);
	}







	const List & operator = { const List & rhs };

	iterator begain();
	const_iterator


public:
	class const_iterator
	{
	public:
		const_iterator() : current (NULL)
		{ }

		const Object & operator++ ( )
		{
			current = current->next;
			return *this;
		} 

		const_iterator operator++ ( int )
		{
			const_iterator old = *this;
			++( *this );
			return old;
		}

		bool operator== (const_iterator & rhs ) const
		{
			return current == rhs.current;
		}

		bool operator!=( const_iterator & rhs ) const
		{
			return !( *this == rhs );
		}

	protected:
		Node *current;

		Object & retrieve( ) const
		{
			return current->data;
		}

		const_iterator ( Node *p ) : current( p )
			{}

		friend class List<Object>;
		
	};

	class iterator : public const_iterator
	{
	public:
		iterator( ){}

		Object & operator* ( )
			{ return retrieve( );}

		const Object & operator* ( ) const
			 { return const_iterator::operator*( );}

		iterator & operator++ ( )
		{
			current = current->next;
			return *this;
		} 

		iterator operator++ ( int )
		{
			iterator old = *this;
			++( *this );
			return old;
		}

	protected:
		iterator( Node *p ) : const_iterator( p )
			{}

		friend class List<Object>;

	protected:
		const List<Object> *theList;
		
		Node *current;
		
		const_iterator( const List<Object> & lst, Node *p )
			: theList( &lst ), current ( p )
			{}

		void assertIsValid( ) const
		{
			if ( theList == NULL || current == NULL || current ==theList->head )
				throw IteratorOutOfBoundsException( );	
		}
	};

private:
	struct Node
	{
		Object data;
		Node *prev;
		Node *next;

		Node( const Object & d = Object( ), Node *p = NULL, Node *n = NULL )
			: data( d ), prev( p ), next( n ) {}
	};

private:
	int theSize;
	Node *head;
	Node *tail;

};