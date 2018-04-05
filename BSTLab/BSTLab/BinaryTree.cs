using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTLab
{
    public class BinaryTree<T>
    {
        private BinaryTreeNode<T> root;

        public BinaryTree()
        {
            root = null;
        }

        public virtual void Clear()
        {
            root = null;
        }

        public BinaryTreeNode<T> Root
        {
            get
            {
                return root;
            }

            set
            {
                root = value;
            }
        }

        private string InOrder(BinaryTreeNode<T> current)
        {
            string tree = string.Empty;

            if (current != null)
            {
                tree += InOrder(current.Left);
                tree += current.ToString()+ " -> ";
                tree += InOrder(current.Right);
            }

            return tree;
            //L-V-R
            //This code will need to be updated for HandsOnTest2 and the Binary Search Tree Lab.
            //if (current != null)
            //{
            //    InOrder(current.Left);
            //    Console.Write(current.Item + " -> ");
            //    InOrder(current.Right);
            //}
            //return "";
        }

        public string InOrderTrav()
        {               
            //This code will need to be updated for HandsOnTest2 and the Binary Search Tree Lab.
            return InOrder(Root);
        }

        private string PreOrder(BinaryTreeNode<T> current)
        {
            //V-L-R
            //This code will need to be updated for HandsOnTest2.
            string tree = string.Empty;

            if (current != null)
            {
                tree += current.ToString() + " -> ";
                tree += InOrder(current.Left);                
                tree += InOrder(current.Right);
            }

            return tree;
        }

        public string PreOrderTrav()
        {
            //This code will need to be updated for HandsOnTest2.
            return PreOrder(Root);
        }

        private string PostOrder(BinaryTreeNode<T> current)
        {
            //L-R-V
            //This code will need to be updated for HandsOnTest2.
            string tree = string.Empty;

            if (current != null)
            {
                tree += InOrder(current.Left);
                tree += InOrder(current.Right);
                tree += current.ToString() + " -> ";
            }

            return tree;
        }

        public string PostOrderTrav()
        {
            //This code will need to be updated for HandsOnTest2.
            return PostOrder(Root);
        }
        
        public override string ToString()
        {
            return InOrder(root);
        }
    }
}
