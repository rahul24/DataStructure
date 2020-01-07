using System;
using System.Collections.Generic;
using System.Text;

namespace RAD.DS.Algo.Problems.Linkedlist
{
    public class RotateRightLinkedList
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            ListNode node = head;

            while(node != null)
            {
                if(node?.next?.next == null)
                {
                    node.next = head;
                    head = node;
                }

                node = node.next;
            }

            return null;
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
