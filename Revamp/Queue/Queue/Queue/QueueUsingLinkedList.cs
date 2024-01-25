using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class QueueUsingLinkedList
    {
        public class Node
        {
            public int value;
            public Node next;
            public Node(int v,Node n)
            {
                value = v;
                next = n;
            }
           
        }
        Node head;
        int count = 0;

       
    }
}
