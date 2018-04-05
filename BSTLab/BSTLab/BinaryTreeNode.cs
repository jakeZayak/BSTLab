/*
 * Author:  Jake Zayak
 * Date:  3/23/2018
 * Purpose:  This class implements a Binary Tree Node generically.
 * Version:  1.1
 * Last Update:  4/5/2018
 */

namespace BSTLab
{
    /*
    * Class that implements the Binary Tree Node generically
    */
    public class BinaryTreeNode<T>
    {
        private T item; //generic data item
        private BinaryTreeNode<T> left = null; //left child
        private BinaryTreeNode<T> right = null; //right child

        /*
         * Empty default constructor (do nothing)
         */
        public BinaryTreeNode() { }
        /*
         * One parameter constructor (assumes data)
         * calls the three parameter consturctor with
         * null children.
         * /
        public BinaryTreeNode(T item) : this(item, null, null) { }

        /*
         * Three parameter constructor takes data, left, and right
         * and creates the node with the correct data pointing to the 
         * specified left and right.  Both left and right must be binary
         * tree nodes.
         */
        public BinaryTreeNode(T item) : this(item, null, null) { }
        public BinaryTreeNode(T item, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
        {
            this.item = item;
            this.left = left;
            this.right = right;
        }


        /*
         * Provide public get and set access to the data item.
         */
        public T Item
        {
            get
            {
                return item;
            }

            set
            {
                item = value;
            }
        }


        /*
         * Provide public access to the Left child, must be a Binary
         * Tree node reference to set and returns Binary Tree node 
         * reference on get.
         */
        public BinaryTreeNode<T> Left
        {
            get
            {
                return left;
            }

            set
            {
                left = value;
            }
        }

        /* Provide public access to the Right child.  Must be a 
         * Binary Tree Node reference to set and returns a Binary
         * Tree Node reference on get.
         */
        public BinaryTreeNode<T> Right
        {
            get
            {
                return right;
            }

            set
            {
                right = value;
            }
        }

        /*
        * Explain to C# how to create a string from this node
        */
        public override string ToString()
        {

            //If the data item is null return an empty string
            //because null does not print well
            if (item == null)
            {
                return string.Empty;
            }
            //Call the generic data items ToString to return the
            //value.  If it is custom, it is up to programmer to
            //provide.
            else
            {
                return item.ToString();
            }
        }
    }
}
