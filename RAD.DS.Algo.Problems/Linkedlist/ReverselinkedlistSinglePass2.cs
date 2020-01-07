using System;
using System.Collections.Generic;
using System.Text;

namespace RAD.DS.Algo.Problems.Linkedlist
{
    public class ReverselinkedlistSinglePass2
    {
        public Node Root { get; set; }

        public void InsertNode(int data)
        {
            if(this.Root == null)
            {
                this.Root = new Node() { Data = data };
            }
            else
            {
                Node node = this.Root;
                while (node != null)
                {
                    if(node.Next == null)
                    {
                        break;
                    }

                    node = node.Next;
                }

                node.Next = new Node() { Data = data };
            }
        }

        public void Reverse(Node node, int m, int n)
        {
            if (m < 1 || m > n || n > Getlength(node))
                return;
            node1 = this.Root;
            mid = Math.Ceiling((double)(n - m) / 2);
            Process(node, m, n, 1);
        }

        Node node1 = null;
        double mid = 0;

        public bool Process(Node node, int m, int n, int index)
        {
            if (node == null)
                return true;

            if(index < m)
            {
                node1 = node1.Next;
            }

            Process(node.Next, m, n, index+1);
            
            if(mid <= (index - m) && index <= n)
            {
                int t = node.Data;
                node.Data = node1.Data;
                node1.Data = t;
                node1 = node1.Next;
            }

            return true;
        }


        public void Print()
        {
            Node node = this.Root;
            while (node != null)
            {
                Console.WriteLine($"{node.Data}");
                node = node.Next;
            }
        }


        public int Getlength(Node node)
        {
            int count = 0;
            while(node != null)
            {
                count++;
                node = node.Next;
            }

            return count;
        }


        public class Node
        {
            public Node Next { get; set; }
            public int Data { get; set; }
        }

    }

    
}
