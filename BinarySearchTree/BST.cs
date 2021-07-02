using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BST<T> where T : IComparable
    {
        T NodeData;
        public BST<T> leftTree { get; set; }
        public BST<T> rightTree { get; set; }
        public BST(T NodeData)
        {
            this.NodeData = NodeData;
            leftTree = null;
            rightTree = null;
        }
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (leftTree == null)
                    leftTree = new BST<T>(item);
                else
                    leftTree.Insert(item);
            }
            else
            {
                if (rightTree == null)
                    rightTree = new BST<T>(item);
                else
                    rightTree.Insert(item);
            }
        }
        public void Display()
        {
            if (leftTree != null)
            {
                leftTree.Display();
            }
            Console.WriteLine(NodeData.ToString());
            if (rightTree != null)
            {
                rightTree.Display();
            }
        }

    }
}
