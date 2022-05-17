using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "(1+2>";
            //Expression ex = new Expression();
            //var result = ex.isBalanced(str);
            //Console.WriteLine(result);

            Stack<int> stack = new Stack<int>();  
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            var top = stack.Pop();
            
            
            foreach(int i in stack)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(top);
        }
    }
}
