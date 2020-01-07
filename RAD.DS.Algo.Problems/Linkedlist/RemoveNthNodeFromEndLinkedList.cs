using System;
using System.Collections.Generic;
using System.Text;

namespace RAD.DS.Algo.Problems.Linkedlist
{
    public class RemoveNthNodeFromEndLinkedList
    {
        public ListNode Root { get; set; }

        public void InsertNode(int key)
        {
            if(this.Root == null)
            {
                this.Root = new ListNode(key);
            }
            else
            {
                ListNode lastNode = this.Root;
                while(lastNode.next != null)
                {
                    lastNode = lastNode.next;
                }

                lastNode.next = new ListNode(key);
            }
        }

        int length = 1;
        ListNode node;

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            Process(ref head, n, length);
            return head;
        }

        public bool Process(ref ListNode head, int n, int index)
        {
            if(head == null)
            {
                length = index;
                return true;
            }

            bool r =Process(ref head.next, n, index + 1);

            if (index == length - n - 1)
            {
                head.next = node;
                node = null;
            }

            if (length - n == 1 && index == 1)
            {
                if (head.next != null)
                {
                    head = head.next;
                }
                else
                {
                    head = null;
                }
            }
            else if (index == length - n)
            {
                node = head.next;
                head = null;

            }           

            return r;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }
    }
}
