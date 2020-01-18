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

            if(isEmpty())
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

        public void addFirst(int item)
        {
            var node = new Node(item);

            if (isEmpty())
                first = last = node;
            else
            {
                node.next = first;
                first = node;
            }
        }

        private Boolean isEmpty()
        {
            return first == null;
        }

        public int indexOf(int item)
        {
            int index = 0;
            var current = first;
            while (current != null)
            {
                if (current.value == item) return index;
                current = current.next;
                index++;
            }
            return -1;


        }
    }
}
