using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class TwoStack
    {
        private readonly int MAX_SIZE = 50;
        internal int top1;
        internal int top2;
        internal int[] data;

        public TwoStack()
        {
            top1 = -1;
            top2 = MAX_SIZE;
            data = new int[MAX_SIZE];
        }

        public void stackOnePush(int value)
        {
            if(top1 < top2-1) {
                data[++top1]= value;

            }
            else
            {
                Console.WriteLine("Stack is full");
            }

        }
        public void stackTwoPush(int value)
        {
            if(top2 < top1-1)
            {
                data[--top2]= value;
            }
            else
            {
                Console.WriteLine( "Stack is full");
            }
        }

        public int stackOnePop()
        {
            if (top1 >= 0)
            {
                int value= data[--top1];
                return value;
            }
            else
            {
                Console.WriteLine("Stack Empty");
            }
            return -999;
        }

        public int stackPopTwo()
        {
            if (top2 < MAX_SIZE)
            {
                int value = data[top2++];
                return value;
            }

            else
            {
                Console.WriteLine("Stack Empty");
            }
            return -999;
        }
    }
}
