/******************************************************************
 * Binary Search Tree Implementation
 * Author: Jake Zayak
 * Creation Date:  3/23/2018
 * Version 1.7 
 * Last Updated: 4/27/18
 * Using Deletion Method from Microsoft:
 * https://msdn.microsoft.com/en-US/library/ms379570(v=vs.80).aspx
 * Adjusted for use within this program.
 * ***************************************************************/

using System;

namespace BSTLab
{
    class BinarySearchTree<T> : BinaryTree<T>
    {
        public BinarySearchTree() : base() { } //Constructor calls base class constructor

        public void Add(T item)
        {
            BinaryTreeNode<T> newNode = new BinaryTreeNode<T>(item);

            int compResult; //Holds the IComparable results between nodes

            BinaryTreeNode<T> current = Root;
            BinaryTreeNode<T> parent = null;

            while (current != null)
            {
                compResult = ((IComparable<T>)(current.Item)).CompareTo(item);

                
                if (compResult == 0) // if the item is EQUAL to the current
                {
                    parent = current;
                    current = current.Left;
                }
                else if (compResult > 0) //if the item is GREATER than the current
                {
                    parent = current;
                    current = current.Left;
                }
                else if (compResult < 0) //if the item is LESS than the current
                {
                    parent = current;
                    current = current.Right;
                }
            }

            //if the tree is empty, adding a new node adds to the root
            if (parent == null)
                Root = newNode;
            //based on IComparable, inserts the new node to the left or right
            else
            {
                compResult = ((IComparable<T>)(parent.Item)).CompareTo(item);

                if (compResult > 0)
                    parent.Left = newNode;
                else if (compResult < 0)
                    parent.Right = newNode;
                else
                    parent.Left = newNode;
            }
            Console.WriteLine("Added: " + item);
        }

        /* ****************************************************************
         * Using Deletion Method from Microsof
         * https://msdn.microsoft.com/en-US/library/ms379570(v=vs.80).aspx
         * Remove is almost mirror image of Add, with the exception of
         * moving items up or down the tree. 
         ******************************************************************/
        public bool Remove(T item)
        {
            //EMPTY TREE
            if (Root == null)
                return false;       // no items to remove


            BinaryTreeNode<T> current = Root, parent = null;
            int compResult = ((IComparable<T>)(current.Item)).CompareTo(item);
            while (compResult != 0)
            {
                // item > current.Value
                if (compResult > 0)
                {
                    parent = current;
                    current = current.Left;
                }
                // item < current.Value
                else if (compResult < 0)
                {
                    parent = current;
                    current = current.Right;
                }
                //Item not found, no additional work required.                
                if (current == null)
                {
                    Console.WriteLine(item + " not found in BST, item not removed.");
                    return false;
                }
                else
                {
                    compResult = ((IComparable<T>)(current.Item)).CompareTo(item);
                }
            }

            //If current has no right child, then current's left child becomes
            //         the node pointed to by the parent
            if (current.Right == null)
            {
                if (parent == null)
                    Root = current.Left;
                else
                {
                    compResult = ((IComparable<T>)(parent.Item)).CompareTo(current.Item);
                    if (compResult > 0)
                        // parent.Value > current.Value, so make current's left child a left child of parent
                        parent.Left = current.Left;
                    else if (compResult < 0)
                        // parent.Value < current.Value, so make current's left child a right child of parent
                        parent.Right = current.Left;
                }
            }
            //If current's right child has no left child, then current's right child
            //         replaces current in the tree
            else if (current.Right.Left == null)
            {
                current.Right.Left = current.Left;

                if (parent == null)
                    Root = current.Right;
                else
                {
                    compResult = ((IComparable<T>)(parent.Item)).CompareTo(current.Item);
                    if (compResult > 0)
                        // parent.Item > current.Item, so make current's right child a left child of parent
                        parent.Left = current.Right;
                    else if (compResult < 0)
                        // parent.Item < current.Item, so make current's right child a right child of parent
                        parent.Right = current.Right;
                }
            }
            //If current's right child has a left child, replace current with current's
            //          right child's left-most descendent
            else
            {
                // We first need to find the right node's left-most child
                BinaryTreeNode<T> leftmost = current.Right.Left, lmParent = current.Right;
                while (leftmost.Left != null)
                {
                    lmParent = leftmost;
                    leftmost = leftmost.Left;
                }

                // the parent's left subtree becomes the leftmost's right subtree
                lmParent.Left = leftmost.Right;

                // assign leftmost's left and right to current's left and right children
                leftmost.Left = current.Left;
                leftmost.Right = current.Right;

                if (parent == null)
                    Root = leftmost;
                else
                {
                    compResult = ((IComparable<T>)(parent.Item)).CompareTo(current.Item);
                    if (compResult > 0)
                        // parent.Value > current.Value, so make leftmost a left child of parent
                        parent.Left = leftmost;
                    else if (compResult < 0)
                        // parent.Value < current.Value, so make leftmost a right child of parent
                        parent.Right = leftmost;
                }
            }
            Console.WriteLine("Removed: " + item);
            return true;
        }
    }
}
