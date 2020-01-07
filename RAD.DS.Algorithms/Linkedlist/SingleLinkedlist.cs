using System;
using System.Collections.Generic;
using System.Text;

namespace RAD.DS.Algorithms.Linkedlist
{
    public class SingleLinkedlist
    {
        public Node Root { get; set; }

        public void InsertNode(string data)
        {
            if (this.Root == null)
            {
                this.Root = new Node() { Data = data };
            }
            else
            {
                Node lastNode = this.Root;

                while (lastNode.Next != null)
                {
                    lastNode = lastNode.Next;
                }

                lastNode.Next = new Node { Data = data };
            }

        }

        public void DeleteNode(string key)
        {
            if (this.Root == null)
            {
                throw new UnderflowException("No data in the linkedlist");
            }

            Node nextNode = this.Root;
            Node prevNode = this.Root;
            bool isKeyfound = false;

            while (nextNode != null)
            {
                if (nextNode.Data == key)
                {
                    isKeyfound = true;
                    break;
                }

                prevNode = nextNode;
                nextNode = nextNode.Next;
            }

            if (!isKeyfound)
                throw new OverflowException("Key not found!!");

            if (nextNode == prevNode)
            {
                this.Root = null;
                prevNode = null;
            }
            else
            {
                prevNode.Next = nextNode.Next;
                nextNode = null;
            }
        }

        public void PrintNodes()
        {
            Node lastNode = this.Root;
            Console.WriteLine("===============================");
            while (lastNode != null)
            {
                Console.WriteLine($"{lastNode.Data},");
                lastNode = lastNode.Next;
            }

            Console.WriteLine(lastNode != null ? lastNode.Data : string.Empty);
            Console.WriteLine("===============================");
        }



        public class Node
        {
            public Node Next { get; set; }
            public string Data { get; set; }
        }

        public class UnderflowException : Exception
        {
            public UnderflowException(string data) : base(data)
            {

            }
        }
    }
}
