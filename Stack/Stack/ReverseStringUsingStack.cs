using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
	public static class ReverseStringUsingStack
	{
		public static string reverse(string S)
		{
			//Your code here
			string  s =string.Empty;

			Stack<char> stack = new Stack<char>();
			foreach (char c in S) { 
			 stack.Push(c);
			}

			while (stack.Count > 0)
			{
				char c = stack.Pop();
				s =s + c.ToString(); 
			}
			return s;
		}
	}
}
