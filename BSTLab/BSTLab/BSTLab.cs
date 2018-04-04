using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTLab
{
    class HandsOnTest2
    {
        static void display(string displayPrompt = "", string data = "")
        {
            if (!displayPrompt.Equals(""))
                Console.WriteLine(displayPrompt);

            if (!data.Equals(""))
                Console.WriteLine(data);
        }

        static void displayPause(string displayPrompt = "", string data = "")
        {
            display(displayPrompt, data);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>();

            display("Initial Add");
            bst.Add(12);
            bst.Add(9);
            bst.Add(14);
            bst.Add(41);
            bst.Add(13);
            bst.Add(3);
            display("InOrder:", bst.InOrderTrav());
            display("PreOrder:", bst.PreOrderTrav());
            display("PostOrder:", bst.PostOrderTrav());
            display("Add and Remove");
            bst.Add(33);
            bst.Remove(41);
            bst.Remove(13);
            bst.Remove(99);
            bst.Add(14);
            display("InOrder:", bst.InOrderTrav());
            display("PreOrder:", bst.PreOrderTrav());
            displayPause("PostOrder:", bst.PostOrderTrav());
        }
    }
}