using System;
using System.Collections.Generic;
using System.Text;

namespace RAD.DS.Algo.Problems.Linkedlist
{
    public class SplitLinkedlistInParts
    {
        public ListNode Root { get; set; }

        public void InsertNode(int key)
        {
            if (this.Root == null)
            {
                this.Root = new ListNode(key);
            }
            else
            {
                ListNode lastNode = this.Root;
                while (lastNode.next != null)
                {
                    lastNode = lastNode.next;
                }

                lastNode.next = new ListNode(key);
            }
        }

        #region Solution2
        public ListNode[] splitListToParts(ListNode root, int k)
        {
            ListNode cur = root;
            int N = 0;
            while (cur != null)
            {
                cur = cur.next;
                N++;
            }

            int width = N / k, rem = N % k;

            ListNode[] ans = new ListNode[k];
            cur = root;
            for (int i = 0; i < k; ++i)
            {
                ListNode head = cur;
                for (int j = 0; j < width + (i < rem ? 1 : 0) - 1; ++j)
                {
                    if (cur != null) cur = cur.next;
                }
                if (cur != null)
                {
                    ListNode prev = cur;
                    cur = cur.next;
                    prev.next = null;
                }
                ans[i] = head;
            }
            return ans;
        }
        #endregion



        #region Solution1
        public ListNode[] SplitListToParts1(ListNode root, int k)
        {   
            int len = (root == null)?k: GetLength(root);
            int length = (k > len) ? k : len;
            List<ListNode> nodes = new List<ListNode>();
            int bucketSize = (length % k == 0) ? k : (int)Math.Ceiling((double)length / k);
            int bucketSize1 = (length % k == 0) ? k : (int)Math.Floor((double)length / k);
            int finalBucketSize = (k > len) ? 1 : (bucketSize > bucketSize1) ? bucketSize : bucketSize1;
            int headIndex = 1;
            ListNode nn = root;

            if (k > len)
            {
                for (int i = 1; i <= length; i++)
                {
                    if (nn == null)
                    {
                        nodes.Add(nn);
                        continue;
                    }

                    ListNode t = nn.next;
                    nn.next = null;
                    nodes.Add(nn);
                    nn = t;
                }
            }
            else
            {
                for (int i = 1; i <= length; i++)
                {
                    if (nn == null)
                    {
                        nodes.Add(nn);
                        continue;
                    }

                    if (i == finalBucketSize)
                    {
                        ListNode t = nn.next;
                        nn.next = null;
                        if (k == 1)
                            nodes.Add(nn);
                        headIndex = i + 1;
                        finalBucketSize += (k > len) ? 1 : (bucketSize > bucketSize1) ? bucketSize1 : bucketSize;
                        nn = t;
                    }
                    else
                    {
                        if (headIndex == i)
                            nodes.Add(nn);
                        nn = nn.next;
                    }
                }
            }

            return nodes.ToArray();
        }

        public int GetLength(ListNode root)
        {
            int count = 1;
            while(root.next != null)
            {
                count++;
                root = root.next;
            }

            return count;
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
