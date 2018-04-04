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
            //This code will need to be updated for HandsOnTest2 and the Binary Search Tree Lab.
            return "";
        }

        public string InOrderTrav()
        {
            //This code will need to be updated for HandsOnTest2 and the Binary Search Tree Lab.
            return "";
        }

        private string PreOrder(BinaryTreeNode<T> current)
        {
            //This code will need to be updated for HandsOnTest2.
            return "";
        }

        public string PreOrderTrav()
        {
            //This code will need to be updated for HandsOnTest2.
            return "";
        }

        private string PostOrder(BinaryTreeNode<T> current)
        {
            //This code will need to be updated for HandsOnTest2.
            return "";
        }

        public string PostOrderTrav()
        {
            //This code will need to be updated for HandsOnTest2.
            return "";
        }
        
        public override string ToString()
        {
            return InOrder(root);
        }
    }
}
