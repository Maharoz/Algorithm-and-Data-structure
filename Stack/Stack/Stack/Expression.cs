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
                if (ch == '(' || ch=='<'||ch=='[' || ch=='{')
                    stack.Push(ch);

                if (ch == ')' || ch == '>' || ch == ']' || ch == '}')
                {
                    if (stack.Count == 0)
                        return false;
                   var top= stack.Pop();

                    if((ch==')' && top != '(') ||
                       (ch == '>' && top != '<') ||
                       (ch == ']' && top != '[') ||
                       (ch =='}' && top!='{')) 
                    {
                        return false;
                    }
                }
                    
            }
            return stack.Count == 0 ? true : false;
        }
    }
}
