using System;
using System.Collections.Generic;
using System.Text;

namespace RAD.DS.Algo.Problems.Linkedlist
{
    public class ReorderLinkedlist
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

        public void ReorderList(ListNode head)
        {
            Process(ref head, length);
        }

        ListNode node = null;
        int length = 1;

        private void Process(ref ListNode head, int index)
        {
            if (head == null)
            {
                length = index - 1;
                return;
            }

            Process(ref head.next, index + 1);

            if (node == null)
            {
                if (index == 1)
                    return;

                node = this.Root;
                head.next = node.next;
                node.next = head;
            }
            else
            {
                if(node == node.next || node.next == null)
                {
                    node.next = null;
                    return;
                }

                if(node == head)
                {
                    if(node.next != head)
                    {
                        node = node.next;
                        node.next = null;                        
                        return;
                    }
                }

                node = node.next;
                head.next = node.next;
                node.next = head;
            }

            node = node.next;
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
