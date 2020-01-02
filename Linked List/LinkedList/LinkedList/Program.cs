using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddFirst(5);
            Console.WriteLine(list);

            foreach (int num in list)
            {
                Console.WriteLine(num);
            }


        }
    }
}
