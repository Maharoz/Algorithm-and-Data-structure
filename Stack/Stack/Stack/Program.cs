using System;
using System.Collections;
namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Stack st = new System.Collections.Stack();
            st.Push(10);
            st.Push(20);
            st.Push(30);
            var top = st.Pop();
            foreach(var c in st)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine(top);
        }
    }
}
