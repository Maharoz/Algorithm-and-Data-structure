using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class StringReverser
    {
        public string reverse(string input)
        {
            if (input == null)
            {
                throw new Exception();
            }
            Stack<Char> st = new Stack<Char>();

          
            foreach(char ch in input.ToCharArray())
            {
                st.Push(ch);
            }

           // string reversed = "";


            StringBuilder reversed = new StringBuilder();
            while (st.Count != 0)
            {
               // st.Pop();
                reversed.Append(st.Pop());
            }

            return reversed.ToString();
        }
    }
}
