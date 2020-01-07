using System;
using System.Collections.Generic;
using System.Text;

namespace RAD.DS.Algo.Problems.Linkedlist
{
    public class LinkedlistCycle
    {
        public ListNode Root { get; set; }

        public void InsertNode(int key, bool isCycle)
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


                if(isCycle)
                {
                    lastNode.next = new ListNode(key) { next = this.Root };
                }
                else
                {
                    lastNode.next = new ListNode(key);
                }

            }
        }


        #region "Solution 2"
        public bool HasCycle(ListNode head)
        {
            if (head == null)
                return false;

            ListNode next = head.next;
            if (head.val == -9999)
            {
                return true;
            }
            else
            {                
                if(next != null)
                    head.next = new ListNode(-9999) { next = next };
            }

            return HasCycle(next);

        }

        #endregion

        #region "Solution 1"
            List<ListNode> nodeList = new List<ListNode>();
        public bool HasCycle1(ListNode head)
        {
            if (head == null)
                return false;

            if (!nodeList.Contains(head))
            {
                nodeList.Add(head);
            }
            else
            {
                return true;
            }

            return HasCycle(head.next);
        }
        #endregion



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
