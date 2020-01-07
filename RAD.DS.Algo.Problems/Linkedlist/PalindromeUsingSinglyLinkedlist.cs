using System;
using System.Collections.Generic;
using System.Text;

namespace RAD.DS.Algo.Problems.Linkedlist
{
    public class PalindromeUsingSinglyLinkedlist
    {
        public Node Root { get; set; }

        public void InsertNode(string data)
        {
            Node lastNode = this.Root;
            if (this.Root == null)
            {
                lastNode = new Node() { Data = data };
                this.Root = lastNode;
            }
            else
            {
                while (lastNode != null)
                {
                    if (lastNode.Next != null)
                    {
                        lastNode = lastNode.Next;
                    }
                    else
                    {
                        break;
                    }
                }

                lastNode.Next = new Node() { Data = data };
            }
        }

        #region "Solution 2"
        public bool IsPalindrome()
        {
            return Process1(this.Root);
        }

        public bool Process1(Node node)
        {
           if (node == null)
                return true;

           bool r =  Process1(node.Next);

            
            if (this.Root.Data == node.Data && r)
            {
                this.Root = this.Root.Next;
                return true;
            }

            return false;

        }
        #endregion


        #region "Solution 1" 

        public bool IsPalendrome()
        {
            return Process(this.Root, GetLength());
        }

        private bool Process(Node startNode, int size)
        {
            if (size <= 0)
                return true;

            Node lastNode = startNode; 
            for (int i = 1; i < size; i++)
            {
                if (lastNode.Next != null)
                {
                    lastNode = lastNode.Next;
                }
                else
                {
                    break;
                }
            }

            if(startNode.Data == lastNode.Data)
            {
                return Process(startNode.Next, size - 2);
            }

            return false;
        }

        public int GetLength()
        {
            Node node = this.Root;
            int count = 0;
            while (node != null)
            {
                count++;
                node = node.Next;
            }

            return count;
        }
        #endregion
    }

    public class Node
    {
        public string Data { get; set; }
        public Node Next { get; set; }
    }

}
