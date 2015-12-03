#ifndef TREENODE_H
#define TREENODE_H

template < typename NODETYPE > class Tree;
template < typename NODETYPE > 
class TreeNode {
	friend class Tree< NODETYPE >;
public:
	//constructor
	TreeNode( const NODETYPE &d )
		:leftPtr( 0 ),
		 data( d ),
		 rightPtr( 0 ) //pointer to right substree
	{
		//empty body
	} //end TreeNode constructor

	NODETYPE getData() const {
		return data;
	}

private:
	TreeNode< NODETYPE > *leftPtr;
	NODETYPE data;
	TreeNode< NODETYPE > *rightPtr;
} //end class TreeNode
#endif
