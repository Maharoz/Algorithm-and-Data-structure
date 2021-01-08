using System;

namespace MakingQueueUsingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayQueue q = new ArrayQueue(5);
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            var front = q.dequeue();
            Console.WriteLine(front);
            foreach (int i in q.items)
            {
                Console.Write(i + " ");
            }
        }

      
    }
}
