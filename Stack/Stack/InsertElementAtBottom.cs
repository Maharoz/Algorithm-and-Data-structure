using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
	public class InsertElementAtBottom
	{
		public Stack<int> insertAtBottom(Stack<int> st, int x)
		{
			void insertAtBottom(Stack<int> st)
			{
                if ((st.Count==0))
                {
					st.Push(x);
					
                }
				int temp =st.Pop();
				insertAtBottom(st);
				st.Push(temp);

			}
		    insertAtBottom(st);
			return st;
		}
	}
}
