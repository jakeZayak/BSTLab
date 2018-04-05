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
        }

        public bool Remove(T item)
        {
            if (Root == null)
            {
                return false;
            }
            BinaryTreeNode<T> current = Root;
            //This code will need to be updated for the Binary Search Tree Lab.
            return false;
        }
    }
}
