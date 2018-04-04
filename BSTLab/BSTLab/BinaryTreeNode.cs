using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTLab
{
    public class BinaryTreeNode<T>
    {
        private T item;
        private BinaryTreeNode<T> left = null;
        private BinaryTreeNode<T> right = null;


        public BinaryTreeNode() { }
        public BinaryTreeNode(T item) : this(item, null, null) { }
        public BinaryTreeNode(T item, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
        {
            this.item = item;
            this.left = left;
            this.right = right;
        }

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

        public override string ToString()
        {
            if (item == null)
                return string.Empty;
            else
                return item.ToString();
        }
    }
}
