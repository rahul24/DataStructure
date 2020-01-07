using RAD.DS.Algo.Problems.Array;
using RAD.DS.Algo.Problems.Linkedlist;
using RAD.DS.Algorithms.Linkedlist;
using System;

namespace RAD.DS
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            SingleLinkedlist linkedlist = new SingleLinkedlist();

            linkedlist.InsertNode("10");
            linkedlist.InsertNode("20");
            linkedlist.InsertNode("30");
            linkedlist.InsertNode("40");
            linkedlist.InsertNode("50");
            linkedlist.PrintNodes();            
            linkedlist.DeleteNode("20");
            linkedlist.DeleteNode("30");
            linkedlist.DeleteNode("40");
            linkedlist.DeleteNode("50");
            linkedlist.DeleteNode("10");
            linkedlist.DeleteNode("60");
            linkedlist.PrintNodes();
            */

            /*

            PalindromeUsingSinglyLinkedlist p = new PalindromeUsingSinglyLinkedlist();
            p.InsertNode("N");
            p.InsertNode("I");
            p.InsertNode("T");
            p.InsertNode("I");
            p.InsertNode("N");

            bool r = p.IsPalindrome();
            Console.WriteLine(r?"Palindrome":"Not Palindrome");
            */

            /*
            ReverselinkedlistSinglePass2 s = new ReverselinkedlistSinglePass2();
            s.InsertNode(1);
            s.InsertNode(2);
            s.InsertNode(3);
            s.InsertNode(4);
            s.InsertNode(5);
            s.InsertNode(6);

            s.Reverse(s.Root, 3, 6);
            s.Print();
            *
            */

            /*
            ReverseSinglyLinkedlistSinglePass r = new ReverseSinglyLinkedlistSinglePass();
            r.InsertNode(1);
            r.InsertNode(2);
            r.InsertNode(3);
            r.InsertNode(4);
            r.InsertNode(5);
            r.InsertNode(6);

            r.ReverseList(r.Root);
            r.Print();
            */

            /*
            LinkedlistCycle c = new LinkedlistCycle();
            c.InsertNode(10, false);
            c.InsertNode(20, false);
            c.InsertNode(30, false);
            c.InsertNode(40, false);

            Console.WriteLine(c.HasCycle(c.Root)?"Has Cycle":"Has no Cycle");
            */

            /* INCOMPLETE
            MergeSortedLinkedlist m = new MergeSortedLinkedlist();
            m.InsertNode(10);
            m.InsertNode(20);
            m.InsertNode(40);
            m.Root1 = m.Root;
            m.Root = null;
            m.InsertNode(10);
            m.InsertNode(30);
            m.InsertNode(40);
            m.MergeTwoLists(m.Root, m.Root1);
            */

            /*
            RemoveNthNodeFromEndLinkedList r = new RemoveNthNodeFromEndLinkedList();
            r.InsertNode(10);
            r.InsertNode(20);

            r.RemoveNthFromEnd(r.Root, 1);
            */

            /*
            ReorderLinkedlist ro = new ReorderLinkedlist();
            ro.InsertNode(10);
            ro.InsertNode(20);
            ro.InsertNode(30);
            ro.InsertNode(40);
            ro.InsertNode(50);

            ro.ReorderList(ro.Root);
            */

            /*
            SwapNodesInPairs sw = new SwapNodesInPairs();
            sw.InsertNode(10);
            sw.InsertNode(20);
            sw.InsertNode(30);
            sw.InsertNode(40);
            sw.InsertNode(50);
            sw.InsertNode(60);
            sw.SwapPairs(sw.Root);
            */

            /*
            SplitLinkedlistInParts sp = new SplitLinkedlistInParts();
            //sp.InsertNode(10);
            //sp.InsertNode(20);
            //sp.InsertNode(30);
            //sp.InsertNode(40);
            //sp.InsertNode(50);
            //sp.InsertNode(60);
            //sp.InsertNode(70);
            sp.splitListToParts(sp.Root, 1);
            */

            /*
            FindNumberWithEvenNumberOfDigit d = new FindNumberWithEvenNumberOfDigit();
            d.FindNumbers(new int[] { 12, 345, 2, 6, 7896 });
            */
            /*
            SubarraySumItem s = new SubarraySumItem();
            int r = s.SubarraySum(new int[] { -1, -1, 1 }, 1);
            //int r = s.SubarraySum(new int[] { 100,1,2,3,4 }, 6);
            */

            /*
            ThirdMaxNumber t = new ThirdMaxNumber();
            int x = t.ThirdMax(new int[] { 2,2,3,3,1 });
            */

            /*
            int[][] m = new int[][] {
                new int[] {-9, - 9, - 9, 0, 1, 2 },
                new int[] {1, - 9,  1, 8, 0, 5 },
                new int[] {-9, - 9, - 9, 5, 1, 3 },
                new int[] {0,  0,  0, 1, 2, 3 },
                new int[] {2,  0,  9, 1, 6, 3 },
                new int[] {0,  0,  0, 3, 4, 7 }
            };

            FindHourGlassMaxSum h = new FindHourGlassMaxSum();
            int r = h.FindMaxSum(m);
            */

            /*
            SortArrayByParitySolutuion p = new SortArrayByParitySolutuion();
            p.SortArrayByParity(new int[] { 3 });
            */

            SortArrayByParity2 p = new SortArrayByParity2();
            p.SortArrayByParityII(new int[] { 3,4 });

            Console.Read();
        }
    }
}
