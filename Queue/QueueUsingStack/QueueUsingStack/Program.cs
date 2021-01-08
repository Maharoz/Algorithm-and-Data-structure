using System;

namespace QueueUsingStack
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueUsingStack queue = new QueueUsingStack();
            queue.enqueue(10);
            queue.enqueue(20);
            queue.enqueue(30);
            queue.dequeue();

            foreach (int i in queue.s2)
            {
                Console.Write(i + " ");
            }

        }
    }
}
