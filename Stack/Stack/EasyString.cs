using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
	public static class EasyString
	{
		public static string transform(string S)
		{
			// code here
			Stack<char> stack = new Stack<char>();

			char[] chars = S.ToLower().ToCharArray();

			foreach (char c in chars)
			{
				stack.Push(c);
			}
			int count = 0;
			string result =string.Empty;
			while (stack.Count > 0)
			{
				
				char x = stack.Pop();
				char? y = stack.Count > 0?stack.Peek():null;
                if (x==y)
                {
					count++;
                }
				else
				{
					result=(count+1).ToString()+x.ToString()+ result;
					count = 0;
				}

				
            }
			return result;
		}
	}
}
