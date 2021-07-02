using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class BST<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public BST<T> LeftTree { get; set; }
        public BST<T> RightTree { get; set; }
        public BST(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }

        int leftCount = 0, rightCount = 0;

        /// <summary>
        /// Insert Node to Binary Search Tree
        /// </summary>
        /// <param name="item">Node of tree</param>
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if (currentNodeValue.CompareTo(item) > 0)
            {
                if (this.LeftTree == null)
                    this.LeftTree = new BST<T>(item);
                else
                    this.LeftTree.Insert(item);
            }
            else
            {
                if (this.RightTree == null)
                    this.RightTree = new BST<T>(item);
                else
                    this.RightTree.Insert(item);
            }
        }

        /// <summary>
        /// Get size of Binary Search Tree
        /// </summary>
        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));
        }

        /// <summary>
        /// Display Binary Search Tree
        /// </summary>
        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.leftCount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            {
                this.rightCount++;
                this.RightTree.Display();
            }
        }


    }
}
