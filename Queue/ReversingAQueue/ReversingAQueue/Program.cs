using System;
using System.Collections;

namespace ReversingAQueue
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
            ReverseOfQueue(q);
            Console.WriteLine("Queue elements are:");
            foreach (int i in q)
            {
                Console.Write(i + " ");
            }


        }

        public static void ReverseOfQueue(Queue q){
            Stack s = new Stack();
            while (q.Count != 0)
            {
                s.Push(q.Dequeue());
            }
            while (s.Count != 0)
            {
                q.Enqueue(s.Pop());
            }
            }
    }
}
