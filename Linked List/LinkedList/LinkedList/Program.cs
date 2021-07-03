using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.addLast(10);
            list.addLast(20);
            list.addLast(30);
            list.removeFirst();
            var array = list.toArray();
            Console.WriteLine(list.contains(10));

        }
    }
}
