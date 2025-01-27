﻿using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Binary Search tree Program");
            {
                BST<int> bst = new BST<int>(56); //Tree Starts With
                bst.Insert(30);
                bst.Insert(70);
                bst.Insert(22);
                bst.Insert(40);
                bst.Insert(60);
                bst.Insert(95);
                bst.Insert(11);
                bst.Insert(65);
                bst.Insert(3);
                bst.Insert(16);
                bst.Insert(63);
                bst.Insert(67);
                bst.Insert(70);
                bst.Display();
                bst.GetSize();
                bool result = bst.IfExist(67, bst); //Element To Search
                Console.WriteLine(result);
            }
        }
    }
}
