using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTLab
{
    class BinarySearchTree<T> : BinaryTree<T>
    {
        public BinarySearchTree() : base() { } //Constructor calls base class constructor

        public void Add(T item)
        {
            BinaryTreeNode<T> newNode = new BinaryTreeNode<T>(item);

            int compResult;

            BinaryTreeNode<T> current = Root;
            BinaryTreeNode<T> parent = null;

            while (current != null)
            {
                compResult = ((IComparable<T>)(current.Item)).CompareTo(item);

                if (compResult == 0)
                    return;
                else if (compResult > 0)
                {
                    parent = current;
                    current = current.Left;
                }
                else if (compResult < 0)
                {
                    parent = current;
                    current = current.Right;
                }
            }

            if (parent == null)
                Root = newNode;
            else
            {
                compResult = ((IComparable<T>)(parent.Item)).CompareTo(item);

                if (compResult > 0)
                    parent.Left = newNode;
                else
                    parent.Right = newNode;
            }
            Console.WriteLine("Added: " + item);
        }

        public bool Remove(T item)
        {
           // // first make sure there exist some items in this tree
           // if (Root == null)
           // {
           //     return false;       // no items to remove
           // }
           // // Now, try to find data in the tree

           // BinaryTreeNode<T> current = Root, parent = null;

           // int compResult;
           // compResult = ((IComparable<T>)(current.Item)).CompareTo(item);
           // while (compResult != 0)
           // {
           //     if (compResult > 0)
           //     {
           //         // current.Value > data, if data exists it's in the left subtree
           //         parent = current;
           //         current = current.Left;
           //     }
           //     else if (compResult < 0)
           //     {
           //         // current.Value < data, if data exists it's in the right subtree
           //         parent = current;
           //         current = current.Right;
           //     }
           //     // If current == null, then we didn't find the item to remove
           //     if (current == null)
           //     {
           //         return false;
           //     }
           //     else
           //         compResult = ((IComparable<T>)(parent.Item)).CompareTo(item);
           // }

           // // At this point, we've found the node to remove
           ////count--;

           // // We now need to "rethread" the tree
           // // CASE 1: If current has no right child, then current's left child becomes
           // //         the node pointed to by the parent
           // if (current.Right == null)
           // {
           //     if (parent == null)
           //         Root = current.Left;
           //     else
           //     {
           //         compResult = ((IComparable<T>)(parent.Item)).CompareTo(item);
           //         if (compResult > 0)
           //             // parent.Value > current.Value, so make current's left child a left child of parent
           //             parent.Left = current.Left;
           //         else if (compResult < 0)
           //             // parent.Value < current.Value, so make current's left child a right child of parent
           //             parent.Right = current.Left;
           //     }
           //     Console.WriteLine("Removed: " + item);
           // }
           // // CASE 2: If current's right child has no left child, then current's right child
           // //         replaces current in the tree
           // else if (current.Right.Left == null)
           // {
           //     current.Right.Left = current.Left;

           //     if (parent == null)
           //         Root = current.Right;
           //     else
           //     {
           //         compResult = ((IComparable<T>)(parent.Item)).CompareTo(item);
           //         if (compResult > 0)
           //             // parent.Value > current.Value, so make current's right child a left child of parent
           //             parent.Left = current.Right;
           //         else if (compResult < 0)
           //             // parent.Value < current.Value, so make current's right child a right child of parent
           //             parent.Right = current.Right;
           //     }
           //     Console.WriteLine("Removed: " + item);
           // }
           // // CASE 3: If current's right child has a left child, replace current with current's
           // //          right child's left-most descendent
           // else
           // {
           //     // We first need to find the right node's left-most child
           //     BinaryTreeNode<T> leftmost = current.Right.Left, lmParent = current.Right;
           //     while (leftmost.Left != null)
           //     {
           //         lmParent = leftmost;
           //         leftmost = leftmost.Left;
           //     }

           //     // the parent's left subtree becomes the leftmost's right subtree
           //     lmParent.Left = leftmost.Right;

           //     // assign leftmost's left and right to current's left and right children
           //     leftmost.Left = current.Left;
           //     leftmost.Right = current.Right;

           //     if (parent == null)
           //         Root = leftmost;
           //     else
           //     {
           //         compResult = ((IComparable<T>)(parent.Item)).CompareTo(item);
           //         if (compResult > 0)
           //             // parent.Value > current.Value, so make leftmost a left child of parent
           //             parent.Left = leftmost;
           //         else if (compResult < 0)
           //             // parent.Value < current.Value, so make leftmost a right child of parent
           //             parent.Right = leftmost;
           //     }
           //     Console.WriteLine("Removed: " + item);
           // }
            //This code will need to be updated for the Binary Search Tree Lab.
            return true;
        }
    }
}
