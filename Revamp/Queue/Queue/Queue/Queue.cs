using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Queue
    {
        private int count;
        private int capacity = 100;
        private int[] data;
        internal int front =0;
        internal int back =0;

        public Queue() {
            count = 0;
            data = new int[100];
        }


        //Add to queue
        public bool Add(int value)
        {
            if (count >= capacity)
            {
                Console.WriteLine("Queue is full");
                return false;
            }
            else
            {
                count++;
                data[back] = value;
                back = (++back) % (capacity - 1);
            }
            return true;
        }

        //remove
        public int remove()
        {
            int value;
            if (count <= 0)
            {
                return -999;
            }
            else
            {
                count--;
                value = data[front];
                front=(++front) % (capacity - 1);
            }
            return value;
        }

        //IsEmpty check

        public bool Empty
        {
            get
            {
                return count == 0;
            }
        }

        internal int size()
        {
            return count;
        }

    }
}
