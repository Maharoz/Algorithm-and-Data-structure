using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack
    {
        private int capacity = 1000;
        private int[] data;
        private int top = -1;

        public Stack() { 
            data = new int[capacity];
        }

        public Stack(int size)
        {
            data = new int[size];
            capacity = size;
        }

        //Empty
        public bool Empty
        {
            get
            {
                return (top == -1);
            }
        }

        //Size
        public int size()
        {
            return (top + 1);
        }

        //Print
        public void print()
        {
            for(int i=top;i>=-1;i--)
            {
                Console.WriteLine(data[i]+" ");
            }
        }

        //push
        public void push(int value)
        {
            if(size()==data.Length)
            {
                throw new System.InvalidOperationException("Stack overflow exception");
            }
            top++;
            data[top] = value;
        }

        //pop
        public int pop()
        {
            if(Empty)
            {
                throw new System.InvalidOperationException("Stack overflow exception");
            }
            int topaval = data[top];
            top--;
            return topaval;
        }

        //Peek
        public int Peek()
        {
            if (Empty)
            {
                throw new System.InvalidOperationException("Stack overflow exception");
            }
            return data[top];
        }

        //Sorted Insert
        public void sortedInsert(int value)
        {
            Stack<int> stackHelper = new Stack<int>();
            while(Peek()>value)
            {
                stackHelper.Push(pop());
            }
            push(value);
            while (stackHelper.Count()!=0){
                push(stackHelper.Pop());
            }
        }
        //Bottom Insert
        public void bottomInsert(Stack stk, int element)
        {
            int temp = 0;
            if (stk.size() == 0)
            {
                stk.push(element);
            }
            else
            {
                temp = stk.pop();
                bottomInsert(stk, element);
                stk.push(temp);

            }
        }


        //Reverse Stack
        public void ReverseStack(Stack stk)
        {
            if(stk.size() == 0)
            {
                Console.WriteLine("Stack is empty");
            }

            else
            {
                int temp = stk.pop();
                
                ReverseStack(stk);
                bottomInsert(stk, temp);
            }
        }


        //Reverse K element
        public void ReverseKElemnt(Stack stk, int k)
        {
            Queue<int> queue = new Queue<int>();
            int i = 0;
           while(stk.size() > 0 && i<k) { 
            queue.Enqueue(stk.pop());
                i++;
            
            }
           while(queue.Count() != 0)
            {
                stk.push(queue.Dequeue());
            }
        }

    }
}
