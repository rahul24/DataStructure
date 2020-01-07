using System;
using System.Collections.Generic;
using System.Text;

namespace RAD.DS.Algo.Problems.Linkedlist
{
    public class ReverseSinglyLinkedlistSinglePass
    {
        public ListNode Root { get; set; }


        public void InsertNode(int key)
        {
            if(this.Root == null)
            {
                this.Root = new ListNode() { Val = key };
            }
            else
            {
                ListNode lastNode = this.Root;

                while(lastNode.Next != null) 
                {
                    lastNode = lastNode.Next;
                }

                lastNode.Next = new ListNode() { Val = key };
                     
            }
        }

        public ListNode ReverseList(ListNode head)
        {
            bool r = Process(head,1);
            return this.Root;
        }

        ListNode lastnode = null;

        public bool Process(ListNode head, int Index)
        {
            if (head == null)
                return true;

            Process(head.Next, Index + 1);

            if(head.Next == null)
            {
                this.Root = head;
                lastnode = head;
            }
            else
            {
                if (Index == 1)
                {                    
                    lastnode.Next = head;
                    head.Next = null;
                }
                else
                {
                    lastnode.Next = head;
                    lastnode = head;
                }
            }

            return true;
        }

        public void Print()
        {
            ListNode node = this.Root;

            while(node != null)
            {
                Console.WriteLine($"{node.Val}");
                node = node.Next;
            }
        }


        public class ListNode
        {
            public ListNode Next { get; set; }
            public int Val { get; set; }
        }
    }
}
