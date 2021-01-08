using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QueueUsingStack
{
   public class QueueUsingStack
    {

        public Stack s1 = new Stack();
        public Stack s2 = new Stack();
        

        public void enqueue(int item)
        {
            s1.Push(item);
        }

        public int dequeue()
        {
            if(s2.Count==0)
                while(s1.Count != 0)
                {
                    s2.Push(s1.Pop());
                }

            return (int)s2.Pop();
        }

    }
}
