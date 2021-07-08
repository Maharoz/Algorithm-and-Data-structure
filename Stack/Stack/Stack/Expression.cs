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
                if (isLeftBracket(ch))
                    stack.Push(ch);

                if (isRightBracker(ch))
                {
                    if (stack.Count == 0)
                        return false;
                   var top= stack.Pop();

                    if(bracketsMatch(top,ch))
                    {
                        return false;
                    }
                }
                    
            }
            return stack.Count == 0 ? true : false;
        }

        private bool isLeftBracket(char ch)
        {
            return ch == '(' || ch == '<' || ch == '[' || ch == '{';
        }

        private bool isRightBracker(char ch)
        {
            return ch == ')' || ch == '>' || ch == ']' || ch == '}';
        }

        private bool bracketsMatch(char left,char right)
        {
            return ((right == ')' && left != '(') ||
                       (right == '>' && left != '<') ||
                       (right == ']' && left != '[') ||
                       (right == '}' && left != '{'));
        }
    }
}
