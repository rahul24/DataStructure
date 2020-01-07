using System;
using System.Collections.Generic;
using System.Text;

namespace RAD.DS.Algo.Problems.Linkedlist
{
    public class MergeSortedLinkedlist
    {

        public ListNode Root { get; set; }
        public ListNode Root1 { get; set; }

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


        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode head = null;
            ListNode merge = null;

            while(l1 != null && l2 != null)
            {
                //ListNode l1next = l1.next;
                //ListNode l2next = l2.next;

                if (l1.val <= l2.val)
                {                    
                    if (merge != null)
                        merge = l1;
                    else
                        merge = l1;

                    l1 = l1.next;
                }
                else 
                {                    
                    if (merge != null)
                        merge = l2;
                    else
                        merge = l2;

                    l2 = l2.next;
                }

                if (head == null)
                    head = merge;

                merge = merge.next;
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
