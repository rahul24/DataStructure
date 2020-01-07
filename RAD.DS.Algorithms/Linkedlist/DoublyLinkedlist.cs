using System;
using System.Collections.Generic;
using System.Text;

namespace RAD.DS.Algorithms.Linkedlist
{
    public class DoublyLinkedlist
    {
        public class Node
        {
            public Node Next { get; set; }
            public Node Previous { get; set; }
            public string Data { get; set; }

        }
        public class UnderflowException : Exception
        {
            public UnderflowException(string data) : base(data)
            {

            }
        }
    }
}
