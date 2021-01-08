using System;
using System.Collections.Generic;
using System.Text;

namespace MakingQueueUsingArray
{
    public class ArrayQueue
    {
        public int[] items;
        public int rear;
        public int front;
        public int count;
        public ArrayQueue(int capacity)
        {
            items = new int[capacity];
        }
        public void Enqueue(int item)
        {
            if (count == items.Length)
                throw new Exception();
            items[rear] = item;
            rear++;
            count++;
        }

        public int dequeue()
        {
            var item =  items[front++];
            items[front] = 0;
            count--;
            return item;
        }
    }
}
