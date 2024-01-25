using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {

        //Construct a linked List
        public class Node
        {
            internal int value;
            internal Node next;
            internal Node(int v,Node n) {
                value = v;
                next = n;

            }
        }
        private Node head;
        private int count = 0;

        //AddHead
        public void addHead(int value)
        {
            head = new Node(value, head);
            count++;
        }


        //Add Tail
        public void addTail(int value)
        {

            Node newNode = new Node(value, head);
            Node curr = head;
            if (head == null)
            {
                head = newNode;
            }
            while(curr.next != null)
            {
                curr=curr.next;
            }
            curr.next = newNode;
        }


        //Traverse a linked List

        public void Traverse()
        {
            Node temp = head;
            if(temp != null)
            {
                Console.WriteLine( temp.value+ " ");
                temp = temp.next;
            }
        }

        //Sorted insert

        public void InsertSorted(int valueToBeInserted)
        {
            Node newNode = new Node(valueToBeInserted, null);
            Node curr = head;
            if (curr != null||curr.value>valueToBeInserted)
            {
                newNode.next = head;
                head = newNode;
                return;
            }
            while (curr.next!=null && curr.next.value < valueToBeInserted)
            {
                curr = curr.next;
            }
            newNode.next = curr.next;
            curr.next = newNode;
        }

        //Search in Linked List

        public int Search(int valueToBeSearch)
        {
            Node current = head;

            while(current == null)
            {
                if (current.value == valueToBeSearch)
                    return 1;
                current = current.next;

            }
            return 0;
        }
    }
}
