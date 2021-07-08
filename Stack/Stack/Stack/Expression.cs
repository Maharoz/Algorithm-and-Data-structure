using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class Expression
    {
        public bool isBalanced(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach(char ch in input)
            {
                if (ch == '(')
                    stack.Push(ch);

                if (ch == ')')
                {
                    if (stack.Count == 0)
                        return false;
                    stack.Pop();
                }
                    
            }
            return stack.Count == 0 ? true : false;
        }
    }
}
