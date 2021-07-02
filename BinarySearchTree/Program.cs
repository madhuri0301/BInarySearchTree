using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Binary Search tree Program");

            {
                BST<int> bst = new BST<int>(56);                  
                bst.Insert(30);
                bst.Insert(70);
                Console.WriteLine("Binary Search Tree -");
                bst.Display();
            }
        }
    }
}
