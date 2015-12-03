#ifndef TREE_H
#define TREE_H

#include <iostream>
#include "TreeNode.h"

using namespace std;

template < typename NODETYPE > class tree {
public:
	Tree();
	void insertNode( const NODETYPE & );
	void preOrderTraversal() const;
	void inOrderTraversal() const;
	void postOrderTraversal() const;
private:
	TreeNode<NODETYPE> *rootPtr;

	//utility function
	void insertNodeHelper( TreeNode< NODETYPE > **,const NODETYPE & );
	void perOrderHelper( TreeNode< NODETYPE > * ) const;
	void inOrderHelper( TreeNode< NODETYPE > * ) const;
	void postOrderHelper( TreeNode< NODETYPE > * ) const;
} //end class tree

template < typename NODETYPE >
Tree< NODETYPE >::Tree() {
	rootPtr = 0;
}

template < typename NODETYPE > 
void Tree< NODETYPE >::insertNode(const NODETYPE &value) {
	insertNodeHelper( &rootPtr ,value );
}

template < typename NODETYPE >
void Tree< NODETYPE >::insertNodeHelper(
	TreeNode< NODETYPE > **ptr, 
