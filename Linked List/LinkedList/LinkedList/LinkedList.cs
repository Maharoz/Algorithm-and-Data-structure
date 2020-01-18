using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class Node
    {
        public int value;
        public Node next;

        public Node(int value)
        {
            this.value = value;
        }
    }
    public class LinkedList
    {
        private Node first;
        private Node last;

        public void addLast(int item)
        {
            Node node = new Node(item);

            if(first == null)
            {
                first = node;
                last = node;
            }
            else
            {
                last.next = node;
                last = node;
            }
        }
    }
}
