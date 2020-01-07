using System;
using System.Collections.Generic;
using System.Text;

namespace RAD.DS.Algo.Problems.Linkedlist
{    
    public class SwapNodesInPairs
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

        ListNode header = null;
        public ListNode SwapPairs(ListNode head)
        {
            if (head.next == null)
                return head;

            ListNode p = head;
            ListNode c = p.next;

            head = c;

            while(p != null && c!= null)
            {
                ListNode n = c.next;
                c.next = p;
                
                if(n == null || n.next == null)
                {
                    p.next = n;
                    break;
                }

                p.next = n.next;

                p = n;
                c = n.next;

            }

            return head;
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
