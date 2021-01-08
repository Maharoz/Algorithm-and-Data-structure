using System;
namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Queue q = new System.Collections.Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            Console.WriteLine("Queue elements are:");
            foreach (int i in q)
            {
                Console.Write(i + " ");
            }
        }
    }
}
